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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int j=0;
        Random r = new Random();
        string s = " Cuvântul Ragnarok este derivat din vechiul cuvânt nordic Ragnarök, format\ndin două părți : ragna care este genitivul plural al cuvântului regin(„zei” sau\n„conducători”) și rök care înseamnă „soartă”. \nSe mai scrie ca Ragnarøkkr sau Ragnarøk.";

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            button2.Visible = false;
            pictureBox1.Visible = true;
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

   
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s.Length > j)
                label1.Text = label1.Text + s[j];
            else
                timer1.Enabled = false;
            j++;
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X <= 12 - 20 && pictureBox1.Location.X >= 12 - 20 - 20)
            {
                timer2.Enabled = false;
                pictureBox1.Location = new Point(12, pictureBox1.Location.Y);
            }
            pictureBox1.Location = new Point(pictureBox1.Location.X + r.Next(20), pictureBox1.Location.Y);
            
        }
    }
}
