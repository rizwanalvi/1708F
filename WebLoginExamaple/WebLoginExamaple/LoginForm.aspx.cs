using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLoginExamaple
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ValidateUser(object sender, AuthenticateEventArgs e)
        {
           
           FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);
           // FormsAuthentication.SetAuthCookie(Login1.UserName, Login1.RememberMeSet);
        }
    }
}