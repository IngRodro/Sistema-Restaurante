using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Entidades;
using SistemaRestaurante.Modelos;

namespace SistemaRestaurante.Controladores
{
    class CProveedor
    {
        MProveedor mProveedor = new MProveedor();
        public List<Proveedores> ListadoActivos()
        {
            return mProveedor.ListadoActivos();
        }
        internal void guardarProveedor(Proveedores P)
        {
            mProveedor.guardarProveedor(P);
        }
        internal void actualizarProveedor(Proveedores P)
        {
            mProveedor.actualizarProveedor(P);
        }
        internal void eliminarProveedor(Proveedores P)
        {
            mProveedor.eliminarProveedor(P);
        }
        public List<Proveedores> Listado()
        {
            return mProveedor.Listado();
        }
    }
}
