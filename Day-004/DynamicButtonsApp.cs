using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicButtonsApp
{
    public partial class Form1 : Form
    {
        private Button[] numberButtons;
        private TextBox txtInput;
        private Button btnLogin;
        private Label lblResult;
        private int wrongAttempts = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void InitializeUI()
        {
            this.Size = new Size(350, 450);
            this.Text = "Login Example";

            // Create number buttons (1 to 9)
            numberButtons = new Button[9];
            int buttonSize = 50;
            int spacing = 5;

            for (int i = 0; i < 9; i++)
            {
                numberButtons[i] = new Button();
                numberButtons[i].Text = (i + 1).ToString();
                numberButtons[i].Size = new Size(buttonSize, buttonSize);
                numberButtons[i].Location = new Point(spacing + (i % 3) * (buttonSize + spacing), spacing + (i / 3) * (buttonSize + spacing));
                numberButtons[i].Click += NumberButtonClick;
                this.Controls.Add(numberButtons[i]);
            }

            // Create TextBox for input
            txtInput = new TextBox();
            txtInput.Size = new Size(buttonSize * 3 + 2 * spacing, buttonSize);
            txtInput.Location = new Point(spacing, 4 * buttonSize + 5 * spacing);
            txtInput.PasswordChar = '*';
            this.Controls.Add(txtInput);

            // Create Login button
            btnLogin = new Button();
            btnLogin.Text = "Login";
            btnLogin.Size = new Size(buttonSize * 3 + 2 * spacing, buttonSize);
            btnLogin.Location = new Point(spacing, 5 * buttonSize + 6 * spacing);
            btnLogin.Click += LoginButtonClick;
            this.Controls.Add(btnLogin);

            // Create Label for result
            lblResult = new Label();
            lblResult.Size = new Size(buttonSize * 3 + 2 * spacing, buttonSize);
            lblResult.Location = new Point(spacing, 6 * buttonSize + 7 * spacing);
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(lblResult);
        }
        private void NumberButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            txtInput.Text += clickedButton.Text;
        }

        private void LoginButtonClick(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                lblResult.Text = "Textbox is empty";
                lblResult.ForeColor = Color.Black;
                lblResult.BackColor = Color.White;
            }
            else if (txtInput.Text == "1111")
            {
                lblResult.Text = "Success";
                lblResult.ForeColor = Color.White;
                lblResult.BackColor = Color.Green;
                DisableButtonsAndTextbox();
            }
            else
            {
                lblResult.Text = (wrongAttempts+1) + " Failed";
                lblResult.ForeColor = Color.White;
                lblResult.BackColor = Color.Red;
                txtInput.Text = "";
                wrongAttempts++;
                if (wrongAttempts >= 3)
                {
                    lblResult.Text = "System Locked";
                    DisableButtonsAndTextbox();
                }
            }
        }

        private void DisableButtonsAndTextbox()
        {
            txtInput.Enabled = false;
            btnLogin.Enabled = false;

            foreach (Button button in numberButtons)
            {
                button.Enabled = false;
            }
        }
    }
}
