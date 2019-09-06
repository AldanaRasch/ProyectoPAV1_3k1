using BugTracker.Controllers;
using BugTracker.Models;
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
    }
}
