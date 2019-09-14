using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.DataAccessLayer
{
    class CategoriaDao
    {
        public IList<Categoria> GetAll()
        {
            List<Categoria> listadoBugs = new List<Categoria>();

            var strSql = "SELECT id_categoria, nombre from Categorias";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(MappingBug(row));
            }

            return listadoBugs;
        }

        private Categoria MappingBug(DataRow row)
        {
            Categoria oCategoria = new Categoria
            {
                IdCategoria = Convert.ToInt32(row["id_categoria"].ToString()),
                Nombre = row["nombre"].ToString()
            };

            return oCategoria;
        }
    }
}
