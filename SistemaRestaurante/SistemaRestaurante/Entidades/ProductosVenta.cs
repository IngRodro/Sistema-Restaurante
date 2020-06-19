using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Entidades
{
    public class ProductosVenta
    {
        public int idProductoV { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public string categoria { get; set; }
    }
}
