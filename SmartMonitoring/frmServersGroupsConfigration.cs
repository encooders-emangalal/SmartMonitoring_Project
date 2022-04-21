using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMonitoring
{
    public partial class frmServersGroupsConfigration : Form
    {
        bool isedit = false;
        int iseditnum = 0;
        string message = string.Empty;
        public frmServersGroupsConfigration()
        {
            InitializeComponent();
        }

        private void frmServersGroupsConfigration_Load(object sender, EventArgs e)
        {
            DataTable _table = new DataTable();
            string _sql = "select * from server_groups";
            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                _connection.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(_sql, _connection))
                {
                    da.Fill(_table);
                    gvServersGroups.DataSource = _table;
                }

                _connection.Close();
            }
        }

        

       
    }
}
