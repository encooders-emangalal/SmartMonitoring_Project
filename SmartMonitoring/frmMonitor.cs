using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMonitoring
{
    public partial class frmMonitor : Form
    {
		private SmartMonitoringEntities1 db = new SmartMonitoringEntities1();

		public static string strMonitorID = "";
        public static string strCounterID = "";
        public static string strInstanceName = "";
        private double query;

        public double? Value { get; set; }

        public Timer Timer { get; set; }

        public frmMonitor()
        {
            InitializeComponent();
        }

        private bool Get(double? value, string mathSymbol, double ruleValue)
        {
            if (mathSymbol == "equals")
                return value == ruleValue;
            else if (mathSymbol == "more_than")
                return value > ruleValue;
            else if (mathSymbol == "less_than")
                return value < ruleValue;
            else
                return value != ruleValue;
        }

        private void frmMonitor_Load(object sender, EventArgs e)
        {
            var rules = db.montr_monitor_rules.ToList();
            foreach (var rule in rules)
            {
                var counter = db.montr_monitor_counters.FirstOrDefault(c => c.machine_id == rule.machine_id && c.counter_id == rule.counter_id && c.instance_id == rule.instance_id);
                if (rule.rule_field == "current")
                {
                    Value = counter.current_value;
                    
                }
                else if (rule.rule_field == "average")
                {
                    Value = counter.average_value;
                    query = db.montr_monitor_transactions.OrderByDescending(t => t.counter_datetime).Take(rule.ocuurance_interval).Average(c => c.counter_value);
                }
                else if (rule.rule_field == "minimum")
                {
                    Value = counter.minimum_value;
                    query = db.montr_monitor_transactions.OrderByDescending(t => t.counter_datetime).Take(rule.ocuurance_interval).Min(c => c.counter_value);
                }
                else
                {
                    Value = counter.maximum_value;
                    query = db.montr_monitor_transactions.OrderByDescending(t => t.counter_datetime).Take(rule.ocuurance_interval).Max(c => c.counter_value);
                }

                if (Get(Value, rule.rule_math_symbol, rule.rule_value))
                {

                }
                // refmnilekr
                if (rule.rule_field == "current")
                {
                    if (rule.rule_math_symbol == "equals")
                    {
                        if (counter.current_value == rule.rule_value)
                        {
                            if (rule.rule_ocuurance_type == 1) // For n occurance
                            {
                                var q = db.montr_monitor_transactions.OrderByDescending(c => c.counter_datetime).Take(rule.ocuurance_interval);
                                if (q.Where(c => c.counter_value == rule.rule_value).Count() == rule.ocuurance_interval)
                                {
                                    // do something
                                }
                            }
                            else // For specific period of time in seconds
                            {
                                var t = db.montr_monitor_transactions.Where(c => c.counter_datetime == DateTime.Now.AddSeconds(-rule.ocuurance_interval)).Count();
                                var q = db.montr_monitor_transactions.OrderByDescending(c => c.counter_datetime).Take(t);
                                if (q.Where(c => c.counter_value == rule.rule_value).Count() == t)
                                {
                                    // do something
                                }
                            }
                        }
                    }
                    else if (rule.rule_math_symbol == "not_equal")
                    {

                    }
                    else if (rule.rule_math_symbol == "more_than")
                    {
                        if (counter.current_value > rule.rule_value)
                        {
                            if (rule.rule_ocuurance_type == 1) // For n occurance
                            {
                                var q = db.montr_monitor_transactions.OrderByDescending(c => c.counter_datetime).Take(rule.ocuurance_interval).ToList();
                                if (q.Where(c => c.counter_value > rule.rule_value).Count() == rule.ocuurance_interval)
                                {
                                    // do something
                                }
                            }
                            else // For specific period of time in seconds
                            {
                                var dt = db.montr_monitor_transactions.OrderByDescending(c => c.counter_datetime).FirstOrDefault();
                                var x = dt.counter_datetime.AddSeconds(-rule.ocuurance_interval);
                                var t = db.montr_monitor_transactions.Where(c => c.counter_datetime > x).Count();
                                var q = db.montr_monitor_transactions.OrderByDescending(c => c.counter_datetime).Take(t).ToList();
                                if (q.Where(c => c.counter_value > rule.rule_value).Count() == t)
                                {
                                    // do something
                                }
                            }
                        }
                    }
                    else
                    {

                    }
                }
                else if (rule.rule_field == "average")
                {
                    if (rule.rule_math_symbol == "equals")
                    {

                    }
                    else if (rule.rule_math_symbol == "not_equal")
                    {

                    }
                    else if (rule.rule_math_symbol == "more_than")
                    {

                    }
                    else
                    {

                    }
                }
                else if (rule.rule_field == "minimum")
                {
                    if (rule.rule_math_symbol == "equals")
                    {

                    }
                    else if (rule.rule_math_symbol == "not_equal")
                    {

                    }
                    else if (rule.rule_math_symbol == "more_than")
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    if (rule.rule_math_symbol == "equals")
                    {

                    }
                    else if (rule.rule_math_symbol == "not_equal")
                    {

                    }
                    else if (rule.rule_math_symbol == "more_than")
                    {

                    }
                    else
                    {

                    }
                }
            }
            //Timer = new Timer
            //{
            //    Interval = 6000
            //};
            //Timer.Tick += TimerOnTick;
            tmrSelCounter.Start();
            //Timer.Start();

            load_servers();

            design_chart1();
            design_chart2();

            //Form1 _frm = new Form1();
            //_frm.Show();
        }

        private void design_chart1()
        {

            Chart1.DisableAnimations = false;
            Chart1.AnimationsSpeed = new TimeSpan(0);
            Chart1.TicksForeground = System.Windows.Media.Brushes.Black;
            Chart1.Base.Foreground = System.Windows.Media.Brushes.Black;
            Chart1.Base.FontWeight = System.Windows.FontWeights.Bold;
            Chart1.Base.FontSize = 16;
            Chart1.Wedge = 250;
            Chart1.TicksStrokeThickness = 1;
            Chart1.SectionsInnerRadius = 0.7;
            Chart1.LabelsStep = 10;
            Chart1.TickStep = 5;
            //Chart1.LabelFormatter = value => value.ToString() + "";

            Chart1.Sections.Add(new LiveCharts.Wpf.AngularSection
            {
                FromValue = 0,
                ToValue = 70,
                Height = 10,
                Width = 10,
                Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(57, 148, 60))
            });
            Chart1.Sections.Add(new LiveCharts.Wpf.AngularSection
            {
                FromValue = 70,
                ToValue = 90,
                Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(247, 166, 37))
            });
            Chart1.Sections.Add(new LiveCharts.Wpf.AngularSection
            {
                FromValue = 90,
                ToValue = 100,
                Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(254, 57, 57))
            });

            Chart1.BackColor = Color.White;
            

        }

        public ChartValues<MeasureModel> ChartValues { get; set; }
        
        public Random R { get; set; }

		public string _counter_id;

		public string _instance_id;

        public int _server_row_index; 

		public int _counter_row_index;
		private void design_chart2()
        {

            //To handle live data easily, in this case we built a specialized type
            //the MeasureModel class, it only contains 2 properties
            //DateTime and Value
            //We need to configure LiveCharts to handle MeasureModel class
            //The next code configures MEasureModel  globally, this means
            //that livecharts learns to plot MeasureModel and will use this config every time
            //a ChartValues instance uses this type.
            //this code ideally should only run once, when application starts is reccomended.
            //you can configure series in many ways, learn more at http://lvcharts.net/App/examples/v1/wpf/Types%20and%20Configuration

            var mapper = Mappers.Xy<MeasureModel>()
                .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
                .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<MeasureModel>(mapper);

            //the ChartValues property will store our values array
            ChartValues = new ChartValues<MeasureModel>();
            Chart2.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = ChartValues,
                    DataLabels = false,
                    LabelPoint = value => "",
                    PointGeometrySize = 8,
                    StrokeThickness = 2
                }
            };
            Chart2.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                //LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                LabelFormatter = value => "",
                IsMerged = true,
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(10).Ticks,
                    StrokeThickness = 1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 4 }),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });
            Chart2.AxisY.Add(new Axis
            {
                IsMerged = true,
                Separator = new Separator
                {
                    Step = 10,
                    StrokeThickness = 1,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 4 }),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });

            //Chart1.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 46, 49));
            Chart2.Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));

            SetAxisLimits(System.DateTime.Now);

            //The next code simulates data changes every 500 ms
            Timer = new Timer
            {
                Interval = 6000
            };
            Timer.Tick += TimerOnTick;
            R = new Random();
            Timer.Start();
        }
		MeasureModel m = new MeasureModel();
		private void SetAxisLimits(System.DateTime now)
        {
            Chart2.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks; // lets force the axis to be 100ms ahead
            Chart2.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(60).Ticks; //we only care about the last 8 seconds
        }

        public string _server_id;
        public string _monitor_id;
        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            if (txtSelServerID.Text != "" && _counter_id != null && _instance_id != null)
            {

                var now = System.DateTime.Now;

                _server_id = txtSelServerID.Text;
                _monitor_id = txtSelMonitorID.Text;



                var row = db.montr_monitor_transactions.Where(b => b.machine_id == txtSelServerID.Text && b.counter_id == _counter_id && b.instance_id == _instance_id).OrderBy(p => p.counter_datetime).ToList().LastOrDefault();
                if (row != null && row.counter_datetime != null)
                {

                    DateTime dt = (DateTime)row.counter_datetime;
                    DateTime dtPlusSeconds = dt.AddSeconds(10);


                    if (row.counter_value > 0)
                    {

                        if (_server_id != null && _monitor_id != null)
                        {
                            DataTable _table = new DataTable();
                            string _sql = $@"select tbl_link.counter_id, set_counters.counter_description,set_counters.counter_unit, counters.instance_id, counters.instance_name, servers1.machine_name, counters.current_value, counters.average_value, counters.minimum_value, counters.maximum_value
from [dbo].[montr_monitor_groups_counters] tbl_link
inner join [dbo].[montr_monitor_counters] counters on tbl_link.machine_id = counters.machine_id and tbl_link.counter_id = counters.counter_id and tbl_link.instance_id = counters.instance_id
inner join [dbo].[set_counters] set_counters on counters.counter_id = set_counters.counter_id
inner join [dbo].[montr_machines_list] servers1 on tbl_link.machine_id = servers1.machine_id
where tbl_link.machine_id = '{_server_id}' and tbl_link.group_id = {_monitor_id}";

                            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
                            {
                                _connection.Open();

                                using (SqlDataAdapter da = new SqlDataAdapter(_sql, _connection))
                                {
                                    da.Fill(_table);
                                }

                                _connection.Close();
                            }

                            for (int i = 0; i < _table.Rows.Count; i++)
                            {
                                for (int x = 0; x < gvCounters.Rows.Count; x++)
                                {
                                    if (_table.Rows[i]["counter_id"].ToString() == gvCounters.Rows[x].Cells[0].Value.ToString() && _table.Rows[i]["instance_id"].ToString() == gvCounters.Rows[x].Cells[2].Value.ToString())
                                    {
                                        if (!(_table.Rows[i]["current_value"] is DBNull))
                                            gvCounters.Rows[x].Cells[5].Value = Math.Round(Convert.ToDouble(_table.Rows[i]["current_value"]), 1) + " " + _table.Rows[i]["counter_unit"].ToString();
                                        if (!(_table.Rows[i]["average_value"] is DBNull))
                                            gvCounters.Rows[x].Cells[6].Value = Math.Round(Convert.ToDouble(_table.Rows[i]["average_value"]), 1) + " " + _table.Rows[i]["counter_unit"].ToString();
                                        if (!(_table.Rows[i]["minimum_value"] is DBNull))
                                            gvCounters.Rows[x].Cells[7].Value = Math.Round(Convert.ToDouble(_table.Rows[i]["minimum_value"]), 1) + " " + _table.Rows[i]["counter_unit"].ToString();
                                        if (!(_table.Rows[i]["maximum_value"] is DBNull))
                                            gvCounters.Rows[x].Cells[8].Value = Math.Round(Convert.ToDouble(_table.Rows[i]["maximum_value"]), 1) + " " + _table.Rows[i]["counter_unit"].ToString();
                                    }
                                }
                            }
                        }
                        //if (gvCounters.SelectedRows == null)
                        //    gvCounters.Rows[0].Selected = true;
                        if (gvCounters.SelectedRows[0].Cells[5].Value != null)
                        {
                            string lastValue = gvCounters.SelectedRows[0].Cells[5].Value.ToString();

                            string[] array = lastValue.Split(' ');
                            double lValDouble = Convert.ToDouble(array[0]);

                            ChartValues.Add(new MeasureModel
                            {
                                DateTime = now,
                                Value = lValDouble
                            });
                            Chart1.Value = lValDouble;
                            lblChart1Value.Text = Math.Round(lValDouble, 1).ToString() + " " + array[1];
                        }
                        
                        SetAxisLimits(now);

                        //lets only use the last 60 values
                        if (ChartValues.Count > 60) ChartValues.RemoveAt(0);

                    }
                    else
                    {
                        ChartValues.Clear();
                        Chart1.Value = 0;
                        lblChart1Value.Text = "- %";
                        for (int i = 0; i < gvCounters.Rows.Count; i++)
                        {
                            gvCounters.Rows[i].Cells[5].Value = "";
                            gvCounters.Rows[i].Cells[6].Value = "";
                            gvCounters.Rows[i].Cells[7].Value = "";
                            gvCounters.Rows[i].Cells[8].Value = "";
                        }
                        // load_Counters(txtSelServerID.Text, Convert.ToInt32(_monitor_id));
                    }
                }

            }
            else
            {
                ChartValues.Clear();
                Chart1.Value = 0;
                lblChart1Value.Text = "- %";
                // load_Counters(txtSelServerID.Text, Convert.ToInt32(_monitor_id));
            }

        }


        private void load_servers()
        {
            gvServers.Rows.Clear();
            if (ChartValues != null)
            {
                ChartValues.Clear();
                Chart1.Value = 0;
                lblChart1Value.Text = "- %";
            }

            DataTable _table = new DataTable();
            string _sql = "select machine_id, '' as server_image_id, '' as server_image, machine_name from montr_machines_list where is_deleted = 0";
            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                _connection.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(_sql, _connection))
                {
                    da.Fill(_table);
                }

                _connection.Close();
            }

            for (int i = 0; i < _table.Rows.Count; i++)
            {
                gvServers.Rows.Add(_table.Rows[i]["machine_id"].ToString(), _table.Rows[i]["server_image_id"].ToString(), _table.Rows[i]["server_image"].ToString(),
                    _table.Rows[i]["machine_name"].ToString());
                gvServers.Rows[i].Cells[2].Value = Properties.Resources.devices_computer;
            }

            //gvServers.DataSource = _table;

            //load_monitors();
        }

        private void load_Monitors(string _server_id)
        {
            gvMonitors.Rows.Clear();
            if (ChartValues != null)
            {
                ChartValues.Clear();
                Chart1.Value = 0;
                lblChart1Value.Text = "- %";
            }

            DataTable _table = new DataTable();
            string _sql = $"select group_id, group_image_id as monitor_image_id, '' as monitor_image, group_name from montr_monitor_groups where is_deleted = 0 and machine_id = '{_server_id}'";
            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                _connection.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(_sql, _connection))
                {
                    da.Fill(_table);
                }

                _connection.Close();
            }


            for (int i = 0; i < _table.Rows.Count; i++)
            {
                gvMonitors.Rows.Add(_table.Rows[i]["group_id"].ToString(), _table.Rows[i]["monitor_image_id"].ToString(), _table.Rows[i]["monitor_image"].ToString(),
                    _table.Rows[i]["group_name"].ToString());
                if (_table.Rows[i]["monitor_image_id"].ToString() == "system_monitor")
                {
                    gvMonitors.Rows[i].Cells[2].Value = Properties.Resources.devices_system;
                }
                else if (_table.Rows[i]["monitor_image_id"].ToString() == "system_status")
                {
                    gvMonitors.Rows[i].Cells[2].Value = Properties.Resources.devices_system3;
                }
                else if (_table.Rows[i]["monitor_image_id"].ToString() == "extended_status")
                {
                    gvMonitors.Rows[i].Cells[2].Value = Properties.Resources.devices_system2;
                }
                else if (_table.Rows[i]["monitor_image_id"].ToString() == "cpu_monitor")
                {
                    gvMonitors.Rows[i].Cells[2].Value = Properties.Resources.devices_cpu;
                }
                else if (_table.Rows[i]["monitor_image_id"].ToString() == "memory_monitor")
                {
                    gvMonitors.Rows[i].Cells[2].Value = Properties.Resources.devices_ram;
                }
                else if (_table.Rows[i]["monitor_image_id"].ToString() == "process_monitor")
                {
                    gvMonitors.Rows[i].Cells[2].Value = Properties.Resources.actions_view_process;
                }
                else if (_table.Rows[i]["monitor_image_id"].ToString() == "network_monitor")
                {
                    gvMonitors.Rows[i].Cells[2].Value = Properties.Resources.devices_modem;
                }
                else if (_table.Rows[i]["monitor_image_id"].ToString() == "system_analyzer")
                {
                    gvMonitors.Rows[i].Cells[2].Value = Properties.Resources.actions_charts_chart3;
                }
                else if (_table.Rows[i]["monitor_image_id"].ToString() == "disk_monitor")
                {
                    gvMonitors.Rows[i].Cells[2].Value = Properties.Resources.devices_harddisk;
                }
                else if (_table.Rows[i]["monitor_image_id"].ToString() == "nas_monitor")
                {
                    gvMonitors.Rows[i].Cells[2].Value = Properties.Resources.devices_nas2;
                }
                else if (_table.Rows[i]["monitor_image_id"].ToString() == "sql_monitor")
                {
                    gvMonitors.Rows[i].Cells[2].Value = Properties.Resources.apps_tools_database;
                }
                else if (_table.Rows[i]["monitor_image_id"].ToString() == "iis_monitor")
                {
                    gvMonitors.Rows[i].Cells[2].Value = Properties.Resources.devices_internet;
                }
                else if (_table.Rows[i]["monitor_image_id"].ToString() == "custom_monitor")
                {
                    gvMonitors.Rows[i].Cells[2].Value = Properties.Resources.actions_window_normal;
                }
            }


            //gvMonitors.DataSource = _table;
        }

        private void load_Counters(string _server_id, int _monitor_id)
        {
            gvCounters.Rows.Clear();
            if (ChartValues != null)
            {
                ChartValues.Clear();
                Chart1.Value = 0;
                lblChart1Value.Text = "- %";
            }

            DataTable _table = new DataTable();
            string _sql = $@"select tbl_link.counter_id, set_counters.counter_description, set_counters.counter_unit, counters.instance_id, counters.instance_name, servers1.machine_name, counters.current_value, counters.average_value, counters.minimum_value, counters.maximum_value
from [dbo].[montr_monitor_groups_counters] tbl_link
inner join [dbo].[montr_monitor_counters] counters on tbl_link.machine_id = counters.machine_id and tbl_link.counter_id = counters.counter_id and tbl_link.instance_id = counters.instance_id
inner join [dbo].[set_counters] set_counters on counters.counter_id = set_counters.counter_id
inner join [dbo].[montr_machines_list] servers1 on tbl_link.machine_id = servers1.machine_id
where counters.is_deleted = 0 and tbl_link.machine_id = '{_server_id}' and tbl_link.group_id = {_monitor_id}";
            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                _connection.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(_sql, _connection))
                {
                    da.Fill(_table);
                }

                _connection.Close();
            }

            for (int i = 0; i < _table.Rows.Count; i++)
            {
                gvCounters.Rows.Add(_table.Rows[i]["counter_id"].ToString(), _table.Rows[i]["counter_description"].ToString(), _table.Rows[i]["instance_id"].ToString(),
                    _table.Rows[i]["instance_name"].ToString(), _table.Rows[i]["machine_name"].ToString());
                if (!(_table.Rows[i]["current_value"] is DBNull))
                    gvCounters.Rows[i].Cells[5].Value = Math.Round(Convert.ToDouble(_table.Rows[i]["current_value"]), 1) + " " + _table.Rows[i]["counter_unit"].ToString();
                if (!(_table.Rows[i]["average_value"] is DBNull))
                    gvCounters.Rows[i].Cells[6].Value = Math.Round(Convert.ToDouble(_table.Rows[i]["average_value"]), 1) + " " + _table.Rows[i]["counter_unit"].ToString();
                if (!(_table.Rows[i]["minimum_value"] is DBNull))
                    gvCounters.Rows[i].Cells[7].Value = Math.Round(Convert.ToDouble(_table.Rows[i]["minimum_value"]), 1) + " " + _table.Rows[i]["counter_unit"].ToString();
                if (!(_table.Rows[i]["maximum_value"] is DBNull))
                    gvCounters.Rows[i].Cells[8].Value = Math.Round(Convert.ToDouble(_table.Rows[i]["maximum_value"]), 1) + " " + _table.Rows[i]["counter_unit"].ToString();
                //for (int x = 0; x < gvCounters.Rows.Count; x++)
                //{
                //    if (_table.Rows[i]["counter_id"].ToString() == gvCounters.Rows[x].Cells[0].Value.ToString() && _table.Rows[i]["instance_id"].ToString() == gvCounters.Rows[x].Cells[2].Value.ToString())
                //    {
                //        if (!(_table.Rows[i]["current_value"] is DBNull))
                //            gvCounters.Rows[x].Cells[5].Value = Math.Round(Convert.ToDouble(_table.Rows[i]["current_value"]), 1) + " " + _table.Rows[i]["counter_unit"].ToString();
                //        if (!(_table.Rows[i]["average_value"] is DBNull))
                //            gvCounters.Rows[x].Cells[6].Value = Math.Round(Convert.ToDouble(_table.Rows[i]["average_value"]), 1) + " " + _table.Rows[i]["counter_unit"].ToString();
                //        if (!(_table.Rows[i]["minimum_value"] is DBNull))
                //            gvCounters.Rows[x].Cells[7].Value = Math.Round(Convert.ToDouble(_table.Rows[i]["minimum_value"]), 1) + " " + _table.Rows[i]["counter_unit"].ToString();
                //        if (!(_table.Rows[i]["maximum_value"] is DBNull))
                //            gvCounters.Rows[x].Cells[8].Value = Math.Round(Convert.ToDouble(_table.Rows[i]["maximum_value"]), 1) + " " + _table.Rows[i]["counter_unit"].ToString();
                //    }
                //}
            }

            //gvCounters.DataSource = _table;
        }

        private void frmMonitor_Resize(object sender, EventArgs e)
        {
            pnlServers.Height = this.Height - (menuStrip.Height + tsMain.Height + 55);
            pnlMonitors.Height = this.Height - (menuStrip.Height + tsMain.Height + 55);
            pnlCounters.Height = this.Height - (menuStrip.Height + tsMain.Height + 55);
            pnlServers.Top = menuStrip.Height + tsMain.Height + 5;
            pnlMonitors.Top = menuStrip.Height + tsMain.Height + 5;
            pnlCounters.Top = menuStrip.Height + tsMain.Height + 5;

            pnlServers.Left = 5;
            pnlMonitors.Left = 260;
            pnlCounters.Width = this.Width - 540;
            pnlCounters.Left = 515;
            gvCounters.Width = pnlCounters.Width;
            

            design_chart1();
        }

        private void gvServers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string _server_id = gvServers.Rows[e.RowIndex].Cells[0].Value.ToString();
            string _server_name = gvServers.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (_server_row_index != e.RowIndex && ChartValues != null)
            {
                ChartValues.Clear();
                Chart1.Value = 0;
                lblChart1Value.Text = "- %";
            }
            _server_row_index = e.RowIndex;
            txtSelServerID.Text = _server_id;
            txtSelServerName.Text = _server_name;
            txtSelMonitorID.Text = "";
            txtSelCounterID.Text = "";
			if (_counter_id != null && _instance_id != null)
			{
				_counter_id = null;
				_instance_id = null;
			}
             load_Monitors(_server_id);
        }

        private void gvMonitors_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string _monitor_id = gvMonitors.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (ChartValues != null)
            {
                ChartValues.Clear();
                Chart1.Value = 0;
                lblChart1Value.Text = "- %";
            }
            txtSelMonitorID.Text = _monitor_id;
            txtSelCounterID.Text = "";
			if (_counter_id != null && _instance_id != null)
			{
				_counter_id = null;
				_instance_id = null;
			}
			load_Counters(txtSelServerID.Text, Convert.ToInt32(_monitor_id));
        }

        private void btnJobStart_Click(object sender, EventArgs e)
        {

		}

        public static void AddCounter()
        {
            //DataGridView _gv = this.
        }

        private void gvCounters_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (_counter_row_index != e.RowIndex && ChartValues != null)
            {
                ChartValues.Clear();
                Chart1.Value = 0;
                lblChart1Value.Text = "- %";
            }				
			_counter_row_index = e.RowIndex;
            _counter_id = gvCounters.Rows[e.RowIndex].Cells[0].Value.ToString();
			_instance_id = gvCounters.Rows[e.RowIndex].Cells[2].Value.ToString();
			string _machine_id = gvCounters.Rows[e.RowIndex].Cells[4].Value.ToString();
			txtSelCounterID.Text = _counter_id;

			m.DateTime = DateTime.Now;

		}

		
		private void tmrSelCounter_Tick(object sender, EventArgs e)
        {
			
			
			
		}

        private void mnuServerAdd_Click(object sender, EventArgs e)
        {
			using (frmMachineDetails dialogForm = new frmMachineDetails("add", ""))
			{
				DialogResult dr = dialogForm.ShowDialog(this);
				if (dr == DialogResult.OK)
				{
                    int index = gvServers.SelectedRows[0].Index;
                    load_servers();
                    //if (dialogForm.ServerID != null)
                    //    load_Monitors(dialogForm.ServerID);
                    gvServers.ClearSelection();
                    gvServers.Rows[index].Selected = true;
                }
				dialogForm.Close();
			}
		}

        private void mnuServerEdit_Click(object sender, EventArgs e)
        {
            using (frmMachineDetails dialogForm = new frmMachineDetails("edit", txtSelServerID.Text))
            {
                DialogResult dr = dialogForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    int index = gvServers.SelectedRows[0].Index;
                    load_servers();
                    gvServers.ClearSelection();
                    gvServers.Rows[index].Selected = true;
                }
                dialogForm.Close();
            }
        }

		private void mnuServerDelete_Click(object sender, EventArgs e)
		{
			//Int32 rowToDelete = gvServers.Rows.GetFirstRow(DataGridViewElementStates.Selected);
			//string machine_id = txtSelServerID.Text;

			DialogResult dr = MessageBox.Show("Are you Sure you want to Delete this Server?", "Deleting Server", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			if (dr == DialogResult.OK)
			{
                //gvServers.Rows.RemoveAt(rowToDelete);
                //gvServers.ClearSelection();

                var serverToDelete = db.montr_machines_list.FirstOrDefault(s => s.machine_id == txtSelServerID.Text);
                serverToDelete.is_deleted = true;
                serverToDelete.delete_dt = DateTime.Now;
                serverToDelete.delete_user_id = 0;
                db.Entry(serverToDelete).State = EntityState.Modified;
                db.SaveChanges();
                load_servers();
			}
		}

        private void mnuServerDuplicate_Click(object sender, EventArgs e)
        {
            using (frmMachineDetails dialogForm = new frmMachineDetails("duplicate", txtSelServerID.Text))
            {
                DialogResult dr = dialogForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    int index = gvServers.SelectedRows[0].Index;
                    load_servers();
                    gvServers.ClearSelection();
                    gvServers.Rows[index].Selected = true;
                }
                dialogForm.Close();
            }
            //using (frmMachineDetails dialogForm = new frmMachineDetails(true, txtSelServerID.Text, txtSelServerName.Text))
            //{
            //    DialogResult dr = dialogForm.ShowDialog(this);
            //    if (dr == DialogResult.OK)
            //    {
            //        int index = gvServers.SelectedRows[0].Index;
            //        load_servers();
            //        gvServers.ClearSelection();
            //        gvServers.Rows[index].Selected = true;
            //    }
            //    dialogForm.Close();
            //}
        }

        private void mnuCounterAdd_Click(object sender, EventArgs e)
		{
			using (frmCountersAdd dialogForm = new frmCountersAdd(txtSelServerID.Text, txtSelServerName.Text, txtSelMonitorID.Text))
			{
			    DialogResult dr = dialogForm.ShowDialog(this);
			    if (dr == DialogResult.OK)
			    {
			        string[] _arr_result = dialogForm.getText().Split(';');
			        gvCounters.Rows.Add(_arr_result[0], _arr_result[1], _arr_result[2], _arr_result[3], _arr_result[4], "-", "-", "-", "-");
			    }
			    dialogForm.Close();
			}
		}

		private void gvCounters_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				var hti = gvCounters.HitTest(e.X, e.Y);
				
				// _counter_id = gvCounters.Rows[hti.RowIndex].Cells[0].Value.ToString();
				//_instance_id = gvCounters.Rows[hti.RowIndex].Cells[2].Value.ToString();
				//string _machine_id = gvCounters.Rows[hti.RowIndex].Cells[4].Value.ToString();
				txtSelCounterID.Text = _counter_id;

				m.DateTime = DateTime.Now;
				gvCounters.ClearSelection();
				if (hti.RowIndex < 0)
				{
					cmnuCounters.Items.Find("mnuCounterDelete", true).FirstOrDefault().Enabled = false;
                    cmnuCounters.Items.Find("mnuNotificationRules", true).FirstOrDefault().Enabled = false;
                    cmnuCounters.Items.Find("mnuCounterDetails", true).FirstOrDefault().Enabled = false;
                }
				else
				{
                    if (_counter_row_index != hti.RowIndex && ChartValues != null)
                        ChartValues.Clear();
                    _counter_row_index = hti.RowIndex;
                    cmnuCounters.Items.Find("mnuCounterDelete", true).FirstOrDefault().Enabled = true;
                    cmnuCounters.Items.Find("mnuNotificationRules", true).FirstOrDefault().Enabled = true;
                    cmnuCounters.Items.Find("mnuCounterDetails", true).FirstOrDefault().Enabled = true;
                    gvCounters.Rows[hti.RowIndex].Selected = true;
                    txtSelCounterID.Text = gvCounters.Rows[hti.RowIndex].Cells[0].Value.ToString();
                    _instance_id = gvCounters.Rows[hti.RowIndex].Cells[2].Value.ToString();
                    // string _machine_id = gvCounters.Rows[hti.RowIndex].Cells[4].Value.ToString();
                }

            }
		}

		private void mnuCounterDelete_Click(object sender, EventArgs e)
		{
			Int32 rowToDelete = gvCounters.Rows.GetFirstRow(DataGridViewElementStates.Selected);
			string mach_id = txtSelServerID.Text;
			string coun_id = txtSelCounterID.Text;
			string inst_id = gvCounters.Rows[rowToDelete].Cells[2].Value.ToString();
            string _monitor_id = txtSelMonitorID.Text;

            DialogResult dr = MessageBox.Show("Are you Sure you want to Delete this Row?\nNote: All Data that related to this Counter will be Deleted Permanently!", "Deleting Counter", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			if (dr == DialogResult.OK)
			{
				//gvCounters.Rows.RemoveAt(rowToDelete);
				//gvCounters.ClearSelection();

                using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
				{
					using (SqlCommand _command = new SqlCommand())
					{
						_connection.Open();
						_command.Connection = _connection;
                        _command.CommandText = @"DELETE FROM montr_monitor_transactions WHERE machine_id = @machine_id and counter_id = @counter_id and instance_id = @instance_id";
                        _command.Parameters.AddWithValue("@machine_id", mach_id);
                        _command.Parameters.AddWithValue("@counter_id", coun_id);
                        _command.Parameters.AddWithValue("@instance_id", inst_id);
                        _command.ExecuteNonQuery();

						_connection.Close();
					}
				}
                using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
                {
                    using (SqlCommand _command = new SqlCommand())
                    {
                        _connection.Open();
                        _command.Connection = _connection;
                        _command.CommandText = @"DELETE FROM montr_monitor_rules WHERE machine_id = @machine_id and counter_id = @counter_id and instance_id = @instance_id";
                        _command.Parameters.AddWithValue("@machine_id", mach_id);
                        _command.Parameters.AddWithValue("@counter_id", coun_id);
                        _command.Parameters.AddWithValue("@instance_id", inst_id);
                        _command.ExecuteNonQuery();

                        _connection.Close();
                    }
                }
                using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
                {
                    using (SqlCommand _command = new SqlCommand())
                    {
                        _connection.Open();
                        _command.Connection = _connection;
                        _command.CommandText = @"DELETE FROM montr_monitor_groups_counters WHERE machine_id = @machine_id and group_id = @group_id and counter_id = @counter_id and instance_id = @instance_id";
                        _command.Parameters.AddWithValue("@machine_id", mach_id);
                        _command.Parameters.AddWithValue("@group_id", _monitor_id);
                        _command.Parameters.AddWithValue("@counter_id", coun_id);
                        _command.Parameters.AddWithValue("@instance_id", inst_id);
                        _command.ExecuteNonQuery();

                        _connection.Close();
                    }
                }
                using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
                {
                    using (SqlCommand _command = new SqlCommand())
                    {
                        _connection.Open();
                        _command.Connection = _connection;
                        _command.CommandText = @"DELETE FROM montr_monitor_counters WHERE machine_id = @machine_id and counter_id = @counter_id and instance_id = @instance_id";
                        _command.Parameters.AddWithValue("@machine_id", mach_id);
                        _command.Parameters.AddWithValue("@counter_id", coun_id);
                        _command.Parameters.AddWithValue("@instance_id", inst_id);
                        _command.ExecuteNonQuery();

                        _connection.Close();
                    }
                }

                
               load_Counters(mach_id, Convert.ToInt32(_monitor_id));
                //gvCounters.Rows[0].Selected = true;

			}
		}

		private void gvServers_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{

				var hti = gvServers.HitTest(e.X, e.Y);
                //ChartValues.Clear();

                

                //            txtSelMonitorID.Text = "";
                //txtSelCounterID.Text = "";
                if (_counter_id != null && _instance_id != null)
				{
					_counter_id = null;
					_instance_id = null;
				}
				
				 gvServers.ClearSelection();
				if (hti.RowIndex < 0)
				{
					
					cmnuServers.Items.Find("mnuServerDelete", true).FirstOrDefault().Enabled = false;
					cmnuServers.Items.Find("mnuServerDuplicate", true).FirstOrDefault().Enabled = false;
                    cmnuServers.Items.Find("mnuServerEdit", true).FirstOrDefault().Enabled = false;
                }
				else
				{
                    string _server_id = gvServers.Rows[hti.RowIndex].Cells[0].Value.ToString();
                    string _server_name = gvServers.Rows[hti.RowIndex].Cells[3].Value.ToString();
                    if (_server_row_index != hti.RowIndex && ChartValues != null)
                    {
                        ChartValues.Clear();
                        Chart1.Value = 0;
                        lblChart1Value.Text = "- %";
                    }
                    _server_row_index = hti.RowIndex;
                    txtSelServerID.Text = _server_id;
                    txtSelServerName.Text = _server_name;
                    txtSelMonitorID.Text = "";
                    txtSelCounterID.Text = "";
                    if (_counter_id != null && _instance_id != null)
                    {
                        _counter_id = null;
                        _instance_id = null;
                    }
                    load_Monitors(_server_id);
                    if (_server_row_index != hti.RowIndex && ChartValues != null)
                    {
                        ChartValues.Clear();
                        Chart1.Value = 0;
                        lblChart1Value.Text = "- %";
                        load_Monitors(gvServers.Rows[hti.RowIndex].Cells[0].Value.ToString());
                    }
                    _server_row_index = hti.RowIndex;
                    txtSelServerID.Text = gvServers.Rows[hti.RowIndex].Cells[0].Value.ToString();
					txtSelServerName.Text = gvServers.Rows[hti.RowIndex].Cells[3].Value.ToString();
					cmnuServers.Items.Find("mnuServerDelete", true).FirstOrDefault().Enabled = true;
					cmnuServers.Items.Find("mnuServerDuplicate", true).FirstOrDefault().Enabled = true;
                    cmnuServers.Items.Find("mnuServerEdit", true).FirstOrDefault().Enabled = true;
                    gvServers.Rows[hti.RowIndex].Selected = true;
                    
                }
			}
		}

		

        private void mnuNotificationRules_Click(object sender, EventArgs e)
        {
            int row = gvCounters.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            string countName = gvCounters.Rows[row].Cells[1].Value.ToString();
            string mach_id = txtSelServerID.Text;
            string coun_id = txtSelCounterID.Text;
            string inst_id = gvCounters.Rows[row].Cells[2].Value.ToString();

            using (NotificationRules dialogForm = new NotificationRules(countName, mach_id, coun_id, inst_id))
            {
                DialogResult dr = dialogForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {

                }
                dialogForm.Close();
            }
        }

        private void mnuCounterDetails_Click(object sender, EventArgs e)
        {
            CounterDetails countDetails = new CounterDetails(txtSelCounterID.Text, gvCounters.SelectedRows[0].Cells[2].Value.ToString(), gvCounters.SelectedRows[0].Cells[3].Value.ToString());
            countDetails.ShowDialog();
        }

        private void mnuCounterViewData_Click(object sender, EventArgs e)
        {
            if (gvCounters.SelectedRows[0].Cells[5].Value != null)
            {
                string[] splitToGetCounterUnit = gvCounters.SelectedRows[0].Cells[5].Value.ToString().Split(' ');
                CounterData countData = new CounterData(txtSelServerID.Text, txtSelCounterID.Text, gvCounters.SelectedRows[0].Cells[2].Value.ToString(), splitToGetCounterUnit[1]);
                countData.ShowDialog();
            }
            
        }

        private void mnuCounterExportData_Click(object sender, EventArgs e)
        {
            ExportCounter expCounter = new ExportCounter();
            expCounter.ShowDialog();
        }

        private void btnErrors_Click(object sender, EventArgs e)
        {
            MonitorErrors monitorError = new MonitorErrors();
            monitorError.ShowDialog();
        }

        private void gvCounters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            frmUserConfigration frmUserConfigration = new frmUserConfigration();
            frmUserConfigration.ShowDialog();
        }
    }

    public class MeasureModel
    {
        public System.DateTime DateTime { get; set; }
        public double Value { get; set; }
    }

}
