using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Entidades
{
    public class Compras
    {
        public int idCompra { get; set; }
        public DateTime fechadeCompra { get; set; }
        public float totalaPagar { get; set; }
        public int idProveedor { get; set; }
        public string nombredeUsuario { get; set; }
        public List<DetallesCompra> detalles { get; set; }
        public Compras()
        {
            detalles = new List<DetallesCompra>();
        }

        public void AgregarDetalles(DetallesCompra detalle)
        {
            detalle.idCompra = this.idCompra;
            detalles.Add(detalle);
        }
    }
}
