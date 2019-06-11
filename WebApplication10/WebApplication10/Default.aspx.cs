using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack) { 
            DropDownList1.Items.Add("Pakistan");
            DropDownList1.Items.Add("China");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(TextBox1.Text);
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text= ListBox1.SelectedItem.Text;
        }
    }
}