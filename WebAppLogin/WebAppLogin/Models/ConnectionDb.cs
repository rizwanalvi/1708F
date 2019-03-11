﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppLogin.Models
{
    public class ConnectionDb
    {
        private static ConnectionDb Instance = null;
        private SqlConnection _SqlConn = null;
        private ConnectionDb()
        {

        }

        public static ConnectionDb getInstance()
        {
            if (Instance == null)
                Instance = new ConnectionDb();
            return Instance;
        }

        public SqlConnection getConnection()
        {
            if (Instance == null)
                getInstance();

            _SqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);
            return _SqlConn;
        }
    }
}