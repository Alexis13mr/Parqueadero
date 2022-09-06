using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueadero.CDatos
{
    class Conexion
    {
        SqlConnection conex;
        public Conexion()
        {
            conex = new SqlConnection("Server=ALX\\SQLEXPRESS;Database=PARQUEADERO;integrated security=true");
        }
        public SqlConnection conectar()
        {
            try
            {
                conex.Open();
                return conex;
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public bool desconectar()
        {
            try
            {
                conex.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}
