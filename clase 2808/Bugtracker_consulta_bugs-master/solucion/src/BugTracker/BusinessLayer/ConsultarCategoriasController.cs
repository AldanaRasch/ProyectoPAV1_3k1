using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.BusinessLayer
{
    class ConsultarCategoriasController
    {
        List<CategoriaService> categorias = new List<CategoriaService>();
        DBHelper dbContext = DBHelper.GetDBHelper();

        public ConsultarCategoriasController()
        {
            DataTable tablaProducto = dbContext.ConsultaSQL("SELECT * FROM Categorias");

            foreach (DataRow row in tablaProducto.Rows)
            {       
                int idCateg = int.Parse(row["id_categoria"].ToString());
                string nombre = row["nombre"].ToString();

                CategoriaService prod = new CategoriaService(idCateg, nombre);
                categorias.Add(prod);
            }

        }

        public CategoriaService obtenerCategoria(int index)
        {
            CategoriaService cat = categorias.ElementAt(index - 1);
            return cat;
        }

        public List<CategoriaService> obtenerListCategorias()
        {
            return categorias;
        }
    }
}
