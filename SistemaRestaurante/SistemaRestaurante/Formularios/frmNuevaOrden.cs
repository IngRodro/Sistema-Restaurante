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
    public partial class frmNuevaOrden : Form
    {
        public frmNuevaOrden()
        {
            InitializeComponent();
            Nuevo();
        }
        CProductosCompra cProductosCompra = new CProductosCompra();
        DetallesCompra detalles = new DetallesCompra();
        BindingList<DetallesCompra> listaDetalles = new BindingList<DetallesCompra>();
        CProveedor cProveedor = new CProveedor();
        Compras compras = new Compras();
        private void Nuevo()
        {
            comprasBindingSource.MoveLast();
            comprasBindingSource.AddNew();
            detallesCompraBindingSource1.MoveLast();
            detallesCompraBindingSource1.AddNew();
        }

        private void CargarComboP()
        {
            if (idProveedorComboBox.SelectedValue != null)
            {
                int IdProvee = Int32.Parse(idProveedorComboBox.SelectedValue.ToString());
                productosCompraBindingSource1.DataSource = cProductosCompra.ListaProductosCProveedor(IdProvee);
            }
        }
        private void frmNuevaOrden_Load(object sender, EventArgs e)
        {
            proveedoresBindingSource.DataSource = cProveedor.Listado();
            productosCompraBindingSource.DataSource = cProductosCompra.Listado();
        }

        private void idProveedorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboP();
        }

        private void idProductoCComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idProductoCComboBox.SelectedValue != null)
            {
                int IdProdC = Int32.Parse(idProductoCComboBox.SelectedValue.ToString());
                detalles.precioCompra = cProductosCompra.obtenerPrecioCompra(IdProdC);
                detalles.idProductoC = IdProdC;
                detallesCompraBindingSource1.DataSource = detalles;
            }
        }

        private void cantidadTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cantidadTextBox.Text != "")
            {
                if (Int32.Parse(cantidadTextBox.Text) > 0)
                {
                    int IdProdC = Int32.Parse(idProductoCComboBox.SelectedValue.ToString());
                    detalles.precioCompra = Convert.ToDouble(precioCompraTextBox.Text);
                    detalles.idProductoC = IdProdC;
                    detalles.cantidad = Convert.ToInt32(cantidadTextBox.Text);
                    detalles.totalProducto = Convert.ToDouble(cantidadTextBox.Text) * Convert.ToDouble(precioCompraTextBox.Text);
                    detallesCompraBindingSource1.DataSource = detalles;
                }
                else
                {
                    cantidadTextBox.Text = "0";
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cantidadTextBox.Text.Equals("0") || precioCompraTextBox.Text.Equals("0") || idProductoCComboBox.SelectedValue == null || totalProductoTextBox.Text.Equals("0"))
            {
                MessageBox.Show("Debe Ingresar todos los campos");
            }
            else
            {

                listaDetalles.Add((DetallesCompra)detallesCompraBindingSource1.Current);
                detallesCompraBindingSource1.EndEdit();
                detallesCompraBindingSource1.AddNew();

                detallesCompraBindingSource.DataSource = listaDetalles;
                detallesCompraBindingSource.ResetBindings(true);


            }
        }
    }
}
