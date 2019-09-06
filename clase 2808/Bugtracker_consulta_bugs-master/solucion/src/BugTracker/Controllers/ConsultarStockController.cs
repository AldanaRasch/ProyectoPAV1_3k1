using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Controllers
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
                float cantMin = float.Parse(row["cantMin"].ToString());
            }
        }

        
        //public int consultarStockActualDelProducto(int codProd)
        //{
        //    Stock stockProd = null;

        //    foreach(Stock s in stock)
        //    {
        //        if(s.getCodProducto() == codProd)
        //        {
        //            stockProd = s;
        //        }
        //    }
        //    return stockProd.cantidadDelProducto();

        //}
    }
}
