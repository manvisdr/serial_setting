using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class SerialManager
    {
        private SerialPort serialPort;
        //SByte indexA, indexB, indexC;
        //string dataA, dataB, dataC;
        private byte flagHead = 0x3C;
        private byte flagTail = 0x3E;
        private byte regA = 0x41;
        private byte regE = 0x45;
        private byte regI = 0x49;
        private byte regK = 0x4B;
        private byte regL = 0x4C;
        private byte regM = 0x4D;
        private byte regR = 0x52;

        public string[] getAvailablePorts()
        {
            return SerialPort.GetPortNames();
        }

        public bool connect(string serialPortName)
        {
            serialPort = new SerialPort(serialPortName, 9600);
            serialPort.NewLine = "\r\n";
            serialPort.ReadTimeout = 500;

            try
            {
                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open serial port: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // First handshake with the device:
        // when it received ## it must answer with !!
        public bool handshake()
        {
            serialPort.WriteLine("##");

            string response = "";
            try
            {
                response = serialPort.ReadLine();
            }
            catch (Exception)
            {
                MessageBox.Show("No data from serial port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (response.Equals("!!")) return true;
            MessageBox.Show("Unknown device", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        // Get the version of the running sketch
        // command: ?V
        // response: <version> (for example "1.0")
        public string getAllData()
        {
            serialPort.WriteLine("<A>");
            

            string response = "";
            try
            {
                response = serialPort.ReadLine();
            }
            catch (Exception)
            {
                MessageBox.Show("No data from serial port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return response;
        }

        public void sendData(String strBuff)
        {
            serialPort.Write(strBuff);
        }

        // Get the actual RTC date and time 
        // command: ?T
        // response: date and time in the form dd/MM/yyyy hh:mm:ss
        public string getIDDevice()
        {
            serialPort.WriteLine("<I>");
            string response = "";
            try
            {
                response = serialPort.ReadLine();
            }
            catch (Exception)
            {
                MessageBox.Show("No data from serial port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "UNKNOWN";
            }
            return response;
        }

        // Set the RTC date and time
        // command: !TddMMyyyyhhmmss
        // response: OK
        public bool setRTCTime(DateTime time)
        {
            // Wait until we're 200ms before the next second
            while (DateTime.Now.Millisecond != 850)
                Thread.Sleep(1);

            string command = "!T" + time.AddSeconds(1).ToString("ddMMyyyyHHmmss");
            serialPort.WriteLine(command);

            string response = "";
            try
            {
                response = serialPort.ReadLine();
            }
            catch (Exception)
            {
                MessageBox.Show("No data from serial port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (response.Equals("OK"))
            {
                MessageBox.Show("RTC set!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            MessageBox.Show("Wrong response from RTC", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public void disconnect()
        {
            serialPort.Close();
        }
    }
}