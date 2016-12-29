using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;              //to be able to use serial ports

namespace SerialCommTester
{
    public partial class frmSerialComm : Form
    {
        SerialPort _PuertoSerial;
        delegate void SetTextCallback(string text);
        modbus mb = new modbus();
        

        public frmSerialComm()
        {
            InitializeComponent();  //funcion necesaria en puertos seriales. No editar
            getAvailablePorts();    //funcion local para inicializar los puertos disponibles en la computadora
        }

        //---------------------------------RS-232/422/485--------------------------------------
        //---------------------------------mis funciones---------------------------------------
        //-------------------------------------------------------------------------------------
        void getAvailablePorts()    //Funcion para recibir los puertos existentes en la computadora
        {
            string[] ports = SerialPort.GetPortNames();
            cmbPortList.Items.AddRange(ports);
        }

        void activatePort()         //funcion para asignar las caracteristicas del puerto serial
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

                bool[] format = { false, false, false, true, true, true, true };
                enableDisableGUI(format);
            }
            else
            {
                MessageBox.Show("Input selection missing 1 or more characteristics","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bool[] format = { true, true, true, false, false, false, false };
                enableDisableGUI(format);

            }
        }

        void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)  //funcion para capturar recibir informacion del serial
        {
            printReceivedText(_PuertoSerial.ReadExisting());
        }

        private void printReceivedText(string text)     //funcion que lee la informacion recibida y la imprime, despues limpia el buffer
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtSend.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(printReceivedText);     //https://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k(EHInvalidOperation.WinForms.IllegalCrossThreadCall);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.5.2);k(DevLang-csharp)&rd=true
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtRecieve.AppendText(text);
                _PuertoSerial.DiscardInBuffer();
            }
        }

        void enableDisableGUI(bool[] input)             //Funcion para habilitar o deshabilitar GUI
        {
            grpConnection.Enabled = input[0];
            grpCharacteristics.Enabled = input[1];
            btnOpenPort.Enabled = input[2];
            btnClosePort.Enabled = input[3];
            btnSend.Enabled = input[4];
            txtSend.Enabled = ((cmbControlMasterSlave.Text == "Slave") ? false : true);
            txtSend.Enabled = input[5];
        }

        //---------------------------------RS-232/422/485--------------------------------------
        //----------------------------C# objects / functions-----------------------------------
        //-------------------------------------------------------------------------------------
        private void btnOpenPort_Click(object sender, EventArgs e)      //Hacer click en boto para activar puerto
        {
            try
            {
                _PuertoSerial = new SerialPort();   //the object needed to handle everything about the serial port is created here
                activatePort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClosePort_Click(object sender, EventArgs e)     //Hacer click en boton para desactivar puerto
        {
            _PuertoSerial.DiscardInBuffer();
            _PuertoSerial.DiscardOutBuffer();
            _PuertoSerial.Close();
            bool[] format = { true, true, true, false, false, false, false };
            enableDisableGUI(format);
        }

        private void btnSend_Click(object sender, EventArgs e)          //Mensaje predeterminado
        {
            _PuertoSerial.WriteLine("Hello World!");
        }

        private void txtSend_KeyPress(object sender, KeyPressEventArgs e)       //Enviar cada nuevo caracter al puerto
        {
            if (_PuertoSerial.IsOpen)
           {
                switch (e.KeyChar)
                {
                    case (char)8:
                        _PuertoSerial.Write("<-");
                        break;
                    case (char)13:
                        _PuertoSerial.Write("\r\n");
                        break;
                    case (char)17:
                        _PuertoSerial.Write("XoNn");
                        break;
                    case (char)19:
                        _PuertoSerial.Write("XoFf");
                        break;
                    case (char)27:
                        _PuertoSerial.Write("Esc");
                        break;
                    default:
                        _PuertoSerial.Write(e.KeyChar.ToString());
                        break;
                }
                _PuertoSerial.DiscardOutBuffer();
            }
        }

        private void btnClearTxts_Click(object sender, EventArgs e)     //mandatory cleaning feature
        {
            txtRecieve.Clear();
            txtSend.Clear();
        }

        private void btnDefault_Click(object sender, EventArgs e)       //Boton para llenar opciones automaticamente
        {
            cmbChannelSimplexHalfD.Text = "Simplex";
            cmbControlMasterSlave.Text = "Master";
            cmbDataBits.Text = "7";
            cmbHandShake.Text = "No Flow Control";
            cmbParity.Text = "Odd";
            cmbBaudRate.Text = "9600";
            cmbStopBits.Text = "1";
        }

        private void tabProtocolos_TabIndexChanged(object sender, EventArgs e)      //Si se cambia de tab, se cierran los puertos que esten abiertos y se resetea todo
        {
            _PuertoSerial.DiscardInBuffer();
            _PuertoSerial.DiscardOutBuffer();
            _PuertoSerial.Close();
            bool[] format = { true, true, true, false, false, false, false };
            enableDisableGUI(format);
        }

    } //class closes
} //program closes

//https://www.codeproject.com/Articles/678025/Serial-Comms-in-Csharp-for-Beginners
//http://codesamplez.com/programming/serial-port-communication-c-sharp
//http://stackoverflow.com/questions/24421631/c-sharp-serialport-dsr-dtr-and-cts-rts-handshaking
//http://stackoverflow.com/questions/41354705/how-to-know-the-input-buffer-of-the-serial-port-has-information-in-c


