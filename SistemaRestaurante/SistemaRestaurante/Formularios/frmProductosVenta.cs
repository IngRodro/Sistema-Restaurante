using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaRestaurante.Controladores;
using SistemaRestaurante.Entidades;

namespace SistemaRestaurante.Formularios
{
    public partial class frmProductosVenta : Form
    {
        public frmProductosVenta()
        {
            InitializeComponent();
            cargarDatos();
            Nuevo();
        }
        
        ProductosVenta productosVenta = new ProductosVenta();

        CProductosVenta cProductosVenta = new CProductosVenta();
        internal void Nuevo()
        {
            productosVentaBindingSource.MoveLast();
            productosVentaBindingSource.AddNew();
            idProductoVTextBox.Visible = false;
            IdProductoVlabel.Visible = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            IdProductoVlabel.Visible = false;
            idProductoVTextBox.Visible = false;
        }
        internal void cargarDatos()
        {
            productosVentaBindingSource1.DataSource = cProductosVenta.Listado();
        }


        private void productosVentaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productosVenta = (ProductosVenta) productosVentaBindingSource1.Current;
            productosVentaBindingSource.DataSource = productosVenta;
            idProductoVTextBox.Visible = true;
            IdProductoVlabel.Visible = true;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text.Equals("") || precioTextBox.Text.Equals("0")  || categoriaTextBox.Text.Equals(""))
            {
                MessageBox.Show("Ingrese todos los campos para Continuar");
            }
            else
            {
                productosVentaBindingSource.EndEdit();
                productosVenta = (ProductosVenta)productosVentaBindingSource.Current;
                cProductosVenta.guardarProductoV(productosVenta);
                cargarDatos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            productosVentaBindingSource.EndEdit();
            productosVenta = (ProductosVenta)productosVentaBindingSource.Current;
            cProductosVenta.actualizarProductoV(productosVenta);
            cargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            productosVentaBindingSource.EndEdit();
            productosVenta = (ProductosVenta)productosVentaBindingSource.Current;
            cProductosVenta.eliminarProductoV(productosVenta);
            cargarDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnReceta_Click(object sender, EventArgs e)
        {
            ProductosVenta productosV = new ProductosVenta();
            productosV = (ProductosVenta)productosVentaBindingSource1.Current;
            frmRecetas frmReceta = new frmRecetas(productosV);
            frmReceta.Show();
        }
    }
}
