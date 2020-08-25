using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    
    public class Cl_Usuario
    {
        
        public int idUsuario { get; set; }
        
        public string user { get; set; }
        
        public string pass { get; set; }

        
        public int idTipoUsuario { get; set; }

        
        public int idTrabajador { get; set; }

        public Cl_Usuario()
        {

        }
    }
}
