using SistemaRestaurante.Entidades;
using SistemaRestaurante.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Controladores
{
    class CVenta
    {
        MVenta mVenta = new MVenta();
        CDetallesVenta CDetalles = new CDetallesVenta();
        public List<Ventas> Listado()
        {
            return mVenta.Listado();
        }

        internal void guardarCompra(Ventas V)
        {
            DetallesVenta detalles = new DetallesVenta();

            mVenta.guardarVenta(V);
            for (int i = 0; i < V.detalles.Count; i++)
            {
                detalles = V.detalles[i];
                detalles.idVenta = retornoId();
                CDetalles.guardarDetallesCompra(detalles);
            }
            mVenta.procesarVenta(retornoId());
        }

        internal void actualizarestado(Ventas V)
        {
            mVenta.actualizarestado(V);
        }
        public int retornoId()
        {
            return mVenta.recibirIdV();
        }
    }
}
