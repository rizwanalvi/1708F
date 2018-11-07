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
    public partial class Form2 : Form
    {
        public static System.Windows.Forms.Button btnShow;
        public Form2()
        {
            InitializeComponent();
        }
        int i = 0;
        private void btnShow_Click(object sender, EventArgs e)
        {
            //Form1.label1.Text = i.ToString();
            i++;
        }
    }
}
