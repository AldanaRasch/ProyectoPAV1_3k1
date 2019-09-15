using BugTracker.Controllers;
using BugTracker.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker.Views
{
    public partial class frmConsultaStock : Form
    {
        public frmConsultaStock()
        {
            InitializeComponent();
            cargarComboBox();
            cargarTabla();
        }

        private void FrmConsultaStockCritico_Load(object sender, EventArgs e)
        {
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConsultarCantidadProductosPorCategoria ccpg = new ConsultarCantidadProductosPorCategoria();

            List<Producto> productos = ccpg.getProductos();
            List<Stock> stock = ccpg.getStock();
            for (int i = 0; i < productos.Count; i++)
            {
                Producto prod = productos.ElementAt(i);
                Stock s = stock.ElementAt(i);
                int idProd = prod.getIdProducto();
                string nomProd = prod.getNombre();
                string nomCateg = prod.getCategoria().getNombre();
                int stockProd = s.cantidadDelProducto();


            }
        }

        private void listCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ConsultarCantidadProductosPorCategoria ccpg = new ConsultarCantidadProductosPorCategoria();

            string filtro = listCategoria.Text;
            List<Producto> productos = ccpg.getProductos();
            List<Stock> stock = ccpg.getStock();

            
                for (int i = 0; i < productos.Count; i++)
                {
                    Producto prod = productos.ElementAt(i);
                    string nomCateg = prod.getCategoria().getNombre();

                    if (String.Compare(filtro, nomCateg) == 00)
                    {
                        Stock s = stock.ElementAt(i);
                        int idProd = prod.getIdProducto();
                        string nomProd = prod.getNombre();
                        int stockProd = s.cantidadDelProducto();

                        dataGridView1.Rows.Add(idProd, nomProd, nomCateg, stockProd);

                        if (dataGridView1.Rows.Count == 0)
                        {
                            MessageBox.Show("No se encontraron productos de la categoría seleccionada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
        }

        private void cargarComboBox()
        {
            ConsultarCategoriasController ccc = new ConsultarCategoriasController();
            List<Categoria> categorias = ccc.obtenerListCategorias();

            foreach (Categoria cat in categorias)
            {
                listCategoria.Items.Add(cat.getNombre());
            }
        }
        private void cargarTabla()
        {
            ConsultarCantidadProductosPorCategoria ccpg = new ConsultarCantidadProductosPorCategoria();

            List<Producto> productos = ccpg.getProductos();
            List<Stock> stock = ccpg.getStock();
            for (int i = 0; i < productos.Count; i++)
            {
                Producto prod = productos.ElementAt(i);
                Stock s = stock.ElementAt(i);
                int idProd = prod.getIdProducto();
                string nomProd = prod.getNombre();
                string nomCateg = prod.getCategoria().getNombre();
                int stockProd = s.cantidadDelProducto();
                dataGridView1.Rows.Add(idProd, nomProd, nomCateg, stockProd);
            }
        }


    }
}
