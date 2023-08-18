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
            catch (Exception)//(Exception error dersek)
            {
                label1.Text = "You made a mistake";
                //label1.Text = error.Message;  
            }
            finally
            {
                //try ya da catch whatever if you want to say the last word  the last action
                //you can write the last code in here 
                MessageBox.Show("All task completed");

            }
        }
    }
}
