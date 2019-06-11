using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.Model;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            // new DALCategory().Insert(new Category { CatName = "Soap"});
            new DALProduct().Insert(new Product { CatId=2,ProductName="Lux",Price=26.40f,Quantity=50});
        }
    }
}
