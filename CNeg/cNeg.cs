using System;
using System.Collections.Generic;
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
    }
}
