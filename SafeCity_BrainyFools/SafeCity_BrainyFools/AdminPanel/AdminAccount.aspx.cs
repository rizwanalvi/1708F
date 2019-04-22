using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_Default3 : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"Data Source=LAB4PC-2\STUDENT;Initial Catalog=safe_city;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            try
            {
                conn.Open();

                string query = "select * from users where email_id = '" + Session["new"].ToString() + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rs = cmd.ExecuteReader();
                while (rs.Read())
                {
                    Label1.Text = rs["UserId"].ToString();
                    TextBox1.Text = rs["first_name"].ToString();
                    TextBox2.Text = rs["last_name"].ToString();
                    TextBox3.Text = rs["email_id"].ToString();
                    TextBox4.Text = rs["passwords"].ToString();
                    TextBox5.Text = rs["contact"].ToString();
                    Image1.ImageUrl = "~/profileimg/" + rs["images"].ToString();

                }

                conn.Close();


            }
            catch (Exception)
            {

            }
        }
    }

    public void showdata()
    {

        try
        {
            conn.Open();

            string query = "select * from users where email_id = '" + Session["new"].ToString() + "' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                Label1.Text = rs["UserId"].ToString();
                TextBox1.Text = rs["first_name"].ToString();
                TextBox2.Text = rs["last_name"].ToString();
                TextBox3.Text = rs["email_id"].ToString();
                TextBox4.Text = rs["passwords"].ToString();
                TextBox5.Text = rs["contact"].ToString();
                Image1.ImageUrl = "~/profileimg/" + rs["images"].ToString();

            }

            conn.Close();

        }
        catch (Exception e)
        {
            Label2.Text = e.Message;
            Label2.ForeColor = System.Drawing.Color.Red;

        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {

            string strname = FileUpload1.FileName.ToString();
            FileUpload1.PostedFile.SaveAs(Server.MapPath("~/profileimg/") + strname);
            conn.Open();
            string ext = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName);
            if (ext == ".jpg" || ext == ".png")
            {
                string query = "update users set first_name =@name,last_name = @lastname ,email_id = @email, passwords = @pass,contact = @cont,images = @img where UserId = '"+int.Parse(Label1.Text)+"' ";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@lastname", TextBox2.Text);
                cmd.Parameters.AddWithValue("@email", TextBox3.Text);
                cmd.Parameters.AddWithValue("@pass", TextBox4.Text);
                cmd.Parameters.AddWithValue("@cont", TextBox5.Text);

                cmd.Parameters.AddWithValue("@img", strname);

                cmd.ExecuteNonQuery();
                Label2.Text = "Your Details Has been Updated. ";
                
            }
            else
            {
                Label2.Text = "image formate not support";
                Label2.ForeColor = System.Drawing.Color.Red;
            }

            conn.Close();
            showdata();
           
        }
        else
        {
            Response.Write("Plz Upload Image");
        }
    }
}