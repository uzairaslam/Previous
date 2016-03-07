using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginClass
    {
        //retrieves User_Id
        public bool getUserId(string UserName,string Password)
        {

            User_Id = 0;

            using (SqlConnection conn = DB.getSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "LoginOMR";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@UserName", UserName));
                    cmd.Parameters.Add(new SqlParameter("@Password", Password));
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        User_Id = int.Parse(dr[0].ToString());
                        CanBarCodeExcpt = bool.Parse(dr[1].ToString());
                        CanShiftExcpt = bool.Parse(dr[2].ToString());
                        CanPaperCodeExcpt = bool.Parse(dr[3].ToString());
                        CanRollNoExcpt = bool.Parse(dr[4].ToString());
                        CanSheetExcpt = bool.Parse(dr[5].ToString());
                    }

                }
            }
            return User_Id > 0 ? true : false;
        }
        public static int User_Id { get; set; }
        public static bool CanBarCodeExcpt { get; set; }
        public static bool CanShiftExcpt { get; set; }
        public static bool CanPaperCodeExcpt { get; set; }
        public static bool CanRollNoExcpt { get; set; }
        public static bool CanSheetExcpt { get; set; }

    }
}
