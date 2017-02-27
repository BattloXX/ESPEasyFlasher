using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashESP8266
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] ports = SerialPort.GetPortNames();
            foreach (var port in ports)
            {
                cbx_serial.Items.Add(port);
                cbx_serial.Text = port;
            }

            string[] fileArray = Directory.GetFiles(@".", "*.bin");
            foreach (var files in fileArray)
            {
                //files.Replace(@".\", "");
                cbx_firmware.Items.Add(files);
            }

            cbx_firmware.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_serial.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void bttn_flash_Click(object sender, EventArgs e)
        {
            string serial = this.cbx_serial.GetItemText(this.cbx_serial.SelectedItem);
            string firmware = this.cbx_firmware.GetItemText(this.cbx_firmware.SelectedItem);

            if (serial == "")
            {
                MessageBox.Show("Please select Com-Port!");
            }
            if (firmware == "")
            {
                MessageBox.Show("Please select Firmware!");
            }

            if (firmware != "" & serial != "")
            {

                string arg = "-vv -cd nodemcu -cb 115200 -cp " + serial + " -ca 0x00000 -cf " + firmware;
                string cmd = "esptool.exe";

                Process myProcess = null;

                try
                {
                    // Start the process.
                    myProcess = Process.Start(cmd, arg);

                    // Display the process statistics until
                    // the user closes the program.
                    do
                    {
                        if (!myProcess.HasExited)
                        {
                            // Refresh the current process property values.
                            myProcess.Refresh();

                            if (myProcess.Responding)
                            {
                                
                            }
                            else
                            {
                               
                            }
                        }
                    }
                    while (!myProcess.WaitForExit(1000));

                    if (myProcess.ExitCode != 0)
                    {
                        MessageBox.Show("Flash Failed");
                    }
                    else
                    {
                        MessageBox.Show("Flash Complete");

                    }


                }
                finally
                {
                    if (myProcess != null)
                    {
                        myProcess.Close();
                    }
                }

            }

        }
    }
}
