using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;      //to be able to use serial ports

namespace SerialCommTester
{
    public partial class frmSerialComm : Form
    {
        SerialPort _PuertoSerial;    //Will control the port itself (object)
        delegate void SetTextCallback(string text);

        public frmSerialComm()
        {
            InitializeComponent();  //funcion necesaria en puertos seriales. No editar
            getAvailablePorts();    //funcion local para inicializar los puertos disponibles en la computadora
        }

        //---------------------------------mis funciones--------------------------------------
        void getAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            cmbPortList.Items.AddRange(ports);
        }

        void getAvailableFlowControl()
        {
            foreach (string s in Enum.GetNames(typeof(Handshake)))
            {
                cmbHandShake.Items.Add(s);
            }
        }

        void activatePort()
        {
            if (cmbPortList.Text != "" && cmbBaudRate.Text != "" && cmbParity.Text != "" && cmbStopBits.Text != "")
            {
                _PuertoSerial.PortName = cmbPortList.Text;
                _PuertoSerial.BaudRate = Convert.ToInt32(cmbBaudRate.Text);
                _PuertoSerial.RtsEnable = true;
                _PuertoSerial.DtrEnable = true;

                _PuertoSerial.DataBits = Convert.ToInt32(cmbDataBits.Text);

                if (cmbParity.Text == "Even") { _PuertoSerial.Parity = Parity.Even; }
                else if (cmbParity.Text == "Odd") { _PuertoSerial.Parity = Parity.Odd; }
                else if (cmbParity.Text == "Space") { _PuertoSerial.Parity = Parity.Space; }
                else if (cmbParity.Text == "Mark") { _PuertoSerial.Parity = Parity.Mark; }
                else { _PuertoSerial.Parity = Parity.None; }

                if (cmbStopBits.Text =="2") { _PuertoSerial.StopBits = StopBits.Two; }
                else if (cmbStopBits.Text == "1.5") { _PuertoSerial.StopBits = StopBits.OnePointFive; }
                else { _PuertoSerial.StopBits = StopBits.One; }

                if (cmbHandShake.Text == "Software Flow Control") { _PuertoSerial.Handshake = Handshake.XOnXOff; }
                else if (cmbHandShake.Text == "Hardware Flow Control") { _PuertoSerial.Handshake = Handshake.RequestToSend; }
                else { _PuertoSerial.Handshake = Handshake.None; }

                _PuertoSerial.ReadTimeout = 500; 
                _PuertoSerial.WriteTimeout = 500;

                _PuertoSerial.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);   //not working properly
                _PuertoSerial.Open();
            }
            else
            {
                MessageBox.Show("Input selection missing 1 or more characteristics","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bool[] format = { true, true, true, false, false, false };
                enableDisableGUI(format);

            }
        }

        void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)  //not working properly
        {
            printReceivedText(_PuertoSerial.ReadExisting());
        }

        private void printReceivedText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtSend.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(printReceivedText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtRecieve.AppendText(text);
                _PuertoSerial.DiscardInBuffer();
            }
        }

        void enableDisableGUI(bool[] input)
        {
            grpConnection.Enabled = input[0];
            grpCharacteristics.Enabled = input[1];
            btnOpenPort.Enabled = input[2];
            btnClosePort.Enabled = input[3];
            btnSend.Enabled = input[4];
            btnRecieve.Enabled = input[5];
            txtSend.Enabled = ((cmbControlMasterSlave.Text == "Slave") ? false : true);
        }

        //----------------------------C# objects / functions--------------------------------------
        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                _PuertoSerial = new SerialPort();   //the object needed to handle everything about the serial port is created here
                activatePort();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bool[] format = { false, false, false, true, true, true};
            enableDisableGUI(format);
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            _PuertoSerial.Close();
            bool[] format = { true, true, true, false, false, false };
            enableDisableGUI(format);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            _PuertoSerial.WriteLine("Hello World!");
        }

        private void btnRecieve_Click(object sender, EventArgs e)
        {
            try
            {
                txtRecieve.Text = _PuertoSerial.ReadExisting();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // enter key  
            {
                _PuertoSerial.Write("\r\n");
                txtSend.Text = "";
            }
            else
            {
                _PuertoSerial.Write(e.KeyChar.ToString());
            }
        }

        private void txtSend_KeyUp(object sender, KeyEventArgs e)
        {
            //try
            //{
            //    txtRecieve.AppendText(_PuertoSerial.ReadExisting());
            //    _PuertoSerial.DiscardInBuffer();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnClearTxts_Click(object sender, EventArgs e)
        {
            txtRecieve.Clear();
            txtSend.Clear();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            cmbChannelSimplexHalfD.Text = "Simplex";
            cmbControlMasterSlave.Text = "Master";
            cmbDataBits.Text = "7";
            cmbHandShake.Text = "No Flow Control";
            cmbParity.Text = "Odd";
            cmbBaudRate.Text = "9600";
            cmbStopBits.Text = "1";
        }
    } //class closes
} //program closes

//https://www.codeproject.com/Articles/678025/Serial-Comms-in-Csharp-for-Beginners
//http://codesamplez.com/programming/serial-port-communication-c-sharp
//http://stackoverflow.com/questions/24421631/c-sharp-serialport-dsr-dtr-and-cts-rts-handshaking
//http://stackoverflow.com/questions/41354705/how-to-know-the-input-buffer-of-the-serial-port-has-information-in-c


