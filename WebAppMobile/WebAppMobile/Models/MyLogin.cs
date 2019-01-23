using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppMobile.Models
{
    public class MyLogin
    {
        public int ID { get; set; }
        public int UserRoleID { get; set; }
        public String UserPassword { get; set; }
        public String UserName { get; set; }
    }
}