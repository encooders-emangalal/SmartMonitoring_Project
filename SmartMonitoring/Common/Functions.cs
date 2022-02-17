using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMonitoring.Common
{
    public class Functions
    {




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
}
