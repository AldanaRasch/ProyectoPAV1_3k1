using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.DataAccessLayer;

namespace BugTracker.BusinessLayer
{
    class DetalleVentaService
    {
        DetalleVentaDao oDetVentaDao;

        DetalleVentaService()
        {
            oDetVentaDao = new DetalleVentaDao();
        }
    }
}
