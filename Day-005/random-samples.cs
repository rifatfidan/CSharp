using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int uret = rnd.Next(1, 10);//if we write 100 0-100 numbers can choosen

            label1.Text = uret.ToString();
            if (uret>5)
            {
                label2.Text = "You Win";
                label2.ForeColor = Color.White;
                label2.BackColor = Color.Green;
            }
            else
            {
                label2.Text = "You lost";
                label2.ForeColor = Color.White;
                label2.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(65, 90);
            label2.Text = Convert.ToChar(number).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            Random urt = new Random();

            for (int i = 0; i < 6; i++)
            {
                label3.Text += Convert.ToChar(urt.Next(65,90)).ToString();
                //or we try for lowercase with char
                //label3.Text += ((char)urt.Next('a', 'z')).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int uret;
            int sayac=0;
            int[] numbers = new int[6];

            Random no = new Random();
            label4.Text = "";

            while (sayac<6)
            {
                uret = no.Next(1, 50);
                if (Array.IndexOf(numbers,uret)==-1)
                {
                    numbers[sayac] = uret;
                    sayac++;
                }
            }
            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                label4.Text += item + " - ";
            }

        }
    }
}
