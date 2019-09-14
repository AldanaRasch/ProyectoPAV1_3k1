using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    class Compra
    {
        public int NroComprobante { get; set; }
        public DateTime Fecha { get; set; }
        public int Empleado { get; set; }

        public override string ToString()
        {
            return "NroComprobante" + NroComprobante + "Fecha" + Fecha + "Empleado" + Empleado;
        }
    }

}
