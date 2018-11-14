using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassingDataForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Product _pd = new Product();
            InitializeComponent();
            dataGridView1.DataSource = _pd.getProductList();



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow _row = dataGridView1.CurrentRow;
            
            Product _prd = new Product {ProductId = int.Parse(_row.Cells[0].Value.ToString()),
                ProductName = _row.Cells[1].Value.ToString(),Quantity = int.Parse(_row.Cells[3].Value.ToString()),
                Brand =_row.Cells[2].Value.ToString(),
                Price = float.Parse(_row.Cells[4].Value.ToString()),
                CategoryId = int.Parse(_row.Cells[5].Value.ToString())

            };
            Form2 fmProduct = new Form2(_prd);
            fmProduct.ShowDialog();


        }
    }
}
