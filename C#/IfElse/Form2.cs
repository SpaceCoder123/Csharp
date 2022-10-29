using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfElse
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        private void Calculate_Click(object sender, EventArgs e)
        {
            string ageValue = AgeInput.Text;
            int age = Convert.ToInt32(ageValue);
            switch (age)
            {
                case 18:
                    OutputLabel.Text = "You are eligible for high school";
                    break;
                case 20:
                    OutputLabel.Text = "You are eligible for College";
                    break;
                case 16:
                    OutputLabel.Text = "You are eligible for School";
                    break;
                default:
                    OutputLabel.Text = "Hey! Please enter a number within 16 to 20";
                    break;
            }
        }

        //private void AgeInput_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
