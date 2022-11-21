using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionEcole
{
    class Utilisateurs
    {
        public static string username;
        private static short groupe_id;

        public static bool connect(string user,string pass) {
            if(Connection.connect()) {
                SqlCommand sc = new SqlCommand("select username,groupe_id from Utilisateurs where username=@username and pasword =@password", Connection.SC);
                sc.Parameters.AddWithValue("@username", user);
                sc.Parameters.AddWithValue("@password",pass);
                SqlDataReader dr=  sc.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        username=dr["username"].ToString();
                        groupe_id=short.Parse(dr["groupe_id"].ToString());
                        return true;
                    }
                }

                return false;
            }
            return true;
        }
    }
}
