using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAcces
{
    public class CD_Evaluaciones
    {
        private Conexion conexion = new Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public void CrearEvaluacion(string CodigoEva, int total,string CodEstandar, int CodUsuario,DateTime fecha,int CodCargo)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CrearEvaluacion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CodEvaluacion", CodigoEva);
            comando.Parameters.AddWithValue("@total", total);
            comando.Parameters.AddWithValue("@CodEstandar", CodEstandar);
            comando.Parameters.AddWithValue("@CodUsuario", CodUsuario);
            comando.Parameters.AddWithValue("@FechaCreacion", fecha);
            comando.Parameters.AddWithValue("@CodCargo", CodCargo);
            comando.ExecuteNonQuery();
        }

        public DataTable UltimaEvaluacion()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "UltimaEvaluacion";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public bool ComprobarEvaluado(string codigo)
        {
            SqlDataReader book;
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ComprobarEvaluado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@CodEvaluacion", codigo);
            book = comando.ExecuteReader();
            if (book.HasRows)
            {
                comando.Connection = conexion.CerrarConexion();
                return false;
            }
            else
            {
                comando.Connection = conexion.CerrarConexion();
                return true;
            }
        }
    }
}
