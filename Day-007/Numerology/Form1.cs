using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerology
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim = txtIsim.Text.ToUpper();
            txtIsim.Text = isim.ToString();
            
            string[] kalip9 = { "I", "İ","R" };
            string[] kalip8 = { "H", "Z" };
            string[] kalip7 = { "G", "Ğ","P","Y" };
            string[] kalip6 = { "O", "Ö","F"};
            string[] kalip5 = { "E", "N"};
            string[] kalip4 = { "D", "M","V"};
            string[] kalip3 = { "C", "Ç","L","U","Ü"};
            string[] kalip2 = { "B", "K","T"};
            string[] kalip1 = { "A", "S","Ş","J"};

            int toplamKalip9 = HesaplaHarfSayisi(isim, kalip9);
            int toplamKalip8 = HesaplaHarfSayisi(isim, kalip8);
            int toplamKalip7 = HesaplaHarfSayisi(isim, kalip7);
            int toplamKalip6 = HesaplaHarfSayisi(isim, kalip6);
            int toplamKalip5 = HesaplaHarfSayisi(isim, kalip5);
            int toplamKalip4 = HesaplaHarfSayisi(isim, kalip4);
            int toplamKalip3 = HesaplaHarfSayisi(isim, kalip3);
            int toplamKalip2 = HesaplaHarfSayisi(isim, kalip2);
            int toplamKalip1 = HesaplaHarfSayisi(isim, kalip1);


            // lblklp9.Text = toplamKalip9.ToString();
            int[] toplamKalip = new int[] { toplamKalip1, toplamKalip2, toplamKalip3, toplamKalip4, toplamKalip5, toplamKalip6, toplamKalip7, toplamKalip8, toplamKalip9 };

            for (int i = 0; i < toplamKalip.Length; i++)
            {
                string lblName = "lblklp" + (i + 1).ToString();
                var label = Controls.Find(lblName, true).FirstOrDefault() as Label;

                if (label != null)
                {
                    label.Text = toplamKalip[i].ToString();
                }
            }

        }

        private int HesaplaHarfSayisi(string metin, string[] kalip)
        {
            int toplamSayi = 0;

            foreach (string harf in kalip)
            {
                toplamSayi += metin.Count(h => h.ToString() == harf);
            }

            return toplamSayi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            does the following:

This line searches for controls on the form by looking for the specified label name. The Controls.Find method searches for controls with the given name and returns an array of matching controls. To target a specific control among these, we use the FirstOrDefault() method. It returns either the first matching control or null if no control is found.

With the as Label expression, we attempt to cast the found control into a Label object. If the found control can be cast to a Label, it is assigned to the label variable. If the found control is not a Label, the label variable remains null.

As a result, if a Label object with the specified label name is found, it is assigned to the label variable, and its text content is cleared (set to an empty string). If the found control is not a Label, the label variable remains null, and no further action is taken.
            */

            for (int i = 1; i <= 9; i++)
            {
                string lblName = "lblklp" + i.ToString();
                var label = Controls.Find(lblName, true).FirstOrDefault() as Label;

                if (label != null)
                {
                    label.Text = "";
                }
            }


            txtIsim.Clear();

        }
    }
}
