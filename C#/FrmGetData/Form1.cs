using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmGetData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name1 = LastName.Text;
            string name2 = FirstName.Text;
             
            frm_show_data frm_show = new frm_show_data();
            frm_show.outputLabel.Text = name2 + name1;
            frm_show.Show();
        }
    }
}
