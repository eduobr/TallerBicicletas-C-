using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CapaAccesoDatos
{
    public class Cl_Persona
    {
        
        public string rut { get; set; }
        public string  nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public string comuna { get; set; }
        public int idComuna { get; set; }

    }
}