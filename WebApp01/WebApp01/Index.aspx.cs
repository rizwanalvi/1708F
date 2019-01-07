using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp01
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack) { 
            lstFruit.Items.Add("Apple");
            lstFruit.Items.Add("Mango"); lstFruit.Items.Add("Orange");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Response.Write("Ok");
        }

        protected void lstFruit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstFruit.SelectedItem.Value.ToString())
            {
                case "Apple":
                    lblFruitName.Text = lstFruit.SelectedItem.Value.ToString();
                    imgFruit.ImageUrl = "~/img/apple01.jpg";
                    break;
                case "Mango":
                    lblFruitName.Text = lstFruit.SelectedItem.Value.ToString();
                    imgFruit.ImageUrl = "~/img/mango.jpg";
                    break;
                default:
                    break;
            }
        }
    }
}