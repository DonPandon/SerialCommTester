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
            this.cmbPortList = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.grpSend = new System.Windows.Forms.GroupBox();
            this.txtSend = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.grpReceive = new System.Windows.Forms.GroupBox();
            this.txtRecieve = new System.Windows.Forms.RichTextBox();
            this.btnRecieve = new System.Windows.Forms.Button();
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
            this.grpSend.SuspendLayout();
            this.grpReceive.SuspendLayout();
            this.grpConnection.SuspendLayout();
            this.grpCharacteristics.SuspendLayout();
            this.grpActivation.SuspendLayout();
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
            this.grpSend.Location = new System.Drawing.Point(156, 28);
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
            this.txtSend.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyUp);
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(246, 194);
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
            this.grpReceive.Location = new System.Drawing.Point(156, 250);
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
            // btnRecieve
            // 
            this.btnRecieve.Enabled = false;
            this.btnRecieve.Location = new System.Drawing.Point(627, 437);
            this.btnRecieve.Name = "btnRecieve";
            this.btnRecieve.Size = new System.Drawing.Size(75, 23);
            this.btnRecieve.TabIndex = 2;
            this.btnRecieve.Text = "Receive";
            this.btnRecieve.UseVisualStyleBackColor = true;
            this.btnRecieve.Click += new System.EventHandler(this.btnRecieve_Click);
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
            this.btnClearTxts.Location = new System.Drawing.Point(621, 498);
            this.btnClearTxts.Name = "btnClearTxts";
            this.btnClearTxts.Size = new System.Drawing.Size(75, 37);
            this.btnClearTxts.TabIndex = 18;
            this.btnClearTxts.Text = "Clear";
            this.btnClearTxts.UseVisualStyleBackColor = true;
            this.btnClearTxts.Click += new System.EventHandler(this.btnClearTxts_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Channel";
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
            this.cmbChannelSimplexHalfD.Location = new System.Drawing.Point(6, 35);
            this.cmbChannelSimplexHalfD.Name = "cmbChannelSimplexHalfD";
            this.cmbChannelSimplexHalfD.Size = new System.Drawing.Size(121, 21);
            this.cmbChannelSimplexHalfD.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 58);
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
            this.cmbControlMasterSlave.Location = new System.Drawing.Point(6, 77);
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
            this.grpConnection.Location = new System.Drawing.Point(12, 22);
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
            this.grpCharacteristics.Location = new System.Drawing.Point(12, 132);
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
            this.grpActivation.Location = new System.Drawing.Point(12, 425);
            this.grpActivation.Name = "grpActivation";
            this.grpActivation.Size = new System.Drawing.Size(138, 120);
            this.grpActivation.TabIndex = 25;
            this.grpActivation.TabStop = false;
            this.grpActivation.Text = "3. Activation";
            // 
            // txtTester
            // 
            this.txtTester.Enabled = false;
            this.txtTester.Location = new System.Drawing.Point(162, 489);
            this.txtTester.Multiline = true;
            this.txtTester.Name = "txtTester";
            this.txtTester.Size = new System.Drawing.Size(133, 56);
            this.txtTester.TabIndex = 1;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(163, 444);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(132, 39);
            this.btnDefault.TabIndex = 26;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // frmSerialComm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 557);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.txtTester);
            this.Controls.Add(this.grpActivation);
            this.Controls.Add(this.grpCharacteristics);
            this.Controls.Add(this.grpConnection);
            this.Controls.Add(this.btnClearTxts);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnRecieve);
            this.Controls.Add(this.grpReceive);
            this.Controls.Add(this.grpSend);
            this.Name = "frmSerialComm";
            this.Text = "Serial Port - Alpha - Prepared by Daniel G Gonzalez";
            this.grpSend.ResumeLayout(false);
            this.grpReceive.ResumeLayout(false);
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            this.grpCharacteristics.ResumeLayout(false);
            this.grpCharacteristics.PerformLayout();
            this.grpActivation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPortList;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.GroupBox grpSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox grpReceive;
        private System.Windows.Forms.Button btnRecieve;
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
    }
}

