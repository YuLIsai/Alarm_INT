using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
namespace AlarmTech.Model
{
    public class Registro
    {
        public static bool Registro_u(Usuario c)
        {
            bool right = false;
            try
            {
                String sql = String.Format("insert into usuario values(null,null,'{0}','{1}','{2}','{3}',now(),now() )",
                    c.Nombre, c.Apellidos, c.Correo_electronico, c.contrasena);
                MySqlCommand cmd = new MySqlCommand(sql, Connection.TryConnection());
                cmd.ExecuteNonQuery();

                right = true;
                Connection.Cerrar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return right;
        }
    }
}
