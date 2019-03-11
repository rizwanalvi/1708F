using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppLogin.Models
{
    public class DAOLogin
    {
        SqlConnection _sqlconn = null;
        public DAOLogin()
        {
            _sqlconn = ConnectionDb.getInstance().getConnection();

        }
        public void InsertLoginUser(MyLogin lg)
        {
            if (_sqlconn.State == System.Data.ConnectionState.Closed)
                _sqlconn.Open();
            SqlCommand _cmd = new SqlCommand("INSERT INTO tbLogin VALUES(@RID,@USERNAME,@UPASS)", _sqlconn);
            _cmd.Parameters.AddWithValue("@ID", lg.UserRole);
            _cmd.Parameters.AddWithValue("@UNAME", lg.UserName);
            _cmd.Parameters.AddWithValue("@UPASS", lg.UserPassword);

            _cmd.ExecuteNonQuery();
            _sqlconn.Close();
        }

        public bool IsValidUser(MyLogin lg) {
            if (_sqlconn.State == System.Data.ConnectionState.Closed)
                _sqlconn.Open();
            SqlCommand _cmd = new SqlCommand("SELECT COUNT(*) FROM TBLOGIN WHERE UNAME =@UNAME AND UPASS =@UPASS", _sqlconn);
            _cmd.Parameters.Add("@UNAME", lg.UserName);
            _cmd.Parameters.Add("@UPASS", lg.UserPassword);
            int i = int.Parse(_cmd.ExecuteScalar().ToString());
            _sqlconn.Close();
            return i>0?true:false;
        }
    }
}