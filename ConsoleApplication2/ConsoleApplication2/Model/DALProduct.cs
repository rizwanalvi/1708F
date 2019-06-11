using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Model
{
   public class DALProduct
    {
        SqlConnection _sqlConn = null;
        SqlCommand _cmd = null;
        public DALProduct()
        {

            _sqlConn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=Shoppings;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _cmd = new SqlCommand();
        }
        public void Insert(Product pro)
        {
            if (_sqlConn.State == System.Data.ConnectionState.Closed)
                _sqlConn.Open();
            _cmd.CommandText = "INSERT INTO PRODUCT VALUES(@catid,@name,@price,@quantity)";
            _cmd.Connection = _sqlConn;
            _cmd.Parameters.AddWithValue("@catid", pro.CatId);
            _cmd.Parameters.AddWithValue("@name", pro.ProductName);
            _cmd.Parameters.AddWithValue("@price", pro.Price);
            _cmd.Parameters.AddWithValue("@quantity", pro.Quantity);
            _cmd.ExecuteNonQuery();
        }


      
    }
}
