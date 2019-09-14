using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    class Stock
    {
        private int codProducto;
        private int cantActual;
        private int cantMin;

        public Stock()
        {
        }

        public Stock(int codProducto, int cantActual, int cantMin)
        {
            this.codProducto = codProducto;
            this.cantActual = cantActual;
            this.cantMin = cantMin;
        }


        public int cantidadDelProducto()
        {
            return cantActual;
        }

        public int getCodProducto()
        {
            return codProducto;
        }

        public int getCantMin()
        {
            return cantMin;
        }
    }
}
