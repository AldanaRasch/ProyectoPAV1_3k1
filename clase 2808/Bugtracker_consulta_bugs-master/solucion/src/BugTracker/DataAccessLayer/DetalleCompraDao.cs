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
    class DetalleCompraDao
    {
     public IList<DetalleCompra> GetAll()
        {
            List<DetalleCompra> listadoBugs = new List<DetalleCompra>();

            var strSQL = "SELECT codDetalle, idCompra, codProducto, cantidad, precio WHERE borrado=0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSQL);

            foreach( DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(MappingBug(row));
            };
            return listadoBugs;
        }
        private DetalleCompra MappingBug(DataRow row)
     {
        DetalleCompra oDetalleCompra = new DetalleCompra
        {
            CodDetalle= Convert.ToInt32(row["codDetalle"].ToString()),
            IdCompra= Convert.ToInt32(row["idCompra"].ToString()),
            CodProducto= Convert.ToInt32(row["codProducto"].ToString()),
            Cantidad= Convert.ToInt32(row["cantidad"].ToString()),
            Precio= float.Parse(row["precio"].ToString())

        };
        return oDetalleCompra;
     }
    }
}
