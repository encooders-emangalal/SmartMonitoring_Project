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
    public partial class ExportCounter : Form
    {
        public ExportCounter()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportCounter_Load(object sender, EventArgs e)
        {
            cbSelectExportTime.SelectedIndex = 0;
        }
    }
}
