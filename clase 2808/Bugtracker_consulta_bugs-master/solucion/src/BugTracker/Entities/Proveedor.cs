using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    class Proveedor
    {
        public int NroProveedor { get; set; }
        public string RazonSocial { get; set; }
        public int CUIT { get; set; }
        public string Telefono { get; set; }

        public override string ToString()
        {
            return "NroProveedor" + NroProveedor + "RazonSocial" + RazonSocial + "CUIT" + CUIT + "Telefono" + Telefono;
        }
    }
}
