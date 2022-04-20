using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMonitoring.DAL
{
    public class clsDBFunctions
    {

        

        public static string getConnectionString()
        {
            string _connection_string = @"Data source=DESKTOP-HPEA1S0\SQLEXPRESS; Database=SmartMonitoring;User Id=sa;Password=123";
            return _connection_string;
        }

        public static int getRecordsCount(string _sql)
        {
            int _count = 0;

            using (SqlConnection _connection = new SqlConnection(getConnectionString()))
            {
                _connection.Open();

                using (SqlCommand _command = new SqlCommand(_sql, _connection))
                {
                    _count = (Int32)_command.ExecuteScalar();
                }
            }

            return _count;
        }

        public static string getDBValue(string _sql)
        {
            string _value = "";

            using (SqlConnection _connection = new SqlConnection(getConnectionString()))
            {
                _connection.Open();

                using (SqlCommand _command = new SqlCommand(_sql, _connection))
                {
                    _value = _command.ExecuteScalar().ToString();
                }
            }

            return _value;
        }

        public static int UpdateDBRecord(string _sql)
        {
            int _count = 0;

            using (SqlConnection _connection = new SqlConnection(getConnectionString()))
            {
                _connection.Open();

                using (SqlCommand _command = new SqlCommand(_sql, _connection))
                {
                    _count = _command.ExecuteNonQuery();
                }
            }

            return _count;
        }

    }
}
