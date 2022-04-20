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
        bool isedit = false;
        int iseditnum = 0;
        string message = string.Empty;
        int index=0;
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


        private void btnSave_Click(object sender, EventArgs e)
        {
            int _count = 0;
            int newindex= 0;
            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                _connection.Open();
                string _sql = "";
                if (!string.IsNullOrEmpty(nametxt.Text.Trim())&& !string.IsNullOrEmpty(emailtxt.Text.Trim()))
                {
                    if (isedit)
                    {
                        if (MessageBox.Show(string.Format("Do you want to Update User ID: {0}?", iseditnum), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            _sql = "update users set name= '" + nametxt.Text.Trim() + "',email='" + emailtxt.Text.Trim() + "' where id =" + iseditnum;
                            message = "Updated Sucessfully";
                            newindex = index;
                        }
                    }
                    else
                    {
                        _sql = "INSERT INTO users VALUES ('" + nametxt.Text.Trim() + "','" + emailtxt.Text.Trim() + "')";
                        message = "Inserted Sucessfully";
                        newindex = gvUsers.Rows.Count; ;
                       
                    }
                }
                else
                {
                    return;
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
                    btnNew.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;
                    gvUsers.Enabled = true;
                   


                    MessageBox.Show(message);
                    nametxt.Text = "";
                    emailtxt.Text = "";

                    frmUserConfigration_Load(sender, e);
                    gvUsers.ClearSelection();
                    gvUsers.Rows[newindex].Selected = true;
                }

            }
        }

        private void btnJobLocation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvUsers_SelectionChanged_1(object sender, EventArgs e)
        {
            int rows = gvUsers.SelectedRows.Count;

            if (rows > 0)
            {
                iseditnum = int.Parse(gvUsers.SelectedRows[0].Cells[0].Value.ToString());
                nametxt.Text = gvUsers.SelectedRows[0].Cells[1].Value.ToString().Trim();
                emailtxt.Text = gvUsers.SelectedRows[0].Cells[2].Value.ToString().Trim();
                isedit = true;
                index = gvUsers.SelectedRows[0].Index;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            gvUsers.Enabled = false;
            nametxt.Text = "";
            emailtxt.Text = "";
            isedit = false;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int rows = gvUsers.SelectedRows.Count;

            if (rows > 0)
            {
                if (MessageBox.Show(string.Format("Do you want to delete User ID: {0}?", iseditnum), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM users WHERE id = @id", _connection))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@id", iseditnum);
                            _connection.Open();
                            cmd.ExecuteNonQuery();
                            _connection.Close();
                        }
                    }                    
                }
                int previndex = index - 1;
                frmUserConfigration_Load(sender, e);
                gvUsers.ClearSelection();                
               gvUsers.Rows[previndex].Selected = true;
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = false;
            gvUsers.Enabled = true;
            nametxt.Text = "";
            emailtxt.Text = "";
        }
    }
}





            
  





