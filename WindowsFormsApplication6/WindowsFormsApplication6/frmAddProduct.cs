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
    public partial class frmAddProduct : Form
    {
        DB1708FEntities dbEntity = null;
        public frmAddProduct()
        {
            InitializeComponent();
            dbEntity = new DB1708FEntities();
        }


        public frmAddProduct(Product pd)
        {
            InitializeComponent();
            dbEntity = new DB1708FEntities();

            textBox1.Text = pd.PRO_NAME;
            textBox2.Text = pd.BRAND;
            textBox3.Text = pd.PRICE.ToString();
            textBox4.Text = pd.QUANTITY.ToString();
          //  comboBox1.SelectedItem = pd.Category.CAT_NAME.ToString();
            label6.Text = pd.PROID.ToString();
            button1.Text = "Update";
            this.Text = "Update Records";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btnCrud = (Button) sender;
            switch (btnCrud.Text)
            {
                case "Add":
                    dbEntity.Products.Add(new Product { PRO_NAME = textBox1.Text, BRAND = textBox2.Text, PRICE = float.Parse(textBox3.Text), QUANTITY = int.Parse(textBox4.Text), CATID = int.Parse(comboBox1.SelectedIndex.ToString()) + 1 });
                    dbEntity.SaveChanges();
                    break;
                case "Update":
                    Product proddata = dbEntity.Products.Where(x => x.PROID == 1).Single<Product>();
                    proddata.PRO_NAME = textBox1.Text;
                    proddata.BRAND = textBox2.Text;
                    proddata.PRICE =float.Parse(textBox3.Text);
                    proddata.QUANTITY = int.Parse(textBox4.Text);
                    proddata.CATID = int.Parse(comboBox1.SelectedIndex.ToString())+1;

                    dbEntity.SaveChanges();
                    break;
                default:
                    break;
            }
           
        }
    }
}
