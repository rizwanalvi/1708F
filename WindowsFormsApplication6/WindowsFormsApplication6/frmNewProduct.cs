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
    public partial class frmNewProduct : Form
    {
        DB1708FEntities dbEntity = null;
        public frmNewProduct()
        {
            InitializeComponent();
            dbEntity = new DB1708FEntities();

           dataGridView1.DataSource=  dbEntity.Products.ToList<Product>();


        }


      

        private void button3_Click(object sender, EventArgs e)
        {
            frmAddProduct fm = new frmAddProduct();
            fm.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow _row = dataGridView1.CurrentRow;
            Product pd = new Product
            {
                PROID = int.Parse(_row.Cells[0].Value.ToString()),
                PRO_NAME = _row.Cells[1].Value.ToString(),
                BRAND = _row.Cells[2].Value.ToString(),
                PRICE = float.Parse(_row.Cells[3].Value.ToString()),
                QUANTITY = int.Parse(_row.Cells[4].Value.ToString()),
                CATID = int.Parse(_row.Cells[5].Value.ToString())
            };
            new frmAddProduct(pd).ShowDialog();
            }
    }
}
