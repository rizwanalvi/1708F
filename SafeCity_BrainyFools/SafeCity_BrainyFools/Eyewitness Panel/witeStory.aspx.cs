using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Eyewitness_Panel_Default : System.Web.UI.Page
{

    SqlConnection conn = new SqlConnection(@"Data Source=LAB4PC-2\STUDENT;Initial Catalog=safe_city;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        conn.Open();
        string query = "insert into story(category,descriptions,dates) values (@cate,@des,getdate())";
        SqlCommand cmd = new SqlCommand(query ,conn);
        cmd.Parameters.AddWithValue("@cate", DropDownList1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@des", TextBox1.Text);

            cmd.ExecuteNonQuery();
        

        conn.Close();




    }
}