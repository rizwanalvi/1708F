using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingDataForm
{
  public  class Product
    {
        private List<Product> _product = null;
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public String Brand { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public int CategoryId { get; set; }

        public List<Product> getProductList() {
            _product = new List<Product>();
            _product.Add(new Product { ProductId=100,ProductName="LG Printer 1506",Brand="LG",Quantity=26,Price=5000,CategoryId=1});
            _product.Add(new Product { ProductId = 101, ProductName = "LG Printer 1507", Brand = "LG", Quantity = 26, Price = 5000, CategoryId = 1 });
            _product.Add(new Product { ProductId = 102, ProductName = "LG Printer 1506", Brand = "LG", Quantity = 26, Price = 5000, CategoryId = 1 });
            _product.Add(new Product { ProductId = 103, ProductName = "LG Printer 1506", Brand = "LG", Quantity = 26, Price = 5000, CategoryId = 1 });

            return _product;
        }

       
    }
}
