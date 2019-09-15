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
    class EmpleadoDao
    {
        public IList<Empleado> GetAll()
        {
            List<Empleado> listadoBugs = new List<Empleado>();

            var strSql = "SELECT dni, nombre, usuario FROM Empleados";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(MappingBug(row));
            }

            return listadoBugs;

        }
        private Empleado MappingBug(DataRow row)
        {
            Empleado oEmpleado = new Empleado
            {
                Dni = Convert.ToInt32(row["dni"].ToString()),
                Nombre = row["nombre"].ToString(),
                Usuario = Convert.ToInt32(row["usuario"].ToString())
            };
            return oEmpleado;
        }
    }
}
