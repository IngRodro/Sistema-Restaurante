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
    public partial class frmProductosCompra : Form
    {
        public frmProductosCompra()
        {
            InitializeComponent();
        }

        ProductosCompra productosCompra = new ProductosCompra();
        CProductosCompra cProductosCompra = new CProductosCompra();
        CProveedor cProveedor = new CProveedor();
        internal void Nuevo()
        {
            productosCompraBindingSource.MoveLast();
            productosCompraBindingSource.AddNew();
            idProductoCTextBox.Visible = false;
            idProductoClabel.Visible = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            idProductoClabel.Visible = false;
            idProductoCTextBox.Visible = false;
        }


        internal void cargarDatos()
        {
            proveedoresBindingSource.DataSource = cProveedor.ListadoActivos();
            productosCompraBindingSource1.DataSource = cProductosCompra.ListadoActivos();
            proveedoresBindingSource1.DataSource = cProveedor.Listado();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text.Equals("") || precioTextBox.Text.Equals("0") || idProveedorComboBox.SelectedValue == null || categoriaTextBox.Text.Equals(""))
            {
                MessageBox.Show("Ingrese todos los campos para Continuar");
            }
            else
            {
                productosCompraBindingSource.EndEdit();
                productosCompra = (ProductosCompra)productosCompraBindingSource.Current;
                cProductosCompra.guardarProductoC(productosCompra);
                cargarDatos();
            }
        }

        private void productosVentaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productosCompra = (ProductosCompra)productosCompraBindingSource1.Current;
            productosCompraBindingSource.DataSource = productosCompra;
            idProductoClabel.Visible = true;
            idProductoCTextBox.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            productosCompraBindingSource.EndEdit();
            productosCompra = (ProductosCompra)productosCompraBindingSource.Current;
            cProductosCompra.actualizarProductoC(productosCompra);
            cargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            productosCompraBindingSource.EndEdit();
            productosCompra = (ProductosCompra)productosCompraBindingSource.Current;
            cProductosCompra.eliminarProductoC(productosCompra);
            cargarDatos();
        }

        private void frmProductosCompra_Load(object sender, EventArgs e)
        {
            cargarDatos();
            Nuevo();
        }

        private void productosCompraDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productosCompra = (ProductosCompra)productosCompraBindingSource1.Current;
            productosCompraBindingSource.DataSource = productosCompra;
            idProductoClabel.Visible = true;
            idProductoCTextBox.Visible = true;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
    }
}
