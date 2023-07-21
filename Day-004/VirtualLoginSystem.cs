using System;
using System.Drawing;
using System.Windows.Forms;

namespace VirtualLoginSystem
{
    public partial class Form1 : Form
    {
        int wrong = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "DynamicButtonsApp";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    Button newBtn = new Button();
                    newBtn.Text = ((i*3)+j).ToString();// for numbers 123456789
                    this.Controls.Add(newBtn);
                    //newBtn.Width = 50;  we can use it too
                    newBtn.Size = new Size(50, 50);
                    newBtn.Location = new Point(j*50, (i * 50)+25);//+20 increase y and button location change 
                    newBtn.Click += NewBtn_Click;
                }
            }
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            Button numbers = (Button)sender;
            textBox1.Text += numbers.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (textBox1.Text == "")
            {
                label1.Text = "Textbox is empty";
                label1.BackColor = Color.White;
                label1.ForeColor = Color.Black;
            }
            else if (textBox1.Text=="1111")
            {
                label1.Text = "Success";
                label1.BackColor = Color.Green;
                label1.ForeColor = Color.White;
                wrong = 1;
                MessageBox.Show("Success");
            }
            else if (textBox1.Text!="1111" && wrong<=3)
            {
                label1.Text = wrong+".Wrong Password";
                label1.BackColor = Color.Red;
                label1.ForeColor = Color.White;
                textBox1.Text = "";
                wrong++;


            }
            else if (textBox1.Text != "1111" && wrong > 3)
            {
                label1.Text ="System Locked";
                label1.BackColor = Color.Gray;
                label1.ForeColor = Color.LightGray;
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
        }
    }
}
