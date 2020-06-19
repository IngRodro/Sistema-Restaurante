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
        public frmNuevaVenta()
        {
            InitializeComponent();
            Nuevo();
        }
        CProductosVenta cProductosCompra = new CProductosVenta();
        DetallesVenta detalles = new DetallesVenta();
        BindingList<DetallesVenta> listaDetalles = new BindingList<DetallesVenta>();
        Ventas ventas = new Ventas();

        private void Nuevo()
        {
            ventasBindingSource.MoveLast();
            ventasBindingSource.AddNew();

            detallesVentaBindingSource1.MoveLast();
            detallesVentaBindingSource1.AddNew();
        }
        private void frmNuevaVenta_Load(object sender, EventArgs e)
        {
            productosVentaBindingSource1.DataSource = cProductosCompra.Listado();
            productosVentaBindingSource.DataSource = cProductosCompra.Listado();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            listaDetalles.Add((DetallesVenta)detallesVentaBindingSource1.Current);
            detallesVentaBindingSource1.EndEdit();
            detallesVentaBindingSource1.AddNew();

            detallesVentaBindingSource.DataSource = listaDetalles;
            detallesVentaBindingSource.ResetBindings(true);
            detallesVentaDataGridView.ClearSelection();
        }

    }
}
