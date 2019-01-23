using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebAppMobile.Models;
namespace WebAppMobile.Models
{
    public class DOAMobile
    {
        SqlConnection _sqlconn = null;
        public DOAMobile() {
            //_sqlconn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=dbMobile;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _sqlconn = ConnectionDb.getInstance().getConnection();
        }
        public void InsertMobile(Mobile mb) {
            if (_sqlconn.State == System.Data.ConnectionState.Closed)
                _sqlconn.Open();
            SqlCommand _cmd = new SqlCommand("INSERT INTO MOBILE VALUES(@NAME,@MODEL,@BRAND,@IMGPATH)", _sqlconn);
            _cmd.Parameters.AddWithValue("@NAME", mb.MobileName);
            _cmd.Parameters.AddWithValue("@MODEL", mb.MobileModel);
            _cmd.Parameters.AddWithValue("@BRAND", mb.Brand);
            _cmd.Parameters.AddWithValue("@IMGPATH", mb.ImagePath);
            _cmd.ExecuteNonQuery();
            _sqlconn.Close();
        }
        public void UpdateMobile(Mobile mb)
        {
            if (_sqlconn.State == System.Data.ConnectionState.Closed)
                _sqlconn.Open();
            SqlCommand _cmd = new SqlCommand("UPDATE MOBILE SET NAME=@NAME,MODEL=@MODEL,BRAND=@BRAND,IMGPATH=@IMGPATH WHERE ID=@ID", _sqlconn);
            _cmd.Parameters.AddWithValue("@NAME", mb.ID);
            _cmd.Parameters.AddWithValue("@NAME", mb.MobileName);
            _cmd.Parameters.AddWithValue("@MODEL", mb.MobileModel);
            _cmd.Parameters.AddWithValue("@BRAND", mb.Brand);
            _cmd.Parameters.AddWithValue("@IMGPATH", mb.ImagePath);
            _cmd.ExecuteNonQuery();
            _sqlconn.Close();
        }
    }
}