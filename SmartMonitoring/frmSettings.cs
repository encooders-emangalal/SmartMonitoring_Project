using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMonitoring
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            FillListView();
        }

        private void FillListView()
        {

            DataTable _dt = new DataTable();
            _dt.Columns.Add("SET_KEY", typeof(string));
            _dt.Columns.Add("Description", typeof(string));
            _dt.Rows.Add("GENERAL", "General");
            _dt.Rows.Add("FPROCESS", "File Processing");
            _dt.Rows.Add("FDOWNLOAD", "File Download");
            _dt.Rows.Add("LOGSETTING", "Log Settings");
            _dt.Rows.Add("EMAILNOTIF", "Email Notifications");
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
            if (_set_key == "FPROCESS")
            {
                pnlFileProcessing.Top = 12;
                pnlFileProcessing.Left = 243;
                pnlFileProcessing.Visible = true;
                pnlFileDownload.Visible = false;
                pnlLogSettings.Visible = false;
                pnlEmailNotification.Visible = false;
            }
            else if (_set_key == "FDOWNLOAD")
            {
                pnlFileDownload.Top = 12;
                pnlFileDownload.Left = 243;
                pnlFileDownload.Visible = true;
                pnlFileProcessing.Visible = false;
                pnlLogSettings.Visible = false;
                pnlEmailNotification.Visible = false;
            }
            else if (_set_key == "LOGSETTING")
            {
                pnlLogSettings.Top = 12;
                pnlLogSettings.Left = 243;
                pnlLogSettings.Visible = true;
                pnlFileProcessing.Visible = false;
                pnlFileDownload.Visible = false;
                pnlEmailNotification.Visible = false;
            }
            else if (_set_key == "EMAILNOTIF")
            {
                pnlEmailNotification.Top = 12;
                pnlEmailNotification.Left = 243;
                pnlEmailNotification.Visible = true;
                pnlFileProcessing.Visible = false;
                pnlLogSettings.Visible = false;
                pnlFileDownload.Visible = false;
            }
            else
            {
                pnlFileProcessing.Visible = false;
                pnlFileDownload.Visible = false;
                pnlLogSettings.Visible = false;
                pnlEmailNotification.Visible = false;
            }
        }

    }
}
