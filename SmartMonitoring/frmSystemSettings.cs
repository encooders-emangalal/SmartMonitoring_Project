using SmartMonitoring.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SmartMonitoring.Enums.Enums;

namespace SmartMonitoring
{
    public partial class frmSystemSettings : Form
    {
        bool isedit = false;
        int iseditnum = 0;
        string message = string.Empty;
        int index = 0;
        List<sys_settings> Settings;
        SmartMonitoringEntities1 context;
        public frmSystemSettings()
        {
            InitializeComponent();
            context = new SmartMonitoringEntities1();
            Settings = new List<sys_settings>();
        }

        private void frmSystemSettings_Load(object sender, EventArgs e)
        {
           
            Settings = context.sys_settings.Where(x => x.is_deleted != true).ToList();
            gvSystemSetting.DataSource = Converter.ListToDataTable(Settings.Select(x => new { x.sys_id, x.sys_value,sys_type= Enum.GetName(typeof(sys_type), x.sys_type) }).ToList());
            DataTable _dt = new DataTable();
            _dt.Columns.Add("id", typeof(int));
            _dt.Columns.Add("name", typeof(string));
            _dt.Rows.Add("-1", "Select");
            _dt.Rows.Add("0", "SMTP");
            _dt.Rows.Add("1", "Sender Email");
            _dt.Rows.Add("2", "Email Password");
            _dt.Rows.Add("3", "SMTP Port");
            _dt.Rows.Add("4", "Sender Name");

            typecb.ValueMember = "id";
            typecb.DisplayMember = "name";
            typecb.DataSource = _dt;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            gvSystemSetting.Enabled = false;
            SearchPanal.Enabled = false;
            valuetxt.Text = "";
            typecb.SelectedValue = "-1";
            isedit = false;
        }

        

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int _count = 0;
            int newindex = 0;

            if (!string.IsNullOrEmpty(valuetxt.Text.Trim())&& typecb.SelectedValue.ToString()!="-1")
            {
                if (isedit)
                {
                    var Setting = Settings.FirstOrDefault(x => x.sys_id == iseditnum);
                    if (MessageBox.Show(string.Format("Do you want to Update System Value: {0}?", Setting.sys_value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Setting.sys_value = valuetxt.Text;
                        Setting.sys_type = int.Parse(typecb.SelectedValue.ToString());
                        Setting.update_dt = DateTime.Now;
                        context.Entry(Setting).State = System.Data.Entity.EntityState.Modified;
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
                    sys_settings Setting = new sys_settings();
                    Setting.sys_type = int.Parse(typecb.SelectedValue.ToString());
                    Setting.sys_value = valuetxt.Text;
                    Setting.insert_dt = DateTime.Now;
                    Setting.is_deleted = false;
                    context.sys_settings.Add(Setting);
                    _count = context.SaveChanges();
                    message = "Inserted Sucessfully";
                    newindex = gvSystemSetting.Rows.Count;

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
                gvSystemSetting.Enabled = true;
                SearchPanal.Enabled = true;



                MessageBox.Show(message);
                valuetxt.Text = "";
                typecb.SelectedValue ="-1";
                frmSystemSettings_Load(sender, e);
                gvSystemSetting.ClearSelection();
                gvSystemSetting.Rows[newindex].Selected = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rows = gvSystemSetting.SelectedRows.Count;

            if (rows > 0)
            {
                var Setting = Settings.FirstOrDefault(x => x.sys_id == iseditnum);
                if (MessageBox.Show(string.Format("Do you want to delete System Value: {0}?", Setting.sys_value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    Setting.is_deleted = true;
                    Setting.delete_dt = DateTime.Now;
                    context.Entry(Setting).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                }
                else
                {
                    return;
                }
                int previndex = index == 0 ? index : index - 1;
                frmSystemSettings_Load(sender, e);
                gvSystemSetting.ClearSelection();
                if (gvSystemSetting.Rows.Count > 0)
                {
                    gvSystemSetting.Rows[previndex].Selected = true;
                }
                else
                {
                    valuetxt.Text = "";
                    typecb.SelectedValue = "-1";

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = false;
            gvSystemSetting.Enabled = true;
            SearchPanal.Enabled = true;
            valuetxt.Text = "";
            typecb.SelectedValue = "-1";

        }

        private void gvSystemSetting_SelectionChanged(object sender, EventArgs e)
        {
            int rows = gvSystemSetting.SelectedRows.Count;

            if (rows > 0)
            {
                iseditnum = int.Parse(gvSystemSetting.SelectedRows[0].Cells[0].Value.ToString());
                valuetxt.Text = Settings.FirstOrDefault(x => x.sys_id == iseditnum).sys_value.ToString().Trim();
               typecb.SelectedValue = Settings.FirstOrDefault(x=>x. sys_id == iseditnum).sys_type.ToString().Trim();
                isedit = true;
                index = gvSystemSetting.SelectedRows[0].Index;
            }
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                Settings = context.sys_settings.Where(x => (x.is_deleted == false) && (x.sys_value.Contains(txtSearch.Text.Trim()))).ToList();
                gvSystemSetting.DataSource = Converter.ListToDataTable(Settings.Select(x => new { x.sys_id, x.sys_value, sys_type = Enum.GetName(typeof(sys_type), x.sys_type) }).ToList());
            }
            else
            {
                frmSystemSettings_Load(sender, e);

            }
        }
    }
}
