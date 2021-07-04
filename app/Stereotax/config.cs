using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Stereotaxy
{
    public partial class config : Form
    {
        public config()
        {
            InitializeComponent();
        }

        

        private void Save_Click(object sender, EventArgs e)
        {
            var sw = new StreamWriter("Settings.txt", false);
            sw.WriteLine(sensorLowLimit.Text);
            sw.WriteLine(sensorUpLimit.Text);
            sw.WriteLine(timeInterval.Text);
            sw.WriteLine(drillXoffset.Text);
            sw.WriteLine(drillYoffset.Text);
            sw.WriteLine(drillZleveling.Text);
            sw.WriteLine(drillZstepping.Text);
            sw.WriteLine(drillZsteppingtimer.Text);
            sw.WriteLine(auto_drill.Checked);
            sw.WriteLine(en_force_sensor.Checked);
            sw.Flush();
            sw.Close();
            this.Close();

        }

        private void config_Load(object sender, EventArgs e)
        {
            var sr = new StreamReader("Settings.txt");
            //var lines = sr.ReadToEnd();

            sensorLowLimit.Text = sr.ReadLine().ToString();
            sensorUpLimit.Text = sr.ReadLine().ToString();
            timeInterval.Text = sr.ReadLine().ToString();
            drillXoffset.Text= sr.ReadLine().ToString();
            drillYoffset.Text= sr.ReadLine().ToString();
            drillZleveling.Text = sr.ReadLine().ToString();
            drillZstepping.Text = sr.ReadLine().ToString();
            drillZsteppingtimer.Text = sr.ReadLine().ToString();
            auto_drill.Checked = bool.Parse(sr.ReadLine().ToString());
            en_force_sensor.Checked= bool.Parse(sr.ReadLine().ToString());
            sr.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
