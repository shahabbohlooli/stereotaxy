using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stereotaxy
{
    public partial class core : Form
    {
        public core()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about frm2 = new about();
            frm2.ShowDialog();
        }

        private void controlPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Main frm = new Main();
            frm.ShowDialog();
            
        }

        private void contentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Default.chm");
        }

        private void core_Load(object sender, EventArgs e)
        {
           // Main frm = new Main();
           // frm.ShowDialog();
            
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            config frm = new config();
            frm.ShowDialog();
        }
    }
}
