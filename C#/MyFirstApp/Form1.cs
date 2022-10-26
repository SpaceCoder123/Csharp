using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender,EventArgs e)
        {
            string messageText = "Hello";
            string message = "Did you see the icon? ";
            //MessageBox.Show(messageText,message, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //MessageBox.Show(messageText);
            //DialogResult result = MessageBox.Show(messageText, message, MessageBoxButtons.YesNo);
            button1.Text = "changed";
            //if (result == DialogResult.Yes)
            //{ 
            //    this.Close(); // if yes is clicked then the program closes
            //}
            //else
            //{
            //    // do nothing 
            //}
        }

        //private void Button_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Hello");
        //}

        private void NewButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have clicked the button");
        }

        private void firstLabel_Click(object sender, EventArgs e)
        {
            firstLabel.Text = "Clicked";
        }

        private void FirstlLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.c-sharpcorner.com");
            // this will fire the link that is present in the qoutes and will run the program when 
            // clicked
        }
    }
}
