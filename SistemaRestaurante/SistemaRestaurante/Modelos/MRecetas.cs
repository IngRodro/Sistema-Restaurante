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
    class MRecetas
    {
        public List<Recetas> Listado(int idProdV)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_ListaReceta";
            List<Recetas> listado = new List<Recetas>();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idProductoV", idProdV, DbType.Int32);
            con.Open();
            listado = con.Query<Recetas>(consulta, parametros, commandType: CommandType.StoredProcedure).ToList();
            con.Close();
            return listado;
        }
        internal void guardarReceta(Recetas R, ProductosVenta PV)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_nuevaReceta";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idProductoV", PV.idProductoV, DbType.Int32);
            parametros.Add("@idProductoC", R.idProductoC, DbType.Int32);
            parametros.Add("@cantidad", R.cantidadEstimada, DbType.String);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }

        internal void actualizarReceta(Recetas R, ProductosVenta PV)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_modificarReceta";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idProductoV", PV.idProductoV, DbType.Int32);
            parametros.Add("@idProductoC", R.idProductoC, DbType.Int32);
            parametros.Add("@cantidad", R.cantidadEstimada, DbType.String);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }

        internal void eliminarReceta(Recetas R, ProductosVenta PV)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_eliminarReceta";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idProductoV", PV.idProductoV, DbType.Int32);
            parametros.Add("@idProductoC", R.idProductoC, DbType.Int32);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
    }
}
