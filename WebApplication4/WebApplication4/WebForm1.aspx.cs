using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(TextBox1.Text);
            TextBox1.Text = String.Empty;
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = ListBox1.SelectedItem.Value;
        }
    }
}