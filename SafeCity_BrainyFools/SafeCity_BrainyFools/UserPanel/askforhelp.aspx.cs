using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserPanel_Default : System.Web.UI.Page
{

    SqlConnection conn = new SqlConnection(@"Data Source=LAB4PC-2\STUDENT;Initial Catalog=safe_city;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        
     
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        conn.Open();

        


        string query = "insert into alert(UserId,complain,locations,dates,times,auto_generated_message) values(@uid , @complain ,'nazimabad', getdate(),getdate(),'please Help i am unsafe') ";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@uid",Convert.ToInt32(TextBox1.Text));
        cmd.Parameters.AddWithValue("@complain", TextBox2.Text);
    //  cmd.Parameters.AddWithValue("@loc", labe + "," + lon.Text);

        cmd.ExecuteNonQuery();

        conn.Close();

        

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}