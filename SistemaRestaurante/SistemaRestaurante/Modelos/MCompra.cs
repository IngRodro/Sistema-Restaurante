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
    class MCompra
    {
        public List<Compras> Listado()
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "Select * from Compras";
            List<Compras> listado = new List<Compras>();
            con.Open();
            listado = con.Query<Compras>(consulta).ToList();
            con.Close();
            return listado;
        }
        internal void guardarCompra(Compras C)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_nuevaCompra";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@totalaPagar", C.totalaPagar, DbType.Int32);
            parametros.Add("@idProveedor", C.idProveedor, DbType.Int32);
            parametros.Add("@nombredeUsuario", C.nombredeUsuario, DbType.String);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }

        public int recibirId()
        {
            int idCompra = 0;
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_idUltimaCompra";
            con.Open();
            List<int> listado = new List<int>();
            listado = con.Query<int>(consulta).ToList();
            idCompra = listado[0];
            con.Close();
            return idCompra;
        }
    }
}
