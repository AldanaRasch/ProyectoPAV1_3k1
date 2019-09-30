using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.BusinessLayer
{
    class ConsultarStockController
    {
        List<Stock> stock = new List<Stock>();
        DBHelper dbContext = DBHelper.GetDBHelper();

        public ConsultarStockController()
        {
            DataTable tablaProducto = dbContext.ConsultaSQL("select * from Stock");

            foreach (DataRow row in tablaProducto.Rows)
            {
                int codProd = int.Parse(row["codProducto"].ToString());
                int cantActual = int.Parse(row["cantActual"].ToString());
                int cantMin = int.Parse(row["cantMin"].ToString());

                Stock s = new Stock(codProd, cantActual, cantMin);
                stock.Add(s);

            }
        }


        public int consultarStockActualDelProducto(Producto p)
        {
            Stock stockProd = stock.ElementAt(p.getIdProducto()-1);
            return stockProd.cantidadDelProducto();

        }
    }
}
