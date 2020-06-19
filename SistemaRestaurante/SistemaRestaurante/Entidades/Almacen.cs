using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Entidades
{
    public class Almacen
    {
        public int idProductoC { get; set; }
        public float cantidadDisponible { get; set; }
        public string unidad { get; set; }
    }
}
