using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

// 4 textbox 3 label 2 button create

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            label1.Text = "";
            label2.Text = "";

            for (int i = 0; i < name.Length; i++)
            {
                label1.Text += surname+"\n";
            }

            for (int i = 0; i < surname.Length; i++)
            {
                label2.Text += name + "\n";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int t1, t2, total = 0;
            t1 = Convert.ToInt32(textBox3.Text);
            t2 = Convert.ToInt32(textBox4.Text);

            for (int i = t1; i <= t2; i++)
            {
                total += i;
            }
            label3.Text = "Result....: " + total.ToString();
        }
    }
}
