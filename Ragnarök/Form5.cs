using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ragnarök
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int i = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            label1.Visible = true;
            pictureBox1.Visible = true;
            timer1.Enabled = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 1)
                pictureBox1.Image = Properties.Resources._5;
            if (i == 2)
                pictureBox1.Image = Properties.Resources._6;
            if (i == 3)
                pictureBox1.Image = Properties.Resources._7;
            if (i == 4)
                pictureBox1.Image = Properties.Resources._8;
            if (i == 5)
                pictureBox1.Image = Properties.Resources._9;
            if (i == 6)
                pictureBox1.Image = Properties.Resources._10;
            if (i == 7)
                pictureBox1.Image = Properties.Resources._11;
            if (i == 8)
                pictureBox1.Image = Properties.Resources._12;
            if (i == 9)
                pictureBox1.Image = Properties.Resources._13;
            if (i == 10)
            { pictureBox1.Image = Properties.Resources._14;
                i = 0; }
            i++;


        }

    }
}
