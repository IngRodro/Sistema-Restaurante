using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Entidades
{
    public class ProductosCompra
    {
        public int idProductoC { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public string categoria { get; set; }
        public int idProveedor { get; set; }
    }
}
