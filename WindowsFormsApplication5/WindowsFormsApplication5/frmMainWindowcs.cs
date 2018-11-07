using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class frmMainWindowcs : MetroFramework.Forms.MetroForm
    {
        public frmMainWindowcs()
        {
            InitializeComponent();
        }

        private void frmMainWindowcs_Load(object sender, EventArgs e)
        {
            Form1 fmLogin = new Form1();
            fmLogin.MdiParent = this;
            fmLogin.Show();

        }
    }
}
