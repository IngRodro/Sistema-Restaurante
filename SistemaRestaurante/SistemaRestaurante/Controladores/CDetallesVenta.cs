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

        public bool verificarIngredientes(DetallesVenta DV)
        {
            bool verificar = true;
            MAlmacen mAlmacen = new MAlmacen();
            MRecetas mRecetas = new MRecetas();
            Recetas recetas = new Recetas();
            Almacen almacen = new Almacen();
            if (mRecetas.Listado(DV.idProductoV).Count>0)
            {
                for (int i = 0; i < mRecetas.Listado(DV.idProductoV).Count; i++)
                {
                    recetas = mRecetas.Listado(DV.idProductoV)[i];
                    for (int I = 0; I < mAlmacen.Listado().Count; I++)
                    {
                        almacen = mAlmacen.Listado()[I];
                        if (almacen.idProductoC == recetas.idProductoC)
                        {
                            if (almacen.cantidadDisponible < (DV.cantidad / recetas.cantidadEstimada))
                            {
                                verificar = false;
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else if (almacen.idProductoC != recetas.idProductoC && I == mAlmacen.Listado().Count() - 1)
                        {
                            verificar = false;
                        }
                    }
                    if (verificar == false)
                    {
                        break;
                    }
                }
            }
            else
            {
                verificar = false;
            }
            return verificar;
        }
    }
}
