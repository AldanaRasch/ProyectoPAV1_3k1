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
    class CompraDao
    {
        public IList<Compra> GetAll()
        {
            List<Compra> listadoBugs = new List<Compra>();

            var strSql = "SELECT nroComprobante, fecha, empleado FROM Compras";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(MappingBug(row));
            }

            return listadoBugs;
        }

        private Compra MappingBug(DataRow row)
        {
            Compra oCompra = new Compra
            {
                NroComprobante = Convert.ToInt32(row["nroComprobante"].ToString()),
                Fecha = Convert.ToDateTime(row["fecha"].ToString()),
                Empleado = Convert.ToInt32(row["empleado"].ToString())                
            };

            return oCompra;
        }
    }
}
