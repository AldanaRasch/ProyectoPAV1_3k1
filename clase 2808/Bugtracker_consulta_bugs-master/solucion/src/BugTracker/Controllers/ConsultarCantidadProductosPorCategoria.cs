using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Controllers
{
    class ConsultarCantidadProductosPorCategoria
    {
        List<Producto> productos = new List<Producto>();
        List<Stock> stock = new List<Stock>();
        //ATRIBUTOS
        DBHelper dbContext = DBHelper.GetDBHelper();

        //METODOS
        public ConsultarCantidadProductosPorCategoria()
        {
            DataTable tablaProducto = dbContext.ConsultaSQL(
                "select * from Productos");

            DataTable tablaCategoria = dbContext.ConsultaSQL(
                "select * from Categorias");

            DataTable tablaStock = dbContext.ConsultaSQL(
                "select * from Stock");

            foreach (DataRow row in tablaProducto.Rows)
            {
                int idProd = int.Parse(row["id_producto"].ToString());
                string nomProd = row["nombre"].ToString();
                int id_categ_prod = int.Parse(row["id_categoria"].ToString());
                float precioVenta = float.Parse(row["Stock"].ToString());
            }

            //foreach (DataRow row in tablaCategoria.Rows)
            //{
            //    id_categoria = int.Parse(row["id_producto"].ToString());
            //    nomProd = row["nombre"].ToString();
            //    id_categ_prod = int.Parse(row["id_categoria"].ToString());
            //    precioVenta = int.Parse(row["Stock"].ToString());
            //}

        }



        public int stockProducto(int codProducto)
        {
            Producto p = new Producto();
            p = productos.ElementAt(codProducto-1);

            ConsultarStockController csc = new ConsultarStockController();

            int stockActual = csc.consultarStockActualDelProducto(p);

            return stockActual;

        }



    }

}
