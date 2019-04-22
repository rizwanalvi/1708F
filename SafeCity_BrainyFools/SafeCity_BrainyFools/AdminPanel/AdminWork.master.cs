using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_MasterPage : System.Web.UI.MasterPage
{
    SqlConnection conn = new SqlConnection(@"Data Source=LAB4PC-2\STUDENT;Initial Catalog=safe_city;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {

            if (Session["new"] != null)
            {


                conn.Open();

                string query = "select * from users where email_id = '" + Session["new"].ToString() + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rs = cmd.ExecuteReader();
                while (rs.Read())
                {
                    Label1.Text = rs["first_name"].ToString();

                    Image1.ImageUrl = "~/profileimg/" + rs["images"].ToString();
                }

                conn.Close();
            }else
            {
                Response.Redirect("~/login.aspx");
            }
        }

        notifications();
        messages();
    }
    public  void notifications()
    {

        conn.Open();

        string query = "select  count(approve) as totalap  from users  where approve = 'Not Approve' and not roles= 'Admin'";
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataReader rs = cmd.ExecuteReader();
        while (rs.Read())
        {
            Label2.Text = rs["totalap"].ToString();
            Label3.Text = rs["totalap"].ToString();

        }

        conn.Close();


    }

    public void messages()
    {

        conn.Open();

        string query = "select  count(status) as totalmsg  from alert  where status = 'not seen' ";
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataReader rs = cmd.ExecuteReader();
        while (rs.Read())
        {
            Label4.Text = rs["totalmsg"].ToString();
            Label5.Text = rs["totalmsg"].ToString();

        }

        conn.Close();


    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["new"] = null;
        Response.Redirect("~/login.aspx");
    }
}
