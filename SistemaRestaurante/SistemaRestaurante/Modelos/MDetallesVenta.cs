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
    class MDetallesVenta
    {
        public List<DetallesVenta> Listado()
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "Select * from DetallesVenta";
            List<DetallesVenta> listado = new List<DetallesVenta>();
            con.Open();
            listado = con.Query<DetallesVenta>(consulta).ToList();
            con.Close();
            return listado;
        }
        internal void guardarDetallesVenta(DetallesVenta DV)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_nuevoDetalleV";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idProductoV", DV.idProductoV, DbType.Int32);
            parametros.Add("@precioCompra", DV.precioVenta, DbType.Decimal);
            parametros.Add("@cantidad", DV.cantidad, DbType.Int32);
            parametros.Add("@idCompra", DV.idVenta, DbType.Int32);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }

    }
}
