using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.DataAccessLayer
{
    class StockDao
    {
        public IList<Stock> GetAll()
        {
            List<Stock> listadoBugs = new List<Stock>();

            var strSql = "SELECT codProducto, cantActual, cantMin from Categorias";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(MappingBug(row));
            }

            return listadoBugs;
        }

        private Stock MappingBug(DataRow row)
        {
            Stock oStock = new Stock
            {
                CodProducto = Convert.ToInt32(row["codProducto"].ToString()),
                CantActual = Convert.ToInt32(row["cantactual"].ToString()),
                CantMin = Convert.ToInt32(row["cantMin"].ToString())
            };

            return oStock;
        }
    }
}
