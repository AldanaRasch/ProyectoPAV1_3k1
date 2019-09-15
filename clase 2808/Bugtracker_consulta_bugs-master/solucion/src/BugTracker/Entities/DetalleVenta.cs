using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    class DetalleVenta
    {
        public int IdVenta { get; set; }
        public int CodDetalle { get; set; }
        public int CodProducto { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }

        public override string ToString()
        {
            return "CodDetalle" + CodDetalle + "IdVenta" + IdVenta + "CodProducto" + CodProducto + "Cantidad" + Cantidad + "Precio" + Precio;
        }
    }
}
