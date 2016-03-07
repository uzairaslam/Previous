using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DB
    {
        public static string ConnectionString 
        { 
            get
            {
                return ConfigurationManager.ConnectionStrings["ORMConnection"].ConnectionString;
            }
        }

        //Return opened connection object
        public static SqlConnection getSqlConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
