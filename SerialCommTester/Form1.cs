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
        delegate void SetTextCallback(string text);   //functions not working properly
        string InputData = String.Empty;              //functions not working properly


        public frmSerialComm()
        {
            InitializeComponent();  //funcion necesaria en puertos seriales. No editar
            getAvailablePorts();    //funcion local para inicializar los puertos disponibles en la computadora
            //getAvailableFlowControl();  //funcional local para registrar los controles de flujo disponibles
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

                _PuertoSerial.Open();
                //_PuertoSerial.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);   //not working properly
            }
            else
            {
                txtRecieve.Text = "Input selection missing 1 or more characteristics";
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)  //not working properly
        {
            //SerialPort testing = (SerialPort)sender;
            //string indata = testing.ReadExisting();
            //txtRecieve.Text += indata;
        }

        //Probando ejemplos de pagina (incluida al final)
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)    //not working properly
        {
            //_PuertoSerial.ReadLine();
        }

        //Probando ejemplos de pagina (incluida al final)
        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            InputData = _PuertoSerial.ReadExisting();
            if (InputData != String.Empty)
            {
                this.BeginInvoke(new SetTextCallback(SetText), new object[] { InputData });
            }
        }

        //Probando ejemplos de pagina (incluida al final)
        private void SetText(string text)
        {
            this.txtSend.Text += text;
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
            //else if (e.KeyChar < 32 || e.KeyChar > 126)       //everything must be transfered!
            //{
            //    e.Handled = true; // ignores anything else outside printable ASCII range
            //}
            else
            {
                _PuertoSerial.Write(e.KeyChar.ToString());
            }
        }

        private void txtSend_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txtRecieve.AppendText(_PuertoSerial.ReadExisting());
                _PuertoSerial.DiscardInBuffer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

