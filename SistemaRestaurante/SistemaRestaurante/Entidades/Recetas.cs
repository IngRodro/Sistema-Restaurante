using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Entidades
{
    class Recetas
    {
        public int idReceta { get; set; }
        public int idProductoV { get; set; }
        public int idProductoC { get; set; }
        public float cantidadEstimada { get; set; }
    }
}
