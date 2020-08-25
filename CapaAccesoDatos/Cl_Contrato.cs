using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapaAccesoDatos
{
    public class Cl_Contrato
    {
        public int idContrato { get; set; }

        public string rutaAfp { get; set; }
        public byte[] afp { get; set; }

        public string rutaSalud { get; set; }
        public byte[] salud { get; set; }

        public string rutaCarnet { get; set; }
        public byte[] carnet { get; set; }

        public string rutaCerNacimiento { get; set; }
        public byte[] cerNacimiento { get; set; }

        public string rutaCerResidencia { get; set; }
        public byte[] cerResidencia { get; set; }

    }
}