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
       public static System.Windows.Forms.Panel panelAdmin;
        public static System.Windows.Forms.Button btnShow;
        public Form2()
        {
            panelAdmin = new System.Windows.Forms.Panel();

            InitializeComponent();
        }
        int i = 0;
        private void btnShow_Click(object sender, EventArgs e)
        {
            
        }
    }
}
