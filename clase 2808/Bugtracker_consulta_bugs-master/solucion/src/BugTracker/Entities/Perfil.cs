using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    class Perfil
    {
        public int IdPerfil { get; set; }
        public int Nombre { get; set; }
        public override string ToString()
        {
            return "IdPerfil" + IdPerfil + "Nombre" + Nombre;
        }
    }
}
