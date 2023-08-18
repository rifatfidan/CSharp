using Rehber.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbSirket_CheckedChanged(object sender, EventArgs e)
        {
            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            txtAd.Clear();
            txtSoyad.Clear();
            txtSirketUnvan.Enabled = true;
        }

        private void rdbSahis_CheckedChanged(object sender, EventArgs e)
        {
            txtSirketUnvan.Clear();
            txtSirketUnvan.Enabled = false;
            txtAd.Enabled = true;
            txtSoyad.Enabled = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSirketUnvan.Clear();
            txtSirketUnvan.Enabled = false;
            Yukle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            //Control kontrol = txtAd;
            //kontrol.Text = "";
            //groupBox1.Controls.Clear(); bunu yazarsak tüm öğeler silinir.
            foreach (Control item in groupBox1.Controls)
            {
                //item.Visible = false;
                if (item.GetType() == typeof(TextBox))
                {
                    item.Text = "";
                }
            }
        }

        private void Yukle()
        {
            dataGridView1.DataSource = null;
            Kisi model = new Kisi();
            dataGridView1.DataSource = model.Get();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            Kisi model = new Kisi();
            model.Ad = txtAd.Text;
            model.Soyad = txtSoyad.Text;
            model.SirketUnvan = txtSirketUnvan.Text;
            //tur
            if (rdbSahis.Checked)
            {
                model.Turu = 1;
            }
            else
            {
                model.Turu = 2;
            }
            model.Tel1 = txtTel1.Text;
            model.Tel2 = txtTel2.Text;
            model.Fax = txtFax.Text;
            model.Email = txtEmail.Text;
            model.KayitTarih = DateTime.Now;
            model.Web = txtWeb.Text;
            model.Adres = txtAdres.Text;

            model.Insert(model);
            MessageBox.Show("Kayıt Başarılı", "Rehber Kayıt İşlemi");
            Temizle();
            Yukle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Delete();
            Yukle();
        }

        private void Delete()
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            var dosya = new List<string>(File.ReadAllLines("C:\\Users\\PYTHON\\source\\repos\\Rehber\\rehber.txt"));
            dosya.RemoveAt(rowIndex);
            File.WriteAllLines("C:\\Users\\PYTHON\\source\\repos\\Rehber\\rehber.txt",dosya.ToArray());        }
    }
}
