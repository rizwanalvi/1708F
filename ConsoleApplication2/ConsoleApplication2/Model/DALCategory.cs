using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ConsoleApplication2.Model
{
    public class DALCategory
    {
        SqlConnection _sqlConn = null;
        SqlCommand _cmd = null;
        public DALCategory()
        {

            _sqlConn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=Shoppings;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _cmd = new SqlCommand();
        }
        public void Insert(Category cat)
        {
            if (_sqlConn.State == System.Data.ConnectionState.Closed)
                _sqlConn.Open();
            _cmd.CommandText = "INSERT INTO CATEGORY VALUES(@name)";
            _cmd.Connection = _sqlConn;
            _cmd.Parameters.AddWithValue("@name", cat.CatName);
            _cmd.ExecuteNonQuery();
        }


        public void Update(Category cat)
        {
            if (_sqlConn.State == System.Data.ConnectionState.Closed)
                _sqlConn.Open();
            _cmd.Connection = _sqlConn;
            _cmd.CommandText = "UPDATE CATEGORY SET CATNAME = @CATNAME WHERE CATID =@CATID";
            _cmd.Parameters.AddWithValue("@CATNAME ", cat.CatName);
            _cmd.Parameters.AddWithValue("@CATID", cat.Id);
            _cmd.ExecuteNonQuery();

        }
        public void Delete(Category cat)
        {
            if (_sqlConn.State == System.Data.ConnectionState.Closed)
                _sqlConn.Open();
            _cmd.Connection = _sqlConn;
            _cmd.CommandText = "DELETE FROM CATEGORY WHERE CATID =@CATID";
            _cmd.Parameters.AddWithValue("@CATID", cat.Id);
            _cmd.ExecuteNonQuery();

        }
    }
}
