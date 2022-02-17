using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartMonitoring.BackEnd
{
    public partial class frmMain : Form
    {

        private Form _active_form;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            load_servers();

            //frmServerMonitor _form1 = (frmServerMonitor)Application.OpenForms.Cast<Form>().Where(p => p.Name == "frmServerMonitor" && p.Tag.ToString() == "SERV-00").FirstOrDefault();
            //if (_form1 == null)
            //{
            //    frmServerMonitor _frm1 = new frmServerMonitor("SERV-00");
            //    _frm1.Tag = "SERV-00";
            //    //_frm1.MdiParent = this.MdiParent;
            //    _frm1.DataSent += CF_DataSent;
            //    _frm1.Show();
            //    _frm1.Hide();
            //}
            //else
            //{
            //    _form1.DataSent += CF_DataSent;
            //    _form1.Show();
            //    _form1.Focus();
            //}


            //frmServerMonitor _form2 = (frmServerMonitor)Application.OpenForms.Cast<Form>().Where(p => p.Name == "frmServerMonitor" && p.Tag.ToString() == "SERV-01").FirstOrDefault();
            //if (_form2 == null)
            //{
            //    frmServerMonitor _frm2 = new frmServerMonitor("SERV-01");
            //    _frm2.Tag = "SERV-01";
            //    //_frm2.MdiParent = this.MdiParent;
            //    _frm2.DataSent += CF_DataSent;
            //    _frm2.Show();
            //    _frm2.Hide();
            //}
            //else
            //{
            //    _form2.DataSent += CF_DataSent;
            //    _form2.Show();
            //    _form2.Focus();
            //}



        }

        private void load_servers()
        {

            DataTable _table = new DataTable();
            string _sql = $@"SELECT machine_id,machine_name,machine_description,host_name,ip_address,is_active,is_deleted
FROM montr_machines_list
WHERE is_active = 1 AND is_deleted = 0";
            using (SqlConnection _connection = new SqlConnection(DAL.clsDBFunctions.getConnectionString()))
            {
                _connection.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(_sql, _connection))
                {
                    da.Fill(_table);
                }

                _connection.Close();
            }

            int _paneltop = 0;

            for (int i = 0; i < _table.Rows.Count; i++)
            {
                string _server_id = _table.Rows[i]["machine_id"].ToString();

                // create server controls
                Panel _pnlServer = new Panel();
                pnlServersList.Controls.Add(_pnlServer);
                _pnlServer.Tag = _server_id;
                _pnlServer.Location = new Point(0, _paneltop);
                _pnlServer.Size = new Size(140, 55);
                _paneltop += _pnlServer.Height + 5;

                Button _btnOpenServer = new Button();
                _pnlServer.Controls.Add(_btnOpenServer);
                _btnOpenServer.Tag = _server_id;
                _btnOpenServer.Text = _table.Rows[i]["host_name"].ToString();
                _btnOpenServer.Location = new Point(5, 5);
                _btnOpenServer.Size = new Size(130, 30);
                _btnOpenServer.Click += OpenServerForm;

                Label _lblLastRun = new Label();
                _pnlServer.Controls.Add(_lblLastRun);
                _lblLastRun.Tag = _server_id;
                _lblLastRun.Text = "#";
                _lblLastRun.Location = new Point(9, 38);
                _lblLastRun.AutoSize = true;


                // open server job
                frmServerMonitor _form = (frmServerMonitor)Application.OpenForms.Cast<Form>().Where(p => p.Name == "frmServerMonitor" && p.Tag.ToString() == _server_id).FirstOrDefault();
                if (_form == null)
                {
                    frmServerMonitor _frm1 = new frmServerMonitor(_server_id);
                    _frm1.Tag = _server_id;
                    _frm1.DataSentEvent += CF_DataSent;
                    _frm1.Show();
                    _frm1.Hide();
                }
                else
                {
                    _form.DataSentEvent += CF_DataSent;
                    _form.Show();
                    _form.Focus();
                }

            }
        }


        /// <summary>
        /// This void is to receive progress/information from server monitoring form.
        /// It's assigned to a public delegate event in that form.
        /// </summary>
        /// <param name="Msg">The message that is sent from the other form</param>
        /// <param name="ServerID">The identifier ...</param>
        private void CF_DataSent(string Msg, string ServerID)
        {
            Panel _pnlServer = pnlServersList.Controls.OfType<Panel>().Where(p => p.Tag.ToString() == ServerID).FirstOrDefault();
            if (_pnlServer != null)
            {
                Label _label = _pnlServer.Controls.OfType<Label>().Where(p => p.Tag.ToString() == ServerID).FirstOrDefault();
                if (_label != null)
                {
                    setControls("SEND_OUTPUT", Msg, _label);

                    //_label.Text = Msg;
                }
            }
        }

        private delegate void stringDelegate(string Key, string Value, Label _label);
        private void setControls(string Key, string Value, Label _label)
        {
            try
            {
                if (_label != null)
                {
                    if (_label.InvokeRequired)
                    {
                        stringDelegate sd = new stringDelegate(setControls);
                        this.Invoke(sd, new object[] { Key, Value, _label });
                    }
                    else
                    {
                        _label.Text = Value;

                        //if (Key == "CUR_FILE_NAME")
                        //{
                        //    lblResults01.Text = "Downloading File " + _CurFileIndex01.ToString() + "/" + _TotalFilesCount01.ToString() + " " + Value;
                        //}
                        //else if (Key == "LOGIN_FAILED")
                        //{
                        //    lblResults01.Text = "Login Failed.";
                        //}
                        //else if (Key == "SEND_OUTPUT")
                        //{
                        //    txtOutput.Text += Value;
                        //}
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        private void OpenServerForm(object sender, EventArgs e)
        {
            Button _btnSender = (Button)sender;
            Form _child_form = Application.OpenForms.Cast<Form>().Where(p => p.Name == "frmServerMonitor" && p.Tag.ToString() == _btnSender.Tag.ToString()).FirstOrDefault();
            if (_child_form != null)
            {
                OpenChildForm(_child_form, sender);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form _child_form = Application.OpenForms.Cast<Form>().Where(p => p.Name == "frmServerMonitor" && p.Tag.ToString() == "SERV-00").FirstOrDefault();
            if (_child_form != null)
            {
                OpenChildForm(_child_form, sender);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form _child_form = Application.OpenForms.Cast<Form>().Where(p => p.Name == "frmServerMonitor" && p.Tag.ToString() == "SERV-01").FirstOrDefault();
            if (_child_form != null)
            {
                OpenChildForm(_child_form, sender);
            }
        }

        private void OpenChildForm(Form ChildForm, object btnSender)
        {
            this.pnlChildForm.Controls.Clear();

            if (_active_form != null)
            {
                _active_form.Hide();
            }

            _active_form = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            this.pnlChildForm.Controls.Add(ChildForm);
            this.pnlChildForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            lblActiveFormTitle.Text = ChildForm.Text;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.pnlChildForm.Controls.Clear();

        }
    }
}
