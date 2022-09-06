using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueadero.CDatos
{
    class Datos
    {
        Conexion con = new Conexion();
        SqlCommand comnd = new SqlCommand();

        private void ingreso()
        {
            comnd.Connection = con.conectar();


        }
    }    
}
