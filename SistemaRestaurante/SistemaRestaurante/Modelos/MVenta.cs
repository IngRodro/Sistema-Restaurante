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
    class MVenta
    {
        public List<Ventas> Listado()
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "Select * from Ventas";
            List<Ventas> listado = new List<Ventas>();
            con.Open();
            listado = con.Query<Ventas>(consulta).ToList();
            con.Close();
            return listado;
        }
        internal void guardarVenta(Ventas V)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_nuevaVenta";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@totalaPagar", V.TotalPagar, DbType.Int32);
            parametros.Add("@nombredeUsuario", V.nombredeUsuario, DbType.String);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }

        internal void actualizarestado(Ventas V)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_ActualizarEstadoVenta";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@IdVenta", V.idVenta, DbType.Int32);
            parametros.Add("@estado", V.estado, DbType.String);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }

        public int recibirIdV()
        {
            int idVenta = 0;
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_ultimaVenta";
            con.Open();
            List<int> listado = new List<int>();
            listado = con.Query<int>(consulta).ToList();
            idVenta = listado[0];
            con.Close();
            return idVenta;
        }

        internal void procesarVenta(int idVenta)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_RecibirVenta";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idVenta", idVenta, DbType.Int32);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
    }
}
