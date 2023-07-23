using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerSamples
{
    public partial class Form1 : Form
    {
        int sayac=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random uret = new Random();
            int x = uret.Next(12, 200); //we can say for form size int x = uret.Next(this.Width); 
            int y = uret.Next(12, 200); //we can say for form size  int y = uret.Next(this.Width);
            button1.Location = new Point(x, y);

        }



        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            timer1.Interval -= 100;//every click decrease 100ms  so going fast, not wait much
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            sayac = 0;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            sayac = 0;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac % 2 == 1)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.Blue;

            }
        }
    }
}
