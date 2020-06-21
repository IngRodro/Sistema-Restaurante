using Dapper;
using SistemaRestaurante.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Modelos
{
    class MAlmacen
    {
        public List<Almacen> Listado()
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "Select * from Almacen";
            List<Almacen> listado = new List<Almacen>();
            con.Open();
            listado = con.Query<Almacen>(consulta).ToList();
            con.Close();
            return listado;
        }
    }
}
