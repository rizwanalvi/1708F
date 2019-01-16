using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace WebApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                LoadData();
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadData();
        }

        public void LoadData() {
            
            SqlConnection _sqlconn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString.ToString());
            SqlDataAdapter _dAdapter = new SqlDataAdapter("SELECT * FROM STD", _sqlconn);
            DataSet _ds = new DataSet();
            _dAdapter.Fill(_ds);
            GridView1.DataSource = _ds.Tables[0];
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            LoadData();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow dRow = GridView1.Rows[e.RowIndex];
            TextBox tb = (TextBox) dRow.FindControl("TextBox1");
            TextBox tbfName = (TextBox)dRow.FindControl("TextBox2");
            Label lblID =(Label) dRow.FindControl("lblID");
            SqlConnection _sqlconn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString.ToString());
            _sqlconn.Open();
            SqlDataAdapter _dAdapter = new SqlDataAdapter("UPDATE STD SET NAME = @NAME,FNAME=@FNAME WHERE ID = @ID", _sqlconn);
            _dAdapter.SelectCommand.Parameters.AddWithValue("@ID", lblID.Text);
            _dAdapter.SelectCommand.Parameters.AddWithValue("@NAME", tb.Text);
            _dAdapter.SelectCommand.Parameters.AddWithValue("@FNAME",tbfName.Text);
            _dAdapter.SelectCommand.ExecuteNonQuery();
            GridView1.EditIndex = -1;
            LoadData();
        }
    }
}