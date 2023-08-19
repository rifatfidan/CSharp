using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringTypes_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            string ad = textBox1.Text;
            foreach (char item in ad)
            {
                label1.Text += item + "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            label1.Text = sayi.ToString(); //ya da  başa 
            label1.Text = Convert.ToString(sayi);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string ifadeyi kopyalamak için clone
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            textBox2.Text = (s1.Clone()).ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ToLower ve ToUpper Büyük Küçük Harf
            label1.Text = textBox1.Text.ToUpper();
            label1.Text = textBox1.Text.ToLower();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string haberBaslik = "Edukey Kursları Yeni Dönemde Yayında";
            label1.Text = haberBaslik.Substring(5); // y Kursları .....
            label1.Text = haberBaslik.Substring(5,5); // y Kur  5. kartakterden sonra 5 karakter aldı

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //EndsWith ve StartsWith Büyük küçük harfe duyarlı
            string adi = "Edukey";
            if (adi.StartsWith(textBox1.Text))
            {
                label1.Text = "Var";
            }
            else
            {
                label1.Text = "Yok";
            }

            
            if (adi.EndsWith(textBox2.Text))
            {
                label1.Text = "Var";
            }
            else
            {
                label1.Text = "Yok";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string ad = "Edukey";
            label1.Text = ad.Insert(3, textBox1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //kullanıcı ne girerse girsin 6 karakterden gerisini gösterme alma
            string ad = textBox1.Text;
            label1.Text = ad.Remove(6);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string tarih = "13-11-1981";
            textBox2.Text = tarih.Replace("-", "/");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string kurslar = textBox1.Text;
            string[] kurs = kurslar.Split(' ');
            foreach (var item in kurs)
            {
                label1.Text += item + "\n";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Trim sağda solda boşlukları siler
            //TrimEnd   sondakileri siler
            //TrimStart baştakileri siler
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            label1.Text = ad;
            label2.Text = ad.Trim();

        }
    }
}
