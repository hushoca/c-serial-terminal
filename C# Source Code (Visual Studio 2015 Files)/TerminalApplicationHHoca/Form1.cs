using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace TerminalApplicationHHoca
{
    public partial class Form1 : Form
    {

        SerialPort sp = new SerialPort();
        bool isConnected = false;

        public Form1()
        {
            InitializeComponent();
            baudComboBox.SelectedItem = "9600";

            disconnectButton.Enabled = false;
            sendButton.Enabled = false;
            msgTextBox.Enabled = false;

            sp.DataReceived += new SerialDataReceivedEventHandler(serialDataReceived);
        }

        /// <summary>
        /// Takes necesseary actions to make GUI right for when connected
        /// and set isConnected variable to true
        /// </summary>
        public void setConnected()
        {
            isConnected = true;
            scanButton.Enabled = false;
            connectButton.Enabled = false;
            disconnectButton.Enabled = true;
            sendButton.Enabled = true;
            msgTextBox.Enabled = true;
        }

        public void setDisconnected()
        {
            isConnected = false;
            scanButton.Enabled = true;
            connectButton.Enabled = true;
            disconnectButton.Enabled = false;
            sendButton.Enabled = false;
            msgTextBox.Enabled = false;
        }


        public void safeWrite(string msg){
            try
            {
                sp.WriteLine(msg);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Disconnected from serial port.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                setDisconnected();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get names of available serial ports, clear combobox
            //so that the previous scan doesnt stick and then
            //place the found ports into the combobox.
            string[] portArray = SerialPort.GetPortNames();
            portsComboBox.Items.Clear();
            portsComboBox.Items.AddRange(portArray);    
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            #region Connection Setup
            //get baud rate selected
            String baudRateSelected = baudComboBox.SelectedItem.ToString();
            //check if a com port is selected
            if (portsComboBox.SelectedItem != null)
            {
                //get port selected, as string and turn it to int then
                //set the baud rate to selected baud rate and port name to the 
                //selected port.
                String portSelected = portsComboBox.SelectedItem.ToString();
                sp.BaudRate = Convert.ToInt16(baudRateSelected);
                sp.PortName = portSelected;
                sp.Parity = Parity.None;
                sp.StopBits = StopBits.One;
                sp.DataBits = 8;
                //attempt to connect to serial port and if failed show error message.
                try
                {
                    sp.Open();
                    setConnected();
                }
                catch (System.IO.IOException){
                    MessageBox.Show("Could not connect to the COM port selected!",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                #endregion

            }
            else
            {
                //show an error message since no com port is selected
                MessageBox.Show("Please select a COM port!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void serialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //write received data into received data richbox. needs invoke because the value is
            //being changed from another thread.
            Invoke(new Action(()=>historyBox.Text += sp.ReadExisting()));
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear both received data and sent data boxes.
            historyBox.Clear();
            sentRichBox.Clear();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            //get the message from textbox, send it to serial port and write it into
            //sent data richbox.
            string msg = msgTextBox.Text;
            safeWrite(msg);
            Invoke(new Action(() => sentRichBox.AppendText("[SENT] "+msg+"\n")));
        }

        private void msgTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                sendButton_Click(null, null);
            }
        }
    }
}
