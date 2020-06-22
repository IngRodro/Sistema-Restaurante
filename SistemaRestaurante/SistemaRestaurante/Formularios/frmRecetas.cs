using SistemaRestaurante.Controladores;
using SistemaRestaurante.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRestaurante.Formularios
{
    public partial class frmRecetas : Form
    {
        public frmRecetas(ProductosVenta productosV)
        {
            InitializeComponent();
            this.productosV = productosV;
        }
        ProductosVenta productosV;
        CRecetas cRecetas = new CRecetas();
        CProductosCompra cProductos = new CProductosCompra();
        Recetas recetas = new Recetas();

        private void frmRecetas_Load(object sender, EventArgs e)
        {
            productosVentaBindingSource.DataSource = productosV;
            recetasBindingSource.DataSource = cRecetas.Listado(productosV.idProductoV);
            productosCompraBindingSource1.DataSource = cProductos.Listado();
            productosCompraBindingSource.DataSource = cProductos.Listado();
            idProductoCComboBox.Enabled = false;
            cantidadEstimadaTextBox.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idProductoCComboBox.Enabled = true;
            cantidadEstimadaTextBox.Enabled = true;
            btnGuardar.Enabled = true;
            recetasBindingSource1.MoveLast();
            recetasBindingSource1.AddNew();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            recetas = (Recetas)recetasBindingSource1.Current;
            cRecetas.guardarReceta(recetas, productosV);
            recetasBindingSource.DataSource = cRecetas.Listado(productosV.idProductoV);
        }

        private void recetasDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            recetas = (Recetas)recetasBindingSource.Current;
            recetasBindingSource1.DataSource = recetas;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            cantidadEstimadaTextBox.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            recetas = (Recetas)recetasBindingSource1.Current;
            cRecetas.actualizarReceta(recetas, productosV);
            recetasBindingSource.DataSource = cRecetas.Listado(productosV.idProductoV);
            recetasBindingSource.ResetBindings(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            recetas = (Recetas)recetasBindingSource1.Current;
            cRecetas.eliminarReceta(recetas, productosV);
            recetasBindingSource.ResetBindings(true);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
