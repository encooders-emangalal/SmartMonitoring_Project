using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace SmartMonitoring.ASMX
{
    /// <summary>
    /// Summary description for InsertMonitoringTransaction
    /// </summary>
    //[WebService(Namespace = "http://tempuri.org/")]
    [WebService(Namespace = "http://smartcode.support/nwc/webservices/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    public class MonitoringTransactions : System.Web.Services.WebService
    {

        [WebMethod]
        public WebServiceOutput InsertMonitoringTransaction(string server_id, int sys_up_time, int sys_process_count, int sys_thread_count, decimal cpu_load_percent, decimal cpu_utilization_percent, decimal cpu_processor_speed, decimal memory_total, decimal memory_available, decimal storage_total, decimal storage_free)
        {
            WebServiceOutput _serviceOutput = new WebServiceOutput();

            try
            {

                string _connection_string = "Data source=HP-PC; Database=SmartMetering;User Id=sa;Password=P@ssw0rd";
                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(_connection_string))
                {
                    using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand())
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandText = @"INSERT INTO tool_monitor_servers_transactions (transaction_dt, server_id, sys_up_time, sys_process_count, sys_thread_count,  cpu_load_percent, cpu_utilization_percent, cpu_processor_speed, memory_total, memory_available, storage_total, storage_free)
                                             VALUES (@transaction_dt, @server_id, @sys_up_time, @sys_process_count, @sys_thread_count,  @cpu_load_percent, @cpu_utilization_percent, @cpu_processor_speed, @memory_total, @memory_available, @storage_total, @storage_free)";
                        command.Parameters.Add("@transaction_dt", SqlDbType.DateTime).Value = DateTime.Now;
                        command.Parameters.Add("@server_id", SqlDbType.VarChar).Value = server_id;
                        command.Parameters.Add("@sys_up_time", SqlDbType.Float).Value = sys_up_time;
                        command.Parameters.Add("@sys_process_count", SqlDbType.Int).Value = sys_process_count;
                        command.Parameters.Add("@sys_thread_count", SqlDbType.Int).Value = sys_thread_count;
                        command.Parameters.Add("@cpu_load_percent", SqlDbType.Decimal).Value = cpu_load_percent;
                        command.Parameters.Add("@cpu_utilization_percent", SqlDbType.Decimal).Value = cpu_utilization_percent;
                        command.Parameters.Add("@cpu_processor_speed", SqlDbType.Decimal).Value = cpu_processor_speed;
                        command.Parameters.Add("@memory_total", SqlDbType.Decimal).Value = memory_total;
                        command.Parameters.Add("@memory_available", SqlDbType.Decimal).Value = memory_available;
                        command.Parameters.Add("@storage_total", SqlDbType.Decimal).Value = storage_total;
                        command.Parameters.Add("@storage_free", SqlDbType.Decimal).Value = storage_free;

                        int rowsInserted = command.ExecuteNonQuery();
                        if (rowsInserted == 0)
                        {
                            _serviceOutput.status = "NO";
                            _serviceOutput.responseCode = "1";
                            _serviceOutput.responseDescription = "Transaction Failed";
                            _serviceOutput.errorCode = "1001";
                            _serviceOutput.errorDescription = "";
                        }
                        else
                        {
                            _serviceOutput.status = "OK";
                            _serviceOutput.responseCode = "0";
                            _serviceOutput.responseDescription = "Transaction Inserted Successfully";
                            _serviceOutput.errorCode = "";
                            _serviceOutput.errorDescription = "";
                        }


                        connection.Close();
                    }
                }



                return _serviceOutput;
            }
            catch (Exception ex)
            {
                string _error_message = ex.Message;
                if (ex.InnerException != null) _error_message += " InnerException: " + ex.InnerException.Message;

                _serviceOutput.status = "NO";
                _serviceOutput.responseCode = "1";
                _serviceOutput.responseDescription = "Runtime Error";
                _serviceOutput.errorCode = "1000";
                _serviceOutput.errorDescription = _error_message;

                return _serviceOutput;
            }
        }


        [WebMethod]
        public WebServiceOutput UpdateServerInformation(string server_id, string sys_system_name, string sys_ip_address, string cpu_processor_id, string cpu_processor_name, Int16 cpu_cores_count, Int16 cpu_cores_enabled_count, Int16 cpu_logical_processors_count, Int16 cpu_max_clock_speed, decimal memory_total, decimal storage_total)
        {
            WebServiceOutput _serviceOutput = new WebServiceOutput();

            try
            {
                int rowsInserted = 0;
                int rowsUpdated = 0;

                string _connection_string = "Data source=HP-PC; Database=SmartMetering;User Id=sa;Password=P@ssw0rd";
                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(_connection_string))
                {
                    connection.Open();
                    using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"INSERT INTO tool_monitor_servers_updates (transaction_dt, server_id, sys_system_name, sys_ip_address, cpu_processor_id, cpu_processor_name, cpu_cores_count, cpu_cores_enabled_count, cpu_logical_processors_count, cpu_max_clock_speed, memory_total, storage_total)
                                             VALUES (@transaction_dt, @server_id, @sys_system_name, @sys_ip_address, @cpu_processor_id, @cpu_processor_name, @cpu_cores_count, @cpu_cores_enabled_count, @cpu_logical_processors_count, @cpu_max_clock_speed, @memory_total, @storage_total)";
                        command.Parameters.Add("@transaction_dt", SqlDbType.DateTime).Value = DateTime.Now;
                        command.Parameters.Add("@server_id", SqlDbType.VarChar).Value = server_id;
                        command.Parameters.Add("@sys_system_name", SqlDbType.VarChar).Value = sys_system_name;
                        command.Parameters.Add("@sys_ip_address", SqlDbType.VarChar).Value = sys_ip_address;
                        command.Parameters.Add("@cpu_processor_id", SqlDbType.VarChar).Value = cpu_processor_id;
                        command.Parameters.Add("@cpu_processor_name", SqlDbType.VarChar).Value = cpu_processor_name;
                        command.Parameters.Add("@cpu_cores_count", SqlDbType.SmallInt).Value = cpu_cores_count;
                        command.Parameters.Add("@cpu_cores_enabled_count", SqlDbType.SmallInt).Value = cpu_cores_enabled_count;
                        command.Parameters.Add("@cpu_logical_processors_count", SqlDbType.SmallInt).Value = cpu_logical_processors_count;
                        command.Parameters.Add("@cpu_max_clock_speed", SqlDbType.SmallInt).Value = cpu_max_clock_speed;
                        command.Parameters.Add("@memory_total", SqlDbType.Decimal).Value = memory_total;
                        command.Parameters.Add("@storage_total", SqlDbType.Decimal).Value = storage_total;
                        rowsInserted = command.ExecuteNonQuery();
                    }

                    using (System.Data.SqlClient.SqlCommand command2 = new System.Data.SqlClient.SqlCommand())
                    {
                        command2.Connection = connection;
                        command2.CommandText = @"UPDATE tool_monitor_servers_data SET sys_system_name = @sys_system_name, sys_ip_address = @sys_ip_address, cpu_processor_id = @cpu_processor_id, cpu_processor_name = @cpu_processor_name, cpu_cores_count = @cpu_cores_count, cpu_cores_enabled_count = @cpu_cores_enabled_count, cpu_logical_processors_count = @cpu_logical_processors_count, cpu_max_clock_speed = @cpu_max_clock_speed, memory_total = @memory_total, storage_total = @storage_total WHERE server_id = @server_id";
                        command2.Parameters.Add("@server_id", SqlDbType.VarChar).Value = server_id;
                        command2.Parameters.Add("@sys_system_name", SqlDbType.VarChar).Value = sys_system_name;
                        command2.Parameters.Add("@sys_ip_address", SqlDbType.VarChar).Value = sys_ip_address;
                        command2.Parameters.Add("@cpu_processor_id", SqlDbType.VarChar).Value = cpu_processor_id;
                        command2.Parameters.Add("@cpu_processor_name", SqlDbType.VarChar).Value = cpu_processor_name;
                        command2.Parameters.Add("@cpu_cores_count", SqlDbType.SmallInt).Value = cpu_cores_count;
                        command2.Parameters.Add("@cpu_cores_enabled_count", SqlDbType.SmallInt).Value = cpu_cores_enabled_count;
                        command2.Parameters.Add("@cpu_logical_processors_count", SqlDbType.SmallInt).Value = cpu_logical_processors_count;
                        command2.Parameters.Add("@cpu_max_clock_speed", SqlDbType.SmallInt).Value = cpu_max_clock_speed;
                        command2.Parameters.Add("@memory_total", SqlDbType.Decimal).Value = memory_total;
                        command2.Parameters.Add("@storage_total", SqlDbType.Decimal).Value = storage_total;
                        rowsUpdated = command2.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                if (rowsInserted == 0)
                {
                    _serviceOutput.status = "NO";
                    _serviceOutput.responseCode = "1";
                    _serviceOutput.responseDescription = "Server Information Update Failed";
                    _serviceOutput.errorCode = "1001";
                    _serviceOutput.errorDescription = "";
                }
                else
                {
                    _serviceOutput.status = "OK";
                    _serviceOutput.responseCode = "0";
                    _serviceOutput.responseDescription = "Server Information Updated Successfully";
                    _serviceOutput.errorCode = "";
                    _serviceOutput.errorDescription = "";
                }



                return _serviceOutput;
            }
            catch (Exception ex)
            {
                string _error_message = ex.Message;
                if (ex.InnerException != null) _error_message += " InnerException: " + ex.InnerException.Message;

                _serviceOutput.status = "NO";
                _serviceOutput.responseCode = "1";
                _serviceOutput.responseDescription = "Runtime Error";
                _serviceOutput.errorCode = "1000";
                _serviceOutput.errorDescription = _error_message;

                return _serviceOutput;
            }
        }

    }

    public class WebServiceOutput
    {
        public string status { get; set; }
        public string responseCode { get; set; }
        public string responseDescription { get; set; }
        public string errorCode { get; set; }
        public string errorDescription { get; set; }
    }

}
