using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    class Empleado
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public int Usuario { get; set; }

        public override string ToString()
        {
            return "Dni" + Dni + "Nombre" + Nombre + "Usuario" + Usuario;
        }
    }
}
