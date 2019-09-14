using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    class Categoria
    {
        int idCategoria;
        string nombre;

        public Categoria(int idCategoria, string nombre)
        {
            this.idCategoria = idCategoria;
            this.nombre = nombre;
        }

        public int getIdCategoria()
        {
            return idCategoria;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nom)
        {
            nombre = nom;
        }
    }
}
