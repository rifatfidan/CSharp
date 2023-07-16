using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How are you");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How are you", "Hello");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How are you", "Hello",MessageBoxButtons.YesNoCancel); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult answer = new DialogResult();
            answer = MessageBox.Show("How are you", "Hello", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            label1.Text = answer.ToString(); //need to convert tostring

        }
    }
}
