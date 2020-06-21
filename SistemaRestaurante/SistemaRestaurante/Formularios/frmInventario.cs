using SistemaRestaurante.Controladores;
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
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }
        CAlmacen cAlmacen = new CAlmacen();
        CProductosCompra cProductosCompra = new CProductosCompra();
        private void frmInventario_Load(object sender, EventArgs e)
        {
            almacenBindingSource.DataSource = cAlmacen.Listado();
            productosCompraBindingSource.DataSource = cProductosCompra.Listado();
        }
    }
}
