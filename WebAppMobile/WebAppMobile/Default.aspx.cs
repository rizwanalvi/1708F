using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using WebAppMobile.Models;
using System.Data;

namespace WebAppMobile
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadGridView();
        }
        public void LoadGridView() {
            SqlConnection _sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=dbMobile;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if (_sqlconn.State == System.Data.ConnectionState.Closed)
                _sqlconn.Open();
            DataSet _ds = new DataSet();
            SqlDataAdapter _dAdapter = new SqlDataAdapter("SELECT * FROM MOBILE", _sqlconn);
            _dAdapter.Fill(_ds);
            GridView1.DataSource = _ds.Tables[0];
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            /* SqlConnection _sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=dbMobile;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
             if (_sqlconn.State == System.Data.ConnectionState.Closed)
                 _sqlconn.Open();
             SqlCommand _cmd = new SqlCommand("INSERT INTO MOBILE VALUES(@NAME,@MODEL,@BRAND,@IMGPATH)", _sqlconn);
             _cmd.Parameters.AddWithValue("@NAME", txtName.Text);
             _cmd.Parameters.AddWithValue("@MODEL", txtModel.Text);
             _cmd.Parameters.AddWithValue("@BRAND", lstBrands.SelectedValue);
             _cmd.Parameters.AddWithValue("@IMGPATH", "img/" +FileUpload1.FileName);
             _cmd.ExecuteNonQuery();
             FileUpload1.SaveAs(Server.MapPath("img/" + FileUpload1.FileName));
             */



            DOAMobile mb = new DOAMobile();
            mb.InsertMobile(new Mobile {MobileName= txtName.Text ,MobileModel= txtModel.Text ,Brand= lstBrands.SelectedValue ,ImagePath= "img/" + FileUpload1.FileName });
            FileUpload1.SaveAs(Server.MapPath("img/" + FileUpload1.FileName));
            LoadGridView();
        }
    }
}