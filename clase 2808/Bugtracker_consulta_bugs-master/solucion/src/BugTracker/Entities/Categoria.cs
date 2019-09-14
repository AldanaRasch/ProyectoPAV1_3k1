using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    class Categoria
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }

        public Categoria()
        {

        }
        public Categoria(int idCategoria, string nombre)
        {
            this.IdCategoria = idCategoria;
            this.Nombre = nombre;
        }

        public int getIdCategoria()
        {
            return IdCategoria;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public void setNombre(string nom)
        {
            Nombre = nom;
        }
    }
}
