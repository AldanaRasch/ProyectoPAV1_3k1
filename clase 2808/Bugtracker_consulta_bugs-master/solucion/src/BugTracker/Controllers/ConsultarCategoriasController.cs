using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Controllers
{
    class ConsultarCategoriasController
    {
        List<Categoria> categorias = new List<Categoria>();
        DBHelper dbContext = DBHelper.GetDBHelper();

        public ConsultarCategoriasController()
        {
            DataTable tablaProducto = dbContext.ConsultaSQL("SELECT * FROM Categorias");

            foreach (DataRow row in tablaProducto.Rows)
            {       
                int idCateg = int.Parse(row["id_categoria"].ToString());
                string nombre = row["nombre"].ToString();

                Categoria prod = new Categoria(idCateg, nombre);
                categorias.Add(prod);
            }

        }

        public Categoria obtenerCategoria(int index)
        {
            Categoria cat = categorias.ElementAt(index - 1);
            return cat;
        }

        public List<Categoria> obtenerListCategorias()
        {
            return categorias;
        }
    }
}
