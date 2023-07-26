using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSamples
{
    public partial class Form1 : Form
    {
        public void Listed()
        {
            lblNameList.Text = "";
            lblAuthorList.Text = "";
            lblPublisherList.Text = "";
            lblPriceList.Text = "";

            StreamReader sr = new StreamReader("C:\\PYTHON\\book.txt");
            string oku2 = sr.ReadLine();
            while (oku2 != null)
            {
                string[] parcala2 = oku2.Split('$');
                //Method 1
                //foreach (var item in parcala2)
                //{
                //    lblListed.Text += item + " ";
                //}
                //lblListed.Text += "\n";

                //Method 2
                lblNameList.Text += parcala2[0] + "\n";
                lblAuthorList.Text += parcala2[1] + "\n";
                lblPublisherList.Text += parcala2[2] + "\n";
                lblPriceList.Text += parcala2[3] + "\n";

                oku2 = sr.ReadLine();

            }
            sr.Close();
            sr.Dispose();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            //for use streamreader  we add system.io
            //we give path but use \ again for not error
            StreamReader sr = new StreamReader("C:\\PYTHON\\file.txt");
            string oku = sr.ReadLine();
            label1.Text = oku + "\n \n"; ;
            //for read multiline from file
            while (oku!=null)
            {
                label1.Text += oku + "\n";
                // for read one line again
                oku = sr.ReadLine();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            button2.Visible = false;
            StreamReader sr = new StreamReader("C:\\PYTHON\\courses.txt");
            string oku = sr.ReadLine();
            
            while (oku != null)
            {
                string[] parcala = oku.Split('$');
                //foreach (var item in parcala)
                //{
                //    label1.Text += item + "\n";
                //}
                for (int i = 0; i < parcala.Length; i++)
                {
                    label1.Text += i+1 + ". kurs...............: " + parcala[i] + "\n";
                }
                
                oku = sr.ReadLine();
                sr.Close(); //file must close
                sr.Dispose(); //all source close
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText("C:\\PYTHON\\cities.txt");
            sw.WriteLine(textBox1.Text);
            textBox1.Text = "";
            sw.Close(); 
            sw.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText("C:\\PYTHON\\book.txt");
            string kayit = textBox2.Text + "$" + textBox3.Text + "$" + textBox4.Text + "$" + textBox5.Text;
            sw.WriteLine(kayit);
            sw.Close();
            sw.Dispose();

            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            Listed();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lblListed.Text = "";
            StreamReader sr = new StreamReader("C:\\PYTHON\\book.txt");
            string oku2 = sr.ReadLine();
            while (oku2!=null)
            {
                string[] parcala2 = oku2.Split('$');
                //Method 1
                foreach (var item in parcala2)
                {
                    lblListed.Text += item + " ";
                }
                lblListed.Text += "\n";
                oku2 = sr.ReadLine();

            }
            sr.Close();
            sr.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listed();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listed();
        }
    }
}
