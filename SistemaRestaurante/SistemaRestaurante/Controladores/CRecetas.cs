using SistemaRestaurante.Entidades;
using SistemaRestaurante.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Controladores
{
    class CRecetas
    {
        MRecetas mRecetas = new MRecetas();
        public List<Recetas> Listado(int idProdV)
        {
            return mRecetas.Listado(idProdV);
        }
        internal void guardarReceta(Recetas R, ProductosVenta PV)
        {
            mRecetas.guardarReceta(R, PV);
        }
        internal void actualizarReceta(Recetas R, ProductosVenta PV)
        {
            mRecetas.actualizarReceta(R, PV);
        }
        internal void eliminarReceta(Recetas R, ProductosVenta PV)
        {
            mRecetas.eliminarReceta(R, PV);
        }
    }
}
