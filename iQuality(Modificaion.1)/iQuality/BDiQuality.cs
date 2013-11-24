using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace iQuality
{
    class BDiQuality
    {
        public MySqlConnection conexion_iQuality;
        public void crearconexion()
        {
            string conec = "Server=localhost;database=iquality;uid=root;pwd=g4rs14;";
            conexion_iQuality = new MySqlConnection(conec);
            conexion_iQuality.Open();
        }
        public void cerrarconexion()
        {
            conexion_iQuality.Close();
        }
        public MySqlConnection getConexion()
        {
            return conexion_iQuality;
        }
    }
}
