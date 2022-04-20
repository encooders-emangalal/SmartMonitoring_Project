using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Braintree;
using Newtonsoft.Json;
using NodeServer_WinService.Models;

namespace NodeServer_WinService
{
    public partial class ServerService : ServiceBase
    {
        Timer timer = new Timer();
        private string ApiUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["ApiUrl"] != null ?
                    ConfigurationManager.AppSettings["ApiUrl"] : string.Empty;
            }
        }
        public ServerService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Log("| ---Service Started At: " + DateTime.Now.ToString());           
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 30 * 1000; //number in milisecinds  
            timer.Enabled = true;
        }
        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            Log("Service is recall at:   " + DateTime.Now);
            timer.Enabled = false;
            DoWork();
            timer.Enabled = true;
        }
        protected override void OnStop()
        {
            Log("Service Ended at:   " + DateTime.Now.ToString());
        }

        public void Log(string Message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
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
        [Obsolete("Do not use this in Production code!!!", false)]
        public void NEVER_EAT_POISON_Disable_CertificateValidation()
        {
            // Disabling certificate validation can expose you to a man-in-the-middle attack
            // which may allow your encrypted message to be read by an attacker
            // https://stackoverflow.com/a/14907718/740639
            ServicePointManager.ServerCertificateValidationCallback =
                delegate (
                    object s,
                    X509Certificate certificate,
                    X509Chain chain,
                    SslPolicyErrors sslPolicyErrors
                ) {
                    return true;
                };
        }
        public void DoWork()
        {
            using (var client = new HttpClient())
            {
                NEVER_EAT_POISON_Disable_CertificateValidation();
                var _configurationModel = new ConfigurationModel();

                string HostName = Dns.GetHostName();
                string IPV4 = "";
                var host = Dns.GetHostEntry(HostName);
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        IPV4 = ip.ToString();
                    }
                }
                
                // var IP = Dns.GetHostAddresses(HostName);
                //.FirstOrDefault(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).Address.ToString();
                client.BaseAddress = new Uri(string.Format("{0}/api/Server/", ApiUrl));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Lang", "en");
                client.DefaultRequestHeaders.Add("Origin", ApiUrl);

                var getTask = client.GetAsync(string.Format("GetConfigurations?machineName={0}&ipAddress={1}", "APROAMRDC000", "0"));
                getTask.Wait();

                var result = getTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    _configurationModel = JsonConvert.DeserializeObject<ConfigurationModel>(readTask.Result);
                }

                if (_configurationModel != null && !string.IsNullOrEmpty(_configurationModel.MachineId))
                {

                    CountersVM model = new CountersVM();
                    model.Counters = new List<CountersEditViewModel>();
                    model.MachineId = _configurationModel.MachineId;
                    PerformanceCounter counterxx = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                    var CounterValuexc = counterxx.NextValue();
                    for (int i = 0; i < _configurationModel.counters.Count; i++)
                    {
                        PerformanceCounter counter = new PerformanceCounter(_configurationModel.counters[i].CategoryName, _configurationModel.counters[i].CounterName, _configurationModel.counters[i].InstanceId);                        
                        model.Counters.Add(new CountersEditViewModel { CounterId = _configurationModel.counters[i].CounterId.ToString(), InstanceId = _configurationModel.counters[i].InstanceId.ToString(), CounterDatetime = DateTime.Now, CounterValue = counter.NextValue() });
                    }
                    var Postclient = new HttpClient();


                    Postclient.BaseAddress = new Uri(string.Format("{0}/api/Server/", ApiUrl));
                    Postclient.DefaultRequestHeaders.Accept.Clear();
                    Postclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    Postclient.DefaultRequestHeaders.Add("Lang", "en");
                    Postclient.DefaultRequestHeaders.Add("Origin", ApiUrl);

                    var postTask = Postclient.PostAsJsonAsync(string.Format("PostCounters"), model);
                    postTask.Wait();


                }
            }
        }
    }
}
