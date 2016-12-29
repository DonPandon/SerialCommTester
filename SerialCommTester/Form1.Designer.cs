namespace SerialCommTester
{
    partial class frmSerialComm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSerialComm));
            this.cmbPortList = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.grpSend = new System.Windows.Forms.GroupBox();
            this.txtSend = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.grpReceive = new System.Windows.Forms.GroupBox();
            this.txtRecieve = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbHandShake = new System.Windows.Forms.ComboBox();
            this.btnClearTxts = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbChannelSimplexHalfD = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbControlMasterSlave = new System.Windows.Forms.ComboBox();
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.grpCharacteristics = new System.Windows.Forms.GroupBox();
            this.grpActivation = new System.Windows.Forms.GroupBox();
            this.txtTester = new System.Windows.Forms.TextBox();
            this.btnDefault = new System.Windows.Forms.Button();
            this.tabProtocolos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRTUOpenPort = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.txtRTUSend = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRTUSlaveID = new System.Windows.Forms.TextBox();
            this.txtRTUFunction = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.grpSend.SuspendLayout();
            this.grpReceive.SuspendLayout();
            this.grpConnection.SuspendLayout();
            this.grpCharacteristics.SuspendLayout();
            this.grpActivation.SuspendLayout();
            this.tabProtocolos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPortList
            // 
            this.cmbPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortList.ForeColor = System.Drawing.Color.Black;
            this.cmbPortList.FormattingEnabled = true;
            this.cmbPortList.Location = new System.Drawing.Point(6, 35);
            this.cmbPortList.Name = "cmbPortList";
            this.cmbPortList.Size = new System.Drawing.Size(121, 21);
            this.cmbPortList.TabIndex = 0;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.ForeColor = System.Drawing.Color.Black;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.cmbBaudRate.Location = new System.Drawing.Point(6, 75);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cmbBaudRate.TabIndex = 1;
            // 
            // grpSend
            // 
            this.grpSend.Controls.Add(this.txtSend);
            this.grpSend.Location = new System.Drawing.Point(150, 6);
            this.grpSend.Name = "grpSend";
            this.grpSend.Size = new System.Drawing.Size(546, 160);
            this.grpSend.TabIndex = 3;
            this.grpSend.TabStop = false;
            this.grpSend.Text = "This terminal";
            // 
            // txtSend
            // 
            this.txtSend.Enabled = false;
            this.txtSend.Location = new System.Drawing.Point(7, 20);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(533, 134);
            this.txtSend.TabIndex = 0;
            this.txtSend.Text = "";
            this.txtSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSend_KeyPress);
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(231, 172);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Hello World!";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // grpReceive
            // 
            this.grpReceive.Controls.Add(this.txtRecieve);
            this.grpReceive.Location = new System.Drawing.Point(150, 348);
            this.grpReceive.Name = "grpReceive";
            this.grpReceive.Size = new System.Drawing.Size(546, 181);
            this.grpReceive.TabIndex = 4;
            this.grpReceive.TabStop = false;
            this.grpReceive.Text = "Remote terminal / Loop Back";
            // 
            // txtRecieve
            // 
            this.txtRecieve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecieve.Enabled = false;
            this.txtRecieve.Location = new System.Drawing.Point(6, 22);
            this.txtRecieve.Name = "txtRecieve";
            this.txtRecieve.Size = new System.Drawing.Size(533, 147);
            this.txtRecieve.TabIndex = 0;
            this.txtRecieve.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baud Rate";
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(6, 19);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(121, 40);
            this.btnOpenPort.TabIndex = 8;
            this.btnOpenPort.Text = "Open Port";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // btnClosePort
            // 
            this.btnClosePort.Enabled = false;
            this.btnClosePort.Location = new System.Drawing.Point(6, 70);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(121, 40);
            this.btnClosePort.TabIndex = 9;
            this.btnClosePort.Text = "Close Port";
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Parity";
            // 
            // cmbParity
            // 
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.ForeColor = System.Drawing.Color.Black;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None",
            "Mark",
            "Space"});
            this.cmbParity.Location = new System.Drawing.Point(6, 160);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(121, 21);
            this.cmbParity.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stop bits";
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.ForeColor = System.Drawing.Color.Black;
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cmbStopBits.Location = new System.Drawing.Point(6, 205);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(121, 21);
            this.cmbStopBits.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data Bits";
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBits.ForeColor = System.Drawing.Color.Black;
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cmbDataBits.Location = new System.Drawing.Point(6, 118);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(121, 21);
            this.cmbDataBits.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Handshake";
            // 
            // cmbHandShake
            // 
            this.cmbHandShake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHandShake.ForeColor = System.Drawing.Color.Black;
            this.cmbHandShake.FormattingEnabled = true;
            this.cmbHandShake.Items.AddRange(new object[] {
            "No Flow Control",
            "Software Flow Control",
            "Hardware Flow Control"});
            this.cmbHandShake.Location = new System.Drawing.Point(6, 249);
            this.cmbHandShake.Name = "cmbHandShake";
            this.cmbHandShake.Size = new System.Drawing.Size(121, 21);
            this.cmbHandShake.TabIndex = 16;
            // 
            // btnClearTxts
            // 
            this.btnClearTxts.Location = new System.Drawing.Point(621, 233);
            this.btnClearTxts.Name = "btnClearTxts";
            this.btnClearTxts.Size = new System.Drawing.Size(75, 37);
            this.btnClearTxts.TabIndex = 18;
            this.btnClearTxts.Text = "Clear All";
            this.btnClearTxts.UseVisualStyleBackColor = true;
            this.btnClearTxts.Click += new System.EventHandler(this.btnClearTxts_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Port";
            // 
            // cmbChannelSimplexHalfD
            // 
            this.cmbChannelSimplexHalfD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChannelSimplexHalfD.ForeColor = System.Drawing.Color.Black;
            this.cmbChannelSimplexHalfD.FormattingEnabled = true;
            this.cmbChannelSimplexHalfD.Items.AddRange(new object[] {
            "Simplex",
            "Half-Duplex",
            "Full-Duplex"});
            this.cmbChannelSimplexHalfD.Location = new System.Drawing.Point(6, 31);
            this.cmbChannelSimplexHalfD.Name = "cmbChannelSimplexHalfD";
            this.cmbChannelSimplexHalfD.Size = new System.Drawing.Size(121, 21);
            this.cmbChannelSimplexHalfD.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Control";
            // 
            // cmbControlMasterSlave
            // 
            this.cmbControlMasterSlave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbControlMasterSlave.ForeColor = System.Drawing.Color.Black;
            this.cmbControlMasterSlave.FormattingEnabled = true;
            this.cmbControlMasterSlave.Items.AddRange(new object[] {
            "Master",
            "Slave"});
            this.cmbControlMasterSlave.Location = new System.Drawing.Point(6, 69);
            this.cmbControlMasterSlave.Name = "cmbControlMasterSlave";
            this.cmbControlMasterSlave.Size = new System.Drawing.Size(121, 21);
            this.cmbControlMasterSlave.TabIndex = 21;
            // 
            // grpConnection
            // 
            this.grpConnection.Controls.Add(this.label3);
            this.grpConnection.Controls.Add(this.label8);
            this.grpConnection.Controls.Add(this.cmbChannelSimplexHalfD);
            this.grpConnection.Controls.Add(this.cmbControlMasterSlave);
            this.grpConnection.Location = new System.Drawing.Point(6, 6);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Size = new System.Drawing.Size(138, 104);
            this.grpConnection.TabIndex = 23;
            this.grpConnection.TabStop = false;
            this.grpConnection.Text = "1. Connection";
            // 
            // grpCharacteristics
            // 
            this.grpCharacteristics.Controls.Add(this.label1);
            this.grpCharacteristics.Controls.Add(this.cmbPortList);
            this.grpCharacteristics.Controls.Add(this.cmbBaudRate);
            this.grpCharacteristics.Controls.Add(this.label2);
            this.grpCharacteristics.Controls.Add(this.cmbParity);
            this.grpCharacteristics.Controls.Add(this.label7);
            this.grpCharacteristics.Controls.Add(this.label4);
            this.grpCharacteristics.Controls.Add(this.cmbHandShake);
            this.grpCharacteristics.Controls.Add(this.cmbStopBits);
            this.grpCharacteristics.Controls.Add(this.label6);
            this.grpCharacteristics.Controls.Add(this.label5);
            this.grpCharacteristics.Controls.Add(this.cmbDataBits);
            this.grpCharacteristics.Location = new System.Drawing.Point(6, 116);
            this.grpCharacteristics.Name = "grpCharacteristics";
            this.grpCharacteristics.Size = new System.Drawing.Size(138, 287);
            this.grpCharacteristics.TabIndex = 24;
            this.grpCharacteristics.TabStop = false;
            this.grpCharacteristics.Text = "2. Characteristics";
            // 
            // grpActivation
            // 
            this.grpActivation.Controls.Add(this.btnOpenPort);
            this.grpActivation.Controls.Add(this.btnClosePort);
            this.grpActivation.Location = new System.Drawing.Point(6, 409);
            this.grpActivation.Name = "grpActivation";
            this.grpActivation.Size = new System.Drawing.Size(138, 120);
            this.grpActivation.TabIndex = 25;
            this.grpActivation.TabStop = false;
            this.grpActivation.Text = "3. Activation";
            // 
            // txtTester
            // 
            this.txtTester.Enabled = false;
            this.txtTester.Location = new System.Drawing.Point(330, 173);
            this.txtTester.Multiline = true;
            this.txtTester.Name = "txtTester";
            this.txtTester.Size = new System.Drawing.Size(133, 22);
            this.txtTester.TabIndex = 1;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(150, 172);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDefault.TabIndex = 26;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // tabProtocolos
            // 
            this.tabProtocolos.Controls.Add(this.tabPage1);
            this.tabProtocolos.Controls.Add(this.tabPage2);
            this.tabProtocolos.Location = new System.Drawing.Point(12, 12);
            this.tabProtocolos.Name = "tabProtocolos";
            this.tabProtocolos.SelectedIndex = 0;
            this.tabProtocolos.Size = new System.Drawing.Size(711, 564);
            this.tabProtocolos.TabIndex = 27;
            this.tabProtocolos.TabIndexChanged += new System.EventHandler(this.tabProtocolos_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.grpConnection);
            this.tabPage1.Controls.Add(this.btnDefault);
            this.tabPage1.Controls.Add(this.grpSend);
            this.tabPage1.Controls.Add(this.txtTester);
            this.tabPage1.Controls.Add(this.grpReceive);
            this.tabPage1.Controls.Add(this.btnSend);
            this.tabPage1.Controls.Add(this.btnClearTxts);
            this.tabPage1.Controls.Add(this.grpActivation);
            this.tabPage1.Controls.Add(this.grpCharacteristics);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(703, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RS-232/422/485";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnRTUOpenPort);
            this.tabPage2.Controls.Add(this.txtRTUSend);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(703, 538);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Serial RTU";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(6, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 155);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "3. Activation";
            // 
            // btnRTUOpenPort
            // 
            this.btnRTUOpenPort.Location = new System.Drawing.Point(150, 489);
            this.btnRTUOpenPort.Name = "btnRTUOpenPort";
            this.btnRTUOpenPort.Size = new System.Drawing.Size(121, 40);
            this.btnRTUOpenPort.TabIndex = 8;
            this.btnRTUOpenPort.Text = "Open Port";
            this.btnRTUOpenPort.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(576, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Close Port";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.txtRTUFunction);
            this.groupBox3.Controls.Add(this.txtRTUSlaveID);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Controls.Add(this.comboBox4);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.comboBox6);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(6, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 321);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2. Characteristics";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Port";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.ForeColor = System.Drawing.Color.Black;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(6, 35);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 0;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.ForeColor = System.Drawing.Color.Black;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.comboBox4.Location = new System.Drawing.Point(6, 75);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Baud Rate";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Sample Rate";
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.ForeColor = System.Drawing.Color.Black;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "No Flow Control",
            "Software Flow Control",
            "Hardware Flow Control"});
            this.comboBox6.Location = new System.Drawing.Point(6, 285);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 16;
            // 
            // txtRTUSend
            // 
            this.txtRTUSend.Location = new System.Drawing.Point(162, 37);
            this.txtRTUSend.Name = "txtRTUSend";
            this.txtRTUSend.Size = new System.Drawing.Size(535, 69);
            this.txtRTUSend.TabIndex = 29;
            this.txtRTUSend.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 186);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Data";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Function";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Slave ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Data Type";
            // 
            // txtRTUSlaveID
            // 
            this.txtRTUSlaveID.Location = new System.Drawing.Point(7, 118);
            this.txtRTUSlaveID.Name = "txtRTUSlaveID";
            this.txtRTUSlaveID.Size = new System.Drawing.Size(100, 20);
            this.txtRTUSlaveID.TabIndex = 19;
            // 
            // txtRTUFunction
            // 
            this.txtRTUFunction.Location = new System.Drawing.Point(7, 157);
            this.txtRTUFunction.Name = "txtRTUFunction";
            this.txtRTUFunction.Size = new System.Drawing.Size(100, 20);
            this.txtRTUFunction.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 202);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 246);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(9, 75);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 26;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(9, 36);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Value";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Register";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 38);
            this.button3.TabIndex = 27;
            this.button3.Text = "Do Write";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmSerialComm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 588);
            this.Controls.Add(this.tabProtocolos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSerialComm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Port - Alpha - Prepared by Daniel G Gonzalez";
            this.grpSend.ResumeLayout(false);
            this.grpReceive.ResumeLayout(false);
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            this.grpCharacteristics.ResumeLayout(false);
            this.grpCharacteristics.PerformLayout();
            this.grpActivation.ResumeLayout(false);
            this.tabProtocolos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPortList;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.GroupBox grpSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox grpReceive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbHandShake;
        private System.Windows.Forms.Button btnClearTxts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbChannelSimplexHalfD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbControlMasterSlave;
        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.GroupBox grpCharacteristics;
        private System.Windows.Forms.GroupBox grpActivation;
        private System.Windows.Forms.TextBox txtTester;
        private System.Windows.Forms.RichTextBox txtSend;
        private System.Windows.Forms.RichTextBox txtRecieve;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.TabControl tabProtocolos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRTUOpenPort;
        private System.Windows.Forms.RichTextBox txtRTUSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtRTUFunction;
        private System.Windows.Forms.TextBox txtRTUSlaveID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

