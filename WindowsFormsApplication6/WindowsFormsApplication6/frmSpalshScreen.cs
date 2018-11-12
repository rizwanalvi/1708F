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
    public partial class frmSpalshScreen : Form
    {
        private Timer _timeSpash = null;
        public frmSpalshScreen()
        {
            InitializeComponent();
            _timeSpash = new Timer();
            _timeSpash.Interval = 1000;
            _timeSpash.Tick += _timeSpash_Tick;
           
        }
        int _count = 1;

        private void _timeSpash_Tick(object sender, EventArgs e)
        {

            if (_count< 10)
            {
                progressBar1.Value = _count;
                _count++;
               
            }
            else {

                _timeSpash.Stop();
                Form2 fm2 = new Form2();
                fm2.Show();
                this.Hide();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmSpalshScreen_Load(object sender, EventArgs e)
        {
            _timeSpash.Start();
        }
    }
}
