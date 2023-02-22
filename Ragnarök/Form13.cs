using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ragnarök
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        int i = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 5)
            {
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.None;
                pictureBox1.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
            }
            i++;
            if (i == 11)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            if (i == 12)
            { 
            Process.GetProcessesByName("devenv")[0].Kill();
                
        }
        }
    }
}
