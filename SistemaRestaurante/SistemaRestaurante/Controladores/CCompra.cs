using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Entidades;
using SistemaRestaurante.Modelos;

namespace SistemaRestaurante.Controladores
{
    class CCompra
    {
        MCompra mCompra = new MCompra();
        CDetallesCompra CDetalles = new CDetallesCompra();
        public List<Compras> Listado()
        {
            return mCompra.Listado();
        }

        internal void guardarCompra(Compras C)
        {
            DetallesCompra detalles = new DetallesCompra();

            mCompra.guardarCompra(C);
            for(int i= 0; i < C.detalles.Count; i++)
            {
                detalles = C.detalles[i];
                detalles.idCompra = retornoId();
                CDetalles.guardarDetallesCompra(detalles);
            }
            mCompra.procesarCompra(retornoId());
        }

        public int retornoId()
        {
            return  mCompra.recibirId();
        }
    }
}
