using SmartMonitoring.Repository;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SmartMonitoring
{
    public partial class NotificationRules : Form
    {
        private SmartMonitoringEntities1 db = new SmartMonitoringEntities1();
        private RulesRepository rulesRepository = new RulesRepository();
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
                    string condition = $"{dialogForm.RuleField} {dialogForm.RuleMathSymbol} {dialogForm.RuleValue}";
                    gvRules.Rows.Add(condition, dialogForm.DisplayLevel, dialogForm.ActionType, dialogForm.RuleField, 
                        dialogForm.RuleMathSymbol, dialogForm.RuleValue, dialogForm.RuleOccurance, dialogForm.OccuranceInterval, "", 
                        dialogForm.DisplayLevel, dialogForm.ActionType);
                    //loadRules();                  
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
            if (gvRules.Rows.Count > 0)
                gvRules.Rows.Remove(gvRules.SelectedRows[0]);
            //gvRules.Rows[0].Selected = true;
//            if (gvRules.SelectedRows.Count > 0)
//            {
//                DialogResult dr = MessageBox.Show("Are you Sure you want to Delete this Rule?", "Deleting Rule", MessageBoxButtons.OKCancel);
//                if (dr == DialogResult.OK)
//                {
//                    using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
//                    {
//                        using (SqlCommand _command = new SqlCommand())
//                        {
//                            _connection.Open();
//                            _command.Connection = _connection;
//                            _command.CommandText = @"DELETE FROM montr_monitor_rules WHERE machine_id = @machine_id and counter_id = @counter_id and 
//instance_id = @instance_id and rule_field = @rule_field and 
//rule_math_symbol = @rule_math_symbol and rule_value = @rule_value and 
//rule_ocuurance_type = @rule_ocuurance_type and ocuurance_interval = @ocuurance_interval and 
//display_level = @display_level and action_id = @action_id";
//                            _command.Parameters.AddWithValue("@machine_id", _server_id);
//                            _command.Parameters.AddWithValue("@counter_id", _counter_id);
//                            _command.Parameters.AddWithValue("@instance_id", _instance_id);
//                            _command.Parameters.AddWithValue("@rule_field", txtRField.Text);
//                            _command.Parameters.AddWithValue("@rule_math_symbol", txtRMathSymbol.Text);
//                            _command.Parameters.AddWithValue("@rule_value", float.Parse(txtRValue.Text));
//                            _command.Parameters.AddWithValue("@rule_ocuurance_type", Convert.ToInt32(txtROccureType.Text));
//                            _command.Parameters.AddWithValue("@ocuurance_interval", Convert.ToInt32(txtROccureInterval.Text));
//                            _command.Parameters.AddWithValue("@display_level", txtDisplayLevel.Text);
//                            _command.Parameters.AddWithValue("@action_id", Convert.ToInt32(txtActionId.Text));
//                            _command.ExecuteNonQuery();

//                            _connection.Close();
//                        }
//                    }
//                    loadRules();
//                }
//            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvRules.SelectedRows.Count > 0)
            {
                string ruleField = gvRules.SelectedRows[0].Cells[3].Value.ToString();
                string ruleMathSymbol = gvRules.SelectedRows[0].Cells[4].Value.ToString();
                string occuranceType = gvRules.SelectedRows[0].Cells[6].Value.ToString();
                string displayLevel = gvRules.SelectedRows[0].Cells[9].Value.ToString();
                string actionId = gvRules.SelectedRows[0].Cells[10].Value.ToString();
                string ruleValue = gvRules.SelectedRows[0].Cells[5].Value.ToString();
                string occuranceInterval = gvRules.SelectedRows[0].Cells[7].Value.ToString();

                using (AddAction dialogForm = new AddAction(_server_id, _counter_id, _instance_id, ruleField, ruleMathSymbol, occuranceType, displayLevel, actionId, ruleValue, occuranceInterval))
                {
                    DialogResult dr = dialogForm.ShowDialog(this);
                    if (dr == DialogResult.OK)
                    {
                        gvRules.SelectedRows[0].Cells[0].Value = $"{dialogForm.RuleField} {dialogForm.RuleMathSymbol} {dialogForm.RuleValue}";
                        gvRules.SelectedRows[0].Cells[1].Value = dialogForm.DisplayLevel;
                        gvRules.SelectedRows[0].Cells[2].Value = dialogForm.ActionType;
                        gvRules.SelectedRows[0].Cells[3].Value = dialogForm.RuleField;
                        gvRules.SelectedRows[0].Cells[4].Value = dialogForm.RuleMathSymbol;
                        gvRules.SelectedRows[0].Cells[5].Value = dialogForm.RuleValue;
                        gvRules.SelectedRows[0].Cells[6].Value = dialogForm.RuleOccurance;
                        gvRules.SelectedRows[0].Cells[7].Value = dialogForm.OccuranceInterval;
                        gvRules.SelectedRows[0].Cells[8].Value = "";
                        gvRules.SelectedRows[0].Cells[9].Value = dialogForm.DisplayLevel;
                        gvRules.SelectedRows[0].Cells[10].Value = dialogForm.ActionType;

                        txtRField.Text = gvRules.SelectedRows[0].Cells[3].Value.ToString();
                        txtRMathSymbol.Text = gvRules.SelectedRows[0].Cells[4].Value.ToString();
                        txtRValue.Text = gvRules.SelectedRows[0].Cells[5].Value.ToString();
                        txtROccureType.Text = gvRules.SelectedRows[0].Cells[6].Value.ToString();
                        txtROccureInterval.Text = gvRules.SelectedRows[0].Cells[7].Value.ToString();
                        txtDisplayLevel.Text = gvRules.SelectedRows[0].Cells[9].Value.ToString();
                        txtActionId.Text = gvRules.SelectedRows[0].Cells[10].Value.ToString();
                        //gvRules.SelectedRows[0].Cells[11].Value = (db.montr_monitor_rules.Select(r => r.rule_id).Max() + 1).ToString();

                        //int index = gvRules.SelectedRows[0].Index;
                        //loadRules();
                        //gvRules.ClearSelection();
                        //gvRules.Rows[index].Selected = true;
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
            List<montr_monitor_rules> monitorRules = new List<montr_monitor_rules>();
            string ruleField;
            string ruleMathSymbol;
            byte ruleOccuranceType;
            string displayLevel;
            int actionId;


            foreach (DataGridViewRow row in gvRules.Rows)
            {
                #region 
                if (row.Cells[3].Value.ToString() == "If Current Value")
                    ruleField = "current";
                else if (row.Cells[3].Value.ToString() == "If Average Value")
                    ruleField = "average";
                else if (row.Cells[3].Value.ToString() == "If Maximum Value")
                    ruleField = "maximum";
                else
                    ruleField = "minimum";

                if (row.Cells[4].Value.ToString() == "More Than")
                    ruleMathSymbol = "more_than";
                else if (row.Cells[4].Value.ToString() == "Less Than")
                    ruleMathSymbol = "less_than";
                else if(row.Cells[4].Value.ToString() == "Equals")
                    ruleMathSymbol = "equals";
                else
                    ruleMathSymbol = "not_equal";

                if (row.Cells[6].Value.ToString() == "For n Occurance")
                    ruleOccuranceType = 1;
                else
                    ruleOccuranceType = 2;

                if (row.Cells[9].Value.ToString() == "Show Error")
                    displayLevel = "error";
                else if (row.Cells[9].Value.ToString() == "Show Warning")
                    displayLevel = "warning";
                else
                    displayLevel = "message";

                if (row.Cells[10].Value.ToString() == "No Action")
                    actionId = 0;
                else if (row.Cells[10].Value.ToString() == "Play Notification Sound")
                    actionId = 1;
                else if (row.Cells[10].Value.ToString() == "Send HTML E-mail Notification")
                    actionId = 2;
                else
                    actionId = 3;
                #endregion

                float t = float.Parse(row.Cells[5].Value.ToString());
                int z = int.Parse(row.Cells[7].Value.ToString());
                int x;
                if (row.Cells[11].Value == null)
                {
                    if (db.montr_monitor_rules.Count() == 0)
                        x = 0;
                    else
                        x = db.montr_monitor_rules.Select(r => r.rule_id).Max() + 1;
                }                       
                else
                    x = int.Parse(row.Cells[11].Value.ToString());
                monitorRules.Add(new montr_monitor_rules
                {
                    rule_id = x,
                    machine_id = _server_id,
                    counter_id = _counter_id,
                    instance_id = _instance_id,
                    rule_field = ruleField,
                    rule_math_symbol = ruleMathSymbol,
                    rule_value = t,
                    rule_ocuurance_type = ruleOccuranceType,
                    ocuurance_interval = z,
                    display_level = displayLevel,
                    action_id = actionId
                });
            }

            var currentRules = db.montr_monitor_rules.Where(r => r.machine_id == _server_id && r.counter_id == _counter_id && r.instance_id == _instance_id);
            int[] ids = monitorRules.Select(r => r.rule_id).ToArray();

            rulesRepository.DeleteRange(currentRules.Where(i => !ids.Contains(i.rule_id)).Select(i => i.rule_id));
            rulesRepository.EditRange(monitorRules.Where(i => currentRules.Select(x => x.rule_id).ToList().Contains(i.rule_id)));
            rulesRepository.AddRange(monitorRules.Where(i => !currentRules.Select(x => x.rule_id).ToList().Contains(i.rule_id)));
            rulesRepository.Commit();

       //     using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
       //     {
       //         using (SqlCommand _command = new SqlCommand())
       //         {
       //             _connection.Open();
       //             _command.Connection = _connection;
       //             _command.CommandText = @"DELETE FROM montr_monitor_rules WHERE machine_id = @machine_id and counter_id = @counter_id and instance_id = @instance_id";
       //             _command.Parameters.AddWithValue("@machine_id", _server_id);
       //             _command.Parameters.AddWithValue("@counter_id", _counter_id);
       //             _command.Parameters.AddWithValue("@instance_id", _instance_id);
       //             _command.ExecuteNonQuery();

       //             _connection.Close();
       //         }
       //     }

       //     foreach (var rule in monitorRules)
       //     {
       //         using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
       //         {
       //             using (SqlCommand _command = new SqlCommand())
       //             {
       //                 _connection.Open();
       //                 _command.Connection = _connection;

       //                 _command.CommandText = @"INSERT INTO montr_monitor_rules (machine_id, counter_id, instance_id, rule_field, rule_math_symbol, rule_value, rule_ocuurance_type, ocuurance_interval, display_level, action_id) 
							//VALUES (@machine_id, @counter_id, @instance_id, @rule_field, @rule_math_symbol, @rule_value, @rule_ocuurance_type, @ocuurance_interval, @display_level, @action_id)";
       //                 _command.Parameters.AddWithValue("@machine_id", _server_id);
       //                 _command.Parameters.AddWithValue("@counter_id", _counter_id);
       //                 _command.Parameters.AddWithValue("@instance_id", _instance_id);
       //                 _command.Parameters.AddWithValue("@rule_field", rule.rule_field);
       //                 _command.Parameters.AddWithValue("@rule_math_symbol", rule.rule_math_symbol);
       //                 _command.Parameters.AddWithValue("@rule_value", rule.rule_value);
       //                 _command.Parameters.AddWithValue("@rule_ocuurance_type", rule.rule_ocuurance_type);
       //                 _command.Parameters.AddWithValue("@ocuurance_interval", rule.ocuurance_interval);
       //                 _command.Parameters.AddWithValue("@display_level", rule.display_level);
       //                 _command.Parameters.AddWithValue("@action_id", rule.action_id);

       //                 _command.ExecuteNonQuery();


       //                 _connection.Close();
       //             }
       //         }
       //     }
            //foreach (var currentRule in currentRules)
            //{
            //    db.montr_monitor_rules.Remove(currentRule);
            //    //db.montr_monitor_rules.Remove(currentRules.Where())
            //    //foreach (montr_monitor_rules item in currentRules)
            //    //{
                    
            //    //    //if (item.rule_field == rule.rule_field && item.rule_math_symbol == rule.rule_math_symbol && item.rule_value == rule.rule_value
            //    //    //    && item.rule_ocuurance_type == rule.rule_ocuurance_type && item.occurance_interval == rule.occurance_interval && item.display_level == rule.display_level
            //    //    //    && item.action_id == rule.action_id)
            //    //    //{

            //    //    //}
            //    //}
            //}
            //db.SaveChanges();
            //foreach (var newRule in monitorRules)
            //{
            //    db.montr_monitor_rules.Add(newRule);
            //}
            ////db.SaveChanges();
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
            string _sql = $"select rule_id, rule_field, rule_math_symbol, rule_value, rule_ocuurance_type, ocuurance_interval, display_level, action_id from montr_monitor_rules where machine_id = '{_server_id}' and counter_id = '{_counter_id}' and instance_id = '{_instance_id}'";
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
                        "Show " + _table.Rows[i]["display_level"].ToString(), "", _table.Rows[i]["rule_field"].ToString(), _table.Rows[i]["rule_math_symbol"].ToString(), _table.Rows[i]["rule_value"].ToString(), _table.Rows[i]["rule_ocuurance_type"].ToString(), _table.Rows[i]["ocuurance_interval"].ToString(), "", _table.Rows[i]["display_level"], _table.Rows[i]["action_id"], _table.Rows[i]["rule_id"]);
                    if (_table.Rows[i]["rule_field"].ToString() == "current")
                    {
                        gvRules.Rows[i].Cells[3].Value = "If Current Value";
                    }
                    else if (_table.Rows[i]["rule_field"].ToString() == "average")
                    {
                        gvRules.Rows[i].Cells[3].Value = "If Average Value";
                    }                        
                    else if (_table.Rows[i]["rule_field"].ToString() == "maximum")
                    {
                        gvRules.Rows[i].Cells[3].Value = "If Maximum Value";
                    }                        
                    else
                    {
                        gvRules.Rows[i].Cells[3].Value = "If Minimum Value";
                    }                       

                    if (_table.Rows[i]["rule_math_symbol"].ToString() == "more_than")
                        gvRules.Rows[i].Cells[4].Value = "More Than";
                    else if (_table.Rows[i]["rule_math_symbol"].ToString() == "less_than")
                        gvRules.Rows[i].Cells[4].Value = "Less Than";
                    else if (_table.Rows[i]["rule_math_symbol"].ToString() == "equals")
                        gvRules.Rows[i].Cells[4].Value = "Equals";
                    else
                        gvRules.Rows[i].Cells[4].Value = "Not Equal";

                    gvRules.Rows[i].Cells[0].Value = gvRules.Rows[i].Cells[3].Value + " " + gvRules.Rows[i].Cells[4].Value + " " + _table.Rows[i]["rule_value"].ToString();

                    if (_table.Rows[i]["rule_ocuurance_type"].ToString() == "1")
                        gvRules.Rows[i].Cells[6].Value = "For n Occurance";
                    else
                        gvRules.Rows[i].Cells[6].Value = "For Specific Period of Time(in Second)";

                    if ((int)_table.Rows[i]["action_id"] == 0)
                    {
                        gvRules.Rows[i].Cells[2].Value = "No Action";
                        gvRules.Rows[i].Cells[10].Value = "No Action";
                    }
                    else if ((int)_table.Rows[i]["action_id"] == 1)
                    {
                        gvRules.Rows[i].Cells[2].Value = "Play Notification Sound";
                        gvRules.Rows[i].Cells[10].Value = "Play Notification Sound";
                    }
                    else if ((int)_table.Rows[i]["action_id"] == 2)
                    {
                        gvRules.Rows[i].Cells[2].Value = "Send HTML E-mail Notification";
                        gvRules.Rows[i].Cells[10].Value = "Send HTML E-mail Notification";
                    }
                    else if ((int)_table.Rows[i]["action_id"] == 3)
                    {
                        gvRules.Rows[i].Cells[2].Value = "Send Text E-mail Notification";
                        gvRules.Rows[i].Cells[10].Value = "Send Text E-mail Notification";
                    }

                    if (_table.Rows[i]["display_level"].ToString() == "error")
                        gvRules.Rows[i].Cells[9].Value = "Show Error";
                    else if (_table.Rows[i]["display_level"].ToString() == "warning")
                        gvRules.Rows[i].Cells[9].Value = "Show Warning";
                    else
                        gvRules.Rows[i].Cells[9].Value = "Show Message";
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
