using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.IO;
using System.Management;

namespace SmartMonitoring
{
    public partial class Form1 : Form
    {

        PerformanceCounter PCounter00 = new PerformanceCounter();
        PerformanceCounter PCounter01 = new PerformanceCounter("Processor Information", "% Processor Utility", "_Total");
        PerformanceCounter PCounter02 = new PerformanceCounter("Processor Information", "Processor Frequency", "_Total");
        PerformanceCounter PCounter03 = new PerformanceCounter("Processor Information", "% Processor Performance", "_Total");
        PerformanceCounter PCounter04 = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter PCounter05 = new PerformanceCounter("System", "System Up Time", "");
        PerformanceCounter PCounter06 = new PerformanceCounter("System", "Processes", "");
        PerformanceCounter PCounter07 = new PerformanceCounter("System", "Threads", "");


        PerformanceCounter PCounter12 = new PerformanceCounter("Memory", "Available MBytes", "");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT * FROM Win32_Processor").Get())
            {
                //maxspeed = Convert.ToDouble(obj["MaxClockSpeed"]);
                lblSystemName.Text = obj["SystemName"].ToString();
                lblProcessorId.Text = obj["ProcessorId"].ToString();
                lblProcessorName.Text = obj["Name"].ToString();
                lblProcessorCoresCount.Text = obj["NumberOfCores"].ToString();
                lblProcessorCoresEnabledCount.Text = obj["NumberOfEnabledCore"].ToString();
                lblProcessorLogicalCount.Text = obj["NumberOfLogicalProcessors"].ToString();
                lblProcessorMaxClockSpeed.Text = obj["MaxClockSpeed"].ToString();
                lblProcessorLoadPercentage.Text = obj["LoadPercentage"].ToString();
            }


            timer1.Interval = 3000;
            timer1.Start();
            //timer2.Start();
            ////PCounter1.CategoryName = "Memory";
            ////PCounter1.CounterName = "Available KBytes";
            //label1.Text = performanceCounter1.NextValue().ToString();


            var performanceCounterCategories = PerformanceCounterCategory.GetCategories().OrderBy(p => p.CategoryName);
            foreach (PerformanceCounterCategory performanceCounterCategory in performanceCounterCategories)
            {
                cboCategories.Items.Add(performanceCounterCategory.CategoryName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //performanceCounter1.CategoryName = "Memory";
            //performanceCounter1.CounterName = "Available KBytes";

            //foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT * FROM Win32_Processor").Get())
            //{
            //    maxspeed = Convert.ToDouble(obj["MaxClockSpeed"]);
            //    lblSystemName.Text = obj["SystemName"].ToString();
            //    lblProcessorId.Text = obj["ProcessorId"].ToString();
            //    lblProcessorName.Text = obj["Name"].ToString();
            //    lblProcessorCoresCount.Text = obj["NumberOfCores"].ToString();
            //    lblProcessorCoresEnabledCount.Text = obj["NumberOfEnabledCore"].ToString();
            //    lblProcessorLogicalCount.Text = obj["NumberOfLogicalProcessors"].ToString();
            //    lblProcessorMaxClockSpeed.Text = obj["MaxClockSpeed"].ToString();
            //    lblProcessorLoadPercentage.Text = obj["LoadPercentage"].ToString();
            //}

            label1.Text = PCounter0.NextValue().ToString();

            string ProcessorID = "";
            lblProcessorUtilization.Text = PCounter01.NextValue().ToString();

            double maxspeed = PCounter02.NextValue();
            double cpuValue = PCounter03.NextValue();

            //foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT *, Name FROM Win32_Processor").Get())
            //{
            //    maxspeed = Convert.ToDouble(obj["MaxClockSpeed"]);
            //    ProcessorID = obj["ProcessorId"].ToString();
            //}

            lblProcessorBaseSpeed.Text = (maxspeed / 1000).ToString();
            lblProcessorSpeed.Text = ((maxspeed / 1000) * cpuValue / 100).ToString();

            lblProcessorUpTime.Text = PCounter05.NextValue().ToString();
            lblProcessorProcessesCount.Text = PCounter06.NextValue().ToString();
            lblProcessorThreadsCount.Text = PCounter07.NextValue().ToString();


            //lblMemoryAvailable.Text = PCounter12.NextValue().ToString();

            decimal _MemoryTotal = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
            decimal _MemoryAvailable = new Microsoft.VisualBasic.Devices.ComputerInfo().AvailablePhysicalMemory;
            decimal _MemoryUsed = _MemoryTotal - _MemoryAvailable;

            lblMemoryTotal.Text = (_MemoryTotal / (1024 * 1024 * 1024)).ToString();
            lblMemoryAvailable.Text = (_MemoryAvailable / (1024 * 1024 * 1024)).ToString();
            lblMemoryUsed.Text = (_MemoryUsed / (1024 * 1024 * 1024)).ToString();


            decimal _totalspace = 0;
            decimal _freespace = 0;
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    _totalspace += drive.TotalSize;
                    _freespace += drive.AvailableFreeSpace;
                }
            }
            lblHDDTotalSpace.Text = (_totalspace / (1024 * 1024 * 1024)).ToString();
            lblHDDFreeSpace.Text = (_freespace / (1024 * 1024 * 1024)).ToString();



            this.Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            //PCounter2.CategoryName = "Processor Information";
            //PCounter2.CounterName = "Processor Frequency";
            //PCounter2.InstanceName = "_Total";
            //lblProcessorFrequency.Text = PCounter2.NextValue().ToString();

        }

        private void cboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboInstances.DataSource = null;
            cboCounters.Items.Clear();

            var performanceCounterCategories = PerformanceCounterCategory.GetCategories().FirstOrDefault(category => category.CategoryName == cboCategories.Text);
            var performanceCounterInstances = performanceCounterCategories.GetInstanceNames();
            cboInstances.DataSource = performanceCounterInstances;
            cboInstances.Text = "";

            if (performanceCounterInstances.Count() > 0)
            {
                var performanceCounters = performanceCounterCategories.GetCounters(cboInstances.Items[0].ToString()).OrderBy(p => p.CounterName);
                foreach (PerformanceCounter performanceCounter in performanceCounters)
                {
                    cboCounters.Items.Add(performanceCounter.CounterName);
                }
                cboCounters.Text = "";
            }
            else
            {
                var performanceCounters = performanceCounterCategories.GetCounters().OrderBy(p => p.CounterName);
                foreach (PerformanceCounter performanceCounter in performanceCounters)
                {
                    cboCounters.Items.Add(performanceCounter.CounterName);
                }
                cboCounters.Text = "";
            }


        }

        private void btnDisplayCounterResult_Click(object sender, EventArgs e)
        {
            try
            {
                PCounter00.CategoryName = cboCategories.Text;
                PCounter00.CounterName = cboCounters.Text;
                PCounter00.InstanceName = cboInstances.Text;

                lblCounterResult.Text = PCounter00.NextValue().ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
