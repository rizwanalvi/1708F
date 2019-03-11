using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace WebApplication7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
            SqlConnection _conn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=1601DSTD;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                if(_conn.State == System.Data.ConnectionState.Closed)
                _conn.Open();
                SqlCommand _cmd = new SqlCommand("SELECT * FROM STUDENTINFO", _conn);
          GridView1.DataSource = _cmd.ExecuteReader();
            GridView1.DataBind();
            }
        }
    }
}