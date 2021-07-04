namespace Stereotaxy
{
    partial class config
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
            this.sensorLowLimit = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.timerInterval = new System.Windows.Forms.Label();
            this.timeInterval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sensorUpLimit = new System.Windows.Forms.TextBox();
            this.drillx = new System.Windows.Forms.Label();
            this.drillXoffset = new System.Windows.Forms.TextBox();
            this.drillYoffset = new System.Windows.Forms.TextBox();
            this.drilly = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.drillZleveling = new System.Windows.Forms.TextBox();
            this.drillZstepping = new System.Windows.Forms.TextBox();
            this.drillZsteppingtimer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.auto_drill = new System.Windows.Forms.CheckBox();
            this.en_force_sensor = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sensor Lower Limit:";
            // 
            // sensorLowLimit
            // 
            this.sensorLowLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensorLowLimit.Location = new System.Drawing.Point(201, 46);
            this.sensorLowLimit.Name = "sensorLowLimit";
            this.sensorLowLimit.Size = new System.Drawing.Size(100, 26);
            this.sensorLowLimit.TabIndex = 1;
            this.sensorLowLimit.Text = "8300000";
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(643, 392);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(85, 28);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // timerInterval
            // 
            this.timerInterval.AutoSize = true;
            this.timerInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerInterval.Location = new System.Drawing.Point(57, 113);
            this.timerInterval.Name = "timerInterval";
            this.timerInterval.Size = new System.Drawing.Size(107, 20);
            this.timerInterval.TabIndex = 3;
            this.timerInterval.Text = "Sensor Read:";
            // 
            // timeInterval
            // 
            this.timeInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeInterval.Location = new System.Drawing.Point(201, 109);
            this.timeInterval.Name = "timeInterval";
            this.timeInterval.Size = new System.Drawing.Size(100, 26);
            this.timeInterval.TabIndex = 4;
            this.timeInterval.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sensor Upper Limit:";
            // 
            // sensorUpLimit
            // 
            this.sensorUpLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensorUpLimit.Location = new System.Drawing.Point(201, 79);
            this.sensorUpLimit.Name = "sensorUpLimit";
            this.sensorUpLimit.Size = new System.Drawing.Size(100, 26);
            this.sensorUpLimit.TabIndex = 6;
            this.sensorUpLimit.Text = "8300000";
            // 
            // drillx
            // 
            this.drillx.AutoSize = true;
            this.drillx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drillx.Location = new System.Drawing.Point(56, 172);
            this.drillx.Name = "drillx";
            this.drillx.Size = new System.Drawing.Size(102, 20);
            this.drillx.TabIndex = 7;
            this.drillx.Text = "Drill X Offset:";
            // 
            // drillXoffset
            // 
            this.drillXoffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drillXoffset.Location = new System.Drawing.Point(200, 169);
            this.drillXoffset.Name = "drillXoffset";
            this.drillXoffset.Size = new System.Drawing.Size(100, 26);
            this.drillXoffset.TabIndex = 8;
            this.drillXoffset.Text = "0";
            // 
            // drillYoffset
            // 
            this.drillYoffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drillYoffset.Location = new System.Drawing.Point(200, 199);
            this.drillYoffset.Name = "drillYoffset";
            this.drillYoffset.Size = new System.Drawing.Size(100, 26);
            this.drillYoffset.TabIndex = 10;
            this.drillYoffset.Text = "0";
            // 
            // drilly
            // 
            this.drilly.AutoSize = true;
            this.drilly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drilly.Location = new System.Drawing.Point(56, 202);
            this.drilly.Name = "drilly";
            this.drilly.Size = new System.Drawing.Size(102, 20);
            this.drilly.TabIndex = 9;
            this.drilly.Text = "Drill Y Offset:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "msec";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "mm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(302, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "mm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Drill Z Leveling:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Drill Z Stepping:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Drill Z Stepping Timer:";
            // 
            // drillZleveling
            // 
            this.drillZleveling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drillZleveling.Location = new System.Drawing.Point(200, 231);
            this.drillZleveling.Name = "drillZleveling";
            this.drillZleveling.Size = new System.Drawing.Size(100, 26);
            this.drillZleveling.TabIndex = 17;
            this.drillZleveling.Text = "50";
            // 
            // drillZstepping
            // 
            this.drillZstepping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drillZstepping.Location = new System.Drawing.Point(222, 301);
            this.drillZstepping.Name = "drillZstepping";
            this.drillZstepping.Size = new System.Drawing.Size(100, 26);
            this.drillZstepping.TabIndex = 18;
            this.drillZstepping.Text = "0.05";
            this.drillZstepping.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // drillZsteppingtimer
            // 
            this.drillZsteppingtimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drillZsteppingtimer.Location = new System.Drawing.Point(222, 333);
            this.drillZsteppingtimer.Name = "drillZsteppingtimer";
            this.drillZsteppingtimer.Size = new System.Drawing.Size(100, 26);
            this.drillZsteppingtimer.TabIndex = 19;
            this.drillZsteppingtimer.Text = "1000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(50, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(278, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "mm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(278, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "msec";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(52, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 137);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(250, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "mm";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(52, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 105);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // auto_drill
            // 
            this.auto_drill.AutoSize = true;
            this.auto_drill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auto_drill.Location = new System.Drawing.Point(407, 46);
            this.auto_drill.Name = "auto_drill";
            this.auto_drill.Size = new System.Drawing.Size(130, 24);
            this.auto_drill.TabIndex = 24;
            this.auto_drill.Text = "Automatic Drill";
            this.auto_drill.UseVisualStyleBackColor = true;
            // 
            // en_force_sensor
            // 
            this.en_force_sensor.AutoSize = true;
            this.en_force_sensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.en_force_sensor.Location = new System.Drawing.Point(407, 79);
            this.en_force_sensor.Name = "en_force_sensor";
            this.en_force_sensor.Size = new System.Drawing.Size(124, 24);
            this.en_force_sensor.TabIndex = 25;
            this.en_force_sensor.Text = "Force Sensor";
            this.en_force_sensor.UseVisualStyleBackColor = true;
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.en_force_sensor);
            this.Controls.Add(this.auto_drill);
            this.Controls.Add(this.drillZsteppingtimer);
            this.Controls.Add(this.drillZstepping);
            this.Controls.Add(this.drillZleveling);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drillYoffset);
            this.Controls.Add(this.drilly);
            this.Controls.Add(this.drillXoffset);
            this.Controls.Add(this.drillx);
            this.Controls.Add(this.sensorUpLimit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeInterval);
            this.Controls.Add(this.timerInterval);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.sensorLowLimit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "config";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.config_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sensorLowLimit;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label timerInterval;
        private System.Windows.Forms.TextBox timeInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sensorUpLimit;
        private System.Windows.Forms.Label drillx;
        private System.Windows.Forms.TextBox drillXoffset;
        private System.Windows.Forms.TextBox drillYoffset;
        private System.Windows.Forms.Label drilly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox drillZleveling;
        private System.Windows.Forms.TextBox drillZstepping;
        private System.Windows.Forms.TextBox drillZsteppingtimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox auto_drill;
        private System.Windows.Forms.CheckBox en_force_sensor;
    }
}