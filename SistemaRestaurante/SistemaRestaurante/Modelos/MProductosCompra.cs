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
    class MProductosCompra
    {
        public List<ProductosCompra> ListadoActivos()
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_ListaProductoC";
            List<ProductosCompra> listado = new List<ProductosCompra>();
            con.Open();
            listado = con.Query<ProductosCompra>(consulta, commandType: CommandType.StoredProcedure).ToList();
            con.Close();
            return listado;
        }
        internal void guardarProductoC(ProductosCompra PC)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_nuevoProductoCompra";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombre", PC.nombre, DbType.String);
            parametros.Add("@precio", PC.precio, DbType.Decimal);
            parametros.Add("@categoria", PC.categoria, DbType.String);
            parametros.Add("@idProveedor", PC.idProveedor, DbType.Int32);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }

        internal void actualizarProductoC(ProductosCompra PC)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_modificarProductoCompra";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idProductoC", PC.idProductoC, DbType.Int32);
            parametros.Add("@nombre", PC.nombre, DbType.String);
            parametros.Add("@precio", PC.precio, DbType.String);
            parametros.Add("@categoria", PC.categoria, DbType.String);
            parametros.Add("@idProveedor", PC.idProveedor, DbType.String);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }

        internal void eliminarProductoC(ProductosCompra PC)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_eliminarProductoCompra";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idProductoC", PC.idProductoC, DbType.Int32);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }

        public List<ProductosCompra> ListaProductosCProveedor(int idProveedor)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_ListarProductosCporProveedor";
            List<ProductosCompra> listado = new List<ProductosCompra>();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idProveedor", idProveedor, DbType.Int32);
            con.Open();
            listado = con.Query<ProductosCompra>(consulta, parametros, commandType: CommandType.StoredProcedure).ToList();
            con.Close();
            return listado;
        }
        public List<ProductosCompra> Listado()
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "Select * from ProductosCompra";
            List<ProductosCompra> listado = new List<ProductosCompra>();
            con.Open();
            listado = con.Query<ProductosCompra>(consulta).ToList();
            con.Close();
            return listado;
        }
    }
}
