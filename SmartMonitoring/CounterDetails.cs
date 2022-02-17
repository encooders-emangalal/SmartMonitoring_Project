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
    public partial class CounterDetails : Form
    {
        public CounterDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCounterDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCounterName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCounterUnit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
