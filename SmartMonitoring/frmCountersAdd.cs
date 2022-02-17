using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMonitoring
{
    public partial class frmCountersAdd : Form
    {
        private string _ServerID;
        private string _ServerName;
        private string _GroupID;

        public frmCountersAdd()
        {
            InitializeComponent();

            btnAdd.DialogResult = DialogResult.OK;
        }

        public frmCountersAdd(string ServerID, string ServerName, string GroupID)
        {
            InitializeComponent();

            btnAdd.DialogResult = DialogResult.OK;
            _ServerID = ServerID;
            _ServerName = ServerName;
            _GroupID = GroupID;
        }

        private void frmCountersAdd_Load(object sender, EventArgs e)
        {
            load_monitors();
        }

        private void load_monitors()
        {
            gvMonitors.Rows.Clear();

            DataTable _table = new DataTable();
            string _sql = "select category_id, '' as category_image, category_description from set_counters_categories where is_active = 1";
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
                gvMonitors.Rows.Add(_table.Rows[i]["category_id"].ToString(), _table.Rows[i]["category_image"].ToString(), _table.Rows[i]["category_description"].ToString());
                if (_table.Rows[i]["category_id"].ToString() == "cpu")
                {
                    gvMonitors.Rows[i].Cells[1].Value = Properties.Resources.devices_cpu;
                }
                else if (_table.Rows[i]["category_id"].ToString() == "ram")
                {
                    gvMonitors.Rows[i].Cells[1].Value = Properties.Resources.devices_ram;
                }
                else if (_table.Rows[i]["category_id"].ToString() == "hdd")
                {
                    gvMonitors.Rows[i].Cells[1].Value = Properties.Resources.devices_harddisk;
                }
                else if (_table.Rows[i]["category_id"].ToString() == "nwa")
                {
                    gvMonitors.Rows[i].Cells[1].Value = Properties.Resources.devices_modem;
                }
                else if (_table.Rows[i]["category_id"].ToString() == "nwp")
                {
                    gvMonitors.Rows[i].Cells[1].Value = Properties.Resources.devices_modem;
                }
                else if (_table.Rows[i]["category_id"].ToString() == "sys")
                {
                    gvMonitors.Rows[i].Cells[1].Value = Properties.Resources.devices_computer;
                }
                else if (_table.Rows[i]["category_id"].ToString() == "prc")
                {
                    gvMonitors.Rows[i].Cells[1].Value = Properties.Resources.actions_view_process;
                }
                else if (_table.Rows[i]["category_id"].ToString() == "file")
                {
                    gvMonitors.Rows[i].Cells[1].Value = Properties.Resources.devices_system;
                }
                else if (_table.Rows[i]["category_id"].ToString() == "usb")
                {
                    gvMonitors.Rows[i].Cells[1].Value = Properties.Resources.devices_harddisk;
                }
                else if (_table.Rows[i]["category_id"].ToString() == "nas")
                {
                    gvMonitors.Rows[i].Cells[1].Value = Properties.Resources.devices_nas1;
                }
                else if (_table.Rows[i]["category_id"].ToString() == "sql")
                {
                    gvMonitors.Rows[i].Cells[1].Value = Properties.Resources.apps_tools_database;
                }
                else if (_table.Rows[i]["category_id"].ToString() == "iis")
                {
                    gvMonitors.Rows[i].Cells[1].Value = Properties.Resources.devices_internet;
                }
            }

            gvMonitors.Columns[2].Width = 140;


            //gvMonitors.DataSource = _table;
        }

        private void load_counters(string _category_id)
        {
            DataTable _table = new DataTable();
            string _sql = $"select counter_id, counter_description, category_name, instance_total_name, instance_all_prefix, instance_blank_name from set_counters where category_id = '{_category_id}' and is_active = 1";
            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                _connection.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(_sql, _connection))
                {
                    da.Fill(_table);
                }

                _connection.Close();
            }

            gvCounters.DataSource = _table;

            gvCounters.Columns[0].Visible = false;
            gvCounters.Columns[2].Visible = false;
            gvCounters.Columns[1].HeaderText = "Counter";
            gvCounters.Columns[1].Width = 210;
            gvCounters.Columns[3].Visible = false;
            gvCounters.Columns[4].Visible = false;
            gvCounters.Columns[5].Visible = false;
        }

        private void load_instances(string _category_name)
        {
            gvInstances.Rows.Clear();

            DataTable _table = new DataTable();
            _table.Columns.Add("instance_id", typeof(string));
            _table.Columns.Add("instance_name", typeof(string));

            var performanceCounterCategories = PerformanceCounterCategory.GetCategories().FirstOrDefault(category => category.CategoryName == _category_name);
            if (performanceCounterCategories != null)
            {
                var performanceCounterInstances = performanceCounterCategories.GetInstanceNames();
                if (performanceCounterInstances.Count() > 0)
                {
                    for (int i = 0; i < performanceCounterInstances.Count(); i++)
                    {
                        _table.Rows.Add(performanceCounterInstances[i], "");
                    }
                }
            }

            DataView _view = new DataView();
            _view = _table.DefaultView;
            _view.Sort = "instance_id";


            if (_view.Count > 0)
            {
                for (int i = 0; i < _view.Count; i++)
                {
                    if (_view[i]["instance_id"].ToString() == "_Total")
                    {
                        gvInstances.Rows.Add(_view[i]["instance_id"].ToString(), txtSelCounterInstanceTotal.Text);
                    }
                    else
                    {
                        if (txtSelCounterInstancePrefix.Text != "")
                        {
                            gvInstances.Rows.Add(_view[i]["instance_id"].ToString(), txtSelCounterInstancePrefix.Text + " " + _view[i]["instance_id"].ToString());
                        }
                        else
                        {
                            gvInstances.Rows.Add(_view[i]["instance_id"].ToString(), _view[i]["instance_id"].ToString());
                        }
                    }
                }
            }
            else
            {
                if (txtSelCounterID.Text != "")
                {
                    gvInstances.Rows.Add("", txtSelCounterInstanceBlank.Text);
                }
            }

            //gvInstances.DataSource = _view;

            gvInstances.Columns[1].HeaderText = "Instance";
            gvInstances.Columns[1].Width = 180;
            gvInstances.Columns[0].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtSelInstanceName.Text == "")
            {
                this.DialogResult = DialogResult.None;
            }

            int _counters_inserted = 0;
            string _sql1 = $"select count(*) from montr_monitor_counters where machine_id = '{_ServerID}' and counter_id = '{txtSelCounterID.Text}' and instance_id = '{txtSelInstanceID.Text}'";
            int _existing_counters_count = DAL.clsDBFunctions.getRecordsCount(_sql1);
            if (_existing_counters_count == 0)
            {
                _counters_inserted = InsertCounter(_ServerID, txtSelCounterID.Text, txtSelInstanceID.Text, txtSelInstanceName.Text);
            }
            else
            {
                //MessageBox.Show("Message", "This counter already exists.");
            }


            int _group_counters_inserted = 0;
            string _sql2 = $"select count(*) from montr_monitor_groups_counters where machine_id = '{_ServerID}' and group_id = {Convert.ToInt32(_GroupID)} and counter_id = '{txtSelCounterID.Text}' and instance_id = '{txtSelInstanceID.Text}'";
            int _existing_group_counters_count = DAL.clsDBFunctions.getRecordsCount(_sql2);
            if (_existing_group_counters_count == 0)
            {
                _group_counters_inserted = InsertGroupCounter(_ServerID, Convert.ToInt32(_GroupID), txtSelCounterID.Text, txtSelInstanceID.Text);
            }
            else
            {
                MessageBox.Show("This counter already added to this group.", "Message");
                this.DialogResult = DialogResult.None;
            }

        }

        private int InsertCounter(string _server_id, string _counter_id, string _instance_id, string _instance_name)
        {
            int rowsInserted = 0;

            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                using (SqlCommand _command = new SqlCommand())
                {
                    _connection.Open();
                    _command.Connection = _connection;
                    _command.CommandText = @"INSERT INTO montr_monitor_counters (machine_id, counter_id, instance_id, instance_name, is_active,  is_deleted, insert_dt)
                                             VALUES (@server_id, @counter_id, @instance_id, @instance_name, @is_active,  @is_deleted, @insert_dt)";
                    _command.Parameters.Add("@server_id", SqlDbType.VarChar).Value = _server_id;
                    _command.Parameters.Add("@counter_id", SqlDbType.VarChar).Value = _counter_id;
                    _command.Parameters.Add("@instance_id", SqlDbType.VarChar).Value = _instance_id;
                    _command.Parameters.Add("@instance_name", SqlDbType.VarChar).Value = _instance_name;
                    _command.Parameters.Add("@is_active", SqlDbType.Bit).Value = true;
                    _command.Parameters.Add("@is_deleted", SqlDbType.Bit).Value = false;
                    _command.Parameters.Add("@insert_dt", SqlDbType.DateTime).Value = DateTime.Now;

                    rowsInserted = _command.ExecuteNonQuery();
                    //if (rowsInserted > 0)
                    //{
                    //}


                    _connection.Close();
                }
            }

            return rowsInserted;

        }

        private int InsertGroupCounter(string _server_id, int _group_id, string _counter_id, string _instance_id)
        {
            int rowsInserted = 0;

            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                using (SqlCommand _command = new SqlCommand())
                {
                    _connection.Open();
                    _command.Connection = _connection;
                    _command.CommandText = @"INSERT INTO montr_monitor_groups_counters (machine_id, group_id, counter_id, instance_id)
                                             VALUES (@server_id, @group_id, @counter_id, @instance_id)";
                    _command.Parameters.Add("@server_id", SqlDbType.VarChar).Value = _server_id;
                    _command.Parameters.Add("@group_id", SqlDbType.Int).Value = _group_id;
                    _command.Parameters.Add("@counter_id", SqlDbType.VarChar).Value = _counter_id;
                    _command.Parameters.Add("@instance_id", SqlDbType.VarChar).Value = _instance_id;

                    rowsInserted = _command.ExecuteNonQuery();
                    //if (rowsInserted > 0)
                    //{
                    //}


                    _connection.Close();
                }
            }

            return rowsInserted;

        }

        private void gvMonitors_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string _monitor_id = gvMonitors.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSelMonitorID.Text = _monitor_id;
            txtSelCounterID.Text = "";
            txtSelCounterDescription.Text = "";
            txtSelCategoryName.Text = "";
            txtSelCounterInstanceTotal.Text = "";
            txtSelCounterInstancePrefix.Text = "";
            txtSelCounterInstanceBlank.Text = "";
            txtSelInstanceID.Text = "";
            txtSelInstanceName.Text = "";
            gvCounters.DataSource = null;
            gvInstances.Rows.Clear();
            load_instances("XXXX");
            load_counters(_monitor_id);
        }

        private void gvCounters_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string _counter_id = gvCounters.Rows[e.RowIndex].Cells[0].Value.ToString();
            string _counter_description = gvCounters.Rows[e.RowIndex].Cells[1].Value.ToString();
            string _category_name = gvCounters.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSelCounterID.Text = _counter_id;
            txtSelCounterDescription.Text = _counter_description;
            txtSelCategoryName.Text = _category_name;
            txtSelCounterInstanceTotal.Text = gvCounters.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSelCounterInstancePrefix.Text = gvCounters.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSelCounterInstanceBlank.Text = gvCounters.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtSelInstanceID.Text = "";
            txtSelInstanceName.Text = "";
            gvInstances.Rows.Clear();
            load_instances(_category_name);
        }

        private void gvInstances_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string _instance_id = gvInstances.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSelInstanceID.Text = _instance_id;
            txtSelInstanceName.Text = gvInstances.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        public string getText()
        {
            return $"{txtSelCounterID.Text};{txtSelCounterDescription.Text};{txtSelInstanceID.Text};{txtSelInstanceName.Text};{_ServerName}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
