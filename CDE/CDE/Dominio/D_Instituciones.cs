using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataAcces;

namespace Dominio
{
    public class D_Instituciones
    {
        private CD_Instituciones objetoD = new CD_Instituciones();

        public DataTable MostrarEst()
        {
            DataTable tabla = new DataTable();
            tabla = objetoD.mostrar();
            return tabla;
        }

        public DataTable ListarIns()
        {
            DataTable lista = new DataTable();
            lista = objetoD.ListarInsti();
            return lista;
        }

        public void InsertarEst(string nombre, string localizacion)
        {
            objetoD.Insertar(nombre, localizacion);
        }

        public void Editar(string codigo, string nombre, string localizacion)
        {
            objetoD.Editar(codigo, nombre, localizacion);
        }

        public void Eliminar(string codigo)
        {
            objetoD.Eliminar(codigo);
        }
    }
}
