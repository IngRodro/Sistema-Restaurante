using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SistemaRestaurante.Entidades;
using SistemaRestaurante.Modelos;

namespace SistemaRestaurante.Controladores
{
    class CDetallesCompra
    {
        MDetallesCompra mDetalles = new MDetallesCompra();
        public List<DetallesCompra> Listado()
        {
            return mDetalles.Listado();
        }
        internal void guardarDetallesCompra(DetallesCompra DC)
        {
            mDetalles.guardarDetallesCompra(DC);
        }

        internal void RecibirCompra(int idCompra)
        {
            mDetalles.RecibirCompra(idCompra);
        }
    }
}
