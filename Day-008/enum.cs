using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumLesson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Courses
        {
            Php=1, Bootsrap=2, Javascript=3, Jquery=4, CSharp
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = Courses.CSharp.ToString();
            if (Convert.ToInt32(Courses.Bootsrap) == 2)
            {
                label1.Text = "True";
            }
            else
            {
                label1.Text = "Error";
            }

            //if no need to convert  integer and if want to use string we can use that below code
            label1.Text = Enum.GetName(typeof(Courses), 2);

            //there is a code GetNames too   make is array
            string[] mycourses = Enum.GetNames(typeof(Courses));
            foreach (var item in mycourses)
            {
                label1.Text += item + "\n";
            }

            //IsDefined  We can check in enum  
            if (Enum.IsDefined(typeof(Courses),"CSharp"))
            {
                label1.Text = "There is";
            }
            else
            {
                label1.Text = "There is not";
            }
        }
    }
}
