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
    public partial class Form10 : Form
    {
        Point start;
        Random r=new Random();
        int i, d;
        public Form10()
        {
            InitializeComponent();
            start = panel2.Location;
            Cursor.Position = PointToScreen(start);
            i=r.Next(10,40);
            d = i;
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == -1)
            {
                timer1.Enabled = false;
               DialogResult rezultat= MessageBox.Show("Nu ai reusit sa il salvezi pe Atreus la timp...\nDin fericire, stii sa calatoresti in timp, asa ca, mai incerci o data?", "Ragnarök", MessageBoxButtons.YesNo);
                if (rezultat == DialogResult.Yes)
                {
                    i = d;
                    timer1.Enabled = true;
                    start = panel2.Location;
                    Cursor.Position = PointToScreen(start);
                }
                else
                    this.Close();

            }

            label5.Text = i.ToString();
            i--;
            

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("Felicitari!\nAi reusit sa il salvezi pe Atreus si sa il invingi pe Thor!", "Ragnarök");
            this.Close();
            
            
        }

        private void Zid(object sender, EventArgs e)
        {
            start = panel2.Location;
            Cursor.Position = PointToScreen(start);
        }
    }
}
