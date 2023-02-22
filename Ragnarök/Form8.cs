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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        int S = 0, nr = 0;


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nr = nr + 1;
            groupBox1.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                if (S < 7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            nr = nr + 1;
            groupBox1.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                if (S < 7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            S = S + 1;
            nr = nr + 1;
            groupBox2.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                if (S < 7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            nr = nr + 1;
            groupBox2.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                if (S < 7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            nr = nr + 1;
            groupBox2.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                if (S < 7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            S = S + 1;
            nr = nr + 1;
            groupBox3.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                if (S < 7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;
            }

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            nr = nr + 1;
            groupBox3.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                if (S < 7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            nr = nr + 1;
            groupBox3.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                if (S < 7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            S = S + 1;
            nr = nr + 1;
            groupBox4.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                if (S < 7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            nr = nr + 1;
            groupBox4.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                if (S < 7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            nr = nr + 1;
            groupBox4.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                if (S < 7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            S = S + 1;
            nr = nr + 1;
            groupBox5.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                if (S < 7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            nr = nr + 1;
            groupBox5.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                if (S < 7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            nr = nr + 1;
            groupBox5.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                if (S < 7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;
            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            S = S + 1;
            nr = nr + 1;
            groupBox6.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                if (S < 7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            nr = nr + 1;
            groupBox6.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                if (S < 7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            nr = nr + 1;
            groupBox6.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                if (S < 7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;
            }
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            S = S + 1;
            nr = nr + 1;
            groupBox7.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                if (S < 7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;
            }
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            nr = nr + 1;
            groupBox7.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                if (S < 7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;
            }
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            nr = nr + 1;
            groupBox7.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                if (S < 7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            pictureBox19.Visible = true;
            pictureBox20.Visible = true;
            pictureBox21.Visible = true;

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mimir : Sunt impresionat de aptitudinile tale, esti aproape la fel de destept ca mine! Midgard te va tine minte, de acum inainte, drept al doilea cel mai inteligent om in viata!");
                 
      
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            S = S + 1;
            nr = nr + 1;
            groupBox1.Enabled = false;
            if (nr == 7)
            {
                label2.Visible = true;
                label3.Text = S.ToString();
                label3.Visible = true;
                label4.Visible = true;
                
                
                if (S<7)
                    button1.Visible = true;
                if (S == 7)
                    pictureBox22.Visible = true;


            }

        }
    }
}

