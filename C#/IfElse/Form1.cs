namespace IfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 20, b = 10;
            string name = "charles";
            bool control = true;
            string value1 = value.Text;
            int corr_value = Convert.ToInt32(value1);


            if(corr_value == 20)
            {
                OutputLabel.Text = "Yes, the input value is = " + a;
            }
            else if (corr_value > a)
            {
                OutputLabel.Text = "Yes, the value entered is greater than "+a;
            }
            else
            {
                OutputLabel.Text = "Yes, the value entered is lesser than " + a;
            }
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}