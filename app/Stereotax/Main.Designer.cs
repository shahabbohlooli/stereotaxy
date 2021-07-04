namespace Stereotaxy
{

    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboPort = new System.Windows.Forms.ComboBox();
            this.buttonRefreshPorts = new System.Windows.Forms.Button();
            this.Conn = new System.Windows.Forms.Button();
            this.messageBx = new System.Windows.Forms.TextBox();
            this.Disconn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sendBx = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.enSteppers = new System.Windows.Forms.Button();
            this.disSteppers = new System.Windows.Forms.Button();
            this.X_axis = new System.Windows.Forms.TextBox();
            this.Y_axis = new System.Windows.Forms.TextBox();
            this.X_label = new System.Windows.Forms.Label();
            this.Y_label = new System.Windows.Forms.Label();
            this.Z_axis = new System.Windows.Forms.TextBox();
            this.Z_label = new System.Windows.Forms.Label();
            this.Comm_log = new System.Windows.Forms.Label();
            this.x_unit = new System.Windows.Forms.Label();
            this.z_unit = new System.Windows.Forms.Label();
            this.y_unit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fBox = new System.Windows.Forms.TextBox();
            this.setHome = new System.Windows.Forms.Button();
            this.drill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // comboPort
            // 
            this.comboPort.FormattingEnabled = true;
            this.comboPort.Location = new System.Drawing.Point(126, 27);
            this.comboPort.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboPort.Name = "comboPort";
            this.comboPort.Size = new System.Drawing.Size(120, 21);
            this.comboPort.TabIndex = 1;
            this.comboPort.SelectedIndexChanged += new System.EventHandler(this.comboPort_SelectedIndexChanged);
            // 
            // buttonRefreshPorts
            // 
            this.buttonRefreshPorts.Location = new System.Drawing.Point(278, 27);
            this.buttonRefreshPorts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonRefreshPorts.Name = "buttonRefreshPorts";
            this.buttonRefreshPorts.Size = new System.Drawing.Size(74, 23);
            this.buttonRefreshPorts.TabIndex = 2;
            this.buttonRefreshPorts.Text = "Refresh";
            this.buttonRefreshPorts.UseVisualStyleBackColor = true;
            this.buttonRefreshPorts.Click += new System.EventHandler(this.buttonRefreshPorts_Click);
            // 
            // Conn
            // 
            this.Conn.Location = new System.Drawing.Point(748, 33);
            this.Conn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Conn.Name = "Conn";
            this.Conn.Size = new System.Drawing.Size(74, 23);
            this.Conn.TabIndex = 3;
            this.Conn.Text = "Connect";
            this.Conn.UseVisualStyleBackColor = true;
            this.Conn.Click += new System.EventHandler(this.Conn_Click);
            // 
            // messageBx
            // 
            this.messageBx.Location = new System.Drawing.Point(98, 430);
            this.messageBx.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.messageBx.Multiline = true;
            this.messageBx.Name = "messageBx";
            this.messageBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageBx.Size = new System.Drawing.Size(743, 95);
            this.messageBx.TabIndex = 4;
            this.messageBx.TextChanged += new System.EventHandler(this.messageBx_TextChanged);
            // 
            // Disconn
            // 
            this.Disconn.Location = new System.Drawing.Point(748, 64);
            this.Disconn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Disconn.Name = "Disconn";
            this.Disconn.Size = new System.Drawing.Size(74, 23);
            this.Disconn.TabIndex = 5;
            this.Disconn.Text = "Disconnect";
            this.Disconn.UseVisualStyleBackColor = true;
            this.Disconn.Click += new System.EventHandler(this.Disconn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 534);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Coordinates";
            // 
            // sendBx
            // 
            this.sendBx.AcceptsReturn = true;
            this.sendBx.BackColor = System.Drawing.SystemColors.Info;
            this.sendBx.Location = new System.Drawing.Point(174, 534);
            this.sendBx.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sendBx.Name = "sendBx";
            this.sendBx.Size = new System.Drawing.Size(567, 20);
            this.sendBx.TabIndex = 7;
            this.sendBx.WordWrap = false;
            this.sendBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendBx_KeyDown);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(767, 534);
            this.Send.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(74, 23);
            this.Send.TabIndex = 8;
            this.Send.TabStop = false;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // enSteppers
            // 
            this.enSteppers.Location = new System.Drawing.Point(98, 560);
            this.enSteppers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.enSteppers.Name = "enSteppers";
            this.enSteppers.Size = new System.Drawing.Size(108, 23);
            this.enSteppers.TabIndex = 9;
            this.enSteppers.Text = "Enable Motors";
            this.enSteppers.UseVisualStyleBackColor = true;
            this.enSteppers.Click += new System.EventHandler(this.enSteppers_Click);
            // 
            // disSteppers
            // 
            this.disSteppers.Location = new System.Drawing.Point(232, 560);
            this.disSteppers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.disSteppers.Name = "disSteppers";
            this.disSteppers.Size = new System.Drawing.Size(138, 23);
            this.disSteppers.TabIndex = 10;
            this.disSteppers.Text = "Disable Motors";
            this.disSteppers.UseVisualStyleBackColor = true;
            this.disSteppers.Click += new System.EventHandler(this.disSteppers_Click);
            // 
            // X_axis
            // 
            this.X_axis.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X_axis.Location = new System.Drawing.Point(148, 103);
            this.X_axis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.X_axis.Name = "X_axis";
            this.X_axis.ReadOnly = true;
            this.X_axis.Size = new System.Drawing.Size(262, 62);
            this.X_axis.TabIndex = 11;
            // 
            // Y_axis
            // 
            this.Y_axis.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y_axis.Location = new System.Drawing.Point(150, 183);
            this.Y_axis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Y_axis.Name = "Y_axis";
            this.Y_axis.ReadOnly = true;
            this.Y_axis.Size = new System.Drawing.Size(262, 62);
            this.Y_axis.TabIndex = 12;
            // 
            // X_label
            // 
            this.X_label.AutoSize = true;
            this.X_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X_label.Location = new System.Drawing.Point(80, 103);
            this.X_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.X_label.Name = "X_label";
            this.X_label.Size = new System.Drawing.Size(56, 55);
            this.X_label.TabIndex = 13;
            this.X_label.Text = "X";
            // 
            // Y_label
            // 
            this.Y_label.AutoSize = true;
            this.Y_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y_label.Location = new System.Drawing.Point(70, 186);
            this.Y_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Y_label.Name = "Y_label";
            this.Y_label.Size = new System.Drawing.Size(69, 55);
            this.Y_label.TabIndex = 14;
            this.Y_label.Text = " Y";
            // 
            // Z_axis
            // 
            this.Z_axis.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z_axis.Location = new System.Drawing.Point(150, 277);
            this.Z_axis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Z_axis.Name = "Z_axis";
            this.Z_axis.ReadOnly = true;
            this.Z_axis.Size = new System.Drawing.Size(262, 62);
            this.Z_axis.TabIndex = 15;
            // 
            // Z_label
            // 
            this.Z_label.AutoSize = true;
            this.Z_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Z_label.Location = new System.Drawing.Point(89, 280);
            this.Z_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Z_label.Name = "Z_label";
            this.Z_label.Size = new System.Drawing.Size(53, 55);
            this.Z_label.TabIndex = 16;
            this.Z_label.Text = "Z";
            this.Z_label.UseMnemonic = false;
            // 
            // Comm_log
            // 
            this.Comm_log.AutoSize = true;
            this.Comm_log.Location = new System.Drawing.Point(98, 412);
            this.Comm_log.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Comm_log.Name = "Comm_log";
            this.Comm_log.Size = new System.Drawing.Size(25, 13);
            this.Comm_log.TabIndex = 17;
            this.Comm_log.Text = "Log";
            // 
            // x_unit
            // 
            this.x_unit.AutoSize = true;
            this.x_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_unit.Location = new System.Drawing.Point(416, 108);
            this.x_unit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x_unit.Name = "x_unit";
            this.x_unit.Size = new System.Drawing.Size(104, 55);
            this.x_unit.TabIndex = 18;
            this.x_unit.Text = "mm";
            // 
            // z_unit
            // 
            this.z_unit.AutoSize = true;
            this.z_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z_unit.Location = new System.Drawing.Point(416, 277);
            this.z_unit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.z_unit.Name = "z_unit";
            this.z_unit.Size = new System.Drawing.Size(104, 55);
            this.z_unit.TabIndex = 19;
            this.z_unit.Text = "mm";
            // 
            // y_unit
            // 
            this.y_unit.AutoSize = true;
            this.y_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y_unit.Location = new System.Drawing.Point(416, 191);
            this.y_unit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.y_unit.Name = "y_unit";
            this.y_unit.Size = new System.Drawing.Size(104, 55);
            this.y_unit.TabIndex = 20;
            this.y_unit.Text = "mm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(575, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 55);
            this.label3.TabIndex = 22;
            this.label3.Text = "F";
            // 
            // fBox
            // 
            this.fBox.AcceptsReturn = true;
            this.fBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fBox.Location = new System.Drawing.Point(634, 105);
            this.fBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fBox.Name = "fBox";
            this.fBox.Size = new System.Drawing.Size(90, 62);
            this.fBox.TabIndex = 23;
            this.fBox.Text = "100";
            this.fBox.TextChanged += new System.EventHandler(this.fBox_TextChanged);
            // 
            // setHome
            // 
            this.setHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setHome.Location = new System.Drawing.Point(634, 192);
            this.setHome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.setHome.Name = "setHome";
            this.setHome.Size = new System.Drawing.Size(188, 59);
            this.setHome.TabIndex = 24;
            this.setHome.Text = "Set Home";
            this.setHome.UseVisualStyleBackColor = true;
            this.setHome.Click += new System.EventHandler(this.setHome_Click_1);
            // 
            // drill
            // 
            this.drill.BackColor = System.Drawing.SystemColors.Control;
            this.drill.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drill.Location = new System.Drawing.Point(634, 270);
            this.drill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.drill.Name = "drill";
            this.drill.Size = new System.Drawing.Size(188, 59);
            this.drill.TabIndex = 25;
            this.drill.Text = "Drill";
            this.drill.UseVisualStyleBackColor = false;
            this.drill.Click += new System.EventHandler(this.drill_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 611);
            this.Controls.Add(this.drill);
            this.Controls.Add(this.setHome);
            this.Controls.Add(this.fBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.y_unit);
            this.Controls.Add(this.z_unit);
            this.Controls.Add(this.x_unit);
            this.Controls.Add(this.Comm_log);
            this.Controls.Add(this.Z_label);
            this.Controls.Add(this.Z_axis);
            this.Controls.Add(this.Y_label);
            this.Controls.Add(this.X_label);
            this.Controls.Add(this.Y_axis);
            this.Controls.Add(this.X_axis);
            this.Controls.Add(this.disSteppers);
            this.Controls.Add(this.enSteppers);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.sendBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Disconn);
            this.Controls.Add(this.messageBx);
            this.Controls.Add(this.Conn);
            this.Controls.Add(this.buttonRefreshPorts);
            this.Controls.Add(this.comboPort);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Main";
            this.Text = "Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPort;
        private System.Windows.Forms.Button buttonRefreshPorts;
        private System.Windows.Forms.Button Conn;
        private System.Windows.Forms.TextBox messageBx;
        private System.Windows.Forms.Button Disconn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sendBx;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button enSteppers;
        private System.Windows.Forms.Button disSteppers;
        private System.Windows.Forms.TextBox X_axis;
        private System.Windows.Forms.TextBox Y_axis;
        private System.Windows.Forms.Label X_label;
        private System.Windows.Forms.Label Y_label;
        private System.Windows.Forms.TextBox Z_axis;
        private System.Windows.Forms.Label Z_label;
        private System.Windows.Forms.Label Comm_log;
        private System.Windows.Forms.Label x_unit;
        private System.Windows.Forms.Label z_unit;
        private System.Windows.Forms.Label y_unit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fBox;
        private System.Windows.Forms.Button setHome;
        private System.Windows.Forms.Button drill;
    }
}