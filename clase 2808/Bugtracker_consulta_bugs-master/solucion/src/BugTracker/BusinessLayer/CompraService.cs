using BugTracker.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.BusinessLayer
{
    class CompraService
    {
        CompraDao oCaompraDao;

        CompraService()
        {
            oCaompraDao = new CompraDao();
        }
    }
}
