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
    class VentaDao
    {
        public IList<Venta> GetAll()
        {
            List<Venta> listadoBugs = new List<Venta>();

            var strSQL= " SELECT nroComprobante, fecha, empleado WHERE borrado=0";

            var resultadoConsulta =DBHelper.GetDBHelper().ConsultaSQL(strSQL);

            foreach (DataRow row in resultadoConsulta.Rows) {
                listadoBugs.Add(MappingBug(row));

            }

            return listadoBugs;
        }

        private Venta MappingBug(DataRow row)
        {
            Venta oVenta = new Venta
            {
                NroComprobante = Convert.ToInt32(row["nroComprobante"].ToString()),
                Fecha = Convert.ToDateTime(row["fecha"].ToString()),
                Empleado = Convert.ToInt32(row["empleado"].ToString())
            };
            return oVenta;
        }
    }
}
