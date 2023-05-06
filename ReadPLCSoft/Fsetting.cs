using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReadPLCSoft
{
    public partial class Fsetting : Form
    {
        public Fsetting()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_connection.SelectedIndex == 1)
            {
                panel_serial.Enabled = false;
                panel_TCPIP.Enabled = true;
            }
            else
            {
                panel_serial.Enabled = true;
                panel_TCPIP.Enabled = false;
            }
        }

        private void Fsetting_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();          
            foreach (string port in ports)
            {
                cb_COM.Items.Add(port);
            }
            txt_IP.Text = Properties.Settings.Default.IP.ToString();
            txt_port.Text = Properties.Settings.Default.Port.ToString();
            cb_COM.SelectedItem = Properties.Settings.Default.COM.ToString();
            cb_Baud.SelectedItem = Properties.Settings.Default.Baud.ToString();
            cb_Stopbit.SelectedItem = Properties.Settings.Default.Stopbit.ToString();
            cb_Databit.SelectedItem = Properties.Settings.Default.Databit.ToString();
            cb_parity.SelectedItem = Properties.Settings.Default.Parity.ToString();
            cb_connection.SelectedItem = Properties.Settings.Default.Connection.ToString();
            rd_RTU.Checked = Properties.Settings.Default.RTU;
            rd_ASCII.Checked = Properties.Settings.Default.ASCII;

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["IP"] = txt_IP.Text;
            Properties.Settings.Default["Port"] = txt_port.Text;
            Properties.Settings.Default["COM"] = cb_COM.SelectedItem;
            Properties.Settings.Default["Baud"] = cb_Baud.SelectedItem;
            Properties.Settings.Default["Stopbit"] = cb_Stopbit.SelectedItem;
            Properties.Settings.Default["Databit"] = cb_Databit.SelectedItem;
            Properties.Settings.Default["Parity"] = cb_parity.SelectedItem;
            Properties.Settings.Default["Connection"] =cb_connection.SelectedItem ;
            Properties.Settings.Default["RTU"] = rd_RTU.Checked;
            Properties.Settings.Default["ASCII"] = rd_ASCII.Checked;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
