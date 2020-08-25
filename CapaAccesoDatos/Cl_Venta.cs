using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaAccesoDatos
{
    public class Cl_Venta
    {
        public int idVenta { get; set; }
        public string nombreCompleto { get; set; }
        public DateTime fecha { get; set; }
        public string estado { get; set; }
        public int cantidad { get; set; }
        public int total { get; set; }
        public int idTrabajador { get; set; }
        public int idCliente { get; set; }
        public string tipoPago { get; set; }

    }
}