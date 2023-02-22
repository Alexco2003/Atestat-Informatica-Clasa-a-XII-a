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
    public partial class Form2 : Form
    {

        int j = 0;
        
        string s = "  În mitologia nordică, Ragnarök, adică soarta finală a zeilor, este o serie de evenimente majore, inclusiv o mare bătălie prezisă care va avea ca rezultat final moartea unui număr semnificativ de figuri majore (inclusiv zeii Odin, Thor, Freyr, Heimdall și Loki), dezastre naturale diverse și scufundarea ulterioară a lumii în apă. Se spune că această bătălie va fi purtată de zei (Aesir, conduși de Odin) și de giganți (Jötunnii) și diverși monștri, conduși de Loki si Surtr. Acest zeu va fi, împreună cu copiii săi, lupul Fenrir și șarpele Jormungand, de partea gigantilor. Nu numai că majoritatea zeilor, uriașilor și monștrilor vor muri în această luptă, dar aproape tot ce este în univers va fi distrus.";
       
        public Form2()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            button1.Visible = false;
            timer1.Enabled = true;
           
            pictureBox1.Visible = true;

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
           

            
                richTextBox1.Text = richTextBox1.Text + s[j].ToString();
            j++;
            if (s.Length == j)
            {
                richTextBox1.Select(24, 8);

                richTextBox1.SelectionColor = Color.Red;

                richTextBox1.Select(0, 0);
                timer1.Enabled = false;
            }




        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Artboard_1_100_scaled;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.c2fabff661b2eefa6f6d75eadb219915;
        }

    }
}
