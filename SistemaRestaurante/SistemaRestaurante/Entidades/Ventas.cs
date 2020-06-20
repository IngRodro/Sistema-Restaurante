using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Entidades
{
    public class Ventas
    {
         public int idVenta { get; set; }
        public DateTime Fecha { get; set; }
        public float TotalPagar { get; set; }
        public string estado {get; set;}
        public string nombredeUsuario { get; set; }
        public List<DetallesVenta> detalles { get; set; }
        public Ventas()
        {
            detalles = new List<DetallesVenta>();
        }
    }
}
