using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileTextInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists("secondfile.txt"))
            {
                //File.Create("firstfile.txt");
                //MessageBox.Show("Your file has been created");
                FileInfo newFile = new FileInfo("secondfile.txt");
                newFile.Create();
                MessageBox.Show("The file has been created");
            }
            else
            {
                MessageBox.Show("The requested file already exists! ");
            }

        }

        private void DeleteFile_Click(object sender, EventArgs e)
        {
            File.Delete("firstfile.txt");
            MessageBox.Show("The requested file has been deleted ");
        }

        private void WriteFile_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Third.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Hello! this is the first line");
            sw.WriteLine("Hello! this is the second line");
            sw.Flush();
            sw.Close();
            fs.Close();
            MessageBox.Show("The contents that are offered are successfully written ");

        }

        private void ReadFile_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Third.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                Text += sr.ReadLine()+Environment.NewLine;
            }
            sr.Close();
            fs.Close();
            OutputBox.Text = Text;

        }

        private void getInfo_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo("Third.txt");
            string name = file.FullName;
            MessageBox.Show(name);
        }
    }
}
