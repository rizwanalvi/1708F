using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinConsumerForm.ServiceReference1;
namespace WinConsumerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1Client webservice = new Service1Client();
            dataGridView1.DataSource = webservice.GetEmpByid(int.Parse(textBox1.Text)).Tables[0];
          
        }
    }
}
