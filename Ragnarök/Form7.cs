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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        string s = "  Vor exista câteva semne de avertizare dacă Ragnarök,\n„sfârșitul lumii”, va veni. Primul semn este uciderea zeului\nBaldr, fiul lui Odin și Frigg.";
        string r = " Al doilea semn vor fi trei ierni\nlungi și reci, neîntrerupte, care\nvor dura trei ani, fără vară între\nele. Numele acestor ierni\nneîntrerupte este\n„Fimbulwinter”. In acești trei\nani lungi, lumea va fi afectată\nde războaie, iar frații se vor\nucide intre ei.";
        string p = " Al treilea semn va fi cei doi\nlupi (Sköll si Hati) de pe cer\ncare înghit soarele și luna.\nChiar și stelele vor dispărea\nși vor trimite lumea într-un\nmare întuneric.";
        int j = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Visible = true;
            
            
            pictureBox2.Visible = true;
            
            button1.Visible = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            label1.Visible = true;
            label1.Text = label1.Text + s[j];
            j++;
            if (s.Length==j)
            {
                timer1.Enabled = false;
                label1.ForeColor = Color.Brown;
                timer2.Enabled = true;
                j = 0;

            }    
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            label2.Visible = true;
            label2.Text = label2.Text + r[j];
            j++;
            if (r.Length == j)
            {
                timer2.Enabled = false;
                label2.ForeColor = Color.Blue;
                timer3.Enabled = true;
                j = 0;

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            label3.Visible = true;
            label3.Text = label3.Text + p[j];
            j++;
            if (p.Length == j)
            {
                
                label3.ForeColor = Color.Orange;
                timer3.Enabled = false;
                

            }
        }
    }
}
