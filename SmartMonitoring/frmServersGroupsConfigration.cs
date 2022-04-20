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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            int _count = 0;
            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                _connection.Open();
                string _sql = "";
                if (isedit)
                {
                    _sql = "update server_groups set name= '" + nametxt.Text.Trim() + "'" + iseditnum;
                    message = "Updated Sucessfully";
                }
                else
                {
                    _sql = "INSERT INTO server_groups VALUES ('" + nametxt.Text.Trim() + "')";
                    message = "Inserted Sucessfully";
                }

                using (SqlDataAdapter da = new SqlDataAdapter(_sql, _connection))
                {
                    using (SqlCommand _command = new SqlCommand(_sql, _connection))
                    {
                        _count = _command.ExecuteNonQuery();
                    }
                }
                _connection.Close();
                if (_count > 0)
                {
                    MessageBox.Show(message);
                    nametxt.Text = "";


                    frmServersGroupsConfigration_Load(sender, e);
                }

            }
        }
    }
}
