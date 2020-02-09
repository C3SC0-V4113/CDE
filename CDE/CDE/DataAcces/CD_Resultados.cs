using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAcces
{
    public class CD_Resultados
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();

        public void CrearResultado(int CodCriterio,bool ResultadoCriterio, string CodEvaluacion)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CrearResultado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CodCriterio", CodCriterio);
            comando.Parameters.AddWithValue("@ResultadoCriterio", ResultadoCriterio);
            comando.Parameters.AddWithValue("@CodEvaluacion", CodEvaluacion);
            comando.ExecuteNonQuery();
        }

        public DataTable LeerResultado(string CodEvaluacion)
        {
            comando.Parameters.Clear();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "LeerEvaluado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CodEvaluacion", CodEvaluacion);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.ExecuteNonQuery();
            return tabla;
        }

        public void EliminarResultado(string CodEvaluacion)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarResultados";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CodEvaluacion", CodEvaluacion);
            comando.ExecuteNonQuery();
        }

        public DataTable BuscarFecha(DateTime fechai, DateTime fechaf, string @CodEstandar)
        {
            comando.Parameters.Clear();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarEvaluadoFecha";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fechainicial", fechai);
            comando.Parameters.AddWithValue("@fechafinal", fechaf);
            comando.Parameters.AddWithValue("@CodEstandar", @CodEstandar);
            leer=comando.ExecuteReader();
            tabla.Load(leer);
            comando.ExecuteNonQuery();
            return tabla;
        }
    }
}
