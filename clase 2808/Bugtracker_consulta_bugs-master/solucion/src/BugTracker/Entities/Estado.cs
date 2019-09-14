using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    class Estado
    {
        public int IdEstado { get; set; }
        public string Nombre { get; set; }
        public override string ToString()
        {
            return "IdEstado" + IdEstado + "Nombre" + Nombre;
        }
    }
}
