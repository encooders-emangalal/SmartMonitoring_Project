using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMonitoring
{
    public partial class SelectNotificationSound : Form
    {
        public static string _notifSelected;
        public SelectNotificationSound()
        {
            InitializeComponent();
            btnOk.DialogResult = DialogResult.OK;
        }

        public SelectNotificationSound(string notifSelected)
        {
            InitializeComponent();
            btnOk.DialogResult = DialogResult.OK;
            _notifSelected = notifSelected;
        }

        private void SelectNotificationSound_Load(object sender, EventArgs e)
        {
            dataGridViewSoundName.Rows.Add("Notification");
            dataGridViewSoundName.Rows.Add("Warning");
            dataGridViewSoundName.Rows.Add("Error");
            dataGridViewSoundName.Columns[0].Width = dataGridViewSoundName.Width;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            if (dataGridViewSoundName.SelectedCells.Count == 0)
            {
               MessageBox.Show("Please, Select a Notification Sound", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dataGridViewSoundName.SelectedCells[0].Value.ToString() == "Notification")
                {
                    SoundPlayer player = new SoundPlayer($@"{Application.StartupPath}\sound\notification.wav");
                    player.Play();
                }
                else if (dataGridViewSoundName.SelectedCells[0].Value.ToString() == "Warning")
                {
                    SoundPlayer player = new SoundPlayer($@"{Application.StartupPath}\sound\warning.wav");
                    player.Play();
                }
                else if (dataGridViewSoundName.SelectedCells[0].Value.ToString() == "Error")
                {
                    SoundPlayer player = new SoundPlayer($@"{Application.StartupPath}\sound\error.wav");
                    player.Play();
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dataGridViewSoundName.SelectedCells.Count == 0 || dataGridViewSoundName.SelectedCells[0].Value.ToString() == "")
            {
                MessageBox.Show("Please, Select a Notification Sound", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _notifSelected = dataGridViewSoundName.SelectedCells[0].Value.ToString();
                this.Close();
            }
        }
    }
}
