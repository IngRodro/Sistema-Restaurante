using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Entidades;
using SistemaRestaurante.Modelos;

namespace SistemaRestaurante.Controladores
{
    class CProductosCompra
    {
        MProductosCompra mProductoCompra = new MProductosCompra();
        public List<ProductosCompra> Listado()
        {
            return mProductoCompra.Listado();
        }

        public List<ProductosCompra> ListaProductosCProveedor(int idProveedor)
        {
            return mProductoCompra.ListaProductosCProveedor(idProveedor);
        }

        internal void guardarProductoC(ProductosCompra PC)
        {
            mProductoCompra.guardarProductoC(PC);
        }
        internal void actualizarProductoC(ProductosCompra PC)
        {
            mProductoCompra.actualizarProductoC(PC);
        }
        internal void eliminarProductoC(ProductosCompra PC)
        {
            mProductoCompra.eliminarProductoC(PC);
        }

        public double obtenerPrecioCompra(int IdProductoC)
        {
            double precio = 0;
            for (int i = 0; i < Listado().Count; i++)
            {
                ProductosCompra productosCompra = new ProductosCompra();
                productosCompra = Listado()[i];
                if (productosCompra.idProductoC == IdProductoC)
                {
                    precio = productosCompra.precio;
                }
            }

            return precio;
        }
    }
}
