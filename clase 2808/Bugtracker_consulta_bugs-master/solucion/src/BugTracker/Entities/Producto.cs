using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    class Producto
    {
        private int idProducto;
        private string nombre;
        private Categoria categoria;
        private float precioVenta;

        public Producto()
        {
        }

        public Producto(int idProducto, string nombre, Categoria categoria, float precioVenta)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.categoria = categoria;
            this.precioVenta = precioVenta;
        }

        public int getIdProducto()
        {
            return idProducto;
        }

        public string getNombre()
        {
            return nombre;
        }

        public Categoria getCategoria()
        {
            return categoria;
        }

        public float getPrecioVenta()
        {
            return precioVenta;
        }

        public void setNombre(string nom)
        {
            nombre= nom;
        }

        public void setCategoria(Categoria cat)
        {
            categoria = cat;
        }

        public void setPrecioVenta(float precio)
        {
            precioVenta = precio;
        }
    }
}
