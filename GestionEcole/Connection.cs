using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionEcole
{
    static class Connection
    {
        static string CN = @"Data Source=CC1-CC31-16;Integrated Security=true;Initial Catalog=schoolDB;";
        static SqlConnection sc = null;
        
        public static bool connect() {
            sc = new SqlConnection(Connection.CN);
            sc.Open();
            return sc.State == System.Data.ConnectionState.Open;
        }
        public static void disconnect()
        {
            sc.Close();   
        }
        public static SqlConnection SC
        {
            get
            {
                if (sc != null)
                {
                    return sc;
                }
                else
                {
                    throw new Exception("erro connection");
                }
                
            }
        }
    }
}
