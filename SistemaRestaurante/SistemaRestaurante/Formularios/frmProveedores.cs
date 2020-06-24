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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
            Nuevo();
            cargarDatos();
        }
        Proveedores proveedores = new Proveedores();
        CProveedor cProveedor = new CProveedor();
        internal void Nuevo()
        {
            proveedoresBindingSource1.MoveLast();
            proveedoresBindingSource1.AddNew();
            idProveedorTextBox.Visible = false;
            IdProveedorlabel.Visible = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            IdProveedorlabel.Visible = false;
            idProveedorTextBox.Visible = false;
        }
        internal void cargarDatos()
        {
            proveedoresBindingSource.DataSource = cProveedor.Listado();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text.Equals("") || telefonoTextBox.Text.Equals("") || emailTextBox.Text.Equals("") || UbicacionTextBox.Text.Equals(""))
            {
                MessageBox.Show("Ingrese todos los campos para Continuar");
            }
            else
            {
                proveedoresBindingSource1.EndEdit();
                proveedores = (Proveedores)proveedoresBindingSource1.Current;
                cProveedor.guardarProveedor(proveedores);
                cargarDatos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            proveedoresBindingSource1.EndEdit();
            proveedores = (Proveedores)proveedoresBindingSource1.Current;
            cProveedor.actualizarProveedor(proveedores);
            cargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            proveedoresBindingSource1.EndEdit();
            proveedores = (Proveedores)proveedoresBindingSource1.Current;
            cProveedor.eliminarProveedor(proveedores);
            cargarDatos();
        }

        private void productosVentaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            proveedores = (Proveedores)proveedoresBindingSource.Current;
            proveedoresBindingSource1.DataSource = proveedores;
            idProveedorTextBox.Visible = true;
            IdProveedorlabel.Visible = true;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
    }
}
