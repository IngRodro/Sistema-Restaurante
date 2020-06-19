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
using Microsoft.VisualBasic;

namespace SistemaRestaurante
{
    public partial class FNuevoUsuario : Form
    {
        public FNuevoUsuario()
        {
            InitializeComponent();
            Nuevo();
            
        }
        String AdminPass = "1508";
        private void Nuevo()
        {
            usuariosBindingSource.MoveLast();
            usuariosBindingSource.AddNew();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.EndEdit();
            Usuarios usuarios = new Usuarios();
            usuarios = (Usuarios)usuariosBindingSource.Current;
            CUsuario cUsuario = new CUsuario();
            if (cUsuario.verificarexistencia(nombredeUsuarioTextBox.Text) == true)
            {
                MessageBox.Show("El Usuario ya esta Registrado, intenta con otro");
            }
            else
            {
                if (rolComboBox.Text == "Administrador")
                {
                    if (AdminPass == Interaction.InputBox("Ingrese la clave de Administrador"))
                    {
                        cUsuario.guardar(usuarios);
                        MessageBox.Show("Registro realizado con exito");
                        btnRegresar.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Clave de administrador incorrecta intente nuevamente");
                    }

                }
                else if (rolComboBox.Text == "Usuario")
                {
                    cUsuario.guardar(usuarios);
                    MessageBox.Show("Registro realizado con exito");
                    btnRegresar.PerformClick();
                }
            }
        }

        public static Logueo logueo = new Logueo();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            logueo.Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.Close();
            logueo.Show();
        }
    }
}
