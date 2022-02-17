using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace SmartMonitoring.BackEnd
{
    public delegate void DataSentHandler(string Msg, string ServerID);

    public partial class frmServerMonitor : Form
    {
        public event DataSentHandler DataSentEvent;

        private string _ServerID;
        private string _ServerName;
        private string _MachineName;
        private string _MachineIP;
        private bool _IsCurrentMachine;
        private bool _IsLoggedIn;
        private string _LoginDomain;
        private string _LoginUsername;
        private string _LoginPassword;

        List<PerformanceCounter> counters = new List<PerformanceCounter>();
        List<MonitorCounter> mycounters = new List<MonitorCounter>();
        


        // *********************
        BackgroundWorker m_oWorker01;
        static string _LogFilePath = Application.StartupPath + @"\logfile.txt";
        string _TransGuid = "";
        int _TotalFilesCount01 = 0;
        int _CurFileIndex01 = 0;
        DateTime _JobStartDateTime01;
        int _ProcessedCount01;



        // *********************
        private const int LOGON32_LOGON_NEW_CREDENTIALS = 9;
        private const int LOGON32_PROVIDER_WINNT50 = 3;

        [DllImport("advapi32.dll", CharSet = CharSet.Auto)]
        public static extern bool LogonUser(
            String lpszUserName,
            String lpszDomain,
            String lpszPassword,
            int dwLogonType,
            int dwLogonProvider,
            ref IntPtr phToken);


        //public const int LOGON32_LOGON_INTERACTIVE = 2;
        //public const int LOGON32_LOGON_SERVICE = 3;
        //public const int LOGON32_PROVIDER_DEFAULT = 0;

        //[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        //public extern static bool CloseHandle(IntPtr handle);

        IntPtr userHandle = new IntPtr(0);
        bool logonSuccess = false;
        WindowsIdentity identity;
        WindowsImpersonationContext context;


        public frmServerMonitor()
        {
            InitializeComponent();


            //********
            m_oWorker01 = new BackgroundWorker();
            m_oWorker01.DoWork += new DoWorkEventHandler(m_oWorker01_DoWork);
            m_oWorker01.ProgressChanged += new ProgressChangedEventHandler
                    (m_oWorker01_ProgressChanged);
            m_oWorker01.RunWorkerCompleted += new RunWorkerCompletedEventHandler
                    (m_oWorker01_RunWorkerCompleted);
            m_oWorker01.WorkerReportsProgress = true;
            m_oWorker01.WorkerSupportsCancellation = true;

        }

        public frmServerMonitor(string ServerID)
        {
            InitializeComponent();

            //
            _ServerID = ServerID;
            lblServerID.Text = _ServerID;


            //********
            m_oWorker01 = new BackgroundWorker();
            m_oWorker01.DoWork += new DoWorkEventHandler(m_oWorker01_DoWork);
            m_oWorker01.ProgressChanged += new ProgressChangedEventHandler
                    (m_oWorker01_ProgressChanged);
            m_oWorker01.RunWorkerCompleted += new RunWorkerCompletedEventHandler
                    (m_oWorker01_RunWorkerCompleted);
            m_oWorker01.WorkerReportsProgress = true;
            m_oWorker01.WorkerSupportsCancellation = true;

        }

        private void frmServerMonitor_Load(object sender, EventArgs e)
        {

            //
            load_serverlogindetails();
            load_servercounters();


            if (_IsCurrentMachine == true)
            {
                logonSuccess = true;
                _IsLoggedIn = true;
            }
            else
            {
                logonSuccess = LogonUser(
                              _LoginUsername,
                              _LoginDomain,
                              _LoginPassword,
                              LOGON32_LOGON_NEW_CREDENTIALS,
                              LOGON32_PROVIDER_WINNT50,
                              ref userHandle
                            );

                if (logonSuccess)
                {
                    identity = new WindowsIdentity(userHandle);
                    context = identity.Impersonate();
                    _IsLoggedIn = true;
                }
                else
                {
                    _IsLoggedIn = false;
                }
            }

            // run counter for the first time without adding to DB to avoid zero values of first run
            RunFirstTimeCounters();
            System.Threading.Thread.Sleep(1000);

            //
            tmrMonitor.Interval = 5000;
            tmrMonitor.Start();
        }
        

        private void load_serverlogindetails()
        {
            DataTable _table = new DataTable();
            string _sql = $@"SELECT machine_name, machine_description, host_name, ip_address, is_current_machine, conn_domain_name, conn_user_name, conn_user_password
FROM montr_machines_list WHERE machine_id = '{_ServerID}'";
            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                _connection.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(_sql, _connection))
                {
                    da.Fill(_table);
                }

                _connection.Close();
            }

            if (_table.Rows.Count > 0)
            {
                _ServerName = _table.Rows[0]["machine_name"].ToString();
                _MachineName = _table.Rows[0]["host_name"].ToString();
                _MachineIP = _table.Rows[0]["ip_address"].ToString();
                _IsCurrentMachine = Convert.ToBoolean(_table.Rows[0]["is_current_machine"].ToString());
                _LoginDomain = _table.Rows[0]["conn_domain_name"].ToString();
                _LoginUsername = _table.Rows[0]["conn_user_name"].ToString();
                _LoginPassword = _table.Rows[0]["conn_user_password"].ToString();
            }
        }

        private void load_servercounters()
        {
            counters.Clear();
            mycounters.Clear();

            DataTable _table = new DataTable();
            string _sql = $@"select set_counters.counter_id, set_counters.category_name, set_counters.counter_name, counters.instance_id
from montr_monitor_counters counters
inner join set_counters set_counters on counters.counter_id = set_counters.counter_id
where counters.machine_id = '{_ServerID}' and counters.is_deleted = 0 and counters.is_active = 1";
            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                _connection.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(_sql, _connection))
                {
                    da.Fill(_table);
                }

                _connection.Close();
            }

            bool _machine_reachable = false;
            if (_IsCurrentMachine == false)
            {
                _machine_reachable = PingMachine();
            }
            
            for (int i = 0; i < _table.Rows.Count; i++)
            {
                if (_IsCurrentMachine == true)
                {
                    counters.Add(new PerformanceCounter(_table.Rows[i]["category_name"].ToString(), _table.Rows[i]["counter_name"].ToString(), _table.Rows[i]["instance_id"].ToString()));
                    mycounters.Add(new MonitorCounter() { CounterID = _table.Rows[i]["counter_id"].ToString(), CategoryName = _table.Rows[i]["category_name"].ToString(), CounterName = _table.Rows[i]["counter_name"].ToString(), InstanceName = _table.Rows[i]["instance_id"].ToString() });
                }
                else
                {
                    if (_machine_reachable)
                    {
                        if (_IsLoggedIn)
                        {
                            try
                            {
                                counters.Add(new PerformanceCounter(_table.Rows[i]["category_name"].ToString(), _table.Rows[i]["counter_name"].ToString(), _table.Rows[i]["instance_id"].ToString(), _MachineName));
                                mycounters.Add(new MonitorCounter() { CounterID = _table.Rows[i]["counter_id"].ToString(), CategoryName = _table.Rows[i]["category_name"].ToString(), CounterName = _table.Rows[i]["counter_name"].ToString(), InstanceName = _table.Rows[i]["instance_id"].ToString() });
                            }
                            catch (Exception ex)
                            {
                            }
                        }
                        else
                        {
                            // raise error in database

                        }
                    }
                    else
                    {
                        // raise error in database
                    }
                }

            }
        }

        private void RunFirstTimeCounters()
        {
            if (logonSuccess)
            {
                if (_IsCurrentMachine == false && logonSuccess)
                {
                    identity = new WindowsIdentity(userHandle);
                    context = identity.Impersonate();
                }



                for (int i = 0; i < counters.Count; i++)
                {
                    float _counter_value = counters[i].NextValue();

                    MonitorCounter _mycounter = mycounters.Where(p => p.CategoryName == counters[i].CategoryName && p.CounterName == counters[i].CounterName && p.InstanceName == counters[i].InstanceName).FirstOrDefault();
                    if (_mycounter != null)
                    {
                        // display result on screen
                        setControls("SEND_OUTPUT", _mycounter.CounterID + " >> " + counters[i].CategoryName + " >> " + counters[i].CounterName + " >> " + counters[i].InstanceName + " >> " + _counter_value + Environment.NewLine);
                    }
                }

                setControls("SEND_OUTPUT", "-------------------------------- - " + Environment.NewLine);

                if (_IsCurrentMachine == false && logonSuccess)
                {
                    context.Undo();
                }


            }
            else
            {
                setControls("SEND_OUTPUT", "Login failed" + Environment.NewLine);
                throw new Exception("Login failed");
            }

        }

        private bool PingMachine()
        {
            bool _pingresult = false;

            System.Net.NetworkInformation.Ping pingSender = new System.Net.NetworkInformation.Ping();
            System.Net.NetworkInformation.PingOptions options = new System.Net.NetworkInformation.PingOptions();

            // Use the default Ttl value which is 128,
            // but change the fragmentation behavior.
            options.DontFragment = true;

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;

            try
            {
                System.Net.NetworkInformation.PingReply reply = pingSender.Send(_MachineName, timeout, buffer, options);
                if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                {
                    _pingresult = true;

                    string _result = "";
                    _result += $"Address: {reply.Address.ToString()}";
                    _result += $"RoundTrip time: {reply.RoundtripTime}";
                    _result += $"Time to live: {reply.Options.Ttl}";
                    _result += $"Don't fragment: {reply.Options.DontFragment}";
                    _result += $"Buffer size: {reply.Buffer.Length}";
                }

            }
            catch (Exception ex)
            {
                _pingresult = false;
            }

            return _pingresult;
        }

        private void tmrMonitor_Tick(object sender, EventArgs e)
        {
            if (chkIsActive.Checked == false) return;
            if (m_oWorker01.IsBusy == false)
            {
                btnStart.Enabled = false;
                btnCancel.Enabled = true;
                progressBar01.Value = 0;

                m_oWorker01.RunWorkerAsync();

                tmrMonitor.Stop();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (m_oWorker01.IsBusy)
            {
                m_oWorker01.CancelAsync();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (m_oWorker01.IsBusy == false)
            {
                btnStart.Enabled = false;
                btnCancel.Enabled = true;
                progressBar01.Value = 0;

                m_oWorker01.RunWorkerAsync();
            }
        }


        void m_oWorker01_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int _JobFinalStatus;

            if (e.Cancelled)
            {
                lblResults01.Text = "Task Cancelled.";
                InsertLogMessage("Job cancelled", _LogFilePath);
                InsertLogMessage("-----------------------------------------------------------", _LogFilePath);
                _JobFinalStatus = 3;
            }
            else if (e.Error != null)
            {
                lblResults01.Text = "Error while performing background operation.";
                InsertLogMessage("Job stopped with errors", _LogFilePath);
                InsertLogMessage("-----------------------------------------------------------", _LogFilePath);
                _JobFinalStatus = 2;
            }
            else
            {
                lblResults01.Text = "Task Completed...";
                InsertLogMessage("Job completed successfully", _LogFilePath);
                InsertLogMessage("-----------------------------------------------------------", _LogFilePath);
                _JobFinalStatus = 1;

            }

            btnStart.Enabled = true;
            btnCancel.Enabled = false;

            // set the next run timer
            int _curMinute = DateTime.Now.Minute;
			//int _MinutesToAdd = 1;
			//DateTime _NextRunTime = DateTime.Now.AddMinutes(_MinutesToAdd);
			int _SecondsToAdd = 5;
			DateTime _NextRunTime = DateTime.Now.AddSeconds(_SecondsToAdd);

			tmrMonitor.Interval = _SecondsToAdd * 1000;
			tmrMonitor.Start();
            lblResults01.Text = "Next Run on: " + _NextRunTime.ToString("dd/MM/yyyy HH:mm:ss");

            //insert/update the transaction in db
            //bool _updated = Functions.Update_DB_JOB_Transaction(_TransGuid, _JobStartDateTime01, DateTime.Now, _JobFinalStatus, _ProcessedCount01);
        }

        void m_oWorker01_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == -1)
            {
                lblStatus01.Text = "0 %";
            }
            else
            {
                progressBar01.Value = e.ProgressPercentage;
                lblStatus01.Text = progressBar01.Value.ToString() + " %";
            }
        }

        void m_oWorker01_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //_TransGuid = Guid.NewGuid().ToString();
                _JobStartDateTime01 = DateTime.Now;
                _ProcessedCount01 = 0;

                m_oWorker01.ReportProgress(-1);

                setControls("CUR_STATUS", "Job Started.");

                if (logonSuccess)
                {
                    if (_IsCurrentMachine == false && logonSuccess)
                    {
                        identity = new WindowsIdentity(userHandle);
                        context = identity.Impersonate();
                    }



                    for (int i = 0; i < counters.Count; i++)
                    {
                        float _counter_value = counters[i].NextValue();
                        //if (_counter_value == 0) _counter_value = counters[i].NextValue();

                        MonitorCounter _mycounter = mycounters.Where(p => p.CategoryName == counters[i].CategoryName && p.CounterName == counters[i].CounterName && p.InstanceName == counters[i].InstanceName).FirstOrDefault();
                        if (_mycounter != null)
                        {
                            // insert data to database
                            InsertCounterTransaction(_ServerID, _mycounter.CounterID, counters[i].InstanceName, DateTime.Now, _counter_value);

                            // display result on screen
                            setControls("SEND_OUTPUT", _mycounter.CounterID + " >> " + counters[i].CategoryName + " >> " + counters[i].CounterName + " >> " + counters[i].InstanceName + " >> " + _counter_value + Environment.NewLine);
                        }
                    }

                    setControls("SEND_OUTPUT", "-------------------------------- - " + Environment.NewLine);

                    if (_IsCurrentMachine == false && logonSuccess)
                    {
                        context.Undo();
                    }

                    if (DataSentEvent != null)
                    {
                        // send data/progress to main form which is hosting this child form
                        DataSentEvent(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), _ServerID);
                    }


                    m_oWorker01.ReportProgress(100);

                }
                else
                {
                    setControls("SEND_OUTPUT", "Login failed" + Environment.NewLine);
                    throw new Exception("Login failed");
                }


            }
            catch (Exception ex)
            {
                string _error_message = ex.Message;
                if (ex.InnerException != null) _error_message += " InnerException: " + ex.InnerException.Message;
                InsertLogMessage(_error_message, _LogFilePath);
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        private int InsertCounterTransaction(string _machine_id, string _counter_id, string _instance_id, DateTime _counter_datetime, float _counter_value)
        {
            int rowsInserted = 0;
            int rowsUpdated = 0;

            using (SqlConnection connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO montr_monitor_transactions (machine_id, counter_id, instance_id, counter_datetime, counter_value)
                                             VALUES (@machine_id, @counter_id, @instance_id, @counter_datetime, @counter_value)";
                    command.Parameters.Add("@machine_id", SqlDbType.VarChar).Value = _machine_id;
                    command.Parameters.Add("@counter_id", SqlDbType.VarChar).Value = _counter_id;
                    command.Parameters.Add("@instance_id", SqlDbType.VarChar).Value = _instance_id;
                    command.Parameters.Add("@counter_datetime", SqlDbType.DateTime).Value = _counter_datetime;
                    command.Parameters.Add("@counter_value", SqlDbType.Float).Value = _counter_value;
                    rowsInserted = command.ExecuteNonQuery();
                }

                if (rowsInserted > 0)
                {
                    using (SqlCommand command2 = new SqlCommand())
                    {
                        command2.Connection = connection;
                        command2.CommandType = CommandType.StoredProcedure;
                        command2.CommandText = "UpdateServerCounterValues";
                        command2.Parameters.Add("@machine_id", SqlDbType.VarChar).Value = _machine_id;
                        command2.Parameters.Add("@counter_id", SqlDbType.VarChar).Value = _counter_id;
                        command2.Parameters.Add("@instance_id", SqlDbType.VarChar).Value = _instance_id;
                        command2.Parameters.Add("@counter_datetime", SqlDbType.DateTime).Value = _counter_datetime;
                        command2.Parameters.Add("@counter_value", SqlDbType.Float).Value = _counter_value;
                        command2.ExecuteNonQuery();
                    }
                }

                //using (SqlCommand command2 = new SqlCommand())
                //{
                //    command2.Connection = connection;
                //    command2.CommandText = @"UPDATE tool_monitor_servers_data SET sys_system_name = @sys_system_name, sys_ip_address = @sys_ip_address, cpu_processor_id = @cpu_processor_id, cpu_processor_name = @cpu_processor_name, cpu_cores_count = @cpu_cores_count, cpu_cores_enabled_count = @cpu_cores_enabled_count, cpu_logical_processors_count = @cpu_logical_processors_count, cpu_max_clock_speed = @cpu_max_clock_speed, memory_total = @memory_total, storage_total = @storage_total WHERE server_id = @server_id";
                //    command2.Parameters.Add("@server_id", SqlDbType.VarChar).Value = server_id;
                //    command2.Parameters.Add("@sys_system_name", SqlDbType.VarChar).Value = sys_system_name;
                //    command2.Parameters.Add("@sys_ip_address", SqlDbType.VarChar).Value = sys_ip_address;
                //    command2.Parameters.Add("@cpu_processor_id", SqlDbType.VarChar).Value = cpu_processor_id;
                //    command2.Parameters.Add("@cpu_processor_name", SqlDbType.VarChar).Value = cpu_processor_name;
                //    command2.Parameters.Add("@cpu_cores_count", SqlDbType.SmallInt).Value = cpu_cores_count;
                //    command2.Parameters.Add("@cpu_cores_enabled_count", SqlDbType.SmallInt).Value = cpu_cores_enabled_count;
                //    command2.Parameters.Add("@cpu_logical_processors_count", SqlDbType.SmallInt).Value = cpu_logical_processors_count;
                //    command2.Parameters.Add("@cpu_max_clock_speed", SqlDbType.SmallInt).Value = cpu_max_clock_speed;
                //    command2.Parameters.Add("@memory_total", SqlDbType.Decimal).Value = memory_total;
                //    command2.Parameters.Add("@storage_total", SqlDbType.Decimal).Value = storage_total;
                //    rowsUpdated = command2.ExecuteNonQuery();
                //}

                connection.Close();
            }

            //if (rowsInserted == 0)
            //{
            //    _serviceOutput.status = "NO";
            //    _serviceOutput.responseCode = "1";
            //    _serviceOutput.responseDescription = "Server Information Update Failed";
            //    _serviceOutput.errorCode = "1001";
            //    _serviceOutput.errorDescription = "";
            //}
            //else
            //{
            //    _serviceOutput.status = "OK";
            //    _serviceOutput.responseCode = "0";
            //    _serviceOutput.responseDescription = "Server Information Updated Successfully";
            //    _serviceOutput.errorCode = "";
            //    _serviceOutput.errorDescription = "";
            //}


            return rowsInserted;
        }




        private delegate void stringDelegate(string Key, string Value);
        private void setControls(string Key, string Value)
        {
            try
            {
                if (lblResults01.InvokeRequired)
                {
                    stringDelegate sd = new stringDelegate(setControls);
                    this.Invoke(sd, new object[] { Key, Value });
                }
                else
                {
                    if (Key == "CUR_FILE_NAME")
                    {
                        lblResults01.Text = "Downloading File " + _CurFileIndex01.ToString() + "/" + _TotalFilesCount01.ToString() + " " + Value;
                    }
                    else if (Key == "LOGIN_FAILED")
                    {
                        lblResults01.Text = "Login Failed.";
                    }
                    else if (Key == "SEND_OUTPUT")
                    {
                        txtOutput.Text += Value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public static void InsertLogMessage(string msg, string LogFile)
        {
            //string _filename = "";
            System.IO.StreamWriter sw = System.IO.File.AppendText(LogFile);
            try
            {
                string logLine = System.String.Format("{0:G}: {1}", System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), msg);
                sw.WriteLine(logLine);
            }
            finally
            {
                sw.Close();
            }
        }

    }

    public class MonitorCounter
    {
        public string CounterID { get; set; }
        public string CategoryName { get; set; }
        public string CounterName { get; set; }
        public string InstanceName { get; set; }
    }
}
