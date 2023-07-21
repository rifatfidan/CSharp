using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addObjectWithCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // add new button
            Button ButonBaru = new Button();
            ButonBaru.Text = "Button-1";
            this.Controls.Add(ButonBaru);
            ButonBaru.Location = new Point(50, 50);

            Label LabelBaru = new Label();
            LabelBaru.Text = "Label-1";
            this.Controls.Add(LabelBaru);
            LabelBaru.Location = new Point(50,100);

            TextBox TextBaru = new TextBox();
            TextBaru.Text = "Text New";
            this.Controls.Add(TextBaru);
            TextBaru.Location = new Point(50, 150);

            for (int i = 1; i <= 10; i++)
            {
                Button ButonBaru2 = new Button();
                ButonBaru2.Text = "Button-"+i;
                this.Controls.Add(ButonBaru2);
                ButonBaru2.Location = new Point(200, 25*i);
                ButonBaru2.Click += ButonBaru2_Click;
            }
        }

        private void ButonBaru2_Click(object sender, EventArgs e)
        {
            Button numbers = (Button)sender;
            label1.Text = numbers.Text.ToString();
        }
    }
}
