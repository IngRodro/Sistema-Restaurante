using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Entidades
{
    public class Proveedores
    {
        public int idProveedor { get; set; }
        public string nombre { get; set; }
        public string ubicacion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
    }
}
