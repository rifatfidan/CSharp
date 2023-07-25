using MethodSamples.orlon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodSamples
{
    public partial class Form1 : Form
    {
        //Because of tax we use double
        private double Hesap(double fiyat, double kdv=18) //if not use parameter conuting 18 but
            //if use 28 even default is 18   count is 25
        {
            //return (Convert.ToDouble(textBox3.Text) * kdv) / 100;
            return fiyat * kdv / 100;
            // ya da  double sonuc=(Convert.ToDouble(textBox3.Text) * kdv) / 100;
            // return sonuc;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Rifat Fidan");
            nameSurname();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Rifat Fidan");
            nameSurname();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Rifat Fidan");
            nameSurname();
        }

        private void nameSurname() 
        {
            MessageBox.Show("Rifat Fidan");
        }

        private void adSoyad(string ad, string soyad)
        {
            string yaz = ad + " " + soyad;
            MessageBox.Show(yaz);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            adSoyad(textBox1.Text, textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            yaren yaz = new yaren();
            MessageBox.Show(yaz.Topla(10, 13).ToString());
        }

        public void Say() 
        {
            MessageBox.Show("We dont know your name");
        }
        
        public void Say(string name) 
        {
            MessageBox.Show("Your name is : "+name);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Say("Alper");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "Kdv tax ..... : " + Hesap(Convert.ToDouble(textBox3.Text),18).ToString();
        }

        public char First(string name)
        {
            return name[0];
        }

        public int Uzunluk(string name)
        {
            return name.Length;
        }

        public string TersYaz(string name)
        {
            string sonuc = "";
            for (int i = name.Length-1 ; i >= 0; i--)
            {
                sonuc += name[i];
            }
            return sonuc;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = "First alphabet : " + First(textBox4.Text).ToString()+"\n";
            label2.Text += "Length is : " + Uzunluk(textBox4.Text).ToString() + "\n";
            label2.Text += "Reverse the name : " + TersYaz(textBox4.Text).ToString();

        }

        //namespace is like a directory include all our projects


    }
}
