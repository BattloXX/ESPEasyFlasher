using System;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Management;
using System.Windows.Forms;

namespace FlashESP8266
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
  
            //Check Com Ports
            string[] ports = SerialPort.GetPortNames();
            //Check Firmware files
            string[] fileArray = Directory.GetFiles(@".", "*.bin");

            //Fill out the Combobox with serial Ports
            foreach (var port in ports)
            {
                cbx_serial.Items.Add(port);
                cbx_serial.Text = port;
            }

            //Fill out the Combobox with Firmware Files
            foreach (var files in fileArray)
            {
               cbx_firmware.Items.Add(files);
            }

            cbx_firmware.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_serial.DropDownStyle = ComboBoxStyle.DropDownList;
            speed.DropDownStyle = ComboBoxStyle.DropDownList;
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

                string cmd = "esptool.exe";
                //Flash Arguments for the esptool.exe. Change when needed.
                string arg = "--port " + serial + " --baud "+speed.Text+" write_flash 0x0 " + firmware;

                Process myProcess = null;

                try
                {
                    // Start the process.
                    myProcess = Process.Start(cmd, arg);

                    while (!myProcess.WaitForExit(1000));

                    if (myProcess.ExitCode != 0)
                    {
                        MessageBox.Show("Flash Failed with arg" +arg+ " are the Settings correct?");
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
