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
        List<user> Users;
        SmartMonitoringEntities1 context;
        public frmUserConfigration()
        {
            InitializeComponent();
            context = new SmartMonitoringEntities1();
            Users = new List<user>();
        }

        private void frmUserConfigration_Load(object sender, EventArgs e)
        {
            // gvUsers.Rows.Clear();


            Users = context.users.Where(x => x.is_deleted != true).ToList();
            gvUsers.DataSource = Converter.ListToDataTable(Users.Select(x => new { x.id,x.name, x.email} ).ToList());

        }


        private void btnSave_Click(object sender, EventArgs e)
        {

         
            int _count = 0;
            int newindex= 0;

            if (!string.IsNullOrEmpty(nametxt.Text.Trim()) && !string.IsNullOrEmpty(emailtxt.Text.Trim()))
            {
                if (isedit)
                {
                    var user = Users.FirstOrDefault(x => x.id == iseditnum);
                    if (MessageBox.Show(string.Format("Do you want to Update User Name: {0}?", user.name), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {                        
                        user.name = nametxt.Text;
                        user.email = emailtxt.Text;
                        user.is_active = IsActivecb.Checked;
                        user.comments = commentstxt.Text;
                        user.update_dt = DateTime.Now;
                        context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                        _count=context.SaveChanges();
                        message = "Updated Sucessfully";
                        newindex = index;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    user user = new user();
                    user.name = nametxt.Text;
                    user.email = emailtxt.Text;
                    user.is_active = IsActivecb.Checked;
                    user.comments = commentstxt.Text;
                    user.insert_dt = DateTime.Now;
                    user.is_deleted = false;
                    context.users.Add(user);
                    _count=context.SaveChanges();
                    message = "Inserted Sucessfully";
                    newindex = gvUsers.Rows.Count;

                }
            }
            else
            {
                return;
            }

            if (_count > 0)
            {
                btnNew.Enabled = true;
                btnDelete.Enabled = true;
                btnCancel.Enabled = false;
                gvUsers.Enabled = true;
                SearchPanal.Enabled = true;



                MessageBox.Show(message);
                nametxt.Text = "";
                emailtxt.Text = "";

                frmUserConfigration_Load(sender, e);
                gvUsers.ClearSelection();
                gvUsers.Rows[newindex].Selected = true;
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
                nametxt.Text = Users.FirstOrDefault(x => x.id == iseditnum).name.ToString().Trim();
                emailtxt.Text = Users.FirstOrDefault(x => x.id == iseditnum).email.ToString().Trim();
                commentstxt.Text = Users.FirstOrDefault(x => x.id == iseditnum).comments.ToString().Trim();
                IsActivecb.Checked = Users.FirstOrDefault(x => x.id == iseditnum).is_active ?? false;
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
            SearchPanal.Enabled = false;
            nametxt.Text = "";
            emailtxt.Text = "";
            commentstxt.Text = "";
            IsActivecb.Checked = false;
            isedit = false;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int rows = gvUsers.SelectedRows.Count;

            if (rows > 0)
            {
                var user = Users.FirstOrDefault(x => x.id == iseditnum);
                if (MessageBox.Show(string.Format("Do you want to delete User Name: {0}?", user.name), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    user.is_deleted = true;
                    user.delete_dt = DateTime.Now;
                    context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
               
                }
                else
                {
                    return;
                }
                int previndex = index==0? index : index - 1;
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
            SearchPanal.Enabled = true;
            nametxt.Text = "";
            emailtxt.Text = "";
            commentstxt.Text = "";
            IsActivecb.Checked = false;
          

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                Users = context.users.Where(x => (x.is_deleted==false)&& (x.name.Contains(txtSearch.Text.Trim())||x.email.Contains(txtSearch.Text.Trim()))).ToList();
                gvUsers.DataSource = Converter.ListToDataTable(Users.Select(x => new { x.id, x.name, x.email }).ToList());
              
            }
            else 
            {
                frmUserConfigration_Load(sender, e);
               
            }
           

        }
    }
}





            
  





