using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"Data Source=LAB4PC-2\STUDENT;Initial Catalog=safe_city;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {


        try
        {
            conn.Open();
            // string st = DropDownList1.SelectedItem.ToString();
            string query = "select email_id , passwords ,roles ,approve ,images from users where email_id ='" + TextBox1.Text + "' and passwords = '" + TextBox2.Text + "'  ";
            SqlCommand cmd = new SqlCommand(query,conn);
            SqlDataReader rs = cmd.ExecuteReader();
            if (rs.Read())
            {
                string r = rs["roles"].ToString();
                string ap = rs["approve"].ToString();

                if (r.Equals("Admin"))
                {
                    Session["new"] = TextBox1.Text;
                    Response.Redirect("AdminPanel/adminindex.aspx");

                }
                else
                {
                    Response.Write("Invalid Role");

                }
                if (r.Equals("EyeWitness") && ap.Equals("Approved"))
                {
                    Session["new"] = TextBox1.Text;
                    Response.Redirect("EyeWitness Panel/eyewithome.aspx");
                }
                else
                {
                    Response.Write("Invalid Role");

                }



                if (r.Equals("Victim") && ap.Equals("Approved"))
                {
                    Session["new"] = TextBox1.Text;
                    Response.Redirect("UserPanel/userindex.aspx");
                }
                else
                {
                    Response.Write("Invalid Role");

                }

            }

            else
            {
                Response.Write("Invalid User");

            }

            conn.Close();

        }
        catch (Exception)
        {
            Response.Write("" + e);
        }





    }
}