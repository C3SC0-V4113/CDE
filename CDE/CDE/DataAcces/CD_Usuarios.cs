using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaComun.cacheUsuario;

namespace DataAcces
{
    public class CD_Usuarios
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public bool Login(string usuario, string contraseña)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Usuario", usuario);
            comando.Parameters.AddWithValue("@Contraseña", contraseña);
            leer = comando.ExecuteReader();
            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    CacheUsuariologeo.codigo_Usuario = leer.GetInt32(0);
                    CacheUsuariologeo.usuarioID = leer.GetString(1);
                    CacheUsuariologeo.contraseña = leer.GetString(2);
                    CacheUsuariologeo.nombre = leer.GetString(3);
                    CacheUsuariologeo.apellido = leer.GetString(4);
                    CacheUsuariologeo.codigo_Establecimiento = leer.GetInt32(5);
                }
                comando.Parameters.Clear();
                return true;
            }
            else
            {
                comando.Parameters.Clear();
                return false;
            }
        }

        public DataTable mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT*FROM Usuarios";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string usuario, string contraseña,string Nombre,string Apellido,int CodigoEst)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CrearUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@Usuario", usuario);
            comando.Parameters.AddWithValue("@Contraseña", contraseña);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellido", Apellido);
            comando.Parameters.AddWithValue("@CodIntitución", CodigoEst);
            comando.ExecuteNonQuery();
        }

        public void Editar(int codigo, string usuario, string contraseña, string Nombre, string Apellido, int CodigoEst)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CodUsuario", codigo);
            comando.Parameters.AddWithValue("@Usuario", usuario);
            comando.Parameters.AddWithValue("@Contraseña", contraseña);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellido", Apellido);
            comando.Parameters.AddWithValue("@CodIntitución", CodigoEst);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
