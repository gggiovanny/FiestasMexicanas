using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiestasMexicanas
{
    class clsCatalogo
    {
        public string TABLA;
        public string prefijo;

        public clsCatalogo(string TABLA, string prefijo)
        {
            this.TABLA = TABLA;
            this.prefijo = prefijo;
        }
    }
}
