using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueadero.CNeg
{
    class cNeg
    {
        CDatos.Datos da = new CDatos.Datos();
        

        public int Tarifaing(string tiping, string tipveh)
        {
            int val=da.tarifaind(tiping, tipveh);            
            return val;
        }
        public void exit(string placa, string fecha, int tarifa)
        {
            da.salida(placa, fecha, tarifa);
        }
        public DataTable conscli()
        {
            DataTable dt = new DataTable();
            dt=da.consultacli();
            return dt;
        }
        
        public void ingrCl(string ced, string nomb, string tel)
        {
            da.ingCliente(ced, nomb, tel);
        }
    }
}
