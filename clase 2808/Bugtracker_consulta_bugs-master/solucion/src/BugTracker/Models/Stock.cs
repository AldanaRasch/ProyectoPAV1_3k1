using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    class Stock
    {
        int codProducto;
        int cantActual;
        int catnMin;

        public Stock()
        {
        }

        public Stock(int codProducto, int cantActual, int catnMin)
        {
            this.codProducto = codProducto;
            this.cantActual = cantActual;
            this.catnMin = catnMin;
        }


        public int cantidadDelProducto()
        {
            return cantActual;
        }

        public int getCodProducto()
        {
            return codProducto;
        }
    }
}
