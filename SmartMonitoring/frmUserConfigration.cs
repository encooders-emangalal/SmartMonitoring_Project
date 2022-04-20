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
    public partial class frmUserConfigration : Form
    {
        bool isedit=false;
        int iseditnum=0;
        string message = string.Empty;
        public frmUserConfigration()
        {
            InitializeComponent();
        }

        private void frmUserConfigration_Load(object sender, EventArgs e)
        {
           // gvUsers.Rows.Clear();
           
            DataTable _table = new DataTable();
            string _sql = "select * from users";
            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                _connection.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(_sql, _connection))
                {
                    da.Fill(_table);
                    gvUsers.DataSource = _table;
                }

                _connection.Close();
            }
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
                    _sql = "update users set name= '" + nametxt.Text.Trim() + "',email='" + emailtxt.Text.Trim() + "' where id ="+ iseditnum;
                    message = "Updated Sucessfully";
                }
                else
                {
                    _sql = "INSERT INTO users VALUES ('" + nametxt.Text.Trim() + "','" + emailtxt.Text.Trim() + "')";
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
                if( _count > 0)
                {
                    MessageBox.Show(message);
                    nametxt.Text = "";
                    emailtxt.Text = "";

                    frmUserConfigration_Load(sender,e);
                }
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvUsers_SelectionChanged(object sender, EventArgs e)
        {
            int  rows= gvUsers.SelectedRows.Count;

            if (rows>0)
            {
                iseditnum = int.Parse(gvUsers.SelectedRows[0].Cells[0].Value.ToString());
                nametxt.Text = gvUsers.SelectedRows[0].Cells[1].Value.ToString().Trim();
                emailtxt.Text = gvUsers.SelectedRows[0].Cells[2].Value.ToString().Trim();
                isedit=true;
            }
        }
    }
}




