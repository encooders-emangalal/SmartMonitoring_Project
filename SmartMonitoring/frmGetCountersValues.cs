using SmartMonitoring.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMonitoring
{
    public partial class frmGetCountersValues : Form
    {

        //IEnumerable<PerformanceCounter> _counterslist1;
        //IEnumerable<BackgroundWorker> _workerslist11;
        //BackgroundWorker[] _workerslist;
        //System.Threading.Thread[] _workers;

        static string _Log_Errors = Application.StartupPath + @"\log_app_errors.txt";

        List<PerformanceCounter> _counterslist = new List<PerformanceCounter>();
        List<System.Windows.Forms.Timer> _timerslist = new List<System.Windows.Forms.Timer>();
        DataTable _dtServers = new DataTable();
        DataTable _dtcounters = new DataTable();


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

        IntPtr userHandle = new IntPtr(0);
        bool logonSuccess = false;
        WindowsIdentity identity;
        WindowsImpersonationContext context;

        public frmGetCountersValues()
        {
            InitializeComponent();
        }

        private void frmGetCountersValues_Load(object sender, EventArgs e)
        {

            // get servers list and nfo
            _dtServers = getserversList();

            // login with the server users
            //string _username = "amr.prod";
            //string _password = "NwcP@ssw0rd131313";
            string _username = "mragab";
            string _password = "P@ssw0rd1090";
            logonSuccess = LogonUser(
                                      _username,
                                      "nwc.com.sa",
                                      _password,
                                      LOGON32_LOGON_NEW_CREDENTIALS,
                                      LOGON32_PROVIDER_WINNT50,
                                      ref userHandle
                                    );

            if (logonSuccess)
            {
                identity = new WindowsIdentity(userHandle);
                context = identity.Impersonate();
            }

            // get counters list
            _dtcounters = getCountersList();
            for (int i = 0; i < _dtcounters.Rows.Count; i++)
            {
                if (_dtcounters.Rows[i]["host_name"].ToString() == System.Environment.MachineName)
                {
                    PerformanceCounter _counter = new PerformanceCounter(_dtcounters.Rows[i]["category_name"].ToString(), _dtcounters.Rows[i]["counter_name"].ToString(), _dtcounters.Rows[i]["instance_id"].ToString());
                    _counter.NextValue();
                    _counterslist.Add(_counter);
                }
                else
                {
                    if (logonSuccess)
                    {
                        PerformanceCounter _counter = new PerformanceCounter(_dtcounters.Rows[i]["category_name"].ToString(), _dtcounters.Rows[i]["counter_name"].ToString(), _dtcounters.Rows[i]["instance_id"].ToString(), _dtcounters.Rows[i]["host_name"].ToString());
                        _counter.NextValue();
                        _counterslist.Add(_counter);
                    }
                }
            }

            if (logonSuccess) context.Undo();


            // start thread/timer for each counter
            foreach (var counter in _counterslist)
            {
                System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
                //_timer.Tag = "tag_id";
                _timer.Interval = 5000;
                _timer.Tick += delegate (object my_sender, EventArgs my_e) {
                    tmrTimer_Tick(my_sender, my_e, counter);
                };
                _timer.Start();
                _timerslist.Add(_timer);
            }



            #region MyRegion


            //string _category_name = "Processor";
            //PerformanceCounterCategory cat = new PerformanceCounterCategory(_category_name);
            //var inst = cat.GetInstanceNames();

            //if (inst.Count() > 0)
            //{
            //    foreach (string instance in inst)
            //    {
            //        var _counters = cat.GetCounters(instance).OrderBy(p => p.CounterName);
            //        foreach (PerformanceCounter _counter in _counters)
            //        {
            //            _counterslist.Add(new PerformanceCounter(_category_name, _counter.CounterName, instance));
            //        }

            //    }
            //}
            //else
            //{
            //    var _counters = cat.GetCounters().OrderBy(p => p.CounterName);
            //    foreach (PerformanceCounter _counter in _counters)
            //    {
            //        _counterslist.Add(new PerformanceCounter(_category_name, _counter.CounterName, ""));
            //    }
            //}





            //PerformanceCounter PCounter01 = new PerformanceCounter("Processor Information", "% Processor Utility", "_Total");
            //PerformanceCounter PCounter02 = new PerformanceCounter("Processor Information", "Processor Frequency", "_Total");
            //PerformanceCounter PCounter03 = new PerformanceCounter("Processor Information", "% Processor Performance", "_Total");
            //PerformanceCounter PCounter04 = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
            //PerformanceCounter PCounter05 = new PerformanceCounter("System", "System Up Time", "");
            //PerformanceCounter PCounter06 = new PerformanceCounter("System", "Processes", "");
            //PerformanceCounter PCounter07 = new PerformanceCounter("System", "Threads", "");

            //_counterslist.Add(PCounter01);
            //_counterslist.Add(PCounter02);
            //_counterslist.Add(PCounter03);
            //_counterslist.Add(PCounter04);
            //_counterslist.Add(PCounter05);
            //_counterslist.Add(PCounter06);
            //_counterslist.Add(PCounter07);





            //_counterslist1.Append(PCounter01);
            //_counterslist1.Append(PCounter02);
            //_counterslist1.Append(PCounter03);
            //_counterslist1.Append(PCounter04);
            //_counterslist1.Append(PCounter05);
            //_counterslist1.Append(PCounter06);
            //_counterslist1.Append(PCounter07);


            //tmrThreads.Start();

            //var _counters_filtered = _counterslist.Where(p => p.MachineName == "" && p.CategoryName == "" && p.CounterName == "" && p.InstanceName == "");


            //_workerslist = new BackgroundWorker[3];

            //BackgroundWorker _worker = new BackgroundWorker();

            //_workerslist11.Append(_worker);

            #endregion

        }


        private DataTable getserversList()
        {
            DataTable _table = new DataTable();
            string _sql = $@"SELECT server_id, server_name, server_description, host_name, ip_address, is_current_machine, conn_domain_name, conn_user_name, conn_user_password
  FROM SmartMonitoring.dbo.servers_data";
            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                _connection.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(_sql, _connection))
                {
                    da.Fill(_table);
                }

                _connection.Close();
            }

            return _table;
        }

        private DataTable getCountersList()
        {
            DataTable _table = new DataTable();
            string _sql = $@"select counters.server_id machine_id, servdata.server_name, servdata.host_name, servdata.ip_address, servdata.conn_domain_name, servdata.conn_user_name, servdata.conn_user_password
        , counters.counter_id, setcounters.counter_name, setcounters.category_name, setcounters.counter_unit, counters.instance_id
from montr_monitor_counters counters
inner join set_counters setcounters on counters.counter_id = setcounters.counter_id
inner join servers_data servdata on counters.server_id = servdata.server_id
where setcounters.is_active = 1 and servdata.is_active = 1 and servdata.is_deleted = 0";
            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                _connection.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(_sql, _connection))
                {
                    da.Fill(_table);
                }

                _connection.Close();
            }

            return _table;
        }


        private void tmrTimer_Tick(object sender, EventArgs e, PerformanceCounter _counter)
        {
            try
            {
                if (_counter.MachineName == ".")
                {
                    DataView _dv = _dtcounters.DefaultView;
                    _dv.RowFilter = $"host_name = '{System.Environment.MachineName}' and category_name = '{_counter.CategoryName}' and counter_name = '{_counter.CounterName}' and instance_id = '{_counter.InstanceName}'";
                    if (_dv.Count > 0)
                    {
                        InsertCounterTransaction(_dv[0]["machine_id"].ToString(), _dv[0]["counter_id"].ToString(), _dv[0]["instance_id"].ToString(), DateTime.Now, _counter.NextValue());
                    }
                }
                else
                {
                    DataView _dv = _dtcounters.DefaultView;
                    _dv.RowFilter = $"host_name = '{_counter.MachineName}' and category_name = '{_counter.CategoryName}' and counter_name = '{_counter.CounterName}' and instance_id = '{_counter.InstanceName}'";
                    if (_dv.Count > 0)
                    {
                        InsertCounterTransaction(_dv[0]["machine_id"].ToString(), _dv[0]["counter_id"].ToString(), _dv[0]["instance_id"].ToString(), DateTime.Now, _counter.NextValue());
                    }
                }
            }
            catch (Exception ex)
            {
                Functions.InsertLogMessage(ex.Message, _Log_Errors);
            }
        }


        private int InsertCounterTransaction(string machine_id, string counter_id, string instance_id, DateTime counter_datetime, float counter_value)
        {
            int rowsInserted = 0;

            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                using (SqlCommand _command = new SqlCommand())
                {
                    _connection.Open();
                    _command.Connection = _connection;
                    _command.CommandText = @"INSERT INTO montr_monitor_transactions (machine_id, counter_id, instance_id, counter_datetime, counter_value)
                                             VALUES (@machine_id, @counter_id, @instance_id, @counter_datetime, @counter_value)";
                    _command.Parameters.Add("@machine_id", SqlDbType.VarChar).Value = machine_id;
                    _command.Parameters.Add("@counter_id", SqlDbType.VarChar).Value = counter_id;
                    _command.Parameters.Add("@instance_id", SqlDbType.VarChar).Value = instance_id;
                    _command.Parameters.Add("@counter_datetime", SqlDbType.DateTime).Value = counter_datetime;
                    _command.Parameters.Add("@counter_value", SqlDbType.Float).Value = counter_value;

                    rowsInserted = _command.ExecuteNonQuery();
                    //if (rowsInserted > 0)
                    //{
                    //}


                    _connection.Close();
                }
            }

            return rowsInserted;

        }


        // ping the remote computer 
        private bool VerifyRemoteMachineStatus(string machineName)
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send(machineName);
                    if (reply.Status == IPStatus.Success)
                    { return true; }
                }
            }
            catch (Exception ex)
            {
                // return false for any exception encountered
                // we'll probably want to just shut down anyway
            }
            return false;
        }



















        private int XXInsertCounterTransaction(string machine_name, string category_name, string counter_name, string instance_name, DateTime counter_datetime, float counter_value)
        {
            int rowsInserted = 0;

            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                using (SqlCommand _command = new SqlCommand())
                {
                    _connection.Open();
                    _command.Connection = _connection;
                    _command.CommandText = @"INSERT INTO xx_counters_transactions (machine_name, category_name, counter_name, instance_name, counter_datetime, counter_value)
                                             VALUES (@machine_name, @category_name, @counter_name, @instance_name, @counter_datetime, @counter_value)";
                    _command.Parameters.Add("@machine_name", SqlDbType.VarChar).Value = machine_name;
                    _command.Parameters.Add("@category_name", SqlDbType.VarChar).Value = category_name;
                    _command.Parameters.Add("@counter_name", SqlDbType.VarChar).Value = counter_name;
                    _command.Parameters.Add("@instance_name", SqlDbType.VarChar).Value = instance_name;
                    _command.Parameters.Add("@counter_datetime", SqlDbType.DateTime).Value = counter_datetime;
                    _command.Parameters.Add("@counter_value", SqlDbType.Float).Value = counter_value;

                    rowsInserted = _command.ExecuteNonQuery();
                    //if (rowsInserted > 0)
                    //{
                    //}


                    _connection.Close();
                }
            }

            return rowsInserted;

        }

        private void tmrThreads_Tick(object sender, EventArgs e)
        {
            foreach (var counter in _counterslist)
            {
                Thread t = new Thread(() => run_counters(counter));
                t.Start();
            }
        }

        private void run_counters(PerformanceCounter _counter)
        {
            XXInsertCounterTransaction("", _counter.CategoryName, _counter.CounterName, _counter.InstanceName, DateTime.Now, _counter.NextValue());
        }


    }
}
