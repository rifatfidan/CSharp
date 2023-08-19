using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeSample
{
    public partial class Form1 : Form
    {
        DateTime zaman = new DateTime();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zaman = DateTime.Now;
            label1.Text = "Saat ve Tarih : "+ zaman.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = dateTimePicker1.Value.ToString();
            //ToString() içine parametre yazabiliriz.
            label2.Text = dateTimePicker1.Value.ToString("MMM");
            //https://caylakyazilimci.com/post/tarih-ve-saat-islemleri

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ayın kaçıncı günü
            label2.Text = zaman.Day.ToString();
            label2.Text += "-";
            //Haftanın hangi günü
            label2.Text += zaman.DayOfWeek.ToString();
            label2.Text += "-";
            //Yılın kaçıncı günü
            label2.Text += zaman.DayOfYear.ToString();
            label2.Text += "\n\n";
            label2.Text += zaman.Month.ToString();
            label2.Text += "-";
            label2.Text += zaman.Year.ToString();
            label2.Text += "\n\n";
            label2.Text += zaman.Hour.ToString();
            label2.Text += "-";
            label2.Text += zaman.Minute.ToString();
            label2.Text += "-";
            label2.Text += zaman.Second.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = zaman.AddDays(1).ToString()+"\n\n"; //güne bir ekler
            label2.Text += zaman.AddMonths(1).ToString() + "\n\n"; //aya bir ekler
            label2.Text += zaman.AddYears(1).ToString() + "\n\n"; //yıla bir ekler
            label2.Text += zaman.AddHours(1).ToString() + "\n\n"; //yıla bir ekler
            label2.Text += "\n\n";
            label2.Text += zaman.ToLongDateString().ToString() + "\n\n";
            label2.Text += zaman.ToShortDateString().ToString() + "\n\n";
            label2.Text += zaman.ToLongTimeString().ToString() + "\n\n";
            label2.Text += zaman.ToShortTimeString().ToString() + "\n\n";
            label2.Text += DateTime.DaysInMonth(1980, 11).ToString(); //o ay ve yılda ay kaç çeker verir.

            
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime dTarih = dateTimePicker1.Value;
            DateTime suan = DateTime.Now;
            TimeSpan ts = suan - dTarih;
            int say = Convert.ToInt32(ts.TotalDays);
            label1.Text = say.ToString();
        }
    }
}
