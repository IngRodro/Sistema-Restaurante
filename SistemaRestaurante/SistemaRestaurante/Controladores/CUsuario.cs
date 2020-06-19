using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Entidades;
using SistemaRestaurante.Modelos;

namespace SistemaRestaurante.Controladores
{
    class CUsuario
    {
        MUsuario mUsuario = new MUsuario();
        public List<Usuarios> Listado()
        {
            return mUsuario.Listado();
        }
        public Boolean verificarexistencia(String Usuario)
        {
            Boolean usuarioC = false;
            for (int i = 0; i < mUsuario.Listado().Count(); i++)
            {
                Usuarios user = new Usuarios();
                user = mUsuario.Listado()[i];
                if (Usuario == user.nombredeUsuario)
                {
                    usuarioC = true;
                    break;
                }

            }
            return usuarioC;
        }
        public Boolean verificarLogueo(String Usuario, String Password)
        {
            Boolean usuarioC = false;
            for (int i = 0; i < mUsuario.Listado().Count(); i++)
            {
                Usuarios user = new Usuarios();
                user = mUsuario.Listado()[i];
                if (Usuario == user.nombredeUsuario && Password == user.contraseña)
                {
                    usuarioC = true;
                    break;
                }

            }
            return usuarioC;
        }

        public String ObtenerNombre(String Usuario, String Password)
        {
            String Nombre = "";
            for (int i = 0; i < mUsuario.Listado().Count(); i++)
            {
                Usuarios user = new Usuarios();
                user = mUsuario.Listado()[i];
                if (Usuario == user.nombredeUsuario && Password == user.contraseña)
                {
                    Nombre = user.nombre;
                    break;
                }

            }
            return Nombre;
        }

        internal void guardar(Usuarios U)
        {
            mUsuario.guardar(U);
        }
    }
}
