using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            //string php;
            //php = "PHP";
            string[] courses = { "Jquery", "Javascript", "Bootsrap", "C#", "Scratch" };
            label1.Text = "3rd index"+courses[3].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            string[] courses = { "Jquery", "Javascript", "Bootsrap", "C#", "Scratch" };
            for (int i = 0; i < courses.Length; i++)
            {
                label1.Text += courses[i].ToString() + "\n";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            //we knows items
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            // we dont know items
            int[] nomor = new int[6];
            nomor[5] = 10; // direct create with array
            label1.Text = nomor[5].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            label1.Text = "";
            //for (int i = 0; i < name.Length; i++)
            //{
            //    label1.Text += name[i].ToString()+"\n";
            //}
            foreach (var character in name)
            {
                label1.Text += character + "\n";
            }
            
        }

        private void copy_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int[] numero = { 5, 21, 36, 3, 24, 125, 659 };
            int[] newnumero = new int[4]; // 4 place empty  now we will copy from numero array
            Array.Copy(numero, newnumero, 4);
            label2.Text = newnumero[0].ToString()+"\n"; // can see 5

            foreach (int item in newnumero)
            {
                label2.Text += item.ToString() + " ";
            }
        }

        private void indexof_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int[] numero = { 5, 21, 36, 3, 24, 125, 659 };
            // cant find  return -1, find give indis number
            label2.Text = Array.IndexOf(numero, 24).ToString();
            if (Array.IndexOf(numero, 24)!= -1)
            {
                label2.Text = "You found";
            }
            else
            {
                label2.Text = "Unfortuantely";
            }


        }

        private void reverse_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int[] numero = { 5, 21, 36, 24, 125, 3, 659 };
            Array.Reverse(numero); // there is no sort in reverse, just reverse the array
            for (int i = 0; i < numero.Length; i++)
            {
                label2.Text += numero[i].ToString() + "\n";
            }
        }

        private void sort_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            int[] numero = { 5, 21, 36, 24, 125, 3, 659 };
            Array.Sort(numero);//sort is starting the array from small to high

            foreach (int item in numero)
            {
                label2.Text += item.ToString() + "\n";
            }
        }
    }
}
