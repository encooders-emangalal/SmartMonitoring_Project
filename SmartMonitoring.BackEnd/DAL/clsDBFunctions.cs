using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartMonitoring.BackEnd.DAL
{
    public class clsDBFunctions
    {


        public static string getConnectionString()
        {
            string _connection_string = "Data source=DESKTOP-A0PSS5C; Database=SmartMonitoring;User Id=sa;Password=123456";
            return _connection_string;
        }

    }
}
