using BugTracker.Controllers;
using BugTracker.Entities;
using System.Collections.Generic;
using System;
namespace BugTracker.Views
{
    partial class frmConsultaStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.c1_CodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2_NomProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3_Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listCategoria
            // 
            this.listCategoria.FormattingEnabled = true;
            this.listCategoria.Location = new System.Drawing.Point(118, 12);
            this.listCategoria.Name = "listCategoria";
            this.listCategoria.Size = new System.Drawing.Size(121, 21);
            this.listCategoria.TabIndex = 0;
            this.listCategoria.Text = "Seleccione";
            this.listCategoria.SelectedIndexChanged += new System.EventHandler(this.listCategoria_SelectedIndexChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(12, 15);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(100, 13);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "filtrar por categoria: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1_CodProd,
            this.c2_NomProd,
            this.c3_Categoria,
            this.c4_Stock});
            this.dataGridView1.Location = new System.Drawing.Point(15, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 186);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // c1_CodProd
            // 
            this.c1_CodProd.HeaderText = "Código del Producto";
            this.c1_CodProd.Name = "c1_CodProd";
            // 
            // c2_NomProd
            // 
            this.c2_NomProd.HeaderText = "Producto";
            this.c2_NomProd.Name = "c2_NomProd";
            // 
            // c3_Categoria
            // 
            this.c3_Categoria.HeaderText = "Categoría";
            this.c3_Categoria.Name = "c3_Categoria";
            // 
            // c4_Stock
            // 
            this.c4_Stock.HeaderText = "Stock Actual";
            this.c4_Stock.Name = "c4_Stock";
            // 
            // frmConsultaStock
            // 
            this.ClientSize = new System.Drawing.Size(481, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.listCategoria);
            this.Name = "frmConsultaStock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1_CodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2_NomProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3_Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4_Stock;
    }
}