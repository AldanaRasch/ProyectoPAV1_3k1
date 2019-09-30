using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.BusinessLayer
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
                "SELECT * FROM Productos");

            DataTable tablaStock = dbContext.ConsultaSQL(
                "select * from Stock");

            foreach (DataRow row in tablaProducto.Rows)
            {
                int idProd = int.Parse(row["id_producto"].ToString());
                string nomProd = row["nombre"].ToString();
                int id_categ_prod = int.Parse(row["id_categoria"].ToString());
                decimal precioVenta = decimal.Parse(row["precioVenta"].ToString());

                ConsultarCategoriasController ccc = new ConsultarCategoriasController();

                CategoriaService categoria = ccc.obtenerCategoria(id_categ_prod);
                int idCate = categoria.getIdCategoria();

                Producto nuevoProd = new Producto(idProd, nomProd, idCate, precioVenta);
                productos.Add(nuevoProd);
            }

            foreach(DataRow row in tablaStock.Rows)
            {
                int codProd = int.Parse(row["codProducto"].ToString());
                int cantActual = int.Parse(row["cantActual"].ToString());
                int cantMin = int.Parse(row["cantMin"].ToString());

                Stock nuevoStock = new Stock(codProd,cantActual,cantMin);
                stock.Add(nuevoStock);
            }

        }

        public List<Producto> getProductos()
        {
            return productos;
        }

        public List<Stock> getStock()
        {
            return stock;
        }


        //public int stockProducto(int codProducto)
        //{
        //    Producto p = new Producto();
        //    p = productos.ElementAt(codProducto-1);

        //    ConsultarStockController csc = new ConsultarStockController();

        //    int stockActual = csc.consultarStockActualDelProducto(p);

        //    return stockActual;

        //}



    }

}
