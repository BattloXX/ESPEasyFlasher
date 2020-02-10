namespace FlashESP8266
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
            this.bttn_flash = new System.Windows.Forms.Button();
            this.lbl_serial = new System.Windows.Forms.Label();
            this.cbx_serial = new System.Windows.Forms.ComboBox();
            this.lbl_firmware = new System.Windows.Forms.Label();
            this.cbx_firmware = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bttn_flash
            // 
            this.bttn_flash.Location = new System.Drawing.Point(302, 174);
            this.bttn_flash.Name = "bttn_flash";
            this.bttn_flash.Size = new System.Drawing.Size(75, 23);
            this.bttn_flash.TabIndex = 0;
            this.bttn_flash.Text = "Flash";
            this.bttn_flash.UseVisualStyleBackColor = true;
            this.bttn_flash.Click += new System.EventHandler(this.bttn_flash_Click);
            // 
            // lbl_serial
            // 
            this.lbl_serial.AutoSize = true;
            this.lbl_serial.Location = new System.Drawing.Point(12, 37);
            this.lbl_serial.Name = "lbl_serial";
            this.lbl_serial.Size = new System.Drawing.Size(53, 13);
            this.lbl_serial.TabIndex = 1;
            this.lbl_serial.Text = "COM-Port";
            // 
            // cbx_serial
            // 
            this.cbx_serial.FormattingEnabled = true;
            this.cbx_serial.Location = new System.Drawing.Point(98, 34);
            this.cbx_serial.Name = "cbx_serial";
            this.cbx_serial.Size = new System.Drawing.Size(279, 21);
            this.cbx_serial.TabIndex = 2;
            // 
            // lbl_firmware
            // 
            this.lbl_firmware.AutoSize = true;
            this.lbl_firmware.Location = new System.Drawing.Point(12, 81);
            this.lbl_firmware.Name = "lbl_firmware";
            this.lbl_firmware.Size = new System.Drawing.Size(49, 13);
            this.lbl_firmware.TabIndex = 3;
            this.lbl_firmware.Text = "Firmware";
            // 
            // cbx_firmware
            // 
            this.cbx_firmware.FormattingEnabled = true;
            this.cbx_firmware.Location = new System.Drawing.Point(98, 78);
            this.cbx_firmware.Name = "cbx_firmware";
            this.cbx_firmware.Size = new System.Drawing.Size(279, 21);
            this.cbx_firmware.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Upload speed";
            // 
            // speed
            // 
            this.speed.FormattingEnabled = true;
            this.speed.Items.AddRange(new object[] {
                "4800","9600","14400","19200","38400","57600","115200","230400","460800","921600"
            });
            this.speed.SelectedItem = "115200";
            this.speed.Location = new System.Drawing.Point(98, 122);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(121, 21);
            this.speed.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 209);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_firmware);
            this.Controls.Add(this.lbl_firmware);
            this.Controls.Add(this.cbx_serial);
            this.Controls.Add(this.lbl_serial);
            this.Controls.Add(this.bttn_flash);
            this.Name = "Form1";
            this.Text = "ESPEasy Flasher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_flash;
        private System.Windows.Forms.Label lbl_serial;
        private System.Windows.Forms.ComboBox cbx_serial;
        private System.Windows.Forms.Label lbl_firmware;
        private System.Windows.Forms.ComboBox cbx_firmware;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox speed;
    }
}

