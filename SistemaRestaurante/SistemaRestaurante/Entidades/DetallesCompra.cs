using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Entidades
{
    public class DetallesCompra
    {
        public int idDetalleC { get; set; }
        public int idProductoC { get; set; }
        public double precioCompra { get; set; }
        public int cantidad { get; set; }
        public double totalProducto { get; set; }
        public int idCompra { get; set; }
    }
}
