using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
 
            try
            {
                double output = Convert.ToInt32(Num1Inp.Text) / Convert.ToInt32(Num2Inp.Text);
                OutputLabel1.Text += Convert.ToString(output);
            }
            catch (DivideByZeroException ex)
            {
                //throw new Exception("Cannot divide the number by 0");
                MessageBox.Show(ex.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show("The program has been finished! ");2
                Application.Exit();
            }
            
        }
    }
}
