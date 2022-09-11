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
        private byte flagHead = 0x3C ;
        private byte flagTail = 0x3E ;
        private byte regA = 0x41;
        private byte regE = 0x45;
        private byte regI = 0x49;
        private byte regK = 0x4B;
        private byte regL = 0x4C;
        private byte regM = 0x4D;
        private byte regR = 0x52;
   
        public Form1()
        {
            InitializeComponent();
            
            
        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            connectBtn.Text = "Connect";
            string [] ports = SerialPort.GetPortNames();
            portComboBox.Items.AddRange(ports);
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                connectBtn.Text = "Connect";
            }
            else
            {
                try
                {
                    serialPort1.PortName = portComboBox.Text;
                    serialPort1.BaudRate = 9600;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Parity = Parity.None;
                    serialPort1.Open();
                    connectBtn.Text = "Disconnect";
                }
                catch (Exception err)
                {
                    connectBtn.Text = "Connect";
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void readAllBtn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                byte[] buffData = { flagHead, regA,flagTail };
                serialPort1.Write(buffData, 0, buffData.Length);
            }
        }
    }
}
