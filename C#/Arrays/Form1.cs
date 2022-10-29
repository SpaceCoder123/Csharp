using System;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ShwBtn_Click(object sender, EventArgs e)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            for (int i = 0; i < days.Length; i++)
            {
                string rowData = days[i];
                ArrayOutput.Rows.Add(rowData);
            }
        }
    }
}