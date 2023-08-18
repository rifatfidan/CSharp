using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int s1, s2, top;
                top = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
                label1.Text = top.ToString();
            }
            catch (Exception)
            {

                label1.Text = "Hata yapiyorsun";
            }
        }
    }
}
