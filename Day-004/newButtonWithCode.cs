private void Form1_Load(object sender, EventArgs e)
        {
            // add new button
            Button ButonBaru = new Button();
            ButonBaru.Text = "Button-1";
            this.Controls.Add(ButonBaru);
            ButonBaru.Location = new Point(50, 50);

            Label LabelBaru = new Label();
            LabelBaru.Text = "Label-1";
            this.Controls.Add(LabelBaru);
            LabelBaru.Location = new Point(50,100);

            TextBox TextBaru = new TextBox();
            TextBaru.Text = "Text New";
            this.Controls.Add(TextBaru);
            TextBaru.Location = new Point(50, 150);

            for (int i = 1; i <= 10; i++)
            {
                Button ButonBaru2 = new Button();
                ButonBaru2.Text = "Button-"+i;
                this.Controls.Add(ButonBaru2);
                ButonBaru2.Location = new Point(200, 25*i);
            }
        }
