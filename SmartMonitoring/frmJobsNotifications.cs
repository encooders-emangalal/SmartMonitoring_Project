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
    public partial class frmJobsNotifications : Form
    {
        public frmJobsNotifications()
        {
            InitializeComponent();
        }

        private void frmJobsNotifications_Load(object sender, EventArgs e)
        {
            // Bind Grid


        }

        private void DesignControls(int status)
        {
            if (status == 1) //new
            {
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
                btnCancel.Enabled = true;
                gvPushJobs.Enabled = false;
            }
            else if (status == 2) //cancel
            {
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
                btnCancel.Enabled = true;
                gvPushJobs.Enabled = true;
            }

        }

        
    }
}
