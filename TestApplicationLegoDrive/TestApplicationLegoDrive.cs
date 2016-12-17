using EV3MessengerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApplicationLegoDrive
{
    public partial class TestLegoDrive : Form
    {
        private EV3Messenger messenger;
        EV3Message message;
        int ok = 1; //idle , before pressing first Drive button
        int hand = 1; //idle hand, before pressing first Grab or Drop buttons

        public TestLegoDrive()
        {
            InitializeComponent();
            // Init application
            messenger = new EV3Messenger();
            fillSerialPortSelectionBoxWithAvailablePorts();
            updateFormGUI();
        }

        #region Connection
        private void refreshButton_Click(object sender, EventArgs e)
        {
            fillSerialPortSelectionBoxWithAvailablePorts();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            // Check if a port has been selected
            if (portListBox.SelectedIndex > -1)
            {
                // Get the selected port from the ListBox
                string port = portListBox.SelectedItem.ToString().ToUpper();
                // Try to connect with the Brick via the selected port
                if (messenger.Connect(port))
                {
                    updateFormGUI();

                }
                else
                {
                    MessageBox.Show("Failed to connect to serial port '" + port + "'.\n"
                        + "Make sure your robot is connected to that serial port and try again.");
                }
            }
            else
            {
                MessageBox.Show("Please select a port for the bluetooth connection");
            }

            timer1.Interval = 1000;
            timer1.Start();
        }
        private void disconnectButton_Click(object sender, EventArgs e)
        {
            // Disconnect from the Brick
            messenger.Disconnect();

            updateFormGUI();
            timer1.Stop();
        }
        private void fillSerialPortSelectionBoxWithAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);

            portListBox.Items.Clear();
            foreach (String port in ports)
            {
                portListBox.Items.Add(port);
            }
        }
        #endregion
        #region GUI
        private void updateFormGUI()
        {
            if (messenger.IsConnected)
            {
                refreshButton.Enabled = false;
                connectButton.Enabled = false;

                disconnectButton.Enabled = true;
                driveGroupBox.Enabled = true;
                statusGroupBox.Enabled = true;

                statusListBox.Items.Clear();
            }
            else
            {
                refreshButton.Enabled = true;
                connectButton.Enabled = true;

                statusGroupBox.Enabled = false;
                driveGroupBox.Enabled = false;
                disconnectButton.Enabled = false;
            }
        }
        #endregion
        #region Control
        private void btGrab_Click(object sender, EventArgs e)
        {
            // Send a message to the Brick with title: MESSAGE and the message
            if (messenger.SendMessage("MESSAGE", "Grab"))
            { }
            else
            {
                MessageBox.Show("Unable to send the message to the Brick. Please try again.");
            }
            hand = 2; 
        }

        private void btDrop_Click(object sender, EventArgs e)
        {
            // Send a message to the Brick with title: MESSAGE and the message
            if (messenger.SendMessage("MESSAGE", "Drop"))
            { }
            else
            {
                MessageBox.Show("Unable to send the message to the Brick. Please try again.");
            }
            hand = 3;
        }
        private void driveButton_Click(object sender, EventArgs e)
        {
            // Send a message to the Brick with title: MESSAGE and the message
            if (messenger.SendMessage("MESSAGE", "Drive"))
            {

            }
            else
            {
                MessageBox.Show("Unable to send the message to the Brick. Please try again.");
            }

            ok = 2;
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            // Send a message to the Brick with title: MESSAGE and the message
            if (messenger.SendMessage("MESSAGE", "Stop"))
            {
                
            }
            else
            {
                MessageBox.Show("Unable to send the message to the Brick. Please try again.");
            }
            ok = 3;
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ok == 1)
            {
                statusListBox.Items.Add("Status: Idle");
                // Auto scroll the listbox
                statusListBox.TopIndex = statusListBox.Items.Count - 1;
            }
            else
            {
                // Try to get a message
                message = messenger.ReadMessage();
                // Check if there is a message received from the Brick
                if (message != null)
                {
                    if (message.ValueAsText.Contains("Drive"))
                    {
                        statusListBox.Items.Add("Status: Driving");
                    }

                    else if (message.ValueAsText.Contains("Stop"))
                    {
                        statusListBox.Items.Add("Status: Stopped");
                    }
                    // Auto scroll the listbox
                    statusListBox.TopIndex = statusListBox.Items.Count - 1;
                }
                else
                {
                    if (ok == 2) //drive
                    {
                        statusListBox.Items.Add("Status: Driving");
                        // Auto scroll the listbox
                        statusListBox.TopIndex = statusListBox.Items.Count - 1;
                    }
                    if (ok == 3) //Idle
                    {
                        statusListBox.Items.Add("Status: Stoped");
                        // Auto scroll the listbox
                        statusListBox.TopIndex = statusListBox.Items.Count - 1;
                        statusListBox.Items.Add("Status: Idle");
                        statusListBox.TopIndex = statusListBox.Items.Count - 1;
                    }


                }

            }
            if (hand == 1)
            {
                statusListBox.Items.Add("Status: Idle Hand");
                // Auto scroll the listbox
                statusListBox.TopIndex = statusListBox.Items.Count - 1;
            }
            else
            {
                // Try to get a message
                message = messenger.ReadMessage();
                // Check if there is a message received from the Brick
                if (message != null)
                {
                    if (message.ValueAsText.Contains("Grab"))
                    {
                        statusListBox.Items.Add("Status: Container Grabbed");
                    }

                    else if (message.ValueAsText.Contains("Drop"))
                    {
                        statusListBox.Items.Add("Status: Container Dropped");
                    }
                    // Auto scroll the listbox
                    statusListBox.TopIndex = statusListBox.Items.Count - 1;
                }
                else
                {
                    if (hand == 2) //pick up
                    {
                        statusListBox.Items.Add("Status: Container Grabbed");
                        // Auto scroll the listbox
                        statusListBox.TopIndex = statusListBox.Items.Count - 1;
                        hand = 1;
                        statusListBox.Items.Add("Status: Idle");
                        statusListBox.TopIndex = statusListBox.Items.Count - 1;

                        
                    }
                    if (hand == 3) //Idle
                    {
                        statusListBox.Items.Add("Status: Container Dropped");
                        // Auto scroll the listbox
                        statusListBox.TopIndex = statusListBox.Items.Count - 1;
                        hand = 1;
                        statusListBox.Items.Add("Status: Idle");
                        statusListBox.TopIndex = statusListBox.Items.Count - 1;
                    }


                }

            }
        }
        }
    #endregion

}
