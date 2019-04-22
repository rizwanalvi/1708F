using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class userreg : System.Web.UI.Page
{

    SqlConnection conn = new SqlConnection(@"Data Source=LAB4PC-2\STUDENT;Initial Catalog=safe_city;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {

            string strname = FileUpload1.FileName.ToString();
            FileUpload1.PostedFile.SaveAs(Server.MapPath("~/addressprof/") + strname);
            conn.Open();
            string ext = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName);
            if (ext == ".jpg" || ext == ".png")
            {
                string query = "insert into users(first_name,last_name,email_id,passwords,contact,address_proof,addresses, roles) values(@name , @lastname, @email, @pass,@cont,@proof,@adres, @roles)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@lastname", TextBox2.Text);
                cmd.Parameters.AddWithValue("@cont", TextBox3.Text);
                cmd.Parameters.AddWithValue("@email", TextBox4.Text);
                cmd.Parameters.AddWithValue("@proof", strname);

                cmd.Parameters.AddWithValue("@adres", TextBox5.Text);
                cmd.Parameters.AddWithValue("@pass", TextBox7.Text);


                cmd.Parameters.AddWithValue("@roles", DropDownList2.SelectedItem.ToString());

                cmd.ExecuteNonQuery();

            }
            else
            {
                Response.Write("image formate not support");
            }

            conn.Close();
            Label1.Visible = true;
            Response.Write("User Registration Request  successfully Sent ");
            TextBox1.Text = "";
        }
        else
        {
            Label1.Visible = true;
            Response.Write("Plz Upload Image");
        }
    }
}