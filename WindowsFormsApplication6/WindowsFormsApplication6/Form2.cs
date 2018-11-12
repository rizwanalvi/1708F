using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form2 : Form
    {
        public static Button _btnLogin = null;
        public static Button _btnLogOut = null;
        public static Panel _AdminPanel = null;
        public static Panel _UserPanel = null;

        public Form2()
        {
            InitializeComponent();
            _btnLogin = this.button1;
            _btnLogOut = this.button2;
            _AdminPanel = this.panel2;
            _UserPanel = this.panel3;
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadLogin();
        }

        private void LoadLogin() {

            Form1 frmLogin = new Form1();
            frmLogin.MdiParent = this;
            frmLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadLogin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadLogin();
            button1.Visible = true;
            button2.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRegesteruser reguser = new frmRegesteruser();
            reguser.MdiParent = this;
            reguser.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("You want to Close this Application", "Warning", MessageBoxButtons.YesNo);
            if(dlg == DialogResult.No)
            {
              //  this.Close();
            }
        }
    }
}
