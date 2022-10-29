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

        private void Form1_Load(object sender, EventArgs e)
        {
            string messageText = "Hello";
            string message = "Did you see the icon? ";
            //MessageBox.Show(messageText,message, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //MessageBox.Show(messageText);
            //DialogResult result = MessageBox.Show(messageText, message, MessageBoxButtons.YesNo);
            button1.Text = "changed";

            CheckBoxing.Checked = true;
            bool checking = CheckBoxing.Checked;



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

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            string labeltext = textBoxInput.Text; // capturing the string obtainted from text box
            outputLabel.Text = labeltext; // printing it to the label

            // note the text box can only take 62000 characters, if you want to use more than that
            // then use richtext box which has similar properties except it can input more that 62000
            // characters
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            DropDown1.Items.Add("Monday");
            DropDown1.Items.Add("Tuesday");
            DropDown1.Items.Add("Wednesday");
            DropDown1.SelectedIndex = 1;
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            outputLabel.Text = "The radio button has been checked";
        }

        private void CheckBoxing_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBoxing.Checked = true;
            bool checking = CheckBoxing.Checked;
            string output = Convert.ToString(checking);
            outputLabel.Text = output;
        }

        private void CheckBoxing_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Check status changed"); // when you the changed check state like on or off then
            // you can use this program to automate the process
        }

        private void DropDown1_SelectedIndexChanged(object sender, EventArgs e)
        {
           MessageBox.Show(DropDown1.SelectedIndex.ToString());
        }
    }

}
