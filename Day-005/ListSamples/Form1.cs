using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSamples
{
    public partial class Form1 : Form
    {
        List<string> courses = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "List Samples";
            label5.Text = "";
            label7.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> days = new List<string>();
            days.Add("Monday");
            days.Add("Tuesday");
            days.Add("Wednesday");
            days.Add("Thursday");
            days.Add("Friday");
            days.Add("Saturday");
            days.Add("Sunday");
            //label1.Text = days[0];     Monday
            label1.Text = "";
            foreach (var item in days)
            {
                label1.Text += item + "\n";
                // in foreach we cant add anything to object like item+=item+1 ...
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> days = new List<string>();
            days.Add("Monday");
            days.Add("Tuesday");
            days.Add("Wednesday");
            days.Add("Thursday");
            days.Add("Friday");
            days.Add("Saturday");
            days.Add("Sunday");

            List<int> numbers = new List<int>();
            for (int i = 1; i <=10; i++)
            {
                numbers.Add(i);
            }

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label1.Text = days.Count.ToString();// give count of list  so 7
            label2.Text = numbers.Count.ToString();//from for loop  10
            foreach (var item in numbers)
            {
                label3.Text += item + "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                numbers.Add(i);
            }
            // remove 5, not remove indis 5 direct remove what u write 
            // if write 0 can not delete anything.
            numbers.Remove(5); 
            foreach (var item in numbers)
            {
                label4.Text += item + "\n";
            }
            //if you want delete with index use RemoveAt
            //numbers.RemoveAt(2);
            //for clear all list  numbers.Clear();
            // search in List numbers.Contains()
            if (numbers.Contains(7))
            {
                MessageBox.Show("There is that item (7) in this list ");
            }
            // for reverse list  
            numbers.Reverse();
            label3.Text = "";
            foreach (var item2 in numbers)
            {
                label3.Text += item2 + "\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && !courses.Contains(textBox1.Text))
            {
                courses.Add(textBox1.Text);
                textBox1.Clear(); //textBox1.Text = ""; can be too
            }
            label5.Text = courses.Count().ToString() + "courses added";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            foreach (var item in courses)
            {
                label7.Text += item + "\n";
            }
        }
    }
}
