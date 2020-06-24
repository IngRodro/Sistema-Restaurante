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
    public partial class frmListaProd : Form
    {
        public frmListaProd()
        {
            InitializeComponent();
        }

        CProductosVenta cProductosVenta = new CProductosVenta();
        private void frmListaProd_Load(object sender, EventArgs e)
        {
            productosVentaBindingSource1.DataSource = cProductosVenta.ListadoActivos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
