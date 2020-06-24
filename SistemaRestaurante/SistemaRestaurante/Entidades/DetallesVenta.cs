using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Entidades
{
    public class DetallesVenta
    {
        public int idDetalleV { get; set; }
        public int idProductoV { get; set; }
        public float precioventa { get; set; }
        public int cantidad { get; set; }
        public float totalProducto { get; set; }
        public int idVenta { get; set; }
    }
}
