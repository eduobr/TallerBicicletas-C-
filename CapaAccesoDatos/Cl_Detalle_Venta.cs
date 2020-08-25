using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaAccesoDatos
{
    public class Cl_Detalle_Venta
    {
        public byte[] imagen { get; set; }
        public string nombre { get; set; }
        public string modelo { get; set; }
        public string estado { get; set; }
        public int cantidad { get; set; }
        public int total { get; set; }
        public int idProducto { get; set; }
        public int idDetalleVenta { get; set; }

    }
}