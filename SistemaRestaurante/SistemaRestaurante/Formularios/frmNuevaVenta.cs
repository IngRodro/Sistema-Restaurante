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
    public partial class frmNuevaVenta : Form
    {
        public frmNuevaVenta(string user)
        {
            InitializeComponent();
            Nuevo();
            this.user = user;
        }
        string user;
        CProductosVenta cProductosCompra = new CProductosVenta();
        DetallesVenta detalles = new DetallesVenta();
        BindingList<DetallesVenta> listaDetalles = new BindingList<DetallesVenta>();
        Ventas ventas = new Ventas();
        CVenta cVenta = new CVenta();
        CDetallesVenta cDetalles = new CDetallesVenta();

        private void Nuevo()
        {
            ventasBindingSource.MoveLast();
            ventasBindingSource.AddNew();

            detallesVentaBindingSource1.MoveLast();
            detallesVentaBindingSource1.AddNew();
        }
        private void frmNuevaVenta_Load(object sender, EventArgs e)
        {
            productosVentaBindingSource1.DataSource = cProductosCompra.ListadoActivos();
            productosVentaBindingSource.DataSource = cProductosCompra.ListadoActivos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Ventas totalventa = new Ventas();
            if (cantidadTextBox.Text.Equals("0") || precioVentaTextBox.Text.Equals("0") || idProductoVComboBox.SelectedValue == null || totalProductoTextBox.Text.Equals("0"))
            {
                MessageBox.Show("Debe Ingresar todos los campos");
            }
            else
            {
                detalles = (DetallesVenta)detallesVentaBindingSource1.Current;
                if (cDetalles.verificarIngredientes(detalles) == true)
                {
                    listaDetalles.Add(detalles);
                    detallesVentaBindingSource1.EndEdit();
                    detallesVentaBindingSource1.AddNew();

                    detallesVentaBindingSource.DataSource = listaDetalles;
                    detallesVentaBindingSource.ResetBindings(true);
                    detallesVentaDataGridView.ClearSelection();

                    totalventa = (Ventas)ventasBindingSource.Current;
                    totalventa.TotalPagar = totalventa.TotalPagar + detalles.totalProducto;
                    ventasBindingSource.DataSource = totalventa;
                    ventasBindingSource.ResetBindings(true);
                }
                else
                {
                    MessageBox.Show("Ingredientes Insuficientes en el Almacen");
                }
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ventas = (Ventas)ventasBindingSource.Current;
            ventas.nombredeUsuario = user;
            ventas.detalles = listaDetalles.ToList();
            cVenta.guardarCompra(ventas);
            MessageBox.Show("Venta Realizada con Exito");
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
