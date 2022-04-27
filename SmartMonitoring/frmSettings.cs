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
    public partial class frmSettings : Form
    {
        List<sys_settings> Settings;
        SmartMonitoringEntities1 context;
        public frmSettings()
        {
            InitializeComponent();
            Settings = new List<sys_settings>();
            context = new SmartMonitoringEntities1();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            FillListView();
            GetData();
            FillData();
        }

        private void FillData()
        {
            if (Settings!=null&&Settings.Any())
            {
                hosttxt.Text = Settings.FirstOrDefault(x => x.sys_type == sys_type.SMTP.ToString())?.sys_value??String.Empty;
                porttxt.Text = Settings.FirstOrDefault(x => x.sys_type == sys_type.SMTPPort.ToString())?.sys_value ?? String.Empty;
                emailtxt.Text = Settings.FirstOrDefault(x => x.sys_type == sys_type.SenderEmail.ToString())?.sys_value ?? String.Empty;
                passwordtxt.Text = Settings.FirstOrDefault(x => x.sys_type == sys_type.EmailPassword.ToString())?.sys_value ?? String.Empty;
                sendernametxt.Text = Settings.FirstOrDefault(x => x.sys_type == sys_type.SenderName.ToString())?.sys_value ?? String.Empty;
            }
        }

        private void GetData()
        {
           Settings = context.sys_settings.Where(x=>x.is_deleted==false).ToList();
        }

        private void FillListView()
        {

            DataTable _dt = new DataTable();
            _dt.Columns.Add("SET_KEY", typeof(string));
            _dt.Columns.Add("Description", typeof(string));
            _dt.Rows.Add("GENERAL", "General");
            _dt.Rows.Add("SMTPSETTINGS", "SMTP Settings");
           // _dt.Rows.Add("FDOWNLOAD", "File Download");
           // _dt.Rows.Add("LOGSETTING", "Log Settings");
          //  _dt.Rows.Add("EMAILNOTIF", "Email Notifications");
            gvSettingsList.DataSource = _dt;


            //lvSettingsList.View = View.Details;
            //lvSettingsList.GridLines = true;
            //lvSettingsList.FullRowSelect = true;
            //lvSettingsList.HeaderStyle = ColumnHeaderStyle.None;

            //lvSettingsList.Columns.Clear();
            //lvSettingsList.Columns.Add("SN", 0);
            //lvSettingsList.Columns.Add("Description", 220);
            //lvSettingsList.Items.Clear();

            //string[] _file = new string[2];
            //_file[0] = "1";
            //_file[1] = "File Processing";
            //ListViewItem _lvitem1 = new ListViewItem(_file);

            //lvSettingsList.Items.Add(_lvitem1);

        }

        private void gvSettingsList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string _set_key = gvSettingsList.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (_set_key == "SMTPSETTINGS")
            {
                pnlsmtpsettings.Top = 12;
                pnlsmtpsettings.Left = 243;
                pnlsmtpsettings.Visible = true;
              //  pnlFileDownload.Visible = false;
             //   pnlLogSettings.Visible = false;
              //  pnlEmailNotification.Visible = false;
             
            }
            else if (_set_key == "FDOWNLOAD")
            {
               // pnlFileDownload.Top = 12;
              //  pnlFileDownload.Left = 243;
                //pnlFileDownload.Visible = true;
                pnlsmtpsettings.Visible = false;
                //pnlLogSettings.Visible = false;
                //pnlEmailNotification.Visible = false;
            }
            else if (_set_key == "LOGSETTING")
            {
                //pnlLogSettings.Top = 12;
                //pnlLogSettings.Left = 243;
                //pnlLogSettings.Visible = true;
                pnlsmtpsettings.Visible = false;
                //pnlFileDownload.Visible = false;
                //pnlEmailNotification.Visible = false;
            }
            else if (_set_key == "EMAILNOTIF")
            {
                //pnlEmailNotification.Top = 12;
                //pnlEmailNotification.Left = 243;
                //pnlEmailNotification.Visible = true;
                pnlsmtpsettings.Visible = false;
                //pnlLogSettings.Visible = false;
                //pnlFileDownload.Visible = false;
            }
            else
            {
                pnlsmtpsettings.Visible = false;
                //pnlFileDownload.Visible = false;
                //pnlLogSettings.Visible = false;
                //pnlEmailNotification.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Settings != null && Settings.Any())
                {
                    if (MessageBox.Show(string.Format("Do you want to Update Settings ?"), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        foreach (var key in Settings)
                        {
                            key.sys_value = key.sys_type == sys_type.SMTP.ToString() ? hosttxt.Text : key.sys_type == sys_type.SMTPPort.ToString() ? porttxt.Text : key.sys_type == sys_type.SenderEmail.ToString() ? emailtxt.Text : key.sys_type == sys_type.EmailPassword.ToString() ? passwordtxt.Text : key.sys_type == sys_type.SenderName.ToString() ? sendernametxt.Text : key.sys_value;

                            context.Entry(key).State = System.Data.Entity.EntityState.Modified;
                        }
                    }
                    else
                    {
                        return;
                    }

                }
                else
                {
                    Settings.Add(new sys_settings() { insert_dt = DateTime.Now, is_active = true, is_deleted = false, sys_value = hosttxt.Text, sys_type = Enums.Enums.sys_type.SMTP.ToString() });
                    Settings.Add(new sys_settings() { insert_dt = DateTime.Now, is_active = true, is_deleted = false, sys_value = porttxt.Text, sys_type = Enums.Enums.sys_type.SMTPPort.ToString() });
                    Settings.Add(new sys_settings() { insert_dt = DateTime.Now, is_active = true, is_deleted = false, sys_value = emailtxt.Text, sys_type = Enums.Enums.sys_type.SenderEmail.ToString() });
                    Settings.Add(new sys_settings() { insert_dt = DateTime.Now, is_active = true, is_deleted = false, sys_value = passwordtxt.Text, sys_type = Enums.Enums.sys_type.EmailPassword.ToString() });
                    Settings.Add(new sys_settings() { insert_dt = DateTime.Now, is_active = true, is_deleted = false, sys_value = sendernametxt.Text, sys_type = Enums.Enums.sys_type.SenderName.ToString() });
                    context.sys_settings.AddRange(Settings);

                }
                
                if (context.SaveChanges()>0)
                {
                    MessageBox.Show("Updated Sucessfully");
                }
              
            }
            catch (Exception )
            {

                MessageBox.Show("Unexpected error");
            }
            
        }
    }
}
