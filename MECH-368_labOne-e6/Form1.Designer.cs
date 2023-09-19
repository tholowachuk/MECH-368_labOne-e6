namespace MECH_368_labOne_e6
{
    partial class serialDemo
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
            this.comboBoxCOMPorts = new System.Windows.Forms.ComboBox();
            this.buttonUpdateSerial = new System.Windows.Forms.Button();
            this.textBoxBytesToRead = new System.Windows.Forms.TextBox();
            this.textBoxStringLength = new System.Windows.Forms.TextBox();
            this.textBoxQueuedItems = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDataContents = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.labelAy = new System.Windows.Forms.Label();
            this.labelAZ = new System.Windows.Forms.Label();
            this.labelAX = new System.Windows.Forms.Label();
            this.maskedTextBoxAX = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAY = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAZ = new System.Windows.Forms.MaskedTextBox();
            this.textBoxOrientationX = new System.Windows.Forms.TextBox();
            this.textBoxOrientationY = new System.Windows.Forms.TextBox();
            this.textBoxOrientationZ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxCOMPorts
            // 
            this.comboBoxCOMPorts.FormattingEnabled = true;
            this.comboBoxCOMPorts.Location = new System.Drawing.Point(12, 12);
            this.comboBoxCOMPorts.Name = "comboBoxCOMPorts";
            this.comboBoxCOMPorts.Size = new System.Drawing.Size(177, 21);
            this.comboBoxCOMPorts.TabIndex = 1;
            this.comboBoxCOMPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxCOMPorts_SelectedIndexChanged);
            // 
            // buttonUpdateSerial
            // 
            this.buttonUpdateSerial.Location = new System.Drawing.Point(195, 12);
            this.buttonUpdateSerial.Name = "buttonUpdateSerial";
            this.buttonUpdateSerial.Size = new System.Drawing.Size(114, 23);
            this.buttonUpdateSerial.TabIndex = 2;
            this.buttonUpdateSerial.UseVisualStyleBackColor = true;
            this.buttonUpdateSerial.Click += new System.EventHandler(this.buttonUpdateSerial_Click);
            // 
            // textBoxBytesToRead
            // 
            this.textBoxBytesToRead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBytesToRead.Location = new System.Drawing.Point(128, 46);
            this.textBoxBytesToRead.Name = "textBoxBytesToRead";
            this.textBoxBytesToRead.Size = new System.Drawing.Size(181, 20);
            this.textBoxBytesToRead.TabIndex = 3;
            // 
            // textBoxStringLength
            // 
            this.textBoxStringLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStringLength.Location = new System.Drawing.Point(128, 72);
            this.textBoxStringLength.Name = "textBoxStringLength";
            this.textBoxStringLength.Size = new System.Drawing.Size(181, 20);
            this.textBoxStringLength.TabIndex = 4;
            // 
            // textBoxQueuedItems
            // 
            this.textBoxQueuedItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQueuedItems.Location = new System.Drawing.Point(128, 98);
            this.textBoxQueuedItems.Name = "textBoxQueuedItems";
            this.textBoxQueuedItems.Size = new System.Drawing.Size(181, 20);
            this.textBoxQueuedItems.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Serial Bytes to Read";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Temp String Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Items in Queue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Serial Data Stream:";
            // 
            // textBoxDataContents
            // 
            this.textBoxDataContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDataContents.Location = new System.Drawing.Point(8, 155);
            this.textBoxDataContents.Multiline = true;
            this.textBoxDataContents.Name = "textBoxDataContents";
            this.textBoxDataContents.Size = new System.Drawing.Size(301, 166);
            this.textBoxDataContents.TabIndex = 10;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // labelAy
            // 
            this.labelAy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAy.AutoSize = true;
            this.labelAy.Location = new System.Drawing.Point(5, 363);
            this.labelAy.Name = "labelAy";
            this.labelAy.Size = new System.Drawing.Size(19, 13);
            this.labelAy.TabIndex = 11;
            this.labelAy.Text = "Ay";
            // 
            // labelAZ
            // 
            this.labelAZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAZ.AutoSize = true;
            this.labelAZ.Location = new System.Drawing.Point(5, 389);
            this.labelAZ.Name = "labelAZ";
            this.labelAZ.Size = new System.Drawing.Size(19, 13);
            this.labelAZ.TabIndex = 13;
            this.labelAZ.Text = "Az";
            // 
            // labelAX
            // 
            this.labelAX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAX.AutoSize = true;
            this.labelAX.Location = new System.Drawing.Point(5, 337);
            this.labelAX.Name = "labelAX";
            this.labelAX.Size = new System.Drawing.Size(19, 13);
            this.labelAX.TabIndex = 12;
            this.labelAX.Text = "Ax";
            // 
            // maskedTextBoxAX
            // 
            this.maskedTextBoxAX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAX.Location = new System.Drawing.Point(30, 334);
            this.maskedTextBoxAX.Name = "maskedTextBoxAX";
            this.maskedTextBoxAX.Size = new System.Drawing.Size(129, 20);
            this.maskedTextBoxAX.TabIndex = 15;
            // 
            // maskedTextBoxAY
            // 
            this.maskedTextBoxAY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAY.Location = new System.Drawing.Point(30, 360);
            this.maskedTextBoxAY.Name = "maskedTextBoxAY";
            this.maskedTextBoxAY.Size = new System.Drawing.Size(129, 20);
            this.maskedTextBoxAY.TabIndex = 16;
            // 
            // maskedTextBoxAZ
            // 
            this.maskedTextBoxAZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxAZ.Location = new System.Drawing.Point(30, 386);
            this.maskedTextBoxAZ.Name = "maskedTextBoxAZ";
            this.maskedTextBoxAZ.Size = new System.Drawing.Size(129, 20);
            this.maskedTextBoxAZ.TabIndex = 14;
            // 
            // textBoxOrientationX
            // 
            this.textBoxOrientationX.Location = new System.Drawing.Point(165, 334);
            this.textBoxOrientationX.Name = "textBoxOrientationX";
            this.textBoxOrientationX.Size = new System.Drawing.Size(144, 20);
            this.textBoxOrientationX.TabIndex = 17;
            // 
            // textBoxOrientationY
            // 
            this.textBoxOrientationY.Location = new System.Drawing.Point(165, 360);
            this.textBoxOrientationY.Name = "textBoxOrientationY";
            this.textBoxOrientationY.Size = new System.Drawing.Size(144, 20);
            this.textBoxOrientationY.TabIndex = 18;
            // 
            // textBoxOrientationZ
            // 
            this.textBoxOrientationZ.Location = new System.Drawing.Point(165, 386);
            this.textBoxOrientationZ.Name = "textBoxOrientationZ";
            this.textBoxOrientationZ.Size = new System.Drawing.Size(144, 20);
            this.textBoxOrientationZ.TabIndex = 19;
            // 
            // serialDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 421);
            this.Controls.Add(this.textBoxOrientationZ);
            this.Controls.Add(this.textBoxOrientationY);
            this.Controls.Add(this.textBoxOrientationX);
            this.Controls.Add(this.maskedTextBoxAY);
            this.Controls.Add(this.maskedTextBoxAX);
            this.Controls.Add(this.maskedTextBoxAZ);
            this.Controls.Add(this.labelAZ);
            this.Controls.Add(this.labelAX);
            this.Controls.Add(this.labelAy);
            this.Controls.Add(this.textBoxDataContents);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQueuedItems);
            this.Controls.Add(this.textBoxStringLength);
            this.Controls.Add(this.textBoxBytesToRead);
            this.Controls.Add(this.buttonUpdateSerial);
            this.Controls.Add(this.comboBoxCOMPorts);
            this.MinimumSize = new System.Drawing.Size(334, 460);
            this.Name = "serialDemo";
            this.Text = "Serial Demo";
            this.Load += new System.EventHandler(this.serialDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCOMPorts;
        private System.Windows.Forms.Button buttonUpdateSerial;
        private System.Windows.Forms.TextBox textBoxBytesToRead;
        private System.Windows.Forms.TextBox textBoxStringLength;
        private System.Windows.Forms.TextBox textBoxQueuedItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDataContents;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelAy;
        private System.Windows.Forms.Label labelAZ;
        private System.Windows.Forms.Label labelAX;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAX;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAY;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAZ;
        private System.Windows.Forms.TextBox textBoxOrientationX;
        private System.Windows.Forms.TextBox textBoxOrientationY;
        private System.Windows.Forms.TextBox textBoxOrientationZ;
    }
}

