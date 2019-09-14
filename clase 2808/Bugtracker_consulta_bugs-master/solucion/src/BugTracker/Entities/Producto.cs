using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Entities
{
    class Producto
    {

        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int IdCategoria { get; set; }
        public decimal PrecioVenta { get; set; }

        public Producto()
        {
        }

        public Producto(int idProducto, string nombre, int categoria, decimal precioVenta)
        {
            this.IdProducto = idProducto;
            this.Nombre = nombre;
            this.IdCategoria = categoria;
            this.PrecioVenta = precioVenta;
        }

        public int getIdProducto()
        {
            return IdProducto;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public int getCategoria()
        {
            return IdCategoria;
        }

        public decimal getPrecioVenta()
        {
            return PrecioVenta;
        }

        public void setNombre(string nom)
        {
            Nombre= nom;
        }

        public void setCategoria(int cat)
        {
            IdCategoria = cat;
        }

        public void setPrecioVenta(decimal precio)
        {
            PrecioVenta = precio;
        }
    }
}
