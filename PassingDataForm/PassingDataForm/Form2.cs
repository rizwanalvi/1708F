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
    public partial class Form2 : Form
    {
        private Product ProductInfo { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Product pd)
        {
            InitializeComponent();
            this.ProductInfo = pd;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = ProductInfo.ProductId.ToString();
            textBox1.Text = ProductInfo.ProductName;
            pictureBox1.Image = ProductInfo.ImgProduct;
        }
    }
}
