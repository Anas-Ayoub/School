using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionEcole
{
    static class test
    {
        SqlCommand sc = null;
        public static string select(string table,string[] fields,string[] values)
        {
            string q = "";
            Array.ForEach<string>(fields, (item,index) =>
            {
                q += item.ToString();
                if (index < fields.Length - 1)
                {
                    q += ",";
                }
            });
            return q;
            /*sc = new SqlCommand("select username,groupe_id from Utilisateurs where username=@username and pasword =@password", Connection.SC);
            sc.Parameters.AddWithValue("@username", user);
            sc.Parameters.AddWithValue("@password", pass);
            SqlDataReader dr = sc.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    username = dr["username"].ToString();
                    groupe_id = short.Parse(dr["groupe_id"].ToString());
                    return true;
                }
            }*/
        }
    }
}
