using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace WebApp01
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            SqlDataAdapter dAdapter = new SqlDataAdapter("SELECT * FROM STD", new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=1708F;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
            DataSet _ds = new DataSet();
            dAdapter.Fill(_ds);
            GridView1.DataSource = _ds.Tables[0];
            GridView1.DataBind();
            */
            SqlConnection _sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=1708F;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _sqlconn.Open();
            SqlCommand _cmd = new SqlCommand("spGetStudentById", _sqlconn);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@ID", 1);
            SqlDataReader dReader = _cmd.ExecuteReader();

          //  GridView1.DataSource = dReader;
            //GridView1.DataBind();

            Repeater1.DataSource = dReader;
            Repeater1.DataBind();

        }
    }
}