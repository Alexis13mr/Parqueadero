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
            comnd.Parameters.AddWithValue("@Fech_Ing", DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
            comnd.Parameters.AddWithValue("@Fech_Sal", DateTime.MaxValue.ToString("dd-MM-yyyy HH:mm:ss"));
            comnd.Parameters.AddWithValue("@Valor", val);
            comnd.Parameters.AddWithValue("@Est_Pay", estpay);
            comnd.ExecuteNonQuery();
            comnd.Parameters.Clear();
            con.desconectar();
        }
        public DataTable consultat()
        {
            comnd.Connection = con.conectar();
            comnd.CommandText = "Consulta_General";
            comnd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = comnd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.desconectar();
            return dt;
        }
        public DataTable consultind(string placa)
        {
            comnd.Connection = con.conectar();
            comnd.CommandText = "Consulta_Ingreso";
            comnd.CommandType = CommandType.StoredProcedure;
            comnd.Parameters.AddWithValue("@placa", placa);
            SqlDataReader dr = comnd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            comnd.Parameters.Clear();
            con.desconectar();
            return dt;
        }
        public int tarifaind(string tiping, string tipveh)
        {
            int valorind;
            
            comnd.Connection = con.conectar();
            comnd.CommandText = "Tarifa_Ingreso";
            comnd.CommandType = CommandType.StoredProcedure;
            comnd.Parameters.AddWithValue("@tipveh", tipveh);
            comnd.Parameters.AddWithValue("@tiping", tiping);
            SqlDataReader dr = comnd.ExecuteReader();
            if (dr.Read())
            {
                valorind = int.Parse(dr["valor"].ToString());
                comnd.Parameters.Clear();
                con.desconectar();
                return valorind;
            }
            else
            {
                comnd.Parameters.Clear();
                con.desconectar();
                return 0;
            }            
        }

        public void salida(string placa, string fecha, int tarifa)
        {
            comnd.Connection = con.conectar();
            comnd.CommandText = "Salida";
            comnd.CommandType = CommandType.StoredProcedure;
            comnd.Parameters.AddWithValue("@placa", placa);
            comnd.Parameters.AddWithValue("@fecha", fecha);
            comnd.Parameters.AddWithValue("@tarifa", tarifa);
            comnd.ExecuteNonQuery();
            comnd.Parameters.Clear();
            con.desconectar();
        }

    }    
}
