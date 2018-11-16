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
    public partial class frmRegesteruser : Form
    {
        DB1708FEntities dbEntity = null;
        public frmRegesteruser()
        {
            InitializeComponent();
            dbEntity = new DB1708FEntities();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbEntity.USERS.Add(new USER { UNAME = textBox1.Text, UPASS = textBox2.Text, ROLE_ID = 2 });
            dbEntity.SaveChanges();

        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {
                
            
            }

        }
    }
}
