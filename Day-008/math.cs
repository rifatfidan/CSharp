private void button2_Click(object sender, EventArgs e)
        {
            //round en yakın tam sayıya yuvarlanma ve ondalık ayarlama
            //25,45 - 25     25,69 - 26
            label2.Text = Math.Round(Convert.ToDouble(textBox3.Text)).ToString();
            //ondalık için de
            //100,987654  - 100,99
            label2.Text = Math.Round(Convert.ToDouble(textBox3.Text),2).ToString();
            //ceiling yukarı yuvarlar 25,2 - 26
            label2.Text = Math.Ceiling(Convert.ToDouble(textBox3.Text)).ToString();
            //floor aşağı yuvarlar 25,8 - 25
            label2.Text = Math.Floor(Convert.ToDouble(textBox3.Text)).ToString();
            // Math.Sqrt karekök
            label2.Text = Math.Sqrt(Convert.ToDouble(textBox3.Text)).ToString();

            // negatif,pozitif,0 kontrolü
            label2.Text = Math.Sign(Convert.ToInt32(textBox3.Text)).ToString();

            // Math.Truncate  yalnizca tamsayi kismini döndürür.  25,854 - 25
            label2.Text = Math.Truncate(Convert.ToDouble(textBox3.Text)).ToString();

            // Math.IEEERemainder mod alma işlemi
            label2.Text = Math.IEEERemainder(Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text)).ToString();

            //max , min
            label2.Text = Math.Max(Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text)).ToString();
            label2.Text = Math.Min(Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text)).ToString();



        }
