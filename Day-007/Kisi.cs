using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Rehber.Model
{
    class Kisi
    {
        string baglan = "C:\\Users\\PYTHON\\source\\repos\\Rehber\\rehber.txt";
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string SirketUnvan { get; set; }
        public int Turu { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public DateTime KayitTarih { get; set; }
        public string Web { get; set; }
        public string Adres { get; set; }

        public void Insert(Kisi Model)
        {
            StreamWriter sw = File.AppendText(baglan);
            sw.WriteLine(
                Model.Ad + "$" +
                Model.Soyad + "$" +
                Model.SirketUnvan + "$" +
                Model.Turu + "$" +
                Model.Tel1 + "$" +
                Model.Tel2 + "$" +
                Model.Fax + "$" +
                Model.Email + "$" +
                Model.KayitTarih + "$" +
                Model.Web + "$" +
                Model.Adres
                );

            sw.Close();
            sw.Dispose();
        }

        public List<Kisi> Get()
        {
            List<Kisi> liste = new List<Kisi>();
            StreamReader sr = new StreamReader(baglan);
            string oku = sr.ReadLine();
            while(oku!=null)
            {
                string[] parcala = oku.Split('$');
                Kisi model = new Kisi();
                model.Ad = parcala[0];
                model.Soyad = parcala[1];
                model.SirketUnvan = parcala[2];
                model.Turu = Convert.ToInt32(parcala[3]);
                model.Tel1 = parcala[4];
                model.Tel2 = parcala[5];
                model.Fax = parcala[6];
                model.Email = parcala[7];
                model.KayitTarih = Convert.ToDateTime(parcala[8]);
                model.Web= parcala[9];
                model.Adres= parcala[10];

                liste.Add(model);
                oku = sr.ReadLine();

            }
            sr.Close();
            sr.Dispose();
            return liste;
        }
    }
}
