namespace TerminalApplicationHHoca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxCR = new System.Windows.Forms.CheckBox();
            this.sentRichBox = new System.Windows.Forms.RichTextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.msgTextBox = new System.Windows.Forms.TextBox();
            this.historyBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonResetCounter = new System.Windows.Forms.Button();
            this.labelCounter = new System.Windows.Forms.Label();
            this.radioButtonBinary = new System.Windows.Forms.RadioButton();
            this.numericUpDownBreakline = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bitRateComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonHex = new System.Windows.Forms.RadioButton();
            this.radioButtonAscii = new System.Windows.Forms.RadioButton();
            this.baudComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.scanButton = new System.Windows.Forms.Button();
            this.portsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreakline)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxCR);
            this.groupBox1.Controls.Add(this.sentRichBox);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.sendButton);
            this.groupBox1.Controls.Add(this.msgTextBox);
            this.groupBox1.Controls.Add(this.historyBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 502);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send and Receive";
            // 
            // checkBoxCR
            // 
            this.checkBoxCR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxCR.AutoSize = true;
            this.checkBoxCR.Location = new System.Drawing.Point(7, 477);
            this.checkBoxCR.Name = "checkBoxCR";
            this.checkBoxCR.Size = new System.Drawing.Size(40, 18);
            this.checkBoxCR.TabIndex = 5;
            this.checkBoxCR.Text = "CR";
            this.checkBoxCR.UseVisualStyleBackColor = true;
            // 
            // sentRichBox
            // 
            this.sentRichBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sentRichBox.Location = new System.Drawing.Point(7, 401);
            this.sentRichBox.Name = "sentRichBox";
            this.sentRichBox.ReadOnly = true;
            this.sentRichBox.Size = new System.Drawing.Size(385, 69);
            this.sentRichBox.TabIndex = 4;
            this.sentRichBox.Text = "";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(344, 475);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(47, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(295, 475);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(43, 23);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // msgTextBox
            // 
            this.msgTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msgTextBox.Location = new System.Drawing.Point(52, 476);
            this.msgTextBox.Name = "msgTextBox";
            this.msgTextBox.Size = new System.Drawing.Size(237, 20);
            this.msgTextBox.TabIndex = 1;
            this.msgTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msgTextBox_KeyPress);
            // 
            // historyBox
            // 
            this.historyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyBox.Location = new System.Drawing.Point(7, 20);
            this.historyBox.Name = "historyBox";
            this.historyBox.ReadOnly = true;
            this.historyBox.Size = new System.Drawing.Size(385, 375);
            this.historyBox.TabIndex = 0;
            this.historyBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonResetCounter);
            this.groupBox2.Controls.Add(this.labelCounter);
            this.groupBox2.Controls.Add(this.radioButtonBinary);
            this.groupBox2.Controls.Add(this.numericUpDownBreakline);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.stopBitsComboBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.parityComboBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.bitRateComboBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.radioButtonHex);
            this.groupBox2.Controls.Add(this.radioButtonAscii);
            this.groupBox2.Controls.Add(this.baudComboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.disconnectButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.connectButton);
            this.groupBox2.Controls.Add(this.scanButton);
            this.groupBox2.Controls.Add(this.portsComboBox);
            this.groupBox2.Location = new System.Drawing.Point(417, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 394);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // buttonResetCounter
            // 
            this.buttonResetCounter.Location = new System.Drawing.Point(114, 324);
            this.buttonResetCounter.Name = "buttonResetCounter";
            this.buttonResetCounter.Size = new System.Drawing.Size(81, 23);
            this.buttonResetCounter.TabIndex = 19;
            this.buttonResetCounter.Text = "Rst Counter";
            this.buttonResetCounter.UseVisualStyleBackColor = true;
            this.buttonResetCounter.Click += new System.EventHandler(this.buttonResetCounter_Click);
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Location = new System.Drawing.Point(113, 308);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(54, 14);
            this.labelCounter.TabIndex = 18;
            this.labelCounter.Text = "#Char = 0";
            // 
            // radioButtonBinary
            // 
            this.radioButtonBinary.AutoSize = true;
            this.radioButtonBinary.Location = new System.Drawing.Point(125, 283);
            this.radioButtonBinary.Name = "radioButtonBinary";
            this.radioButtonBinary.Size = new System.Drawing.Size(56, 18);
            this.radioButtonBinary.TabIndex = 17;
            this.radioButtonBinary.TabStop = true;
            this.radioButtonBinary.Text = "Binary";
            this.radioButtonBinary.UseVisualStyleBackColor = true;
            // 
            // numericUpDownBreakline
            // 
            this.numericUpDownBreakline.Location = new System.Drawing.Point(6, 326);
            this.numericUpDownBreakline.Name = "numericUpDownBreakline";
            this.numericUpDownBreakline.Size = new System.Drawing.Size(102, 20);
            this.numericUpDownBreakline.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 14);
            this.label10.TabIndex = 15;
            this.label10.Text = "Max Char per Line :";
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Items.AddRange(new object[] {
            "None",
            "1 Bit",
            "2 Bits",
            "1.5 Bits"});
            this.stopBitsComboBox.Location = new System.Drawing.Point(7, 210);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(188, 22);
            this.stopBitsComboBox.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 14);
            this.label9.TabIndex = 13;
            this.label9.Text = "Stop Bits :";
            // 
            // parityComboBox
            // 
            this.parityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.parityComboBox.Location = new System.Drawing.Point(6, 255);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(189, 22);
            this.parityComboBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "Parity : ";
            // 
            // bitRateComboBox
            // 
            this.bitRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bitRateComboBox.FormattingEnabled = true;
            this.bitRateComboBox.Items.AddRange(new object[] {
            "5 Bits",
            "6 Bits",
            "7 Bits",
            "8 Bits"});
            this.bitRateComboBox.Location = new System.Drawing.Point(6, 163);
            this.bitRateComboBox.Name = "bitRateComboBox";
            this.bitRateComboBox.Size = new System.Drawing.Size(189, 22);
            this.bitRateComboBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "Bit Rate : ";
            // 
            // radioButtonHex
            // 
            this.radioButtonHex.AutoSize = true;
            this.radioButtonHex.Location = new System.Drawing.Point(78, 283);
            this.radioButtonHex.Name = "radioButtonHex";
            this.radioButtonHex.Size = new System.Drawing.Size(45, 18);
            this.radioButtonHex.TabIndex = 8;
            this.radioButtonHex.Text = "HEX";
            this.radioButtonHex.UseVisualStyleBackColor = true;
            // 
            // radioButtonAscii
            // 
            this.radioButtonAscii.AutoSize = true;
            this.radioButtonAscii.Checked = true;
            this.radioButtonAscii.Location = new System.Drawing.Point(21, 283);
            this.radioButtonAscii.Name = "radioButtonAscii";
            this.radioButtonAscii.Size = new System.Drawing.Size(51, 18);
            this.radioButtonAscii.TabIndex = 7;
            this.radioButtonAscii.TabStop = true;
            this.radioButtonAscii.Text = "ASCII";
            this.radioButtonAscii.UseVisualStyleBackColor = true;
            // 
            // baudComboBox
            // 
            this.baudComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudComboBox.FormattingEnabled = true;
            this.baudComboBox.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.baudComboBox.Location = new System.Drawing.Point(6, 116);
            this.baudComboBox.Name = "baudComboBox";
            this.baudComboBox.Size = new System.Drawing.Size(189, 22);
            this.baudComboBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Baud Rate :";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(125, 68);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(70, 23);
            this.disconnectButton.TabIndex = 4;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 14);
            this.label5.TabIndex = 3;
            this.label5.Text = "COM Port :";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(59, 68);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(60, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(6, 68);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(47, 23);
            this.scanButton.TabIndex = 1;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // portsComboBox
            // 
            this.portsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portsComboBox.FormattingEnabled = true;
            this.portsComboBox.Location = new System.Drawing.Point(6, 40);
            this.portsComboBox.Name = "portsComboBox";
            this.portsComboBox.Size = new System.Drawing.Size(189, 22);
            this.portsComboBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(417, 414);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 101);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "About";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Website: http://hhoca.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Version: 1.0.2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author: Huseyin Hoca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title: Serial Terminal";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 529);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(624, 22);
            this.statusBar.TabIndex = 3;
            this.statusBar.Text = "statusBar";
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(32, 17);
            this.statusBarLabel.Text = "label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 551);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 580);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Serial Terminal 1.0.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreakline)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox portsComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox baudComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.RichTextBox historyBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox msgTextBox;
        private System.Windows.Forms.RichTextBox sentRichBox;
        private System.Windows.Forms.RadioButton radioButtonHex;
        private System.Windows.Forms.RadioButton radioButtonAscii;
        private System.Windows.Forms.ComboBox bitRateComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownBreakline;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButtonBinary;
        private System.Windows.Forms.Button buttonResetCounter;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.CheckBox checkBoxCR;
    }
}

