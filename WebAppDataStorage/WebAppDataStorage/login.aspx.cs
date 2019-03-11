using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDataStorage
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Equals("admin@gmai.com") && TextBox2.Text.Equals("admin"))
            {
                Session["UserName"] = "Admin";
                Response.Redirect("dashboard.aspx");
            }
        }
    }
}