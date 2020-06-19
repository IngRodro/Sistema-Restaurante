using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using SistemaRestaurante.Entidades;

namespace SistemaRestaurante.Modelos
{
    class MDetallesCompra
    {
        public List<DetallesCompra> Listado()
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "Select * from DetallesCompra";
            List<DetallesCompra> listado = new List<DetallesCompra>();
            con.Open();
            listado = con.Query<DetallesCompra>(consulta).ToList();
            con.Close();
            return listado;
        }
        internal void guardarDetallesCompra(DetallesCompra DC)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_nuevoDetalleC";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idProductoC", DC.idProductoC, DbType.Int32);
            parametros.Add("@precioCompra", DC.precioCompra, DbType.Decimal);
            parametros.Add("@cantidad", DC.cantidad, DbType.Int32);
            parametros.Add("@idCompra", DC.idCompra, DbType.Int32);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }

        internal void RecibirCompra(int idCompra)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_RecibirCompra";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idCompra", idCompra, DbType.Int32);
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();

        }
    }
}
