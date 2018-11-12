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
    public partial class Form1 : Form
    {
        DB1708FEntities dbEnty = null;
        public Form1()
        {
            InitializeComponent();
            dbEnty = new DB1708FEntities();
           
        }

       

        private void button1_Click(object sender, EventArgs e)
        {try
            {
                var _user = dbEnty.USERS.Where(x => x.UNAME == textBox1.Text && x.UPASS == textBox2.Text).SingleOrDefault();

                switch (_user.ROLE.ROLE_NAME.ToLower())
                {
                    case "admin":
                        MessageBox.Show("Admin");
                        Form2._btnLogin.Visible = false;
                        Form2._AdminPanel.Visible = true;
                        Form2._btnLogOut.Visible = true;
                        this.Hide();

                        break;
                    case "customer":
                        MessageBox.Show("Customer");
                        Form2._btnLogin.Visible = false;
                        Form2._UserPanel.Visible = true;
                        Form2._btnLogOut.Visible = true;
                        this.Hide();
                       
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex) {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
