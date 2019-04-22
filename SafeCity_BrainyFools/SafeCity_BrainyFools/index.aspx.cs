using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    SqlConnection conn = new SqlConnection(@"Data Source=LAB4PC-2\STUDENT;Initial Catalog=safe_city;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label1.Text = "";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        conn.Open();
        
            string query = "insert into story (category,descriptions,dates) values (@cate,@desc, getdate())";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@cate", DropDownList1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@desc", TextBox1.Text);

            cmd.ExecuteNonQuery();
        Label1.Text = "Your Story Request Has been sent to Administration for approval.";
        DropDownList1.SelectedIndex = 0;
        TextBox1.Text = "";

        conn.Close();
        if (IsPostBack)
        {
            Label1.Text = "";

        }


    }
}