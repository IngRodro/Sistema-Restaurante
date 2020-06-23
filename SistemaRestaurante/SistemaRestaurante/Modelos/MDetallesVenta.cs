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
        public List<DetallesVenta> Listado(Ventas V)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_ListaDetalles";
            List<DetallesVenta> listado = new List<DetallesVenta>();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@IdVenta", V.idVenta, DbType.Int32);
            con.Open();
            listado = con.Query<DetallesVenta>(consulta, parametros, commandType: CommandType.StoredProcedure).ToList();
            con.Close();
            return listado;
        }
        internal void guardarDetallesVenta(DetallesVenta DV)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_nuevoDetalleV";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idProductoV", DV.idProductoV, DbType.Int32);
            parametros.Add("@precioVenta", DV.precioventa, DbType.Decimal);
            parametros.Add("@cantidad", DV.cantidad, DbType.Int32);
            parametros.Add("@idVenta", DV.idVenta, DbType.Int32);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }

    }
}
