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
    public partial class MenuUsuario : Form
    {
        public MenuUsuario(string user)
        {

            InitializeComponent();
            this.user = user;
        }
        string user;
        private void Menu_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }
        public static Logueo logueo = new Logueo();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que desea cerrar sesion?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
                logueo.Show();
            }
        }
        private void productosVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaProd frmLista = new frmListaProd();
            frmLista.MdiParent = this;
            frmLista.Show();
        }
        public static frmProveedores fProveedores = new frmProveedores();
        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProveedores.MdiParent = this;
            fProveedores.Show();
        }
        
        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevaVenta fNuevaVenta = new frmNuevaVenta(user);
            fNuevaVenta.MdiParent = this;
            fNuevaVenta.Show();
        }
    }
}
