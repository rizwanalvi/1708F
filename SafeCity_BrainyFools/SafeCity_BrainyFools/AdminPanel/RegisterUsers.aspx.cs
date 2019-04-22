using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_Default4 : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"Data Source=LAB4PC-2\STUDENT;Initial Catalog=safe_city;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            fetchDAta();
        }
    }
    public void fetchDAta()
    {
        conn.Open();

        string query = "select * from users where  not roles= 'Admin' and approve = 'Approved'";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        sda.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();

        conn.Close();
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow dRow = GridView1.Rows[e.RowIndex];
        Label lbl = dRow.FindControl("Label2") as Label;
      //  Label lbl3 = dRow.FindControl("Label3") as Label;
       // string em = lbl3.Text;
        conn.Open();
        SqlDataAdapter _dAdapter = new SqlDataAdapter("DELETE FROM users WHERE UserId = @ID", conn);
        _dAdapter.SelectCommand.Parameters.AddWithValue("@ID", lbl.Text);
        _dAdapter.SelectCommand.ExecuteNonQuery();

        conn.Close();
        fetchDAta();
    }
}