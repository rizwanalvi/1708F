using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using WebAppLogin.Models;
namespace WebAppLogin
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        String Uname = "admin";
        String Upass = "Apple";
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            DAOLogin _login = new DAOLogin();
            //Login1.UserName.Equals(Uname) && Login1.Password.Equals(Upass)
            if (_login.IsValidUser(new MyLogin { UserName=Login1.UserName,UserPassword = Login1.Password}))
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);
            else
            { }
        }
    }
}