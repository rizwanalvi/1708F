using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppMobile.Models
{
    public class DAOLogin
    {
        SqlConnection _sqlconn = null;
        public DAOLogin() {
            _sqlconn = ConnectionDb.getInstance().getConnection();
           
        }
        public void InsertLoginUser(MyLogin lg) {
            if (_sqlconn.State == System.Data.ConnectionState.Closed)
                _sqlconn.Open();
            SqlCommand _cmd = new SqlCommand("INSERT INTO tbLogin VALUES(@RID,@USERNAME,@UPASS)", _sqlconn);
            _cmd.Parameters.AddWithValue("@RID", lg.UserRoleID);
            _cmd.Parameters.AddWithValue("@USERNAME", lg.UserName);
            _cmd.Parameters.AddWithValue("@UPASS", lg.UserPassword);
        
            _cmd.ExecuteNonQuery();
            _sqlconn.Close();
        }
    }
}