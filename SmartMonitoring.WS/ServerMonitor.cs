using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Xml;
using System.Xml.Linq;

namespace SmartMonitoring.WS
{
    public partial class ServerMonitor : ServiceBase
    {
        System.Timers.Timer timer = new System.Timers.Timer();

        PerformanceCounter PCounter00 = new PerformanceCounter();
        PerformanceCounter PCounter01 = new PerformanceCounter("Processor Information", "% Processor Utility", "_Total");
        PerformanceCounter PCounter02 = new PerformanceCounter("Processor Information", "Processor Frequency", "_Total");
        PerformanceCounter PCounter03 = new PerformanceCounter("Processor Information", "% Processor Performance", "_Total");
        PerformanceCounter PCounter04 = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter PCounter05 = new PerformanceCounter("System", "System Up Time", "");
        PerformanceCounter PCounter06 = new PerformanceCounter("System", "Processes", "");
        PerformanceCounter PCounter07 = new PerformanceCounter("System", "Threads", "");

        public ServerMonitor()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            WriteToFile($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: Service started");
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 30000;
            timer.Enabled = true;
        }

        protected override void OnStop()
        {
            WriteToFile($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: Service stopped");
        }

        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            try
            {
                WriteToFile($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: Job Started");

                //*********** GET INFO *****************************************************************************
                // server info
                string _SystemName = "";
                string _SystemIPAddress = "";
                string _ProcessorId = "";
                string _ProcessorName = "";
                Int16 _ProcessorCoresCount = 0;
                Int16 _ProcessorCoresEnabledCount = 0;
                Int16 _ProcessorLogicalCount = 0;
                Int16 _ProcessorMaxClockSpeed = 0;
                decimal _ProcessorLoadPercentage = 0;
                var objset = new ManagementObjectSearcher("SELECT * FROM Win32_Processor").Get();
                foreach (ManagementObject obj in objset)
                {
                    //maxspeed = Convert.ToDouble(obj["MaxClockSpeed"]);
                    _SystemName = obj["SystemName"].ToString();
                    _ProcessorId = obj["ProcessorId"].ToString();
                    _ProcessorName = obj["Name"].ToString();
                    _ProcessorCoresCount = Convert.ToInt16(obj["NumberOfCores"].ToString());
                    _ProcessorCoresEnabledCount = Convert.ToInt16(obj["NumberOfEnabledCore"].ToString());
                    _ProcessorLogicalCount = Convert.ToInt16(obj["NumberOfLogicalProcessors"].ToString());
                    _ProcessorMaxClockSpeed = Convert.ToInt16(obj["MaxClockSpeed"].ToString());
                    _ProcessorLoadPercentage = Convert.ToDecimal(obj["LoadPercentage"].ToString());
                }
                //WriteToFile($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: Win32_Processor collected");

                // system values
                Int32 _ProcessorUpTime = Convert.ToInt32(decimal.Round(Convert.ToDecimal(PCounter05.NextValue()), 0).ToString());
                int _ProcessorProcessesCount = Convert.ToInt32(PCounter06.NextValue().ToString());
                int _ProcessorThreadsCount = Convert.ToInt32(PCounter07.NextValue().ToString());
                //WriteToFile($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: system collected");

                // CPU (processor)
                decimal _ProcessorUtilizationPercentage = Convert.ToDecimal(PCounter01.NextValue().ToString());
                double maxspeed = PCounter02.NextValue();
                double cpuValue = PCounter03.NextValue();
                //string _ProcessorBaseSpeed = (maxspeed / 1000).ToString();
                decimal _ProcessorSpeed = Convert.ToDecimal(((maxspeed / 1000) * cpuValue / 100));
                //WriteToFile($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: processor collected");

                // memory
                decimal _MemoryTotal = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
                decimal _MemoryAvailable = new Microsoft.VisualBasic.Devices.ComputerInfo().AvailablePhysicalMemory;
                decimal _MemoryUsed = _MemoryTotal - _MemoryAvailable;
                decimal _MemoryTotalCalc = (_MemoryTotal / (1024 * 1024 * 1024));
                decimal _MemoryAvailableCalc = (_MemoryAvailable / (1024 * 1024 * 1024));
                decimal _MemoryUsedCalc = (_MemoryUsed / (1024 * 1024 * 1024));
                //WriteToFile($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: memory collected");

                // storage (HDD)
                decimal _totalspace = 0;
                decimal _freespace = 0;
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (drive.IsReady)
                    {
                        _totalspace += drive.TotalSize;
                        _freespace += drive.AvailableFreeSpace;
                    }
                }
                decimal _HDDTotalSpace = (_totalspace / (1024 * 1024 * 1024));
                decimal _HDDFreeSpace = (_freespace / (1024 * 1024 * 1024));
                //WriteToFile($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: hdd collected");
                //*******************************************************************************
                WriteToFile($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: required information collected successfully");

                // get current server details from config file
                XmlDocument xml = new XmlDocument();
                xml.Load(AppDomain.CurrentDomain.BaseDirectory + @"\tool_config.xml");
                XmlElement elt = xml.SelectSingleNode("//ServerDetails[@ID='CurrentServer']") as XmlElement;
                if (elt == null) return;
                string _cfg_server_id = elt["SERVER_ID"].InnerText;
                string _cfg_system_name = elt["SYSTEM_NAME"].InnerText;
                string _cfg_ip_address = elt["IP_ADDRESS"].InnerText;
                string _cfg_cpu_processor_id = elt["CPU_PROCESSOR_ID"].InnerText;
                string _cfg_cpu_processor_name = elt["CPU_PROCESSOR_NAME"].InnerText;
                string _cfg_cpu_cores_count = elt["CPU_CORES_COUNT"].InnerText;
                string _cfg_cpu_cores_enabled_count = elt["CPU_CORES_ENABLED_COUNT"].InnerText;
                string _cfg_cpu_legal_processors_count = elt["CPU_LOGICAL_PROCESSORS_COUNT"].InnerText;
                string _cfg_cpu_max_clock_speed = elt["CPU_MAX_CLOCK_SPEED"].InnerText;
                string _cfg_memory_total = elt["MEMORY_TOTAL"].InnerText;
                string _cfg_storage_total = elt["STORAGE_TOTAL"].InnerText;
                WriteToFile($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: config file data collected successfully");

                // insert current transaction
                string _response_result = PostInsertMonitoringTransaction(_cfg_server_id, _ProcessorUpTime, _ProcessorProcessesCount, _ProcessorThreadsCount
                    , _ProcessorLoadPercentage, _ProcessorUtilizationPercentage, _ProcessorSpeed, _MemoryTotalCalc, _MemoryAvailableCalc, _HDDTotalSpace, _HDDFreeSpace);
                if (_response_result == "OK")
                {
                    WriteToFile($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: collected data inserted to db successfully");
                }
                else
                {
                    WriteToFile($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: failed to insert collected data to db");
                }

                // update server info in db and config file (if required)
                if (_cfg_system_name != _SystemName || _cfg_cpu_processor_id != _ProcessorId || _cfg_cpu_processor_name != _ProcessorName || Convert.ToInt16(_cfg_cpu_cores_count) != _ProcessorCoresCount || Convert.ToInt16(_cfg_cpu_cores_enabled_count) != _ProcessorCoresEnabledCount
                    || Convert.ToInt16(_cfg_cpu_legal_processors_count) != _ProcessorLogicalCount || Convert.ToInt16(_cfg_cpu_max_clock_speed) != _ProcessorMaxClockSpeed || Convert.ToDecimal(_cfg_memory_total) != _MemoryTotalCalc || Convert.ToDecimal(_cfg_storage_total) != _HDDTotalSpace)
                {
                    // update database
                    string _response_result2 = PostUpdateServerInformation(_cfg_server_id, _SystemName, _SystemIPAddress, _ProcessorId
                            , _ProcessorName, _ProcessorCoresCount, _ProcessorCoresEnabledCount, _ProcessorLogicalCount, _ProcessorMaxClockSpeed, _MemoryTotalCalc, _HDDTotalSpace);
                    if (_response_result2 == "OK")
                    {
                        WriteToFile($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: server info updated into db successfully");
                    }
                    else
                    {
                        WriteToFile($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: server info failed to be updated into db");
                    }

                    // update config file
                    elt["SYSTEM_NAME"].InnerText = _SystemName;
                    //elt["IP_ADDRESS"].InnerText = _SystemIPAddress;
                    elt["CPU_PROCESSOR_ID"].InnerText = _ProcessorId;
                    elt["CPU_PROCESSOR_NAME"].InnerText = _ProcessorName;
                    elt["CPU_CORES_COUNT"].InnerText = _ProcessorCoresCount.ToString();
                    elt["CPU_CORES_ENABLED_COUNT"].InnerText = _ProcessorCoresEnabledCount.ToString();
                    elt["CPU_LOGICAL_PROCESSORS_COUNT"].InnerText = _ProcessorLogicalCount.ToString();
                    elt["CPU_MAX_CLOCK_SPEED"].InnerText = _ProcessorMaxClockSpeed.ToString();
                    elt["MEMORY_TOTAL"].InnerText = _MemoryTotalCalc.ToString();
                    elt["STORAGE_TOTAL"].InnerText = _HDDTotalSpace.ToString();
                    xml.Save(AppDomain.CurrentDomain.BaseDirectory + @"\tool_config.xml");
                    WriteToFile($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: config file updated successfully");
                }


                WriteToFile($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: job completed successfully");
                WriteToFile($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: ---------------------------------------------------");
            }
            catch (Exception ex)
            {
                WriteToFile($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: {ex.Message}");
                WriteToFile($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}: ---------------------------------------------------");
            }
        }

        private string PostInsertMonitoringTransaction(string server_id, int sys_up_time, int sys_process_count, int sys_thread_count, decimal cpu_load_percent, decimal cpu_utilization_percent, decimal cpu_processor_speed, decimal memory_total, decimal memory_available, decimal storage_total, decimal storage_free)
        {
            string _response_status = "";

            try
            {
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
                SOAPReqBody.LoadXml($@"<?xml version=""1.0"" encoding=""utf-8""?>  
                <soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:tem=""http://smartcode.support/nwc/webservices/"">
<soapenv:Header/>
    <soapenv:Body>
        <tem:InsertMonitoringTransaction>
            <tem:server_id>{server_id}</tem:server_id>
            <tem:sys_up_time>{sys_up_time}</tem:sys_up_time>
            <tem:sys_process_count>{sys_process_count}</tem:sys_process_count>
            <tem:sys_thread_count>{sys_thread_count}</tem:sys_thread_count>
            <tem:cpu_load_percent>{cpu_load_percent}</tem:cpu_load_percent>
            <tem:cpu_utilization_percent>{cpu_utilization_percent}</tem:cpu_utilization_percent>
            <tem:cpu_processor_speed>{cpu_processor_speed}</tem:cpu_processor_speed>
            <tem:memory_total>{memory_total}</tem:memory_total>
            <tem:memory_available>{memory_available}</tem:memory_available>
            <tem:storage_total>{storage_total}</tem:storage_total>
            <tem:storage_free>{storage_free}</tem:storage_free>
        </tem:InsertMonitoringTransaction>
    </soapenv:Body>
</soapenv:Envelope>");


                using (Stream stream = request.GetRequestStream())
                {
                    SOAPReqBody.Save(stream);
                }

                //Geting response from request  
                using (WebResponse Serviceres = request.GetResponse())
                {
                    using (StreamReader rd = new StreamReader(Serviceres.GetResponseStream()))
                    {
                        //reading stream  
                        string ServiceResult = rd.ReadToEnd();
                        //ServiceResult = ServiceResult.Replace("soap:", "soap_");
                        ResultXML = XDocument.Parse(ServiceResult);

                        List<XElement> _result_elements = ResultXML.Descendants().ToList();
                        foreach (var item in _result_elements)
                        {
                            if (item.Name.LocalName == "status")
                            {
                                _response_status = item.Value;
                                break;
                            }
                        }

                        return _response_status;

                    }
                }
            }
            catch (WebException ex)
            {
                string message = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                return "";
            }


        }

        private string PostUpdateServerInformation(string server_id, string sys_system_name, string sys_ip_address, string cpu_processor_id, string cpu_processor_name, Int16 cpu_cores_count, Int16 cpu_cores_enabled_count, Int16 cpu_logical_processors_count, Int16 cpu_max_clock_speed, decimal memory_total, decimal storage_total)
        {
            string _response_status = "";

            try
            {
                //Making Web Request  
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://localhost:60572/MonitoringTransactions.asmx");
                //SOAPAction  
                request.Headers.Add("SOAPAction", "http://smartcode.support/nwc/webservices/UpdateServerInformation");
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
                SOAPReqBody.LoadXml($@"<?xml version=""1.0"" encoding=""utf-8""?>  
                <soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:tem=""http://smartcode.support/nwc/webservices/"">
<soapenv:Header/>
    <soapenv:Body>
        <tem:UpdateServerInformation>
            <tem:server_id>{server_id}</tem:server_id>
            <tem:sys_system_name>{sys_system_name}</tem:sys_system_name>
            <tem:sys_ip_address>{sys_ip_address}</tem:sys_ip_address>
            <tem:cpu_processor_id>{cpu_processor_id}</tem:cpu_processor_id>
            <tem:cpu_processor_name>{cpu_processor_name}</tem:cpu_processor_name>
            <tem:cpu_cores_count>{cpu_cores_count}</tem:cpu_cores_count>
            <tem:cpu_cores_enabled_count>{cpu_cores_enabled_count}</tem:cpu_cores_enabled_count>
            <tem:cpu_logical_processors_count>{cpu_logical_processors_count}</tem:cpu_logical_processors_count>
            <tem:cpu_max_clock_speed>{cpu_max_clock_speed}</tem:cpu_max_clock_speed>
            <tem:memory_total>{memory_total}</tem:memory_total>
            <tem:storage_total>{storage_total}</tem:storage_total>
        </tem:UpdateServerInformation>
    </soapenv:Body>
</soapenv:Envelope>");


                using (Stream stream = request.GetRequestStream())
                {
                    SOAPReqBody.Save(stream);
                }

                //Geting response from request  
                using (WebResponse Serviceres = request.GetResponse())
                {
                    using (StreamReader rd = new StreamReader(Serviceres.GetResponseStream()))
                    {
                        //reading stream  
                        string ServiceResult = rd.ReadToEnd();
                        //ServiceResult = ServiceResult.Replace("soap:", "soap_");
                        ResultXML = XDocument.Parse(ServiceResult);

                        List<XElement> _result_elements = ResultXML.Descendants().ToList();
                        foreach (var item in _result_elements)
                        {
                            if (item.Name.LocalName == "status")
                            {
                                _response_status = item.Value;
                                break;
                            }
                        }

                        return _response_status;

                    }
                }
            }
            catch (WebException ex)
            {
                string message = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                return "";
            }


        }

        public void WriteToFile(string Message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\logs\\" + DateTime.Now.Date.ToString("yyyyMMdd") + ".txt";
            if (!File.Exists(filepath))
            {
                // Create a file to write to.   
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
        }

    }
}
