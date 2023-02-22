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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            (new Form2()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new Form4()).Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            (new Form5()).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new Form6()).Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            (new Form7()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new Form8()).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new Form9()).Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 1)
                pictureBox1.Image = Properties.Resources._1;
            if (i == 2)
                pictureBox1.Image = Properties.Resources._2;
            if (i == 3)
                pictureBox1.Image = Properties.Resources._3;
            if (i == 4)
            {
                pictureBox1.Image = Properties.Resources._4;
                i = 0;
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            (new Form12()).Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            (new Form13()).Show();
        }
    }
}
