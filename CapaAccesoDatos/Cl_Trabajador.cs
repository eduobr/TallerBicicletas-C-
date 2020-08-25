using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaAccesoDatos
{
    public class Cl_Trabajador
    {
        public int idTrabajador { get; set; }

        public string rut { get; set; }
        public string nombre { get; set; }
        public string cargo { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public DateTime fechaIngreso { get; set; }
        public int sueldo { get; set; }
        public string estado { get; set; }
    }
}