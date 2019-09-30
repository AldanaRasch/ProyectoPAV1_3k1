using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.DataAccessLayer
{
    class PerfilDao
    {
        public IList<Perfil> GetAll()
        {
            List<Perfil> listadoBugs = new List<Perfil>();

            var strSql = "SELECT id_perfil, nombre from Categorias";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(MappingBug(row));
            }

            return listadoBugs;
        }

        private Perfil MappingBug(DataRow row)
        {
            Perfil oPerfil = new Perfil
            {
                IdPerfil = Convert.ToInt32(row["id_categoria"].ToString()),
                Nombre = row["nombre"].ToString()
            };

            return oPerfil;
        }
    }
}
