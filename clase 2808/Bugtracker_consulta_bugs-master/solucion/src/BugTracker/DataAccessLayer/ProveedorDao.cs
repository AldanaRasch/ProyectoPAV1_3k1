using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.DataAccessLayer
{
    class ProveedorDao
    {
        public IList<Proveedor> GetAll()
        {
            List<Proveedor> listadoBugs = new List<Proveedor>();

            var strSql = "SELECT nroProveedor, razonSocial, CUIT, telefono FROM Empleados";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(MappingBug(row));
            }

            return listadoBugs;

        }
        private Proveedor MappingBug(DataRow row)
        {
            Proveedor oProveedor = new Proveedor
            {
                NroProveedor = Convert.ToInt32(row["nroProveedor"].ToString()),
                RazonSocial = row["razonSocial"].ToString(),
                CUIT = Convert.ToInt32(row["CUIT"].ToString()),
                Telefono = row["telefono"].ToString()
            };
            return oProveedor;
        }
    }
}
