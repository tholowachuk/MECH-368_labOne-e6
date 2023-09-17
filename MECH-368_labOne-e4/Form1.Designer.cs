namespace MECH_368_labOne_e4
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
            this.textBoxDataContents.Size = new System.Drawing.Size(301, 207);
            this.textBoxDataContents.TabIndex = 10;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // serialDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 374);
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
            this.MinimumSize = new System.Drawing.Size(334, 413);
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
    }
}

