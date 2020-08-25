using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class Cl_Despacho
    {
        public int idDespacho { get; set; }
        public string rut { get; set; }

        public string nombre { get; set; }
        public string direccion { get; set; }
        public string comuna { get; set; }
        public DateTime fechaPedido { get; set; }
        public string estado { get; set; }
        public int idVenta { get; set; }
    }
}
