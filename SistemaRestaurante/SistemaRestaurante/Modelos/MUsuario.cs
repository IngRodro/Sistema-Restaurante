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
    class MUsuario
    {
        public List<Usuarios> Listado()
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "Select * from Usuarios";
            List<Usuarios> listado = new List<Usuarios>();
            con.Open();
            listado = con.Query<Usuarios>(consulta).ToList();
            con.Close();
            return listado;
        }
        internal void guardar(Usuarios U)
        {
            IDbConnection con = Conexion.Conexion.Conectar();
            String consulta = "sp_registrarUsuario";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombreUsuario", U.nombredeUsuario, DbType.String);
            parametros.Add("@nombre", U.nombre, DbType.String);
            parametros.Add("@edad", U.edad, DbType.Int32);
            parametros.Add("@telefono", U.telefono, DbType.String);
            parametros.Add("@email", U.email, DbType.String);
            parametros.Add("@contraseña", U.contraseña, DbType.String);
            parametros.Add("@rol", U.rol, DbType.String);
            con.Open();
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
    }
}
