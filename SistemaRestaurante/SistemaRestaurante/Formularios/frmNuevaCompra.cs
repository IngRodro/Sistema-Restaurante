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
    public partial class frmNuevaCompra : Form
    {
        public frmNuevaCompra(string user)
        {
            InitializeComponent();
            Nuevo();
            this.user = user;
        }
        String user;
        CProductosCompra cProductosCompra = new CProductosCompra();
        BindingList<DetallesCompra> listaDetalles = new BindingList<DetallesCompra>();
        CProveedor cProveedor = new CProveedor();
        CCompra cCompra = new CCompra();
        DetallesCompra detalles = new DetallesCompra();
        Compras compras = new Compras();
        private void Nuevo()
        {
            comprasBindingSource.MoveLast();
            comprasBindingSource.AddNew();
            detallesCompraBindingSource.MoveLast();
            detallesCompraBindingSource.AddNew();
        }

        private void CargarComboP()
        {
            if (idProveedorComboBox.SelectedValue != null)
            {
                int IdProvee = Int32.Parse(idProveedorComboBox.SelectedValue.ToString());
                productosCompraBindingSource.DataSource = cProductosCompra.ListaProductosCProveedor(IdProvee);
            }
        }
        private void frmNuevaCompra_Load(object sender, EventArgs e)
        {
            proveedoresBindingSource.DataSource = cProveedor.Listado();
            productosCompraBindingSource1.DataSource = cProductosCompra.Listado();
        }

        private void idProveedorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboP();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cantidadTextBox.Text.Equals("0") || precioCompraTextBox.Text.Equals("0") || idProductoCComboBox.SelectedValue == null || totalProductoTextBox.Text.Equals("0"))
            {
                MessageBox.Show("Debe Ingresar todos los campos");
            }
            else
            {
                Compras totalcompra = new Compras();

                detalles = (DetallesCompra)detallesCompraBindingSource.Current;
                listaDetalles.Add(detalles);
                compras.AgregarDetalles(detalles);
                detallesCompraBindingSource.EndEdit();
                detallesCompraBindingSource.AddNew();

                detallesCompraBindingSource1.DataSource = listaDetalles;
                detallesCompraBindingSource1.ResetBindings(true);

                totalcompra = (Compras)comprasBindingSource.Current;
                totalcompra.totalaPagar = totalcompra.totalaPagar + detalles.totalProducto;
                comprasBindingSource.DataSource = totalcompra;
                comprasBindingSource.ResetBindings(true);
                idProveedorComboBox.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            compras = (Compras)comprasBindingSource.Current;
            compras.nombredeUsuario = user;
            compras.detalles = listaDetalles.ToList();
            cCompra.guardarCompra(compras);
            MessageBox.Show("Compra Realizada con Exito");
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
