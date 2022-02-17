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
	public partial class frmMachineDetails : Form
    {
		private SmartMonitoringEntities1 db = new SmartMonitoringEntities1();
		private string _Action;
        private string _RecordID;
		private string _machine_id;

		public frmMachineDetails()
        {
            InitializeComponent();
            btnSave.DialogResult = DialogResult.OK;
        }

		public frmMachineDetails(Boolean duplicate, string machine_id, string machine_name)
		{
			InitializeComponent();
			_machine_id = machine_id;
			if (duplicate == true)
			{
				btnSave.Text = "Duplicate";
				this.Text = "Duplicate from " + machine_name;
				var row = db.montr_machines_list.Where(a => a.machine_id == machine_id).FirstOrDefault();
				txtName.Text = row.machine_name;
				txtDescription.Text = row.machine_description;
				txtHostName.Text = row.host_name;
				txtIPAddress.Text = row.ip_address;
				txtOperatingSystem.Text = row.os_name;
				txtDomain.Text = row.conn_domain_name;
				txtUsername.Text = row.conn_user_name;
				txtPassword.Text = row.conn_user_password;
			}
			btnSave.DialogResult = DialogResult.OK;
		}

		public frmMachineDetails(string Action, string RecordID)
        {
            InitializeComponent();
            btnSave.DialogResult = DialogResult.OK;
            btnUpdate.DialogResult = DialogResult.OK;
            btnDelete.DialogResult = DialogResult.OK;
            _Action = Action;
            _RecordID = RecordID;
            if (Action == "add")
            {
                btnSave.Visible = true;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
				//txtName.Focus();
				clearFields();
            }
            else if (Action == "edit")
            {
                btnSave.Visible = false;
                btnUpdate.Visible = true;
                btnDelete.Visible = false;

				var row = db.montr_machines_list.Where(a => a.machine_id == RecordID).FirstOrDefault();
				txtName.Text = row.machine_name;
				txtDescription.Text = row.machine_description;
				txtHostName.Text = row.host_name;
				txtIPAddress.Text = row.ip_address;
				txtOperatingSystem.Text = row.os_name;
				txtDomain.Text = row.conn_domain_name;
				txtUsername.Text = row.conn_user_name;
				txtPassword.Text = row.conn_user_password;
            }
            else if (Action == "delete")
            {
                btnSave.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public string getValue()
        {
            return $"{txtMachineID.Text};{txtName.Text}";
        }

        private void clearFields()
        {
            txtMachineID.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            txtHostName.Text = "";
            txtIPAddress.Text = "";
            txtOperatingSystem.Text = "";
            chkIsLocalhost.Checked = false;
            txtDomain.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            chkIsActive.Checked = true;
			
        }

        private void loadMachineDetails(string _machine_id)
        {
            DataTable _table = new DataTable();
            string _sql = $@"select machine_id, machine_name, machine_description, host_name, ip_address, os_name, 
            is_current_machine, conn_domain_name, conn_user_name, conn_user_password, is_active, is_deleted from montr_machines_list where machine_id = '{_machine_id}' and is_deleted = 0";
            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                _connection.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(_sql, _connection))
                {
                    da.Fill(_table);
                }

                _connection.Close();
            }

            if (_table.Rows.Count > 0)
            {
                txtMachineID.Text = _table.Rows[0]["XXXXX"].ToString();
                txtName.Text = "";
                txtDescription.Text = "";
                txtHostName.Text = "";
                txtIPAddress.Text = "";
                txtOperatingSystem.Text = "";
                chkIsLocalhost.Checked = false;
                txtDomain.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                chkIsActive.Checked = true;

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
			var check = db.montr_machines_list.Where(b => b.is_deleted == false && b.machine_name == txtName.Text || b.host_name == txtHostName.Text || b.ip_address == txtIPAddress.Text).FirstOrDefault();
			
			if (txtName.Text == "")
			{
				MessageBox.Show("Please write machine name.", "Notification");
				txtName.Focus();
				this.DialogResult = DialogResult.None;
			}
			else if (txtHostName.Text == "")
			{
				MessageBox.Show("Please write host name.", "Notification");
				txtHostName.Focus();
				this.DialogResult = DialogResult.None;
			}
			else if (txtIPAddress.Text == "")
			{
				MessageBox.Show("Please write the IP address.", "Notification");
				txtIPAddress.Focus();
				this.DialogResult = DialogResult.None;
			}
			else if (!chkIsLocalhost.Checked && txtDomain.Text == "")
			{
				MessageBox.Show("Please write the Domain.", "Notification");
				txtDomain.Focus();
				this.DialogResult = DialogResult.None;
			}
			else if (!chkIsLocalhost.Checked && txtUsername.Text == "")
			{
				MessageBox.Show("Please write the Username.", "Notification");
				txtUsername.Focus();
				this.DialogResult = DialogResult.None;
			}
			else if (!chkIsLocalhost.Checked && txtPassword.Text == "")
			{
				MessageBox.Show("Please write the Password.", "Notification");
				txtPassword.Focus();
				this.DialogResult = DialogResult.None;
			}
			else if (check != null && check.machine_name == txtName.Text)
			{
				MessageBox.Show("This machine name already Exists, Please write another one.", "Notification");
				txtName.Focus();
				this.DialogResult = DialogResult.None;
			}
			else if (check != null && check.host_name == txtHostName.Text)
			{
				MessageBox.Show("This Host name already Exists, Please write another one.", "Notification");
				txtHostName.Focus();
				this.DialogResult = DialogResult.None;
			}
			else if (check != null && check.ip_address == txtIPAddress.Text)
			{
				MessageBox.Show("This IP Address already Exists, Please write another one.", "Notification");
				txtIPAddress.Focus();
				this.DialogResult = DialogResult.None;
			}
			else
			{
				// get new server ID
				string _sql1 = $"select serialno_value from set_serialno where identifier_id = 'montr_machines_list'";
				int _server_id = Convert.ToInt32(DAL.clsDBFunctions.getDBValue(_sql1)) + 1;
				txtMachineID.Text = $"MCHN-{_server_id.ToString("000")}";

				// insert machine to montr_machines_list
				int _machines_inserted = 0;
				_machines_inserted = InsertMachine(txtMachineID.Text, txtName.Text, txtDescription.Text, txtHostName.Text, txtIPAddress.Text, txtOperatingSystem.Text, chkIsLocalhost.Checked, txtDomain.Text, txtUsername.Text, txtPassword.Text, chkIsActive.Checked, 0, DateTime.Now);

				// insert group to montr_monitor_groups
				insertGroups(txtMachineID.Text);

				// update serialno
				string _sql2 = $"update set_serialno set serialno_value = {_server_id} where identifier_id = 'montr_machines_list'";
				int _serial_updated = DAL.clsDBFunctions.UpdateDBRecord(_sql2);

				if (btnSave.Text == "Duplicate")
				{
					DataTable _table = new DataTable();
					string _sql = $@"select counter_id, instance_id, instance_name, display_order from montr_monitor_counters where machine_id = '{_machine_id}' and is_deleted = 0";
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
						using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
						{
							using (SqlCommand _command = new SqlCommand())
							{
								_connection.Open();
								_command.Connection = _connection;
								_command.CommandText = @"INSERT INTO montr_monitor_counters (machine_id, counter_id, instance_id, instance_name, display_order, is_active,  is_deleted, insert_dt)
                                             VALUES (@machine_id, @counter_id, @instance_id, @instance_name, @display_order, @is_active,  @is_deleted, @insert_dt)";
								_command.Parameters.AddWithValue("@machine_id", txtMachineID.Text);
								_command.Parameters.AddWithValue("@counter_id", _table.Rows[i]["counter_id"]);
								_command.Parameters.AddWithValue("@instance_id", _table.Rows[i]["instance_id"]);
								_command.Parameters.AddWithValue("@instance_name", _table.Rows[i]["instance_name"]);
								_command.Parameters.AddWithValue("@display_order", _table.Rows[i]["display_order"]);
								_command.Parameters.Add("@is_active", SqlDbType.Bit).Value = true;
								_command.Parameters.Add("@is_deleted", SqlDbType.Bit).Value = false;
								_command.Parameters.Add("@insert_dt", SqlDbType.DateTime).Value = DateTime.Now;

								_command.ExecuteNonQuery();


								_connection.Close();
							}
						}

						string x = _table.Rows[i]["counter_id"].ToString();
						string y = _table.Rows[i]["instance_id"].ToString();

						var oldGroupId = db.montr_monitor_groups_counters.Where(s => s.counter_id == x && s.instance_id == y).FirstOrDefault();
						var oldGroupName = db.montr_monitor_groups.Where(n => n.group_id == oldGroupId.group_id).FirstOrDefault();
						var newGroupId = db.montr_monitor_groups.Where(k => k.group_name == oldGroupName.group_name && k.machine_id == txtMachineID.Text).FirstOrDefault();

						using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
						{
							using (SqlCommand _command = new SqlCommand())
							{
								_connection.Open();
								_command.Connection = _connection;
								_command.CommandText = @"INSERT INTO montr_monitor_groups_counters (machine_id, group_id, counter_id, instance_id)
                                             VALUES (@server_id, @group_id, @counter_id, @instance_id)";
								_command.Parameters.AddWithValue("@server_id", txtMachineID.Text);
								_command.Parameters.AddWithValue("@group_id", newGroupId.group_id);
								_command.Parameters.AddWithValue("@counter_id", _table.Rows[i]["counter_id"]);
								_command.Parameters.AddWithValue("@instance_id", _table.Rows[i]["instance_id"]);

								_command.ExecuteNonQuery();

								_connection.Close();
							}
						}

					}
				}
			}

		}

        private void chkIsLocalhost_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsLocalhost.Checked)
            {
                txtDomain.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtDomain.Enabled = false;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtDomain.Enabled = true;
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }


        private int InsertMachine(string machine_id, string machine_name, string machine_description, string host_name, string ip_address, string os_name, 
            bool is_current_machine, string conn_domain_name, string conn_user_name, string conn_user_password, bool is_active, 
            int insert_user_id, DateTime insert_dt)
        {
            int rowsInserted = 0;

            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                using (SqlCommand _command = new SqlCommand())
                {
                    _connection.Open();
                    _command.Connection = _connection;
                    _command.CommandText = @"INSERT INTO montr_machines_list (machine_id, machine_name, machine_description, host_name, ip_address, os_name, 
            is_current_machine, conn_domain_name, conn_user_name, conn_user_password, is_active, is_deleted,
            insert_user_id, insert_dt) VALUES (@machine_id, @machine_name, @machine_description, @host_name, @ip_address, @os_name, 
            @is_current_machine, @conn_domain_name, @conn_user_name, @conn_user_password, @is_active, @is_deleted,
            @insert_user_id, @insert_dt)";
                    _command.Parameters.Add("@machine_id", SqlDbType.VarChar).Value = machine_id;
                    _command.Parameters.Add("@machine_name", SqlDbType.VarChar).Value = machine_name;
                    _command.Parameters.Add("@machine_description", SqlDbType.VarChar).Value = machine_description;
                    _command.Parameters.Add("@host_name", SqlDbType.VarChar).Value = host_name;
                    _command.Parameters.Add("@ip_address", SqlDbType.VarChar).Value = ip_address;
                    _command.Parameters.Add("@os_name", SqlDbType.VarChar).Value = os_name;
                    _command.Parameters.Add("@is_current_machine", SqlDbType.VarChar).Value = is_current_machine;
                    _command.Parameters.Add("@conn_domain_name", SqlDbType.VarChar).Value = conn_domain_name;
                    _command.Parameters.Add("@conn_user_name", SqlDbType.VarChar).Value = conn_user_name;
                    _command.Parameters.Add("@conn_user_password", SqlDbType.VarChar).Value = conn_user_password;
                    _command.Parameters.Add("@is_active", SqlDbType.Bit).Value = is_active;
                    _command.Parameters.Add("@is_deleted", SqlDbType.Bit).Value = false;
                    _command.Parameters.Add("@insert_user_id", SqlDbType.Int).Value = insert_user_id;
                    _command.Parameters.Add("@insert_dt", SqlDbType.DateTime).Value = insert_dt;

                    rowsInserted = _command.ExecuteNonQuery();

                    _connection.Close();
                }
            }

            return rowsInserted;

        }

		private void insertGroups(string machine_id)
		{
			DataTable _table = new DataTable();
			string _sql = $@"select group_name, group_image_id, display_order from montr_monitor_groups where machine_id = 'SERV-01'";
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
				using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
				{
					using (SqlCommand _command = new SqlCommand())
					{
						_connection.Open();
						_command.Connection = _connection;

						_command.CommandText = @"INSERT INTO montr_monitor_groups (group_name, machine_id, group_image_id, display_order, is_active, is_deleted) 
							VALUES (@group_name, @machine_id, @group_image_id, @display_order, 1, 0)";
						_command.Parameters.AddWithValue("@group_name", _table.Rows[i]["group_name"]);
						_command.Parameters.AddWithValue("@machine_id", machine_id);
						_command.Parameters.AddWithValue("@group_image_id", _table.Rows[i]["group_image_id"]);
						_command.Parameters.AddWithValue("@display_order", _table.Rows[i]["display_order"]);

						_command.ExecuteNonQuery();


						_connection.Close();
					}
				}
			}
				
		}

		private void frmMachineDetails_Load(object sender, EventArgs e)
		{

		}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
			var check = db.montr_machines_list.Where(b => b.is_deleted == false && b.machine_name == txtName.Text || b.host_name == txtHostName.Text || b.ip_address == txtIPAddress.Text).FirstOrDefault();
			
			if (txtName.Text == "")
			{
				MessageBox.Show("Please write machine name.", "Notification");
				txtName.Focus();
				this.DialogResult = DialogResult.None;
			}
			else if (txtHostName.Text == "")
			{
				MessageBox.Show("Please write host name.", "Notification");
				txtHostName.Focus();
				this.DialogResult = DialogResult.None;
			}
			else if (txtIPAddress.Text == "")
			{
				MessageBox.Show("Please write the IP address.", "Notification");
				txtIPAddress.Focus();
				this.DialogResult = DialogResult.None;
			}
			else if (!chkIsLocalhost.Checked && txtDomain.Text == "")
			{
				MessageBox.Show("Please write the Domain.", "Notification");
				txtDomain.Focus();
				this.DialogResult = DialogResult.None;
			}
			else if (!chkIsLocalhost.Checked && txtUsername.Text == "")
			{
				MessageBox.Show("Please write the Username.", "Notification");
				txtUsername.Focus();
				this.DialogResult = DialogResult.None;
			}
			else if (!chkIsLocalhost.Checked && txtPassword.Text == "")
			{
				MessageBox.Show("Please write the Password.", "Notification");
				txtPassword.Focus();
				this.DialogResult = DialogResult.None;
			}
			else if (check != null && check.machine_name == txtName.Text)
			{
				MessageBox.Show("This machine name already Exists, Please write another one.", "Notification");
				txtName.Focus();
				this.DialogResult = DialogResult.None;
			}
			else if (check != null && check.host_name == txtHostName.Text)
			{
				MessageBox.Show("This Host name already Exists, Please write another one.", "Notification");
				txtHostName.Focus();
				this.DialogResult = DialogResult.None;
			}
			else if (check != null && check.ip_address == txtIPAddress.Text)
			{
				MessageBox.Show("This IP Address already Exists, Please write another one.", "Notification");
				txtIPAddress.Focus();
				this.DialogResult = DialogResult.None;
			}
			else
			{
				var mach = db.montr_machines_list.Where(b => b.machine_id == _RecordID).FirstOrDefault();
				if (mach != null)
				{
					mach.machine_name = txtName.Text;
					mach.machine_description = txtDescription.Text;
					mach.host_name = txtHostName.Text;
					mach.ip_address = txtIPAddress.Text;
					mach.os_name = txtOperatingSystem.Text;
					mach.conn_domain_name = txtDomain.Text;
					mach.conn_user_name = txtUsername.Text;
					mach.conn_user_password = txtPassword.Text;

					db.Entry(mach).State = EntityState.Modified;
					db.SaveChanges();
				}
			}


		}
    }
}
