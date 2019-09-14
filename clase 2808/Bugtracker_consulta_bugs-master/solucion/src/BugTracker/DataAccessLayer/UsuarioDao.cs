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
    class UsuarioDao
    {
        public IList<Usuario> GetAll()
        {
            List<Usuario> listadoBugs = new List<Usuario>();

            var strSql = "SELECT id_usuario, id_perfil, usuario, password, email, estado WHERE borrado=0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            //foreach (DataRow row in resultadoConsulta.Rows)
            //{
            //    listadoBugs.Add(MappingBug(row);
            //}

            return listadoBugs;
        }
    }
}
