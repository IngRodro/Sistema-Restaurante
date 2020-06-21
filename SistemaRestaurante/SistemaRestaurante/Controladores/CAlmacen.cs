using SistemaRestaurante.Entidades;
using SistemaRestaurante.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Controladores
{
    class CAlmacen
    {
        MAlmacen mAlmacen = new MAlmacen();
        public List<Almacen> Listado()
        {
            return mAlmacen.Listado();
        }
    }
}
