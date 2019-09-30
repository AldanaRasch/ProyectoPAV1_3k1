using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.DataAccessLayer;


namespace BugTracker.BusinessLayer
{
    class UsuarioService
    {
        UsuarioDao oUsuarioDao;

        UsuarioService()
        {
            oUsuarioDao = new UsuarioDao();
        }
    }
}
