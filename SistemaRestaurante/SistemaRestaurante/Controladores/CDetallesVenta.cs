using SistemaRestaurante.Entidades;
using SistemaRestaurante.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Controladores
{
    class CDetallesVenta
    {
        MDetallesVenta mDetalles = new MDetallesVenta();
        public List<DetallesVenta> Listado()
        {
            return mDetalles.Listado();
        }
        internal void guardarDetallesCompra(DetallesVenta DV)
        {
            mDetalles.guardarDetallesVenta(DV);
        }
    }
}
