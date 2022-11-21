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
        private static string username;
        private static string password;
        private static short groupe_id;

        public static bool connect(string user,string pass) {
            if(Connection.connect()) {
                SqlCommand sc = new SqlCommand("select * from Utilisateurs where username=@username and pasword =@password", Connection.SC);
                sc.Parameters.AddWithValue("@username", user);
                sc.Parameters.AddWithValue("@password",pass);
                sc.ExecuteNonQuery();

                return true;
            }
            return false;
        }
    }
}
