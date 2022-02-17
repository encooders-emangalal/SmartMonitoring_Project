using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SmartMonitoring
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _connection_string = "Data source=HP-PC; Database=SmartMetering;User Id=sa;Password=P@ssw0rd";
            //System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(_connection_string);
            //string query = "INSERT INTO tool_monitor_servers_transactions (transaction_dt, server_id, sys_up_time, sys_process_count, sys_thread_count,  cpu_load_percent, cpu_utilization_percent, cpu_processor_speed, memory_total, memory_available, storage_total, storage_free)";
            //query += " VALUES (@transaction_dt, @server_id, @sys_up_time, @sys_process_count, @sys_thread_count,  @cpu_load_percent, @cpu_utilization_percent, @cpu_processor_speed, @memory_total, @memory_available, @storage_total, @storage_free)";

            //System.Data.SqlClient.SqlCommand myCommand = new System.Data.SqlClient.SqlCommand(query, conn);
            //myCommand.Parameters.Add("@transaction_dt", SqlDbType.Date).Value = DateTime.Now;
            //myCommand.Parameters.Add("@server_id", SqlDbType.VarChar).Value = "qw12";
            //myCommand.Parameters.Add("@sys_up_time", SqlDbType.Float).Value = 1;
            //myCommand.Parameters.Add("@sys_process_count", SqlDbType.Int).Value = 1;
            //myCommand.Parameters.Add("@sys_thread_count", SqlDbType.Int).Value = 1;
            //myCommand.Parameters.Add("@cpu_load_percent", SqlDbType.Decimal).Value = 1;
            //myCommand.Parameters.Add("@cpu_utilization_percent", SqlDbType.Decimal).Value = 1;
            //myCommand.Parameters.Add("@cpu_processor_speed", SqlDbType.Decimal).Value = 1;
            //myCommand.Parameters.Add("@memory_total", SqlDbType.Decimal).Value = 1;
            //myCommand.Parameters.Add("@memory_available", SqlDbType.Decimal).Value = 1;
            //myCommand.Parameters.Add("@storage_total", SqlDbType.Decimal).Value = 1;
            //myCommand.Parameters.Add("@storage_free", SqlDbType.Decimal).Value = 1;
            ////myCommand.Parameters.AddWithValue("@ArticleContent", ArticleContentTextBox.Text);
            //// ... other parameters
            //myCommand.ExecuteNonQuery();



            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(_connection_string))
            {
                using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO tool_monitor_servers_transactions (transaction_dt, server_id, sys_up_time, sys_process_count, sys_thread_count,  cpu_load_percent, cpu_utilization_percent, cpu_processor_speed, memory_total, memory_available, storage_total, storage_free)
                                             VALUES (@transaction_dt, @server_id, @sys_up_time, @sys_process_count, @sys_thread_count,  @cpu_load_percent, @cpu_utilization_percent, @cpu_processor_speed, @memory_total, @memory_available, @storage_total, @storage_free)";
                    command.Parameters.Add("@transaction_dt", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@server_id", SqlDbType.VarChar).Value = "qw12";
                    command.Parameters.Add("@sys_up_time", SqlDbType.Float).Value = 1;
                    command.Parameters.Add("@sys_process_count", SqlDbType.Int).Value = 1;
                    command.Parameters.Add("@sys_thread_count", SqlDbType.Int).Value = 1;
                    command.Parameters.Add("@cpu_load_percent", SqlDbType.Decimal).Value = 1;
                    command.Parameters.Add("@cpu_utilization_percent", SqlDbType.Decimal).Value = 1;
                    command.Parameters.Add("@cpu_processor_speed", SqlDbType.Decimal).Value = 1;
                    command.Parameters.Add("@memory_total", SqlDbType.Decimal).Value = 1;
                    command.Parameters.Add("@memory_available", SqlDbType.Decimal).Value = 1;
                    command.Parameters.Add("@storage_total", SqlDbType.Decimal).Value = 1;
                    command.Parameters.Add("@storage_free", SqlDbType.Decimal).Value = 1;

                    int rowsInserted = command.ExecuteNonQuery();
                    if (rowsInserted == 0)
                    {
                        //MessageBox.Show("Record not inserted");
                    }
                    else
                    {
                        //MessageBox.Show("Success!");
                    }


                    connection.Close();
                }
            }


            return;
            //Making Web Request  
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://localhost:60572/MonitoringTransactions.asmx");
            //SOAPAction  
            request.Headers.Add("SOAPAction", "http://smartcode.support/nwc/webservices/InsertMonitoringTransaction");
            //Content_type  
            request.ContentType = "text/xml;charset=\"utf-8\"";
            request.Accept = "text/xml";
            //HTTP method  
            request.Method = "POST";

            //request.UserAgent = ".NET Framework Client";
            //request.Credentials = CredentialCache.DefaultCredentials;

            XDocument ResultXML;
            XmlDocument SOAPReqBody = new XmlDocument();
            //SOAP Body Request  
            SOAPReqBody.LoadXml(@"<?xml version=""1.0"" encoding=""utf-8""?>  
            <soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:tem=""http://smartcode.support/nwc/webservices/"">
   <soapenv:Header/>
   <soapenv:Body>
      <tem:InsertMonitoringTransaction>
         <tem:server_id>1</tem:server_id>
         <tem:sys_up_time>1</tem:sys_up_time>
         <tem:sys_process_count>1</tem:sys_process_count>
         <tem:sys_thread_count>1</tem:sys_thread_count>
         <tem:cpu_load_percent>1</tem:cpu_load_percent>
         <tem:cpu_utilization_percent>1</tem:cpu_utilization_percent>
         <tem:cpu_processor_speed>1</tem:cpu_processor_speed>
         <tem:memory_total>1</tem:memory_total>
         <tem:memory_available>1</tem:memory_available>
         <tem:storage_total>1</tem:storage_total>
         <tem:storage_free>1</tem:storage_free>
      </tem:InsertMonitoringTransaction>
   </soapenv:Body>
</soapenv:Envelope>");


            using (Stream stream = request.GetRequestStream())
            {
                SOAPReqBody.Save(stream);
            }

            try
            {
                //Geting response from request  
                using (WebResponse Serviceres = request.GetResponse())
                {
                    using (StreamReader rd = new StreamReader(Serviceres.GetResponseStream()))
                    {
                        //reading stream  
                        string ServiceResult = rd.ReadToEnd();
                        //ServiceResult = ServiceResult.Replace("soap:", "soap_");
                        ResultXML = XDocument.Parse(ServiceResult);

                        string _response_status = "";
                        List<XElement> _result_elements = ResultXML.Descendants().ToList();
                        foreach (var item in _result_elements)
                        {
                            if (item.Name.LocalName == "status")
                            {
                                _response_status = item.Value;
                                break;
                            }
                        }

                    }
                }
            }
            catch (WebException ex)
            {
                string message = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
            }



        }
    }
}
