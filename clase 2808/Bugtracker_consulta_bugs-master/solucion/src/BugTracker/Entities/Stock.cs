using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    class Stock
    {
        public int CodProducto { get; internal set; }
        public int CantActual { get; internal set; }
        public int CantMin { get; internal set; }

        public Stock()
        {
        }

        public Stock(int codProducto, int cantActual, int cantMin)
        {
            this.CodProducto = codProducto;
            this.CantActual = cantActual;
            this.CantMin = cantMin;
        }


        public int cantidadDelProducto()
        {
            return CantActual;
        }

        public int getCodProducto()
        {
            return CodProducto;
        }

        public int getCantMin()
        {
            return CantMin;
        }
    }
}
