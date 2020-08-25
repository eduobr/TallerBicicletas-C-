using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class Cl_Comprobante
    {
        public string rut { get; set; }
        public string nombre { get; set; }
        public DateTime fecha { get; set; }
        public string tipoComprobante { get; set; }
    }
}
