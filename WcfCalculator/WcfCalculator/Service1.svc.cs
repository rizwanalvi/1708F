using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using WcfCalculator.Model;

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
            dt.SelectCommand.Parameters.AddWithValue("@ID", i);//
            dt.Fill(_ds);
           
            return _ds;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public int InsertEmpData(Student std)
        {
            _ds = new DataSet();
            SqlConnection _conn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=1708F;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _conn.Open();
            SqlCommand dt = new SqlCommand("INSERT INTO STD VALUES(@NAME,@FNAME,@AGE,@CL,@GENDER)", _conn);
            dt.Parameters.AddWithValue("@NAME", std.StudentName);
            dt.Parameters.AddWithValue("@FNAME", std.FName);
            dt.Parameters.AddWithValue("@AGE", std.Age);
            dt.Parameters.AddWithValue("@CL", std.StdClass);
            dt.Parameters.AddWithValue("@GENDER", std.Gender);
            dt.ExecuteNonQuery();
            return 1;
        }

        public int UpdateEmpData(Student std)
        {
            _ds = new DataSet();
            SqlConnection _conn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=1708F;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _conn.Open();
            SqlCommand dt = new SqlCommand("UPDATE STD SET NAME =@NAME,FNAME =@FNAME,AGE = @AGE,CL = @CL,GENDER =@GENDER WHERE ID= @ID", _conn);
            dt.Parameters.AddWithValue("@ID", std.StdID);
            dt.Parameters.AddWithValue("@NAME", std.StudentName);
            dt.Parameters.AddWithValue("@FNAME", std.FName);
            dt.Parameters.AddWithValue("@AGE", std.Age);
            dt.Parameters.AddWithValue("@CL", std.StdClass);
            dt.Parameters.AddWithValue("@GENDER", std.Gender);
            dt.ExecuteNonQuery();
            return 1;
        }
    }
}
