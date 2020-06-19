using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRestaurante.Conexion
{
    public class Conexion
    {
        public static IDbConnection Conectar()
        {
            //cambiar los datos según su sqlserver
            String cadena = "Data Source=.;" +
                            "Initial Catalog=Restaurante;" +
                            "Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);
            IDbConnection conexion = cn;
            return conexion;
        }
    }
}
