using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamagotchi_goeie
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer2;
        private int counter;
        // private int _sec = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void timerWelzijn_Tick(object sender, EventArgs e)
        {

            string Anik = lblScore.ToString();
            counter++;
            if (counter == 0)
                timerWelzijn.Stop();
            lblScore.Text = counter.ToString();

            pbDorst.Increment(-1);
            pbHonger.Increment(-1);
            //  pbWelZ.Increment(-1);

            if (pbHonger.Value == 0 || pbDorst.Value == 0)

            {
                pbWelZ.Increment(-1);
            }
            else
            {
                pbWelZ.Increment(+1);
            }

            if (pbWelZ.Value > 50 && pbWelZ.Value <= 100)


            {
                pictureBox1.Image = Properties.Resources.blij;
                pictureBox1.Refresh();
            }
            else if (pbWelZ.Value > 25 && pbWelZ.Value <= 50)


            {
                pictureBox1.Image = Properties.Resources.honger;
                pictureBox1.Refresh();
            }
            else if (pbWelZ.Value > 1 && pbWelZ.Value <= 25)


            {
                pictureBox1.Image = Properties.Resources.ziek;
                pictureBox1.Refresh();
            }
            else if (pbWelZ.Value == 0)
            {

                pictureBox1.Image = Properties.Resources.dede;
                pictureBox1.Refresh();
                timerWelzijn.Stop();
                MessageBox.Show("Uw score is" + lblScore.Text);
                Application.Exit();
            }
            else;


        }

        private void pbWelZ_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerWelzijn = new System.Windows.Forms.Timer();
            timerWelzijn.Tick += new EventHandler(timerWelzijn_Tick);
            timerWelzijn.Interval = 100; // 1 second
            timerWelzijn.Start();
            lblScore.Text = counter.ToString();
        }

        private void btnDrinken_Click(object sender, EventArgs e)
        {
            int getal = 100 - pbDorst.Value;
            if (pbDorst.Value <= 95)
            {
                pbDorst.Value += 5;
            }
            else
            {
                pbDorst.Value += getal;
            }
            pictureBox1.Image = Properties.Resources.sehh;
        }

        private void btnEten_Click(object sender, EventArgs e)
        {
            int getal = 100 - pbHonger.Value;
            if (pbHonger.Value <= 95)
            {
                pbHonger.Value += 5;
            }
            else
            {
                pbHonger.Value += getal;
            }

            pictureBox1.Image = Properties.Resources.sehh;
        }
    }
}
