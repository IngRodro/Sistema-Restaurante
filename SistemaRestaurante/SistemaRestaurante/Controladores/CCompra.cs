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
        public List<Compras> Listado()
        {
            return mCompra.Listado();
        }

        internal void guardarProductoV(Compras C)
        {
            mCompra.guardarCompra(C);
        }

        public int retornoId()
        {
            return  mCompra.recibirId();
        }
    }
}
