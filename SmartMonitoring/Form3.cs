using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMonitoring
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private const int LOGON32_LOGON_NEW_CREDENTIALS = 9;
        private const int LOGON32_PROVIDER_WINNT50 = 3;


        //public const int LOGON32_LOGON_INTERACTIVE = 2;
        //public const int LOGON32_LOGON_SERVICE = 3;
        //public const int LOGON32_PROVIDER_DEFAULT = 0;

        [DllImport("advapi32.dll", CharSet = CharSet.Auto)]
        public static extern bool LogonUser(
            String lpszUserName,
            String lpszDomain,
            String lpszPassword,
            int dwLogonType,
            int dwLogonProvider,
            ref IntPtr phToken);

        //[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        //public extern static bool CloseHandle(IntPtr handle);

        IntPtr userHandle = new IntPtr(0);
        bool logonSuccess = false;
        WindowsIdentity identity;
        WindowsImpersonationContext context;

        private void button1_Click(object sender, EventArgs e)
        {

            #region MyRegion

            //bool isValidated = false;

            //using (System.DirectoryServices.AccountManagement.PrincipalContext pContext = new System.DirectoryServices.AccountManagement.PrincipalContext(System.DirectoryServices.AccountManagement.ContextType.Domain, "nwc.com.sa"))
            //{

            //    // validate the credentials
            //    isValidated = pContext.ValidateCredentials("mragab", "P@ssw0rd1009");

            //    PerformanceCounterCategory cat = new PerformanceCounterCategory("Processor", "APROAMRUI000");
            //    List<PerformanceCounter> counters = new List<PerformanceCounter>();
            //    foreach (string instance in cat.GetInstanceNames())
            //        counters.Add(new PerformanceCounter("Processor", "% Processor Time", instance, "APROAMRUI000"));
            //    for (int i = 0; i < 10000; i++)
            //    {
            //        foreach (PerformanceCounter counter in counters)
            //            textBox1.Text += counter.NextValue() + " ";
            //        //Console.Write(counter.NextValue() + " ");
            //    }

            //}




            //var logonSuccess = LogonUser(
            //                              "mragab",
            //                              "nwc.com.sa",
            //                              "P@ssw0rd1090",
            //                              LOGON32_LOGON_INTERACTIVE,
            //                              LOGON32_PROVIDER_DEFAULT,
            //                              ref userHandle
            //                            );


            //LogonUser("mragab", "nwc", "P@ssw0rd1009", LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, ref userHandle);



            #endregion


            //logonSuccess = LogonUser(
            //              "mragab",
            //              "nwc.com.sa",
            //              "P@ssw0rd1090",
            //              LOGON32_LOGON_NEW_CREDENTIALS,
            //              LOGON32_PROVIDER_WINNT50,
            //              ref userHandle
            //            );

            if (logonSuccess)
            {
                identity = new WindowsIdentity(userHandle);
                context = identity.Impersonate();
            }

            if (logonSuccess)
            {

                
                //PerformanceCounterCategory cat = new PerformanceCounterCategory("Processor", txtMachineName.Text);
                List<PerformanceCounter> counters = new List<PerformanceCounter>();
                //foreach (string instance in cat.GetInstanceNames())
                //    counters.Add(new PerformanceCounter("Processor", "% Processor Time", instance, txtMachineName.Text));

                counters.Add(new PerformanceCounter("Processor", "% Processor Time", "_Total", txtMachineName.Text));

                //counters = counters.Sort(p => p.);
                for (int i = 0; i < 10; i++)
                {

                    foreach (PerformanceCounter counter in counters)
                    {
                        textBox1.Text += counter.CategoryName + " >> " + counter.CounterName + " >> " + counter.InstanceName + " >> " + counter.NextValue() + Environment.NewLine;
                    }
                    textBox1.Text += "---------------------------------" + Environment.NewLine;
                    //Console.Write(counter.NextValue() + " ");
                }
                context.Undo();

            }
            else
            {
                textBox1.Text += "LogonUser failed" + Environment.NewLine;
                //throw new Exception("LogonUser failed");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            logonSuccess = LogonUser(
                                      "mragab",
                                      "nwc.com.sa",
                                      "P@ssw0rd1090",
                                      LOGON32_LOGON_NEW_CREDENTIALS,
                                      LOGON32_PROVIDER_WINNT50,
                                      ref userHandle
                                    );

            if (logonSuccess)
            {
                identity = new WindowsIdentity(userHandle);
                context = identity.Impersonate();

            }

        }
    }
}
