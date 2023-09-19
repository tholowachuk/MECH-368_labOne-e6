using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace MECH_368_labOne_e6
{
    public partial class serialDemo : Form
    {
        //create some variables & a queue for later use
        int currentAXValue = 0;
        int currentAYValue = 0;
        int currentAZValue = 0;
        int currentByteIndex = 0;
        int bytesToReadDisplay = 0;
        string tempSerialData = "";
        ConcurrentQueue<Int32> dataQueue = new ConcurrentQueue<Int32>();
        ConcurrentQueue<Int32> aXQueue = new ConcurrentQueue<Int32>();
        ConcurrentQueue<Int32> aYQueue = new ConcurrentQueue<Int32>();
        ConcurrentQueue<Int32> aZQueue = new ConcurrentQueue<Int32>();

        public serialDemo()
        {
            InitializeComponent();
        }

        private void serialDemo_Load(object sender, EventArgs e)
        {
            //clear the dropdown box, add currently used COM ports to it for selection
            comboBoxCOMPorts.Items.Clear();
            comboBoxCOMPorts.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if (comboBoxCOMPorts.Items.Count > 0)
                comboBoxCOMPorts.SelectedIndex = 0;
            else
                comboBoxCOMPorts.Text = "No COM ports!";
            
            //create a timer for events to occur within
            System.Windows.Forms.Timer queueTimer = new System.Windows.Forms.Timer();
            queueTimer.Interval = 100;
            queueTimer.Tick += new EventHandler(queueTimer_Tick);
            queueTimer.Start();

            //update button text with relevant label
            //if (!serialPort1.IsOpen)
            //{
            //    buttonUpdateSerial.Text = "Connect Serial";
            //}
            //else
            //{
            //    buttonUpdateSerial.Text = "Disconnect Serial";
            //}
        }

        private string DetermineOrientation(int ax, int ay, int az)
        {
            // Define orientation thresholds based on criteria for each axis
            int xThreshold = 128;
            int yThreshold = 128;
            int zThreshold= 128;

            // Determine orientation label based on thresholds for each axis
            if (ax > xThreshold && ay == 0 && az == 0)
            {
                return "Facing left (X-)";
            }
            else if (ax <= xThreshold && ay == 0 && az == 0)
            {
                return "Facing right (X+)";
            }
            else if (ay > yThreshold && ax == 0 && az == 0)
            {
                return "Facing front (Y+)";
            }
            else if (ay <= yThreshold && ax == 0 && az == 0)
            {
                return "Facing back (Y-)";
            }
            else if (az > zThreshold && ax == 0 && ay == 0)
            {
                return "Facing up (Z+)";
            }
            else if (az <= zThreshold && ax == 0 && ay == 0)
            {
                return "Facing down (Z-)";
            }
            else
            {
                return "Unknown orientation";
            }
        }

        private void queueTimer_Tick (object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                //update button text with relevant label
                buttonUpdateSerial.Text = "Connect Serial";

                //2023-09-17 - clear text that might have been missed, bug patch
                textBoxDataContents.Text = "";
            }
            else
            {
                //update button text with relevant label
                buttonUpdateSerial.Text = "Disconnect Serial";

                //update display of queued data for processing
                textBoxBytesToRead.Text = bytesToReadDisplay.ToString();

                //update display of string length in queue
                int totalCharacterCount = dataQueue.Sum(item => item.ToString().Length);
                textBoxStringLength.Text = totalCharacterCount.ToString();

                //update display of number of items in queue
                textBoxQueuedItems.Text = dataQueue.Count.ToString();

                //determine orientation based on Ax, Ay, and Az values




                //display orientation labels in their respective textboxes



            }
         
            //dequeue items and insert them into an endless textbox
            while (dataQueue.TryDequeue(out int dequeuedByte))
            {
                //check if next item is 255
                if (dequeuedByte == 255)
                {
                    currentByteIndex = 0;
                }
                else
                {
                    if (currentByteIndex == 0)
                    {
                        currentAXValue = dequeuedByte;
                        string orientationX = DetermineOrientation(dequeuedByte, 0, 0);
                        textBoxOrientationX.Text = orientationX;
                    }
                    else if (currentByteIndex == 1)
                    {
                        currentAYValue = dequeuedByte;
                        string orientationY = DetermineOrientation(0, dequeuedByte, 0);
                        textBoxOrientationY.Text = orientationY;
                    }
                    else if (currentByteIndex == 2)
                    {
                        currentAZValue = dequeuedByte;
                        string orientationZ = DetermineOrientation(0, 0, dequeuedByte);
                        textBoxOrientationZ.Text = orientationZ;
                    }

                    currentByteIndex++;

                    aXQueue.Enqueue(currentAXValue);
                    aYQueue.Enqueue(currentAYValue);
                    aZQueue.Enqueue(currentAZValue);

                    maskedTextBoxAX.Text = currentAXValue.ToString();
                    maskedTextBoxAY.Text = currentAYValue.ToString();
                    maskedTextBoxAZ.Text = currentAZValue.ToString();
                }

                
                textBoxDataContents.AppendText(dequeuedByte.ToString() + ", ");
            }

            //unused code, tried a new method of end cleaning
            //if (textBoxDataContents.Text.EndsWith(", "))
            //{
            //    textBoxDataContents.Text = textBoxQueuedItems.Text.Substring(0, textBoxQueuedItems.Text.Length - 2);
            //}

            //old code prior to part 13 of Ex.4
            //textBoxDataContents.AppendText(tempSerialData);
            //textBoxStringLength.Text = tempSerialData.Length.ToString();
            //tempSerialData = "";
        }

        private void comboBoxCOMPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBoxCOMPorts.Text;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int bytesToRead;
            int newByte = 0;

            bytesToRead = serialPort1.BytesToRead;
            bytesToReadDisplay = bytesToRead;

            while (bytesToRead > 0)
            {
                newByte = serialPort1.ReadByte();
                dataQueue.Enqueue(newByte);
                bytesToRead = serialPort1.BytesToRead;

                //old code prior to part 12 of Ex.4:
                //tempSerialData = tempSerialData + newByte.ToString() + ", ";
            }
        }

        private void buttonUpdateSerial_Click(object sender, EventArgs e)
        {
            //implementing some error handling here using exception messaging
            try
            {
                //if the port is closed, open it and request acceleration data; if the port is open, close and clear text fields
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    serialPort1.Write("A");
                }
                else
                {
                    serialPort1.Close();
                    textBoxBytesToRead.Text = "";
                    textBoxStringLength.Text = "";
                    textBoxQueuedItems.Text = "";
                    textBoxDataContents.Text = "";
                    maskedTextBoxAX.Text = "";
                    maskedTextBoxAY.Text = "";
                    maskedTextBoxAZ.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening the serial port: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
