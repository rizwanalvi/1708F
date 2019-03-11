using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDataStorage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnAuthetication(object sender, AuthenticateEventArgs e)
        {
            if (Login1.UserName.Equals("admin") && Login1.Password.Equals("admin"))
            { 
            Session["UserName"] = "Admin";
            Response.Redirect("dashboard.aspx");
            }
        }
    }
}