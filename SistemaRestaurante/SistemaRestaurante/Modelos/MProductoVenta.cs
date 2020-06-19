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
    class MProductoVenta
    {
        public List<ProductosVenta> Listado()
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "Select * from ProductosVenta";
            List<ProductosVenta> listado = new List<ProductosVenta>();
            con.Open();
            listado = con.Query<ProductosVenta>(consulta).ToList();
            con.Close();
            return listado;
        }
        internal void guardarProductoV(ProductosVenta PV)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_nuevoProductoVenta";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombre", PV.nombre, DbType.String);
            parametros.Add("@precio", PV.precio, DbType.Decimal);
            parametros.Add("@categoria", PV.categoria, DbType.String);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }

        internal void actualizarProductoV(ProductosVenta PV)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_modificarProductoVenta";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idProductoV",PV.idProductoV,DbType.Int32);
            parametros.Add("@nombre", PV.nombre, DbType.String);
            parametros.Add("@precio", PV.precio, DbType.String);
            parametros.Add("@categoria", PV.categoria, DbType.String);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }

        internal void eliminarProductoV(ProductosVenta PV)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_eliminarProductoVenta";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idProductoV", PV.idProductoV, DbType.Int32);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
    }
}
