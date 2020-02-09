using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAcces
{
    public class CD_Instituciones
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        DataTable listado = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT*FROM INSTITUCIONES";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListarInsti()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "LeerNombreInstitucion";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            listado.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return listado;
        }

        public void Insertar(string nombre,string localizacion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CrearInstitucion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Ubicación", localizacion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(string codigo, string nombre, string localizacion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarInstitucion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CodIntitución", codigo);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Ubicación", localizacion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(string codigo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarInstitucion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CodIntitución", codigo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
