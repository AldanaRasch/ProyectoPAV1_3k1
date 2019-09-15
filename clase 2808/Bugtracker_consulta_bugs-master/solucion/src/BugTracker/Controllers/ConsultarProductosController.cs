using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Controllers
{
    class ConsultarProductosController
    {
        private List<Producto> productos = new List<Producto>();
        DBHelper dbContext = DBHelper.GetDBHelper();
        private ConsultarCategoriasController ccc = new ConsultarCategoriasController();

        public ConsultarProductosController()
        {
            
            DataTable tablaProducto = dbContext.ConsultaSQL("select * from Productos");

            foreach(DataRow row  in tablaProducto.Rows)
            {
                Producto prod = new Producto();
                int idProd = int.Parse(row["id_producto"].ToString());
                string nombre = row["nombre"].ToString();
                Categoria categoria = ccc.obtenerCategoria(int.Parse(row["id_categoria"].ToString()));
                float precioVta = float.Parse(row["precioVenta"].ToString());
                productos.Add(prod);

            }
        }
    }

    
}
