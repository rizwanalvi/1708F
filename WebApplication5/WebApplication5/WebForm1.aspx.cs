using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {/*
            if (ViewState["data"] != null)
            {
                Label1.Text = ViewState["data"].ToString();
            }
            else {

                TextBox1.Text = "Textbox was empty";
            }
            */

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*
            if (TextBox1.Text != "")
            {
                ViewState["data"] = TextBox1.Text;
            }
            Label1.Text =TextBox1.Text;
            */
            Label1.Text = TextBox1.Text;
            HttpCookie htp = new HttpCookie("test");
            htp.Value = TextBox1.Text;
            Response.Cookies.Add(htp);
            Response.Redirect("webform2.aspx");
        }
    }
}