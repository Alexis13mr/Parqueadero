using System;
using System.Collections.Generic;
using System.Data;
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

        public void ingreso(string placa, int cli_Id, string tipIng, string tipVeh, string fecIn, string fecSal, int val, int estpay)
        {
            comnd.Connection = con.conectar();
            comnd.CommandText = "Ingreso_Cliente";
            comnd.CommandType = CommandType.StoredProcedure;
            comnd.Parameters.AddWithValue("@placa", placa);
            comnd.Parameters.AddWithValue("@Client_Id", cli_Id);
            comnd.Parameters.AddWithValue("@Tip_Ing", tipIng);
            comnd.Parameters.AddWithValue("@Tip_Veh", tipVeh);
            comnd.Parameters.AddWithValue("@Fech_Ing", DateTime.Now.ToString("dd-MM-AAAA HH:mm:ss"));
            comnd.Parameters.AddWithValue("@Fech_Sal", DateTime.MaxValue.ToString("dd-MM-AAAA HH:mm:ss"));
            comnd.Parameters.AddWithValue("@Valor", val);
            comnd.Parameters.AddWithValue("@Est_Pay", estpay);
            comnd.ExecuteNonQuery();
            comnd.Parameters.Clear();
        }
    }    
}
