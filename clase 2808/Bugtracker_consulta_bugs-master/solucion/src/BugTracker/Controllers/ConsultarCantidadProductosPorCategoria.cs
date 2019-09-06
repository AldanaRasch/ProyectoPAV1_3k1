using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Controllers
{
    class ConsultarCantidadProductosPorCategoria
    {
        //ATRIBUTOS
        private List<Producto> productos = new List<Producto>();
        private List<Stock> stock_prod = new List<Stock>();


        //METODOS
        public ConsultarCantidadProductosPorCategoria()
        {
            
        }

        public ConsultarCantidadProductosPorCategoria(List<Producto> producto, List<Stock> stock)
        {
            this.productos = producto;
            this.stock_prod = stock;
        }


        public int stockProducto(int index)
        {
            Producto p = new Producto();
            p = productos.ElementAt(index);

            ConsultarStockController csc = new ConsultarStockController();
            

        }



    }

}
