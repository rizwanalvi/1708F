using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_Default : System.Web.UI.Page
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

        string query = "select* from story where  status = 'Not Approved'  order by dates desc ";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        sda.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        conn.Close();
    }




    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow dRow = GridView1.Rows[e.RowIndex];
        Label lbl = dRow.FindControl("Label2") as Label;
        conn.Open();
        SqlDataAdapter _dAdapter = new SqlDataAdapter("UPDATE story SET status = 'Approved' WHERE auto_generated_id = @ID", conn);
        _dAdapter.SelectCommand.Parameters.AddWithValue("@ID", lbl.Text);
        _dAdapter.SelectCommand.ExecuteNonQuery();

        conn.Close();
        fetchDAta();
    }
}