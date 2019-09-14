using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    class Usuario
    {
        public int IdUsuario {get; set;}
        public int IdPerfil { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Estado { get; set; }

        public override string ToString()
        {
            return NombreUsuario;
        }
    }
}
