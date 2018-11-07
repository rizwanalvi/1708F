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
    public partial class Form1 : Form
    {
        DB1708FEntities dbEntity = null;
        public Form1()
        {
            InitializeComponent();
            dbEntity = new DB1708FEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != String.Empty && textBox2.Text != String.Empty)
                {
                    USER UserData = dbEntity.USERS.Where(x => x.UNAME == textBox1.Text && x.UPASS == textBox2.Text).
                    SingleOrDefault();
                    String roleName = UserData.ROLE.ROLE_NAME;
                    String UseName = UserData.UNAME;

                    switch (roleName.ToUpper())
                    {
                        case "ADMIN":
                            // Admin Code here
                            frmMainWindowcs.button1.Visible = false;
                            frmMainWindowcs.button2.Visible = true;
                            this.Hide();
                            break;
                        case "CUSTOMER":
                            // Admin Code here
                          
                            break;
                        default:
                            break;
                    }
                    MessageBox.Show(roleName);
                }
            }
            catch (Exception) {
                MessageBox.Show("Invalid User");

            }
        }
    }
}
