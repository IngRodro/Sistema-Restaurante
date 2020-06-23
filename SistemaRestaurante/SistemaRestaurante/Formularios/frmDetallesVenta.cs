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
    public partial class frmDetallesVenta : Form
    {
        public frmDetallesVenta(Ventas ventas)
        {
            InitializeComponent();
            this.ventas = ventas;
        }
        Ventas ventas = new Ventas();
        CDetallesVenta cDetalles = new CDetallesVenta();
        CProductosVenta cProductos = new CProductosVenta();
        CVenta cVenta = new CVenta();
        
        private void frmDetallesVenta_Load(object sender, EventArgs e)
        {
            ventasBindingSource.DataSource = ventas;
            detallesVentaBindingSource.DataSource = cDetalles.Listado(ventas);
            productosVentaBindingSource.DataSource = cProductos.Listado();
        }

        private void btnRecibida_Click(object sender, EventArgs e)
        {
            ventas.estado = "Recibida";
            cVenta.actualizarestado(ventas);
        }

        private void btnEntregada_Click(object sender, EventArgs e)
        {
            ventas.estado = "Entregada";
            cVenta.actualizarestado(ventas);
        }

        private void btnPagada_Click(object sender, EventArgs e)
        {
            ventas.estado = "Pagada";
            cVenta.actualizarestado(ventas);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
