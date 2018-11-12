using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppMdiExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 fmAbc = new Form2();
            fmAbc.MdiParent = this;
            fmAbc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {
                Form2.panelAdmin.Visible = true;
              //  Form2.btnShow.Visible = false;
            } else {
                //Form2.btnShow.Visible = true;
                Form2.panelAdmin.Visible = false;
            }
        }
    }
}
