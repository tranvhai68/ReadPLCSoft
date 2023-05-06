namespace ReadPLCSoft
{
    partial class Fsetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fsetting));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_connection = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_serial = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_ASCII = new System.Windows.Forms.RadioButton();
            this.rd_RTU = new System.Windows.Forms.RadioButton();
            this.cb_Stopbit = new System.Windows.Forms.ComboBox();
            this.cb_parity = new System.Windows.Forms.ComboBox();
            this.cb_Databit = new System.Windows.Forms.ComboBox();
            this.cb_Baud = new System.Windows.Forms.ComboBox();
            this.cb_COM = new System.Windows.Forms.ComboBox();
            this.panel_TCPIP = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel_serial.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_TCPIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_connection);
            this.groupBox1.Location = new System.Drawing.Point(13, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // cb_connection
            // 
            this.cb_connection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_connection.FormattingEnabled = true;
            this.cb_connection.Items.AddRange(new object[] {
            "Serial Port",
            "Modbus TCP/IP"});
            this.cb_connection.Location = new System.Drawing.Point(20, 19);
            this.cb_connection.Name = "cb_connection";
            this.cb_connection.Size = new System.Drawing.Size(205, 21);
            this.cb_connection.TabIndex = 0;
            this.cb_connection.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel_serial
            // 
            this.panel_serial.Controls.Add(this.label7);
            this.panel_serial.Controls.Add(this.label6);
            this.panel_serial.Controls.Add(this.label5);
            this.panel_serial.Controls.Add(this.label4);
            this.panel_serial.Controls.Add(this.label3);
            this.panel_serial.Controls.Add(this.groupBox2);
            this.panel_serial.Controls.Add(this.cb_Stopbit);
            this.panel_serial.Controls.Add(this.cb_parity);
            this.panel_serial.Controls.Add(this.cb_Databit);
            this.panel_serial.Controls.Add(this.cb_Baud);
            this.panel_serial.Controls.Add(this.cb_COM);
            this.panel_serial.Location = new System.Drawing.Point(12, 86);
            this.panel_serial.Name = "panel_serial";
            this.panel_serial.Size = new System.Drawing.Size(333, 167);
            this.panel_serial.TabIndex = 0;
            this.panel_serial.TabStop = false;
            this.panel_serial.Text = "Serial Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rd_ASCII);
            this.groupBox2.Controls.Add(this.rd_RTU);
            this.groupBox2.Location = new System.Drawing.Point(202, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode";
            // 
            // rd_ASCII
            // 
            this.rd_ASCII.AutoSize = true;
            this.rd_ASCII.Location = new System.Drawing.Point(60, 19);
            this.rd_ASCII.Name = "rd_ASCII";
            this.rd_ASCII.Size = new System.Drawing.Size(52, 17);
            this.rd_ASCII.TabIndex = 0;
            this.rd_ASCII.TabStop = true;
            this.rd_ASCII.Text = "ASCII";
            this.rd_ASCII.UseVisualStyleBackColor = true;
            // 
            // rd_RTU
            // 
            this.rd_RTU.AutoSize = true;
            this.rd_RTU.Location = new System.Drawing.Point(6, 19);
            this.rd_RTU.Name = "rd_RTU";
            this.rd_RTU.Size = new System.Drawing.Size(48, 17);
            this.rd_RTU.TabIndex = 0;
            this.rd_RTU.TabStop = true;
            this.rd_RTU.Text = "RTU";
            this.rd_RTU.UseVisualStyleBackColor = true;
            // 
            // cb_Stopbit
            // 
            this.cb_Stopbit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Stopbit.FormattingEnabled = true;
            this.cb_Stopbit.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cb_Stopbit.Location = new System.Drawing.Point(65, 127);
            this.cb_Stopbit.Name = "cb_Stopbit";
            this.cb_Stopbit.Size = new System.Drawing.Size(125, 21);
            this.cb_Stopbit.TabIndex = 0;
            // 
            // cb_parity
            // 
            this.cb_parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_parity.FormattingEnabled = true;
            this.cb_parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cb_parity.Location = new System.Drawing.Point(65, 100);
            this.cb_parity.Name = "cb_parity";
            this.cb_parity.Size = new System.Drawing.Size(125, 21);
            this.cb_parity.TabIndex = 0;
            // 
            // cb_Databit
            // 
            this.cb_Databit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Databit.FormattingEnabled = true;
            this.cb_Databit.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cb_Databit.Location = new System.Drawing.Point(65, 73);
            this.cb_Databit.Name = "cb_Databit";
            this.cb_Databit.Size = new System.Drawing.Size(125, 21);
            this.cb_Databit.TabIndex = 0;
            // 
            // cb_Baud
            // 
            this.cb_Baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Baud.FormattingEnabled = true;
            this.cb_Baud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400"});
            this.cb_Baud.Location = new System.Drawing.Point(65, 46);
            this.cb_Baud.Name = "cb_Baud";
            this.cb_Baud.Size = new System.Drawing.Size(125, 21);
            this.cb_Baud.TabIndex = 0;
            // 
            // cb_COM
            // 
            this.cb_COM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_COM.FormattingEnabled = true;
            this.cb_COM.Location = new System.Drawing.Point(65, 19);
            this.cb_COM.Name = "cb_COM";
            this.cb_COM.Size = new System.Drawing.Size(186, 21);
            this.cb_COM.TabIndex = 0;
            // 
            // panel_TCPIP
            // 
            this.panel_TCPIP.Controls.Add(this.label2);
            this.panel_TCPIP.Controls.Add(this.label1);
            this.panel_TCPIP.Controls.Add(this.txt_port);
            this.panel_TCPIP.Controls.Add(this.txt_IP);
            this.panel_TCPIP.Location = new System.Drawing.Point(13, 259);
            this.panel_TCPIP.Name = "panel_TCPIP";
            this.panel_TCPIP.Size = new System.Drawing.Size(333, 81);
            this.panel_TCPIP.TabIndex = 0;
            this.panel_TCPIP.TabStop = false;
            this.panel_TCPIP.Text = "TCP/IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Address";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(227, 34);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(100, 20);
            this.txt_port.TabIndex = 1;
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(13, 34);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(201, 20);
            this.txt_IP.TabIndex = 0;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(270, 26);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(270, 57);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "COM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Baudrate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Data bits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Parity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Stop bits";
            // 
            // Fsetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 351);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.panel_TCPIP);
            this.Controls.Add(this.panel_serial);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fsetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fsetting";
            this.Load += new System.EventHandler(this.Fsetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel_serial.ResumeLayout(false);
            this.panel_serial.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel_TCPIP.ResumeLayout(false);
            this.panel_TCPIP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox panel_serial;
        private System.Windows.Forms.GroupBox panel_TCPIP;
        private System.Windows.Forms.ComboBox cb_connection;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ComboBox cb_parity;
        private System.Windows.Forms.ComboBox cb_Databit;
        private System.Windows.Forms.ComboBox cb_Baud;
        private System.Windows.Forms.ComboBox cb_COM;
        private System.Windows.Forms.ComboBox cb_Stopbit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd_RTU;
        private System.Windows.Forms.RadioButton rd_ASCII;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}