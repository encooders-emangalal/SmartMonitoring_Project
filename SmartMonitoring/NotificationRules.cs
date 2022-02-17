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
    public partial class NotificationRules : Form
    {
        private SmartMonitoringEntities1 db = new SmartMonitoringEntities1();
        private string _server_id, _counter_id, _instance_id;
        public NotificationRules()
        {
            InitializeComponent();
        }

        public NotificationRules(string counterName, string server_id, string counter_id, string instance_id)
        {
            InitializeComponent();
            btnOk.DialogResult = DialogResult.OK;
            this.Text = counterName + " " + "-" + " Notification Rules";
            _server_id = server_id;
            _counter_id = counter_id;
            _instance_id = instance_id;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddAction dialogForm = new AddAction(_server_id, _counter_id, _instance_id))
            {
                DialogResult dr = dialogForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    loadRules();                  
                }
                dialogForm.Close();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCounter_Load(object sender, EventArgs e)
        {
            loadRules();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvRules.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Are you Sure you want to Delete this Rule?", "Deleting Rule", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
                    {
                        using (SqlCommand _command = new SqlCommand())
                        {
                            _connection.Open();
                            _command.Connection = _connection;
                            _command.CommandText = @"DELETE FROM montr_monitor_rules WHERE machine_id = @machine_id and counter_id = @counter_id and 
instance_id = @instance_id and rule_field = @rule_field and 
rule_math_symbol = @rule_math_symbol and rule_value = @rule_value and 
rule_ocuurance_type = @rule_ocuurance_type and ocuurance_interval = @ocuurance_interval and 
display_level = @display_level and action_id = @action_id";
                            _command.Parameters.AddWithValue("@machine_id", _server_id);
                            _command.Parameters.AddWithValue("@counter_id", _counter_id);
                            _command.Parameters.AddWithValue("@instance_id", _instance_id);
                            _command.Parameters.AddWithValue("@rule_field", txtRField.Text);
                            _command.Parameters.AddWithValue("@rule_math_symbol", txtRMathSymbol.Text);
                            _command.Parameters.AddWithValue("@rule_value", float.Parse(txtRValue.Text));
                            _command.Parameters.AddWithValue("@rule_ocuurance_type", Convert.ToInt32(txtROccureType.Text));
                            _command.Parameters.AddWithValue("@ocuurance_interval", Convert.ToInt32(txtROccureInterval.Text));
                            _command.Parameters.AddWithValue("@display_level", txtDisplayLevel.Text);
                            _command.Parameters.AddWithValue("@action_id", Convert.ToInt32(txtActionId.Text));
                            _command.ExecuteNonQuery();

                            _connection.Close();
                        }
                    }
                    loadRules();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvRules.SelectedRows.Count > 0)
            {
                using (AddAction dialogForm = new AddAction(_server_id, _counter_id, _instance_id, txtRField.Text, txtRMathSymbol.Text, txtROccureType.Text, txtDisplayLevel.Text, txtActionId.Text, txtRValue.Text, txtROccureInterval.Text))
                {
                    DialogResult dr = dialogForm.ShowDialog(this);
                    if (dr == DialogResult.OK)
                    {
                        int index = gvRules.SelectedRows[0].Index;
                        loadRules();
                        gvRules.ClearSelection();
                        gvRules.Rows[index].Selected = true;
                    }
                    dialogForm.Close();
                }
            }
                
        }

        private void gvRules_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void gvRules_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtRField.Text = gvRules.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtRMathSymbol.Text = gvRules.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtRValue.Text = gvRules.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtROccureType.Text = gvRules.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtROccureInterval.Text = gvRules.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtDisplayLevel.Text = gvRules.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtActionId.Text = gvRules.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void loadRules()
        {
            gvRules.Rows.Clear();

            DataTable _table = new DataTable();
            string _sql = $"select rule_field, rule_math_symbol, rule_value, rule_ocuurance_type, ocuurance_interval, display_level, action_id from montr_monitor_rules where machine_id = '{_server_id}' and counter_id = '{_counter_id}' and instance_id = '{_instance_id}'";
            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                _connection.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(_sql, _connection))
                {
                    da.Fill(_table);
                }

                _connection.Close();
            }
            var coun_unit = db.set_counters.Where(b => b.counter_id == _counter_id).FirstOrDefault();
            if (coun_unit != null)
            {
                for (int i = 0; i < _table.Rows.Count; i++)
                {
                    gvRules.Rows.Add(_table.Rows[i]["rule_field"].ToString() + " " + _table.Rows[i]["rule_math_symbol"].ToString() + " " + _table.Rows[i]["rule_value"].ToString() + " " + coun_unit.counter_unit,
                        "Show " + _table.Rows[i]["display_level"].ToString(), "", _table.Rows[i]["rule_field"].ToString(), _table.Rows[i]["rule_math_symbol"].ToString(), _table.Rows[i]["rule_value"].ToString(), _table.Rows[i]["rule_ocuurance_type"].ToString(), _table.Rows[i]["ocuurance_interval"].ToString(), "", _table.Rows[i]["display_level"], _table.Rows[i]["action_id"]);
                    if ((int)_table.Rows[i]["action_id"] == 0)
                    {
                        gvRules.Rows[i].Cells[2].Value = "No Action";
                    }
                    else if ((int)_table.Rows[i]["action_id"] == 1)
                    {
                        gvRules.Rows[i].Cells[2].Value = "Play Notification Sound";
                    }
                    else if ((int)_table.Rows[i]["action_id"] == 2)
                    {
                        gvRules.Rows[i].Cells[2].Value = "Send HTML E-mail Notification";
                    }
                    else if ((int)_table.Rows[i]["action_id"] == 3)
                    {
                        gvRules.Rows[i].Cells[2].Value = "Send Text E-mail Notification";
                    }
                    //if (Convert.ToInt32(_table.Rows[i]["rule_ocuurance_type"]) == 1)
                    //{
                    //    gvRules.Rows[i].Cells[6].Value = "For n Occurance";
                    //}
                    //else
                    //{
                    //    gvRules.Rows[i].Cells[6].Value = "For Specific Period of Time(in Second)";
                    //}
                }
            }
           
        }
    }
}
