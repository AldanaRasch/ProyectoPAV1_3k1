using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    class Producto
    {
        int idProducto { get; set; }
        string nombre { get; set; }
        Categoria categoria { get; set; }
        float precioVenta { get; set; }
    }
}
