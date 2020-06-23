using SistemaRestaurante.Controladores;
using SistemaRestaurante.Entidades;
using SistemaRestaurante.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRestaurante
{
    public partial class frmListaVentas : Form
    {
        public frmListaVentas()
        {
            InitializeComponent();
        }
        CVenta cVenta = new CVenta();
        Ventas ventas = new Ventas();
        private void frmListaVentas_Load(object sender, EventArgs e)
        {
            ventasBindingSource.DataSource = cVenta.Listado();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ventasBindingSource.Count >0)
            {
                ventas = (Ventas)ventasBindingSource.Current;
                frmDetallesVenta frmDetalles = new frmDetallesVenta(ventas);
                frmDetalles.Show();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
