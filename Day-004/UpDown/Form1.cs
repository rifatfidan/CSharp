using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int degree=0;
        private void btnUp_Click(object sender, EventArgs e)
        {
            degree++;
            if (degree <= 3)
            {
                
                lblDegree.Text = degree.ToString();
                lblResult.Text = "Low";
            }
            else if (degree > 3 && degree < 5)
            {
                lblDegree.Text = degree.ToString();
                lblResult.Text = "Normal";
            }
            else if (degree >= 5 && degree <= 8)
            {
             
                lblDegree.Text = degree.ToString();
                lblResult.Text = "High";
            }
            else if (degree > 8 && degree <= 10)
            {
                lblDegree.Text = degree.ToString();
                lblResult.Text = "Very High";
            }
            else if (degree > 10)
            {
                degree = 10;
                lblDegree.Text = degree.ToString();
            }

        }

        private void btnDown_Click(object sender, EventArgs e)
        {

            degree--;
            if (degree < 0)
            {
                degree = 0;
                lblDegree.Text = degree.ToString();
            }
            else if (degree <=3)
            {
                
                lblDegree.Text = degree.ToString();
                lblResult.Text = "Low";
            }
            else if (degree > 3 && degree < 5)
            {
                
                lblDegree.Text = degree.ToString();
                lblResult.Text = "Normal";
            }
            else if (degree >= 5 && degree <= 8)
            {
                
                lblDegree.Text = degree.ToString();
                lblResult.Text = "High";
            }
            else if (degree > 8 && degree <= 10)
            {
                
                lblDegree.Text = degree.ToString();
                lblResult.Text = "Very High";
            }
            
        }
    }
}
