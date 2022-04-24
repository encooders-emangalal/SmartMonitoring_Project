using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SmartMonitoring
{
    public partial class frmServersGroupsConfigration : Form
    {
        bool isedit = false;
        int iseditnum = 0;
        string message = string.Empty;
        int index = 0;
        List<server_groups> Server_Groups;
        SmartMonitoringEntities1 context;

        public frmServersGroupsConfigration()
        {
            InitializeComponent();
            context = new SmartMonitoringEntities1();
            Server_Groups = new List<server_groups>();
        }

        private void frmServersGroupsConfigration_Load(object sender, EventArgs e)
        {
            Server_Groups = context.server_groups.Where(x => x.is_deleted != true).ToList();
            gvServersGroups.DataSource = Converter.ListToDataTable(Server_Groups.Select(x => new { x.id, x.name }).ToList());
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int _count = 0;
            int newindex = 0;

            if (!string.IsNullOrEmpty(nametxt.Text.Trim()))
            {
                if (isedit)
                {
                    var server_group = Server_Groups.FirstOrDefault(x => x.id == iseditnum);
                    if (MessageBox.Show(string.Format("Do you want to Update Server Group Name: {0}?", server_group.name), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        server_group.name = nametxt.Text;
                        server_group.is_active = IsActivecb.Checked;
                        server_group.comments = commentstxt.Text;
                        server_group.update_dt = DateTime.Now;
                        context.Entry(server_group).State = System.Data.Entity.EntityState.Modified;
                        _count = context.SaveChanges();
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
                    server_groups server_group = new server_groups();
                    server_group.name = nametxt.Text;
                    server_group.is_active = IsActivecb.Checked;
                    server_group.comments = commentstxt.Text;
                    server_group.insert_dt = DateTime.Now;
                    server_group.is_deleted = false;
                    context.server_groups.Add(server_group);
                    _count = context.SaveChanges();
                    message = "Inserted Sucessfully";
                    newindex = gvServersGroups.Rows.Count;

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
                gvServersGroups.Enabled = true;
                SearchPanal.Enabled = true;



                MessageBox.Show(message);
                nametxt.Text = "";

                frmServersGroupsConfigration_Load(sender, e);
                gvServersGroups.ClearSelection();
                gvServersGroups.Rows[newindex].Selected = true;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            gvServersGroups.Enabled = false;
            SearchPanal.Enabled = false;
            nametxt.Text = "";
            commentstxt.Text = "";
            IsActivecb.Checked = false;
            isedit = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rows = gvServersGroups.SelectedRows.Count;

            if (rows > 0)
            {
                var server_group = Server_Groups.FirstOrDefault(x => x.id == iseditnum);
                if (MessageBox.Show(string.Format("Do you want to delete Server Group Name: {0}?", server_group.name), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    server_group.is_deleted = true;
                    server_group.delete_dt = DateTime.Now;
                    context.Entry(server_group).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                }
                else
                {
                    return;
                }
                int previndex = index == 0 ? index : index - 1;
                frmServersGroupsConfigration_Load(sender, e);
                gvServersGroups.ClearSelection();
                gvServersGroups.Rows[previndex].Selected = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = false;
            gvServersGroups.Enabled = true;
            SearchPanal.Enabled = true;
            nametxt.Text = "";
            commentstxt.Text = "";
            IsActivecb.Checked = false;
            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvServersGroups_SelectionChanged(object sender, EventArgs e)
        {
            int rows = gvServersGroups.SelectedRows.Count;

            if (rows > 0)
            {
                iseditnum = int.Parse(gvServersGroups.SelectedRows[0].Cells[0].Value.ToString());
                nametxt.Text = Server_Groups.FirstOrDefault(x => x.id == iseditnum).name.ToString().Trim();
                commentstxt.Text = Server_Groups.FirstOrDefault(x => x.id == iseditnum)?.comments?.ToString()?.Trim()??String.Empty;
                IsActivecb.Checked = Server_Groups.FirstOrDefault(x => x.id == iseditnum).is_active ?? false;
                isedit = true;
                index = gvServersGroups.SelectedRows[0].Index;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                Server_Groups = context.server_groups.Where(x => (x.is_deleted == false) && (x.name.Contains(txtSearch.Text.Trim()))).ToList();
                gvServersGroups.DataSource = Converter.ListToDataTable(Server_Groups.Select(x => new { x.id, x.name}).ToList());
               
            }
            else
            {
                frmServersGroupsConfigration_Load(sender, e);

            }

        }
    }
}
