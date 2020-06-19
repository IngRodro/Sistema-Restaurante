using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Entidades;
using SistemaRestaurante.Modelos;

namespace SistemaRestaurante.Controladores
{
    class CProductosVenta
    {
        MProductoVenta mProductoVenta = new MProductoVenta();
        public List<ProductosVenta> Listado()
        {
            return mProductoVenta.Listado();
        }
        internal void guardarProductoV(ProductosVenta PV)
        {
            mProductoVenta.guardarProductoV(PV);
        }
        internal void actualizarProductoV(ProductosVenta PV)
        {
            mProductoVenta.actualizarProductoV(PV);
        }
        internal void eliminarProductoV(ProductosVenta PV)
        {
            mProductoVenta.eliminarProductoV(PV);
        }

        public double obtenerPrecioCompra(int IdProductoC)
        {
            double precio = 0;
            for (int i = 0; i < Listado().Count; i++)
            {
                ProductosVenta productosVenta = new ProductosVenta();
                productosVenta = Listado()[i];
                if (productosVenta.idProductoV == IdProductoC)
                {
                    precio = productosVenta.precio;
                }
            }

            return precio;
        }
    }
}
