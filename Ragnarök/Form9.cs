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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int nr = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            button1.Visible = false;
            timer1.Enabled = true;
            label3.Visible = true;
            button4.Enabled = true;
            button2.Enabled = true;
            label4.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = false;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            nr++;
            if (nr >= 2)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + r.Next(1,10), pictureBox1.Location.Y);
                if (pictureBox1.Location.X >= pictureBox4.Location.X - 97)
                {
                    label1.Text = "Nu ai reusit sa opresti Ragnarök-ul... Pregateste-te de razboi.. sau oare mai exista alta cale?";
                        label5.Text= "Calatoria in timp... ->";
                    button3.Visible = true;
                    label5.Visible = true;
                    label1.Visible = true;
                    timer1.Enabled = false;
                    button2.Visible = false;
                    button4.Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X + 8, pictureBox2.Location.Y);

            if (timer1.Enabled == false)
            {
                if (pictureBox2.Location.X > pictureBox1.Location.X + 25)
                {
                    timer1.Enabled = true;

                }
            }


            if (pictureBox2.Location.X >= pictureBox4.Location.X - 97)
                {
                    label1.Text = "Ai reusit sa opresti Ragnarök-ul! Ai adus pacea in toate cele 9 taramuri cat si in tot universul!";
                    label1.Visible = true;
                    timer1.Enabled = false;
                    button2.Visible = false;
                    button4.Visible = false;
                }
            
            
        }



        private void button3_Click(object sender, EventArgs e)
        {
            (new Form3()).Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button4.Enabled = false;
             
        }


    }
}
