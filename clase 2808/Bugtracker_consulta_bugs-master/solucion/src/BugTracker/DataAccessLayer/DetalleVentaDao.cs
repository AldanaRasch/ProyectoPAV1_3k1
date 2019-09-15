using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using BugTracker.Entities;
using System.Data;

namespace BugTracker.DataAccessLayer
{
    class DetalleVentaDao
    {
        public IList<DetalleVenta> GetAll()
        {
            List<DetalleVenta> listadoBugs = new List<DetalleVenta>();

            var strSQL = "SELECT idVenta, codDetalle, codProducto, cantidad, precio FROM DetalleVenta";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSQL);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
               listadoBugs.Add(MappingBug(row));
            }
            return listadoBugs;
        }

        private DetalleVenta MappingBug(DataRow row)
        {
            DetalleVenta oDetalleVenta = new DetalleVenta
            {
                IdVenta = Convert.ToInt32(row["idVenta"].ToString()),
                CodDetalle = Convert.ToInt32(row["codDetalle"].ToString()),
                CodProducto = Convert.ToInt32(row["codProducto"].ToString()),
                Cantidad = Convert.ToInt32(row["cantidad"].ToString()),
                Precio = float.Parse(row["precio"].ToString())
            };
            return oDetalleVenta;
        }
    }
}
