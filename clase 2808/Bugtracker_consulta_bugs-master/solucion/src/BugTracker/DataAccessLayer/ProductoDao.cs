using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.DataAccessLayer
{
    class ProductoDao
    {
        public IList<Producto> GetAll()
        {
            List<Producto> listadoBugs = new List<Producto>();

            var strSql = "SELECT id_producto, nombre, id_categoria, precioVenta from Productos";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(MappingBug(row));
            }

            return listadoBugs;
        }

        private Producto MappingBug(DataRow row)
        {
            Producto oProducto = new Producto
            {
                IdProducto = Convert.ToInt32(row["id_producto"].ToString()),
                Nombre = row["nombre"].ToString(),
                IdCategoria = Convert.ToInt32(row["id_categoria"].ToString()),
                PrecioVenta = Convert.ToDecimal(row["precioVenta"].ToString())
            };

            return oProducto;
        }
    }
}
