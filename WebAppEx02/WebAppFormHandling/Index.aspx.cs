using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppFormHandling.Models;
namespace WebAppFormHandling
{
   
    public partial class Index : System.Web.UI.Page
    {
        List<Customer> _cust = new List<Customer>();

       
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text;
            lbage.InnerText = TextBox2.Text;
            FileUpload1.SaveAs(Server.MapPath("~/img/"+ FileUpload1.FileName));
            ImgPic.ImageUrl = "~/img/" + FileUpload1.FileName;

        }
    }
}