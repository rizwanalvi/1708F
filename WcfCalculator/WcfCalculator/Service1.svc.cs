using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
namespace WcfCalculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public string GetData(int value)
        {
            return "Hi! " + value;
        }
        DataSet _ds = null;
        public DataSet GetEmpByid(int i)
        {
            _ds = new DataSet();
            SqlConnection _conn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=1708F;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _conn.Open();
            SqlDataAdapter dt = new SqlDataAdapter("SELECT *FROM STD WHERE ID = @ID", _conn);
            dt.SelectCommand.Parameters.AddWithValue("@ID", i);
            dt.Fill(_ds);
           
            return _ds;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }
    }
}
