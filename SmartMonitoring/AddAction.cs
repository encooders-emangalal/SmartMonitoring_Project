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
    public partial class AddAction : Form
    {
        SmartMonitoringEntities1 db = new SmartMonitoringEntities1();

        public static string _ruleField, _ruleMathSymbol, _occureType, _displayLevel, _notification, _notificationText;
        public static int _occurInterval;
        public static float _ruleValue;
        private string _server_id, _counter_id, _instance_id;

        public string RuleField { get; set; }
        public string RuleMathSymbol { get; set; }
        public float RuleValue { get; set; }
        public string RuleOccurance { get; set; }
        public int OccuranceInterval { get; set; }
        public string DisplayLevel { get; set; }
        public string ActionType { get; set; }

        public AddAction(string server_id, string counter_id, string instance_id)
        {
            
            InitializeComponent();
            btnOk.DialogResult = DialogResult.OK;
            _server_id = server_id;
            _counter_id = counter_id;
            _instance_id = instance_id;
            //cbNotification.Enabled = false;
            //txtNotification.Enabled = false;
            //btnNotification.Enabled = false;

            cbRuleField.SelectedIndex = 0;
            cbNotification.SelectedIndex = 0;
            cbRuleMathSymbol.SelectedIndex = 0;
            cbOccureType.SelectedIndex = 0;
            cbDisplayLevel.SelectedIndex = 0;
        }

        public AddAction(string server_id, string counter_id, string instance_id, string rField, string rMathSymbol, string rOcurreType, string rDisplayLevel, string rNotif, string rValue, string rOccureInterval)
        {

            InitializeComponent();
            btnOk.DialogResult = DialogResult.OK;
            _server_id = server_id;
            _counter_id = counter_id;
            _instance_id = instance_id;
            if (rField == "current")
                _ruleField = "If Current Value";
            else if (rField == "average")
                _ruleField = "If Average Value";
            else if (rField == "maximum")
                _ruleField = "If Maximum Value";
            else
                _ruleField = "If Minimum Value";
            // _ruleField = rField;
            if (rMathSymbol == "more_than")
                _ruleMathSymbol = "More Than";
            else if (rMathSymbol == "less_than")
                _ruleMathSymbol = "Less Than";
            else if (rMathSymbol == "equals")
                _ruleMathSymbol = "Equals";
            else
                _ruleMathSymbol = "Not Equal";
            //_ruleMathSymbol = rMathSymbol;
            _occureType = rOcurreType;
            _displayLevel = rDisplayLevel;
            _notification = rNotif;
            _ruleValue = float.Parse(rValue);
            _occurInterval = Convert.ToInt32(rOccureInterval);
            this.Text = "Edit Action";
            btnOk.Text = "Edit";
            cbRuleField.SelectedItem = _ruleField;
            cbRuleMathSymbol.SelectedItem = _ruleMathSymbol;
            cbOccureType.SelectedIndex = int.Parse(rOcurreType) - 1;
            
            if (rDisplayLevel == "error")
            {
                cbDisplayLevel.SelectedIndex = 0;
            }
            else if (rDisplayLevel == "warning")
            {
                cbDisplayLevel.SelectedIndex = 1;
            }
            else
            {
                cbDisplayLevel.SelectedIndex = 2;
            }
            cbNotification.SelectedIndex = Convert.ToInt32(rNotif);
            if (cbNotification.SelectedIndex == 1)
            {
                cbNotification.Width = this.Width / 2;
                txtNotification.ReadOnly = true;
                btnNotification.Enabled = true;
                txtNotification.Visible = true;
                btnNotification.Visible = true;
                txtNotification.Text = "";
            }
            else
            {
                cbNotification.Width = cbDisplayLevel.Width;
                txtNotification.Visible = false;
                btnNotification.Visible = false;

            }

            nudRuleValue.Value = int.Parse(rValue);
            nudOccuranceInterval.Value = int.Parse(rOccureInterval);
        }

        private void cbExAction_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAction_Load(object sender, EventArgs e)
        {
            

            
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            using (SelectNotificationSound dialogForm = new SelectNotificationSound())
            {
                DialogResult dr = dialogForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    txtNotification.Text = SelectNotificationSound._notifSelected;
                }
                dialogForm.Close();
            }
        }

        private void cbNotification_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNotification.SelectedIndex == 1)
            {
                cbNotification.Width = this.Width / 2;
                txtNotification.ReadOnly = true;
                btnNotification.Enabled = true;
                txtNotification.Visible = true;
                btnNotification.Visible = true;
                txtNotification.Text = "";
            }
            else
            {
                cbNotification.Width = cbDisplayLevel.Width;
                txtNotification.Visible = false;
                btnNotification.Visible = false;
                
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            RuleField = cbRuleField.Text;
            RuleMathSymbol = cbRuleMathSymbol.Text;
            RuleValue = (float)nudRuleValue.Value;
            RuleOccurance = cbOccureType.Text;
            OccuranceInterval = (int)nudOccuranceInterval.Value;
            DisplayLevel = cbDisplayLevel.Text;
            ActionType = cbNotification.Text;

            //int occType;
            //string disLevel;
            //int noti;
            //if (cbOccureType.Text == "For n Occurance")
            //{
            //    occType = 1;
            //}
            //else
            //{
            //    occType = 2;
            //}

            //if (cbDisplayLevel.Text == "Show Error")
            //{
            //    disLevel = "error";
            //}
            //else if (cbDisplayLevel.Text == "Show Warning")
            //{
            //    disLevel = "warning";
            //}
            //else
            //{
            //    disLevel = "message";
            //}

            //if (cbNotification.Text == "No Action")
            //{
            //    noti = 0;
            //}
            //else if (cbNotification.Text == "Play Notification Sound")
            //{
            //    noti = 1;
            //}
            //else if (cbNotification.Text == "Send HTML E-mail Notification")
            //{
            //    noti = 2;
            //}
            //else
            //{
            //    noti = 3;
            //}
            //float z = (float)nudRuleValue.Value;

            //var rule = db.montr_monitor_rules.Where(b => b.machine_id == _server_id && b.counter_id == _counter_id && b.instance_id == _instance_id
            //&& b.rule_field == cbRuleField.Text && b.rule_math_symbol == cbRuleMathSymbol.Text && b.rule_value == z && b.rule_ocuurance_type == occType
            //&& b.ocuurance_interval == nudOccuranceInterval.Value && b.display_level == disLevel && b.action_id == noti).FirstOrDefault();
            //if (btnOk.Text == "Ok")
            //{
            //    // int rule = 0;
                

            //    if (cbNotification.Text == "Play Notification Sound" && txtNotification.Text == "")
            //    {
            //        MessageBox.Show("Please, Select a Notification Sound to Play", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.DialogResult = DialogResult.None;
            //    }                
            //    else if (rule != null)
            //    {
            //        MessageBox.Show("This Rule Already Exists!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.DialogResult = DialogResult.None;
            //    }
            //    else
            //    {
            //        btnOk.DialogResult = DialogResult.OK;

            //        using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            //        {
            //            using (SqlCommand _command = new SqlCommand())
            //            {
            //                _connection.Open();
            //                _command.Connection = _connection;
            //                _command.CommandText = @"INSERT INTO montr_monitor_rules (machine_id, counter_id, instance_id, rule_field, rule_math_symbol, rule_value, rule_ocuurance_type, ocuurance_interval, display_level, action_id)
            //                                 VALUES (@server_id, @counter_id, @instance_id, @rule_field, @rule_math_symbol,  @rule_value, @rule_ocuurance_type, @ocuurance_interval, @display_level, @action_id)";
            //                _command.Parameters.AddWithValue("@server_id", _server_id);
            //                _command.Parameters.AddWithValue("@counter_id", _counter_id);
            //                _command.Parameters.AddWithValue("@instance_id", _instance_id);
            //                _command.Parameters.AddWithValue("@rule_field", cbRuleField.Text);
            //                _command.Parameters.AddWithValue("@rule_math_symbol", cbRuleMathSymbol.Text);
            //                _command.Parameters.AddWithValue("@rule_value", nudRuleValue.Value);
            //                if (cbOccureType.Text == "For n Occurance")
            //                {
            //                    _command.Parameters.AddWithValue("@rule_ocuurance_type", 1);
            //                }
            //                else
            //                {
            //                    _command.Parameters.AddWithValue("@rule_ocuurance_type", 2);
            //                }

            //                _command.Parameters.AddWithValue("@ocuurance_interval", nudOccuranceInterval.Value);

            //                if (cbDisplayLevel.Text == "Show Error")
            //                {
            //                    _command.Parameters.AddWithValue("@display_level", "error");
            //                }
            //                else if (cbDisplayLevel.Text == "Show Warning")
            //                {
            //                    _command.Parameters.AddWithValue("@display_level", "warning");
            //                }
            //                else
            //                {
            //                    _command.Parameters.AddWithValue("@display_level", "message");
            //                }

            //                if (cbNotification.Text == "No Action")
            //                {
            //                    _command.Parameters.AddWithValue("@action_id", 0);
            //                }
            //                else if (cbNotification.Text == "Play Notification Sound")
            //                {
            //                    _command.Parameters.AddWithValue("@action_id", 1);
            //                }
            //                else if (cbNotification.Text == "Send HTML E-mail Notification")
            //                {
            //                    _command.Parameters.AddWithValue("@action_id", 2);
            //                }
            //                else
            //                {
            //                    _command.Parameters.AddWithValue("@action_id", 3);
            //                }

            //                _command.ExecuteNonQuery();

            //                _connection.Close();
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    int x = Convert.ToInt32(_occureType);
            //    int y = Convert.ToInt32(_notification);

            //    if (cbNotification.Text == "Play Notification Sound" && txtNotification.Text == "")
            //    {
            //        MessageBox.Show("Please, Select a Notification Sound to Play", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.DialogResult = DialogResult.None;
            //    }
            //    else if (rule != null)
            //    {
            //        MessageBox.Show("This Rule Already Exists!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.DialogResult = DialogResult.None;
            //    }
            //    else
            //    {
            //        using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            //        {
            //            using (SqlCommand _command = new SqlCommand())
            //            {
            //                _connection.Open();
            //                _command.Connection = _connection;
            //                _command.CommandText = $"UPDATE montr_monitor_rules SET rule_field = @rule_field, rule_math_symbol = @rule_math_symbol, rule_value = @rule_value, rule_ocuurance_type = @rule_ocuurance_type, ocuurance_interval = @ocuurance_interval, display_level = @display_level, action_id = @action_id " +
            //                    $"WHERE machine_id = @machine_id and counter_id = @counter_id and instance_id = @instance_id and rule_field = @ruleField " +
            //                    $"and rule_math_symbol = @ruleMath and rule_value = @ruleVal and rule_ocuurance_type = @occType and ocuurance_interval = @occInt " +
            //                    $"and display_level = @dis and action_id = @act";
            //                _command.Parameters.AddWithValue("@machine_id", _server_id);
            //                _command.Parameters.AddWithValue("@counter_id", _counter_id);
            //                _command.Parameters.AddWithValue("@instance_id", _instance_id);
            //                _command.Parameters.AddWithValue("@ruleField", _ruleField);
            //                _command.Parameters.AddWithValue("@ruleMath", _ruleMathSymbol);
            //                _command.Parameters.AddWithValue("@ruleVal", z);
            //                _command.Parameters.AddWithValue("@occType", x);
            //                _command.Parameters.AddWithValue("@occInt", _occurInterval);
            //                _command.Parameters.AddWithValue("@dis", _displayLevel);
            //                _command.Parameters.AddWithValue("@act", y);
            //                _command.Parameters.AddWithValue("@rule_field", cbRuleField.Text);
            //                _command.Parameters.AddWithValue("@rule_math_symbol", cbRuleMathSymbol.Text);
            //                _command.Parameters.AddWithValue("@rule_value", float.Parse(nudRuleValue.Value.ToString()));
            //                if (cbOccureType.Text == "For n Occurance")
            //                {
            //                    _command.Parameters.AddWithValue("@rule_ocuurance_type", 1);
            //                }
            //                else
            //                {
            //                    _command.Parameters.AddWithValue("@rule_ocuurance_type", 2);
            //                }

            //                _command.Parameters.AddWithValue("@ocuurance_interval", Convert.ToInt32(nudOccuranceInterval.Value.ToString()));
            //                if (cbDisplayLevel.Text == "Show Error")
            //                {
            //                    _command.Parameters.AddWithValue("@display_level", "error");
            //                }
            //                else if (cbDisplayLevel.Text == "Show Warning")
            //                {
            //                    _command.Parameters.AddWithValue("@display_level", "warning");
            //                }
            //                else
            //                {
            //                    _command.Parameters.AddWithValue("@display_level", "message");
            //                }

            //                if (cbNotification.Text == "No Action")
            //                {
            //                    _command.Parameters.AddWithValue("@action_id", 0);
            //                }
            //                else if (cbNotification.Text == "Play Notification Sound")
            //                {
            //                    _command.Parameters.AddWithValue("@action_id", 1);
            //                }
            //                else if (cbNotification.Text == "Send HTML E-mail Notification")
            //                {
            //                    _command.Parameters.AddWithValue("@action_id", 2);
            //                }
            //                else
            //                {
            //                    _command.Parameters.AddWithValue("@action_id", 3);
            //                }

            //                int row = _command.ExecuteNonQuery();

            //                _connection.Close();
            //            }
            //        }
            //    }
                

            //    //var rule = db.montr_monitor_rules.Where(b => b.machine_id == _server_id && b.counter_id == _counter_id && b.instance_id == _instance_id
            //    //&& b.rule_field == _ruleField && b.rule_math_symbol == _ruleMathSymbol && b.rule_value == z && b.rule_ocuurance_type == x
            //    //&& b.ocuurance_interval == _occurInterval && b.display_level == _displayLevel && b.action_id == y).FirstOrDefault();

            //    //if (rule != null)
            //    //{
            //    //    rule.rule_field = cbRuleField.Text;
            //    //    rule.rule_math_symbol = cbRuleMathSymbol.Text;
            //    //    rule.rule_value = float.Parse(nudRuleValue.Value.ToString());
            //    //    if (cbOccureType.Text == "For n Occurance")
            //    //    {
            //    //        rule.rule_ocuurance_type = 0;
            //    //    }
            //    //    else
            //    //    {
            //    //        rule.rule_ocuurance_type = 1;
            //    //    }
                    
            //    //    rule.occurance_interval = Convert.ToInt32(nudOccuranceInterval.Value.ToString());

            //    //    if (cbDisplayLevel.Text == "Show Error")
            //    //    {
            //    //        rule.display_level = "error";
            //    //    }
            //    //    else if (cbDisplayLevel.Text == "Show Warning")
            //    //    {
            //    //        rule.display_level = "warning";
            //    //    }
            //    //    else
            //    //    {
            //    //        rule.display_level = "message";
            //    //    }

            //    //    if (cbNotification.Text == "No Action")
            //    //    {
            //    //        rule.action_id = 0;
            //    //    }
            //    //    else if (cbNotification.Text == "Play Notification Sound")
            //    //    {
            //    //        rule.action_id = 1;
            //    //    }
            //    //    else if (cbNotification.Text == "Send HTML E-mail Notification to")
            //    //    {
            //    //        rule.action_id = 2;
            //    //    }
            //    //    else
            //    //    {
            //    //        rule.action_id = 3;
            //    //    }

                    

            //    //    db.Entry(rule).State = EntityState.Modified;
            //    //    db.SaveChanges();
            //    //}
            //}
                                                             
        }
    }
}
