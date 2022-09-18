using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private SerialManager serialManager = new SerialManager();
        SByte indexA, indexB, indexC;
        string dataA, dataB, dataC;
        private bool connected = false;
        private string sketchVersion = "1.0";

        public Form1()
        {
            InitializeComponent();
        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            connectBtn.Text = "Connect";
            string [] ports = SerialPort.GetPortNames();
            portComboBox.Items.AddRange(ports);
            addAvailableComPorts();
            updateUI();
        }

        private void addAvailableComPorts()
        {
            foreach (string comPort in serialManager.getAvailablePorts())
                portComboBox.Items.Add(comPort);

            if (portComboBox.Items.Count > 0) portComboBox.SelectedIndex = 0;
        }

        private void btnEthSend_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtbIP.Text))
            {
                MessageBox.Show("The TextBox is empty!");
               
            }
            else
            {
                serialManager.sendData(txtbIP.Text + "55");

            }
        }

        private void updateUI()
        {
            if (connected)
            {
                connectBtn.Text = "DISCONNECT";

                //btGet.Enabled = true;
                //btSetSystem.Enabled = true;
                //btSetCustom.Enabled = true;
                //dtpCustom.Enabled = true;
                portComboBox.Enabled = false;
            }
            else
            {
                connectBtn.Text = "CONNECT";
                //toolStripStatusLabel1.Text = "Disconnected";
                //btGet.Enabled = false;
                //btSetSystem.Enabled = false;
                //btSetCustom.Enabled = false;
                //dtpCustom.Enabled = false;
                portComboBox.Enabled = true;
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                string serialPortName = (string)portComboBox.SelectedItem;
                bool result = serialManager.connect(serialPortName);

                if (result)
                {
                    connected = true;
                    updateUI();
                }
                else serialManager.disconnect();
            }

            else
            {
                serialManager.disconnect();
                connected = false;
                updateUI();
            }
        }

        private void btnReadDevice_Click(object sender, EventArgs e)
        {
            txtboxIDDev.Text = serialManager.getIDDevice();
        }

        private void btReadAll_Click(object sender, EventArgs e)
        {
            string response;
            response = serialManager.getAllData();

            indexA = Convert.ToSByte(response.IndexOf("A"));
            indexB = Convert.ToSByte(response.IndexOf("B"));
            indexC = Convert.ToSByte(response.IndexOf("C"));

            dataA = response.Substring(indexA + 1, (indexB - indexA) - 1);
            dataB = response.Substring(indexB + 1, (indexC - indexB) - 1);
            dataC = response.Substring(indexC + 1, (response.Length-indexC)-1);

            txtbIP.Text = dataA;
            txtbNetMask.Text = dataB;
            txtbGateway.Text = dataC;
        }
    }
}
