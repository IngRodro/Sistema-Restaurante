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
    class MProveedor
    {
        public List<Proveedores> ListadoActivos()
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_ListaProveedores";
            List<Proveedores> listado = new List<Proveedores>();
            con.Open();
            listado = con.Query<Proveedores>(consulta, commandType: CommandType.StoredProcedure).ToList();
            con.Close();
            return listado;
        }
        internal void guardarProveedor(Proveedores P)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_nuevoProveedor";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombre", P.nombre, DbType.String);
            parametros.Add("@ubicacion", P.ubicacion, DbType.String);
            parametros.Add("@telefono", P.telefono, DbType.String);
            parametros.Add("@email", P.email, DbType.String);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }

        internal void actualizarProveedor(Proveedores P)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_modificarProveedor";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idProveedor", P.idProveedor, DbType.Int32);
            parametros.Add("@nombre", P.nombre, DbType.String);
            parametros.Add("@ubicacion", P.ubicacion, DbType.String);
            parametros.Add("@telefono", P.telefono, DbType.String);
            parametros.Add("@email", P.email, DbType.String);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }

        internal void eliminarProveedor(Proveedores P)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_eliminarProveedor";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idProveedor", P.idProveedor, DbType.Int32);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }

        public List<Proveedores> Listado()
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "Select * from Proveedores";
            List<Proveedores> listado = new List<Proveedores>();
            con.Open();
            listado = con.Query<Proveedores>(consulta).ToList();
            con.Close();
            return listado;
        }
    }
}
