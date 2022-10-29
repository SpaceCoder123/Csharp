namespace Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            OutputBox.Clear();
            string table_num = InputInteger.Text;
            int table_calc = Convert.ToInt32(table_num);
            for (int i = 1; i <= 10; i++)
            {
                OutputBox.Text += table_calc + " x " + i + " = " + table_calc * i +""+Environment.NewLine; 
            }
        }
    }
}