using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
namespace AlarmTech.Model
{
    class Connection
    {
        public static MySqlConnection con;
        public static MySqlConnection TryConnection()
        {
            MySqlConnectionStringBuilder Builder = new MySqlConnectionStringBuilder();
            Builder.Port = 3306;
            Builder.Server = "sql3.freemysqlhosting.net";
            Builder.Database = "sql3476285";
            Builder.UserID = "sql3476285";
            Builder.Password = "MZ2gvs5Ef4";
            try
            {
                con = new MySqlConnection(Builder.ToString());
                con.Open();
            }
            catch (Exception e)
            {
                con = null;
                throw new Exception("Ha ocurrido un error"+e);
                
                
            }
            return con;

        }
        public static void Cerrar() {
            con.Close();
        }
    }
}
