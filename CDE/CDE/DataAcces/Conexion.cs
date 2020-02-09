using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DataAcces
{
    class Conexion
    {
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion_cde"].ConnectionString);

        public SqlConnection AbrirConexion()
        {
            if(conexion.State==ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
