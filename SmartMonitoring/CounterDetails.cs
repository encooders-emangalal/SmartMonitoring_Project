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
        private readonly SmartMonitoringEntities1 db;

        private string counterDesc;
        private string counterName;       
        private string counterUnit;
        private string prefix;
        private string instanceId;
        private string instanceName;


        public CounterDetails(string counterId, string instanceId, string instanceName)
        {            
            InitializeComponent();
            db = new SmartMonitoringEntities1();
            var counter = db.set_counters.FirstOrDefault(c => c.counter_id == counterId);
            if (counter != null)
            {
                counterName = counter.counter_name;
                counterUnit = counter.counter_unit;
                counterDesc = counter.counter_description;
                prefix = counter.instance_all_prefix;
                this.instanceId = instanceId;
                this.instanceName = instanceName;
            }
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

        private void CounterDetails_Load(object sender, EventArgs e)
        {
            txtCounterDescription.Text = counterDesc;
            txtCounterName.Text = counterName;
            txtCounterUnit.Text = counterUnit;
            txtObjectPrefix.Text = prefix;
            txtInstanceId.Text = instanceId;
            txtInstanceName.Text = instanceName;
        }
    }
}
