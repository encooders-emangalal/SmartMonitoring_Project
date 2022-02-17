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
    public partial class MonitorErrors : Form
    {
        public MonitorErrors()
        {
            InitializeComponent();
        }

        private void MonitorErrors_Load(object sender, EventArgs e)
        {
            DataTable _table = new DataTable();
            _table.Columns.Add("Date", typeof(DateTime));
            _table.Columns.Add("Status", typeof(string));
            _table.Columns.Add("Counter", typeof(string));
            _table.Columns.Add("Value", typeof(string));
            _table.Columns.Add("Description", typeof(string));

            for (int i = 0; i < 30; i++)
            {
                _table.Rows.Add(DateTime.Now, "Error", "CPU Usage - All CPUs", "5.0 %", "Current Value is More Than 1 %");
            }
            gvMonitorErrors.DataSource = _table;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
