namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connectBtn = new System.Windows.Forms.Button();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.refreshPortBtn = new System.Windows.Forms.Button();
            this.readAllBtn = new System.Windows.Forms.Button();
            this.deviceGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mqttGroupBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.ethernetGroupBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.loraGroupBox = new System.Windows.Forms.GroupBox();
            this.appSKeyLabel = new System.Windows.Forms.Label();
            this.nwkSKeyLabel = new System.Windows.Forms.Label();
            this.devAddrLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.meterGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.deviceGroupBox.SuspendLayout();
            this.mqttGroupBox.SuspendLayout();
            this.ethernetGroupBox.SuspendLayout();
            this.loraGroupBox.SuspendLayout();
            this.meterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 328);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(12, 10);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 1;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(93, 10);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(121, 21);
            this.portComboBox.TabIndex = 2;
            // 
            // refreshPortBtn
            // 
            this.refreshPortBtn.Location = new System.Drawing.Point(221, 10);
            this.refreshPortBtn.Name = "refreshPortBtn";
            this.refreshPortBtn.Size = new System.Drawing.Size(24, 23);
            this.refreshPortBtn.TabIndex = 3;
            this.refreshPortBtn.Text = "R";
            this.refreshPortBtn.UseVisualStyleBackColor = true;
            // 
            // readAllBtn
            // 
            this.readAllBtn.Location = new System.Drawing.Point(263, 10);
            this.readAllBtn.Name = "readAllBtn";
            this.readAllBtn.Size = new System.Drawing.Size(75, 23);
            this.readAllBtn.TabIndex = 4;
            this.readAllBtn.Text = "Read";
            this.readAllBtn.UseVisualStyleBackColor = true;
            this.readAllBtn.Click += new System.EventHandler(this.readAllBtn_Click);
            // 
            // deviceGroupBox
            // 
            this.deviceGroupBox.Controls.Add(this.textBox6);
            this.deviceGroupBox.Controls.Add(this.label6);
            this.deviceGroupBox.Controls.Add(this.label5);
            this.deviceGroupBox.Controls.Add(this.label4);
            this.deviceGroupBox.Location = new System.Drawing.Point(14, 60);
            this.deviceGroupBox.Name = "deviceGroupBox";
            this.deviceGroupBox.Size = new System.Drawing.Size(200, 100);
            this.deviceGroupBox.TabIndex = 5;
            this.deviceGroupBox.TabStop = false;
            this.deviceGroupBox.Text = "Device";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(94, 19);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Running";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Last Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID Device";
            // 
            // mqttGroupBox
            // 
            this.mqttGroupBox.Controls.Add(this.label14);
            this.mqttGroupBox.Controls.Add(this.label13);
            this.mqttGroupBox.Controls.Add(this.label12);
            this.mqttGroupBox.Controls.Add(this.label11);
            this.mqttGroupBox.Controls.Add(this.textBox14);
            this.mqttGroupBox.Controls.Add(this.textBox9);
            this.mqttGroupBox.Controls.Add(this.textBox8);
            this.mqttGroupBox.Controls.Add(this.textBox7);
            this.mqttGroupBox.Location = new System.Drawing.Point(230, 177);
            this.mqttGroupBox.Name = "mqttGroupBox";
            this.mqttGroupBox.Size = new System.Drawing.Size(200, 124);
            this.mqttGroupBox.TabIndex = 6;
            this.mqttGroupBox.TabStop = false;
            this.mqttGroupBox.Text = "MQTT";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Pass";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "User";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Port";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Server";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(94, 96);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 3;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(94, 70);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 2;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(94, 44);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(94, 19);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 0;
            // 
            // ethernetGroupBox
            // 
            this.ethernetGroupBox.Controls.Add(this.label10);
            this.ethernetGroupBox.Controls.Add(this.label9);
            this.ethernetGroupBox.Controls.Add(this.label8);
            this.ethernetGroupBox.Controls.Add(this.label7);
            this.ethernetGroupBox.Controls.Add(this.textBox13);
            this.ethernetGroupBox.Controls.Add(this.textBox12);
            this.ethernetGroupBox.Controls.Add(this.textBox11);
            this.ethernetGroupBox.Controls.Add(this.textBox10);
            this.ethernetGroupBox.Location = new System.Drawing.Point(445, 177);
            this.ethernetGroupBox.Name = "ethernetGroupBox";
            this.ethernetGroupBox.Size = new System.Drawing.Size(200, 124);
            this.ethernetGroupBox.TabIndex = 7;
            this.ethernetGroupBox.TabStop = false;
            this.ethernetGroupBox.Text = "Ethernet";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "DNS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Gateway";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Net Mask";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "IP Address";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(94, 97);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 3;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(94, 70);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 2;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(94, 44);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 1;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(94, 19);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 0;
            // 
            // loraGroupBox
            // 
            this.loraGroupBox.Controls.Add(this.appSKeyLabel);
            this.loraGroupBox.Controls.Add(this.nwkSKeyLabel);
            this.loraGroupBox.Controls.Add(this.devAddrLabel);
            this.loraGroupBox.Controls.Add(this.textBox3);
            this.loraGroupBox.Controls.Add(this.textBox2);
            this.loraGroupBox.Controls.Add(this.textBox1);
            this.loraGroupBox.Location = new System.Drawing.Point(14, 177);
            this.loraGroupBox.Name = "loraGroupBox";
            this.loraGroupBox.Size = new System.Drawing.Size(200, 105);
            this.loraGroupBox.TabIndex = 8;
            this.loraGroupBox.TabStop = false;
            this.loraGroupBox.Text = "LORA";
            // 
            // appSKeyLabel
            // 
            this.appSKeyLabel.AutoSize = true;
            this.appSKeyLabel.Location = new System.Drawing.Point(8, 74);
            this.appSKeyLabel.Name = "appSKeyLabel";
            this.appSKeyLabel.Size = new System.Drawing.Size(50, 13);
            this.appSKeyLabel.TabIndex = 5;
            this.appSKeyLabel.Text = "appSKey";
            // 
            // nwkSKeyLabel
            // 
            this.nwkSKeyLabel.AutoSize = true;
            this.nwkSKeyLabel.Location = new System.Drawing.Point(6, 48);
            this.nwkSKeyLabel.Name = "nwkSKeyLabel";
            this.nwkSKeyLabel.Size = new System.Drawing.Size(52, 13);
            this.nwkSKeyLabel.TabIndex = 4;
            this.nwkSKeyLabel.Text = "nwkSKey";
            // 
            // devAddrLabel
            // 
            this.devAddrLabel.AutoSize = true;
            this.devAddrLabel.Location = new System.Drawing.Point(6, 22);
            this.devAddrLabel.Name = "devAddrLabel";
            this.devAddrLabel.Size = new System.Drawing.Size(47, 13);
            this.devAddrLabel.TabIndex = 3;
            this.devAddrLabel.Text = "devAddr";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(79, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // meterGroupBox
            // 
            this.meterGroupBox.Controls.Add(this.label3);
            this.meterGroupBox.Controls.Add(this.label2);
            this.meterGroupBox.Controls.Add(this.label1);
            this.meterGroupBox.Controls.Add(this.textBox5);
            this.meterGroupBox.Controls.Add(this.textBox4);
            this.meterGroupBox.Controls.Add(this.comboBox2);
            this.meterGroupBox.Location = new System.Drawing.Point(230, 60);
            this.meterGroupBox.Name = "meterGroupBox";
            this.meterGroupBox.Size = new System.Drawing.Size(200, 100);
            this.meterGroupBox.TabIndex = 9;
            this.meterGroupBox.TabStop = false;
            this.meterGroupBox.Text = "Meter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Meter Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Serial Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Meter";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(94, 46);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(94, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(94, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 350);
            this.Controls.Add(this.meterGroupBox);
            this.Controls.Add(this.loraGroupBox);
            this.Controls.Add(this.ethernetGroupBox);
            this.Controls.Add(this.mqttGroupBox);
            this.Controls.Add(this.deviceGroupBox);
            this.Controls.Add(this.readAllBtn);
            this.Controls.Add(this.refreshPortBtn);
            this.Controls.Add(this.portComboBox);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.deviceGroupBox.ResumeLayout(false);
            this.deviceGroupBox.PerformLayout();
            this.mqttGroupBox.ResumeLayout(false);
            this.mqttGroupBox.PerformLayout();
            this.ethernetGroupBox.ResumeLayout(false);
            this.ethernetGroupBox.PerformLayout();
            this.loraGroupBox.ResumeLayout(false);
            this.loraGroupBox.PerformLayout();
            this.meterGroupBox.ResumeLayout(false);
            this.meterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Button refreshPortBtn;
        private System.Windows.Forms.Button readAllBtn;
        private System.Windows.Forms.GroupBox deviceGroupBox;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox mqttGroupBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.GroupBox ethernetGroupBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.GroupBox loraGroupBox;
        private System.Windows.Forms.Label appSKeyLabel;
        private System.Windows.Forms.Label nwkSKeyLabel;
        private System.Windows.Forms.Label devAddrLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox meterGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

