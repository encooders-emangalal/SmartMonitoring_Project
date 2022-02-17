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
    public partial class CounterData : Form
    {
        public CounterData()
        {
            InitializeComponent();
        }

        private void CounterData_Load(object sender, EventArgs e)
        {
            cbSelectDataTime.SelectedIndex = 0;

            DataTable _table = new DataTable();
            _table.Columns.Add("Time", typeof(DateTime));
            _table.Columns.Add("Counter Value", typeof(string));

            _table.Rows.Add(DateTime.Now, "1.0 %");
            _table.Rows.Add(DateTime.Now, "1.5 %");
            _table.Rows.Add(DateTime.Now, "2.2 %");
            _table.Rows.Add(DateTime.Now, "2.0 %");
            _table.Rows.Add(DateTime.Now, "1.7 %");

            gvCounterData.DataSource = _table;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
