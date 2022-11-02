using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCalculator
{
    public partial class Form1 : Form
    {
        string num1 = "";
        string num2 = "";
        double num3 = 0;
        string operation = "";
       
        public Form1()
        {
            InitializeComponent();
        }

        public void showValue(string value)
        {
            ShowBox.Text = value+ Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = "1";
            num1 += value;
            showValue(num1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = "2";
            num1 += value;
            showValue(num1); 
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string value = "8";
            num1 += value;
            showValue(num1);
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            string value2 = "3";
            num1 += value2;
            showValue(num1);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string value = "6";
            num1 += value;
            showValue(num1);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string value = "5";
            num1 += value;
            showValue(num1);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string value = "4";
            num1 += value;
            showValue(num1);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string value = "7";
            num1 += value;
            showValue(num1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string value = "9";
            num1 += value;
            showValue(num1);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            string value = "0";
            num1 += value;
            showValue(num1);
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            num1 = "";
            num2 = "";
            showValue(num2);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if (num1.Length >= 1)
            {
                num1 = num1.Remove(num1.Length - 1);
                showValue(num1);
            }
            else
            {
                num1 = null;
                showValue(num1);
            }
        }

        public void buttonAdd_Click(object sender, EventArgs e)
        {
            num2 = num1;
            num1 = "";
            showValue(num1);
            operation += "add";
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            string value = ".";
            num1 += value;
            showValue(num1);
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            if (num2 == "")
            {
                num2 = num1;
                num1 = "";
                showValue(num1);
                operation += "subtract";
            }

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (num2 == "")
            {
                showValue(num1);
                num2 = num1;
                num1 = "";
                operation += "divide";
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (num2 == "")
            {
                num2 = num1;
                num1 = null;
                showValue(num1);
                operation += "multiply";
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (operation == "add")
            {
                double value = AllMethods.Add(Convert.ToDouble(num2), Convert.ToDouble(num1));
                string inter = Convert.ToString(value);
                showValue(inter);
                num2 = inter;
                num1 = "";
                operation = "";
            }
            if (operation == "subtract")
            {
                double value = AllMethods.Subtract(Convert.ToDouble(num2), Convert.ToDouble(num1));
                string inter = Convert.ToString(value);
                showValue(inter);
                num2 = inter;
                num1 = "";
                operation = "";
            }
            if (operation == "multiply")
            {
                double value = AllMethods.Multiply(Convert.ToDouble(num2), Convert.ToDouble(num1));
                string inter = Convert.ToString(value);
                showValue(inter);
                num2 = inter;
                num1 = "";
                operation = "";
            }
            if (operation == "divide")
            {
                double value = AllMethods.Divide(Convert.ToDouble(num2), Convert.ToDouble(num1));
                string inter = Convert.ToString(value);
                showValue(inter);
                num2 = inter;
                num1 = "";
                operation = "";
            }
            if (operation == "")
            {
                showValue(num2);
                num1 = "";
            }
            
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ShowBox.Text = num2;
        }
    }
}
