using System;
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.Remoting.Metadata.W3cXsd2001;



namespace TerminalApplicationHHoca
{
    public partial class Form1 : Form
    {

        SerialPort sp = new SerialPort();
        Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
        int breakLineCounter = 0;

        /// <summary>
        /// INITIALISES CONFIG FILE WITH DEFAULT SETTINGS (DEFINED BY DEVELOPER)
        /// ONLY RUNS WHEN USER MESSES WITH CONFIG FILE/LOSES IT OR WHEN THE APP
        /// FIRST TIME RUNS ON A PC.
        /// </summary>
        public void initSettings()
        {
            //clear so if program messed up and already there is a
            // config file adding doesnt duplicate values
            config.AppSettings.Settings.Clear();

            /*
             * ADD THE DEFAULT VALUES TO THE CONFIG FILE
             */
            #region Init first time run config variables
            config.AppSettings.Settings.Add("baud", "4");
            config.AppSettings.Settings.Add("bitRate", "3");
            config.AppSettings.Settings.Add("parity", "0");
            config.AppSettings.Settings.Add("stopBits", "0");
            config.AppSettings.Settings.Add("CR", "true");

            config.AppSettings.Settings.Add("form_x", "0");
            config.AppSettings.Settings.Add("form_y", "0");

            config.AppSettings.Settings.Add("form_width", "580");
            config.AppSettings.Settings.Add("form_height", "640");
            #endregion
            
            //set form items to default.
            baudComboBox.SelectedItem = "9600";
            bitRateComboBox.SelectedItem = "8 Bits";
            parityComboBox.SelectedItem = "None";
            stopBitsComboBox.SelectedIndex = 0;
            checkBoxCR.Checked = true;
            
            //save the config file changes
            config.Save();
        }

        /// <summary>
        /// USE TO LOAD PREVIOUS SESSION SETTINGS FROM CONFIG FILE
        /// (BAUDRATE,BITRATE,FORMX,Y,WIDTH...)
        /// </summary>
        public void loadPreviousSessionSettings()
        {
            //SETUP ALL THE VARIABLES WHICH WILL BE USED
            #region init variables
            bool reint      =    false;
            int baud        =    0;
            int bitRate     =    0;
            int parity      =    0;
            int stopBits    =    0;

            int form_x      =    0;
            int form_y      =    0;
            int form_width  =    0;
            int form_height =    0;

            bool cr         =    true;
            #endregion
            
            //try catch to make sure user didnt mess the xml file and added characters
            //and other non int (in cr case non boolean value) values into it.
            try {
                baud        = int.Parse(config.AppSettings.Settings["baud"].Value);
                bitRate     = int.Parse(config.AppSettings.Settings["bitRate"].Value);
                parity      = int.Parse(config.AppSettings.Settings["parity"].Value);
                stopBits    = int.Parse(config.AppSettings.Settings["stopBits"].Value);
                form_x      = int.Parse(config.AppSettings.Settings["form_x"].Value);
                form_y      = int.Parse(config.AppSettings.Settings["form_y"].Value);
                form_width  = int.Parse(config.AppSettings.Settings["form_width"].Value);
                form_height = int.Parse(config.AppSettings.Settings["form_height"].Value);
                cr = Boolean.Parse(config.AppSettings.Settings["CR"].Value);
            }
            catch (Exception)
            {
                reint = true;   //if exception caught. reint= true;
            }

            //ifs to check; int values are in range of combobox indexes.
            //protects from naughty users who are trying to break the code
            //by changing the xml values.
            #region range check for int values
            if (baud > 13 || baud < 0) reint = true;
            if (bitRate> 3 ||bitRate < 0) reint = true;
            if (parity > 4 || parity < 0) reint = true;
            if (stopBits > 3 || stopBits < 0) reint = true;
            if (form_width < 400) reint = true;
            if (form_height < 400) reint = true;
            #endregion

            //if something is messed up (reint == true)
            if (reint)
            {
                //show error/info message and call initSettings() which will reset
                //the values to default
                MessageBox.Show("Something is wrong with the config file!\nFirst time running the application or\ncorrupt config file. Fixed it for ya!", "");
                initSettings();
            }
            else
            {
                //if everything is right set the values taken from
                //xml file to the comboBoxes, form x,y,width etc..
                #region Setup form according to xml file values
                baudComboBox.SelectedIndex = baud;
                bitRateComboBox.SelectedIndex = bitRate;
                parityComboBox.SelectedIndex = parity;
                stopBitsComboBox.SelectedIndex = stopBits;
                checkBoxCR.Checked = cr;
                this.Left = form_x;
                this.Top = form_y;
                this.Height = form_height;
                this.Width = form_width;
                #endregion
            }
        }

        /// <summary>
        /// SAVES CURRENT SESSION SETTINGS SO THAT THEY CAN BE LOADED
        /// WHEN THE APP RUNS AGAIN.
        /// </summary>
        public void saveCurrentSessionSettings() {

            config.AppSettings.Settings.Clear();

            #region set variables
            String baudRate     =   baudComboBox.SelectedIndex.ToString();
            String bitRate      =   bitRateComboBox.SelectedIndex.ToString();
            String parity       =   parityComboBox.SelectedIndex.ToString();
            String stopBits     =   stopBitsComboBox.SelectedIndex.ToString();

            String CR           =   checkBoxCR.Checked.ToString();
            String form_height  =   this.Height.ToString();
            String form_width   =   this.Width.ToString();
            String form_x       =   this.Location.X.ToString();
            String form_y       =   this.Location.Y.ToString();
            #endregion

            #region set variables in the config file
            config.AppSettings.Settings.Add("baud", baudRate);
            config.AppSettings.Settings.Add("bitRate", bitRate);
            config.AppSettings.Settings.Add("parity", parity);
            config.AppSettings.Settings.Add("stopBits", stopBits);
            config.AppSettings.Settings.Add("CR", CR);

            config.AppSettings.Settings.Add("form_x", form_x);
            config.AppSettings.Settings.Add("form_y", form_y);

            config.AppSettings.Settings.Add("form_width", form_width);
            config.AppSettings.Settings.Add("form_height", form_height);

            config.Save();
            #endregion

        }

        public Form1()
        {
            InitializeComponent();
            loadPreviousSessionSettings();

            statusBarLabel.Text = "To connect simply select serial port and settings then press connect...";

            disconnectButton.Enabled = false;
            sendButton.Enabled = false;
            msgTextBox.Enabled = false;

            findPorts();

            sp.DataReceived += new SerialDataReceivedEventHandler(serialDataReceived);
        }

        public void rstCounter()
        {
            breakLineCounter = 0;
            labelCounter.Text = "#Count = 0";
        }

        /// <summary>
        /// LIST ALL OF THE AVAILABLE PORTS TO THE PORTSCOMBOBOX
        /// </summary>
        public void findPorts()
        {
            string[] portArray = SerialPort.GetPortNames();
            portsComboBox.Items.Clear();
            portsComboBox.Items.AddRange(portArray);

            if (portArray.Length > 0)
            {
                portsComboBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// SET THE UI SO THAT USER CANT PRESS CONNECT OR SCAN WHILE CONNECTED
        /// TO ANOTHER SERIAL PORT.
        /// </summary>
        public void setConnected()
        {
            scanButton.Enabled = false;
            connectButton.Enabled = false;
            disconnectButton.Enabled = true;
            sendButton.Enabled = true;
            msgTextBox.Enabled = true;
            statusBarLabel.Text = "Connected.";
        }

        /// <summary>
        /// RESET UI SO THAT USER CAN CONNECT TO ANOTHER SERIAL PORT
        /// IF NECESSARY
        /// </summary>
        public void setDisconnected()
        {
            scanButton.Enabled = true;
            connectButton.Enabled = true;
            disconnectButton.Enabled = false;
            sendButton.Enabled = false;
            msgTextBox.Enabled = false;
            statusBarLabel.Text = "Not Connnected.";
        }

        /// <summary>
        /// WRITES TO SERIAL PORT SAFELY [MEANING: IF THE SERIAL CONNECTION DIED IT
        /// WARNS THE USER THAT CONNECTION DIED AND RESETS THE UI AND THE SERIALPORT
        /// FOR A NEW CONNECTION TO TAKE PLACE.
        /// </summary>
        /// <param name="msg">MESSAGE WHICH WILL BE SENT TO THE SERIAL DEVICE</param>
        public void safeWrite(string msg)
        {
            try
            {
                sp.Write(msg);
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

        private void button1_Click(object sender, EventArgs e)
        {
            findPorts();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            #region init variables from combobox values
            //get baud rate selected
            String baudRateSelected = baudComboBox.SelectedItem.ToString();

            /*  Parity.None = 0
             *  Parity.Odd = 1
             *  Parity.Even = 2
             *  Parity.Mark = 3
             *  Parity.Space = 4
             *  The collection is setup this order so none is index 0 in 
             *  combobox. therefore the index can directly be used. */
            int paritySelected = parityComboBox.SelectedIndex;

            /*
             *  stopbits.none            =   0 
             *  stopbits.one             =   1
             *  stopbits.two             =   2
             *  stopbits.one point five  =   3
             *
             *  same system with parity selection.   
             */

            int stopBitsSelected = stopBitsComboBox.SelectedIndex;
            #endregion

            //check if a com port is selected
            if (portsComboBox.SelectedItem != null)
            {
                #region Get selected port name and initialize it into a variable
                /* get selected port name from combobox and place it into variable for further use
                 * [needs to be inside if statement because if combobox is empty, checking selected
                 * item will crash the program]
                 */
                String portSelected = portsComboBox.SelectedItem.ToString();
                #endregion

                #region Set all necesarry settings before attempting to connect.

                sp.BaudRate = int.Parse(baudRateSelected);//set baud rate taken from the combobox
                sp.PortName = portSelected;                     //set port name to combobox selection
                sp.Parity = (Parity)paritySelected;            //set parity to the variable setupped earlier.
                #endregion

                #region Set Stop Bits
                //when 0 is entered to stop bits for some reason program crashes.
                //even though StopBits.None is equal to 0. Investigate!
                //the below is temp solution (stop bits are 0 by default[assumption])
                //FIXME
                if (stopBitsSelected > 0)
                {
                    sp.StopBits = (StopBits)stopBitsSelected;
                }
                #endregion

                #region Set bit rate
                //set data bits to combobox index + 5 (bitrate 5 is index 0 therefore (0+5 gives 5 bit rate))
                sp.DataBits = bitRateComboBox.SelectedIndex + 5;
                #endregion

                #region Attempt Connection
                //attempt to connect to serial port and if failed show error message.
                try
                {
                    sp.Open();
                    setConnected();
                }
                catch (System.IO.IOException)
                {
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
            //by default type = 0 meaning its set to ascii
            int type = 0;

            if (radioButtonHex.Checked)
            {
                type = 1; //if hex is selected
            }
            else if (radioButtonBinary.Checked)
            {
                type = 2;//if binary is selected
            }

            #region Overall Processing
            /*invoke because this event is not in main thead. only main thread can change the
             *form items. invoke makes a call to the form thread and form thread does what invoke
             *says. in our case it will write to the history box.
             * 
             *WARNING: MOST OF THE LOGIC CHECK IN THE INVOKE CAN BE TAKEN OUT AND ITS MORE EFFICIENT
             *THAT WAY. BUT LETS BE REAL I AM LAZY...
             */
            Invoke(new Action(() =>
            {
                //read received message
                string s = sp.ReadExisting();
                foreach (char chr in s)
                {   //split text into chars and for each char do the following:

                    String character = "";
                    #region Processing Chr into Binary,Hex,Ascii
                    switch (type)
                    {
                        case 1:
                            //convert char to base16 (hexadecimal) and then make it upper case (visual touch. so ABCDEF becomes uppercase)
                            character = "[0x" + Convert.ToString(chr, 16).ToUpper() + "] ";
                            break;
                        case 2:
                            //convert char to base2 (binary), make it uppercase for ABCDEF
                            character = "[0b" + Convert.ToString(chr, 2).ToUpper() + "] ";
                            break;
                        default:
                            //ascii. convert char to string.
                            character = chr.ToString();
                            break;
                    }
                    #endregion
                    historyBox.Text += character;   //add space to the hex "[0x00] "

                    #region Breakline by user choice
                    int breakLineSetting = (int)numericUpDownBreakline.Value;  //get the breakline value
                    if (breakLineSetting != 0)                  //if its set do the following:
                    {
                        if (breakLineSetting-1 == breakLineCounter)   //if counter is equal to setting
                        {
                            historyBox.Text += "\n";        //break line
                            rstCounter();
                        }
                        else
                        {
                            breakLineCounter++;    //if counter is not equal to setting increment counter
                            labelCounter.Text = "#Count = "+breakLineCounter.ToString();
                        }
                    }
                    #endregion
                }
            }));
            #endregion
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
            if (checkBoxCR.Checked)
            {
                msg += "\n";
            }
            safeWrite(msg);
            Invoke(new Action(() => sentRichBox.AppendText("[SENT] " + msg)));
        }

        private void msgTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if enter is pressed
            if (e.KeyChar == 13)
            {
                //call sendButton_Click function (with nulls which will pass nothing to the function
                //but still will run the function)
                sendButton_Click(null, null);
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            //disconnect from serial_port and take the
            //necessary UI actions (enable some buttons disable some buttons)
            sp.Close();
            setDisconnected();
        }

        private void buttonResetCounter_Click(object sender, EventArgs e)
        {
            //reset break line counter
            rstCounter();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save the UI values for when next time user
            //starts the program. (loadPreviousSessionSettings() will be called
            //to reload exact properties)
            saveCurrentSessionSettings();
        }
    }
}
