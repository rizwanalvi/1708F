using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Model
{
   public class Product
    {
        public int Id { get; set; }
        public int CatId { get; set; }
        public String ProductName { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
    }
}
