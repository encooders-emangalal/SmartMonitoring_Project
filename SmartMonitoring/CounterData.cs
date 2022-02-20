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
        private readonly SmartMonitoringEntities1 db;
        private string serverId, counterId, instanceId, counterUnit;
        public CounterData(string serverId, string counterId, string instanceId, string counterUnit)
        {
            InitializeComponent();
            db = new SmartMonitoringEntities1();
            this.serverId = serverId;
            this.counterId = counterId;
            this.instanceId = instanceId;
            this.counterUnit = counterUnit;
        }

        private void btnDisplayData_Click(object sender, EventArgs e)
        {
            var query = db.montr_monitor_transactions.Where(c => c.machine_id == serverId && c.counter_id == counterId && c.instance_id == instanceId);
            if (cbSelectDataTime.SelectedIndex == 0)
            {
                gvCounterData.Rows.Clear();

                DateTime dt = DateTime.Now.AddDays(-7);
                var lastWeekCounter = query.Where(c => c.counter_datetime >= dt).OrderByDescending(c => c.counter_datetime).ToList();
                foreach (var counter in lastWeekCounter)
                {
                    gvCounterData.Rows.Add(counter.counter_datetime.ToString(), Math.Round(double.Parse(counter.counter_value.ToString()), 1) + " " + counterUnit);
                }

                lblAverage.Text = $"Avg: {Math.Round(lastWeekCounter.Average(c => c.counter_value), 1)} {counterUnit}";
                lblMinimum.Text = $"Min: {Math.Round(lastWeekCounter.Min(c => c.counter_value), 1)} {counterUnit}";
                lblMaximum.Text = $"Max: {Math.Round(lastWeekCounter.Max(c => c.counter_value), 1)} {counterUnit}";
            }
            else if (cbSelectDataTime.SelectedIndex == 1)
            {
                gvCounterData.Rows.Clear();

                DateTime dt = DateTime.Now.AddMonths(-1);
                var lastMonthCounter = query.Where(c => c.counter_datetime >= dt).OrderByDescending(c => c.counter_datetime).ToList();
                foreach (var counter in lastMonthCounter)
                {
                    gvCounterData.Rows.Add(counter.counter_datetime.ToString(), Math.Round(double.Parse(counter.counter_value.ToString()), 1) + " " + counterUnit);
                }

                lblAverage.Text = $"Avg: {Math.Round(lastMonthCounter.Average(c => c.counter_value), 1)} {counterUnit}";
                lblMinimum.Text = $"Min: {Math.Round(lastMonthCounter.Min(c => c.counter_value), 1)} {counterUnit}";
                lblMaximum.Text = $"Max: {Math.Round(lastMonthCounter.Max(c => c.counter_value), 1)} {counterUnit}";
            }
            else if (cbSelectDataTime.SelectedIndex == 2)
            {
                gvCounterData.Rows.Clear();

                DateTime dt = DateTime.Now.AddMonths(-3);
                var last3MonthsCounter = query.Where(c => c.counter_datetime >= dt).OrderByDescending(c => c.counter_datetime).ToList();
                foreach (var counter in last3MonthsCounter)
                {
                    gvCounterData.Rows.Add(counter.counter_datetime.ToString(), Math.Round(double.Parse(counter.counter_value.ToString()), 1) + " " + counterUnit);
                }

                lblAverage.Text = $"Avg: {Math.Round(last3MonthsCounter.Average(c => c.counter_value), 1)} {counterUnit}";
                lblMinimum.Text = $"Min: {Math.Round(last3MonthsCounter.Min(c => c.counter_value), 1)} {counterUnit}";
                lblMaximum.Text = $"Max: {Math.Round(last3MonthsCounter.Max(c => c.counter_value), 1)} {counterUnit}";
            }
            else if (cbSelectDataTime.SelectedIndex == 3)
            {
                gvCounterData.Rows.Clear();

                DateTime dt = DateTime.Now.AddMonths(-6);
                var last6MonthsCounter = query.Where(c => c.counter_datetime >= dt).OrderByDescending(c => c.counter_datetime).ToList();
                foreach (var counter in last6MonthsCounter)
                {
                    gvCounterData.Rows.Add(counter.counter_datetime.ToString(), Math.Round(double.Parse(counter.counter_value.ToString()), 1) + " " + counterUnit);
                }

                lblAverage.Text = $"Avg: {Math.Round(last6MonthsCounter.Average(c => c.counter_value), 1)} {counterUnit}";
                lblMinimum.Text = $"Min: {Math.Round(last6MonthsCounter.Min(c => c.counter_value), 1)} {counterUnit}";
                lblMaximum.Text = $"Max: {Math.Round(last6MonthsCounter.Max(c => c.counter_value), 1)} {counterUnit}";
            }
            else
            {
                gvCounterData.Rows.Clear();

                foreach (var counter in query.OrderByDescending(c => c.counter_datetime))
                {
                    gvCounterData.Rows.Add(counter.counter_datetime.ToString(), Math.Round(double.Parse(counter.counter_value.ToString()), 1) + " " + counterUnit);
                }

                lblAverage.Text = $"Avg: {Math.Round(query.Average(c => c.counter_value), 1)} {counterUnit}";
                lblMinimum.Text = $"Min: {Math.Round(query.Min(c => c.counter_value), 1)} {counterUnit}";
                lblMaximum.Text = $"Max: {Math.Round(query.Max(c => c.counter_value), 1)} {counterUnit}";
            }
        }

        private void CounterData_Load(object sender, EventArgs e)
        {
            cbSelectDataTime.SelectedIndex = 0;

            gvCounterData.Rows.Clear();

            var query = db.montr_monitor_transactions.Where(c => c.machine_id == serverId && c.counter_id == counterId && c.instance_id == instanceId);
            DateTime dt = DateTime.Now.AddDays(-7);
            var lastWeekCounter = query.Where(c => c.counter_datetime >= dt).OrderByDescending(c => c.counter_datetime).ToList();
            foreach (var counter in lastWeekCounter)
            {
                gvCounterData.Rows.Add(counter.counter_datetime.ToString(), Math.Round(double.Parse(counter.counter_value.ToString()), 1) + " " + counterUnit);
            }

            lblAverage.Text = $"Avg: {Math.Round(lastWeekCounter.Average(c => c.counter_value), 1)} {counterUnit}";
            lblMinimum.Text = $"Min: {Math.Round(lastWeekCounter.Min(c => c.counter_value), 1)} {counterUnit}";
            lblMaximum.Text = $"Max: {Math.Round(lastWeekCounter.Max(c => c.counter_value), 1)} {counterUnit}";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
