using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAcces;

namespace Dominio
{
    public class D_Evaluadores
    {
        private CD_Evaluadores objetoD = new CD_Evaluadores();

        public DataTable MostrarEncar()
        {
            DataTable tabla = new DataTable();
            tabla = objetoD.mostrar();
            return tabla;
        }

        public DataTable ListarEncar()
        {
            DataTable lista = new DataTable();
            lista = objetoD.ListarInsti();
            return lista;
        }

        public void InsertarEncar(string nombre, string apellido)
        {
            objetoD.Insertar(nombre, apellido);
        }

        public void Editar(string codigo, string nombre, string apellido)
        {
            objetoD.Editar(codigo, nombre, apellido);
        }

        public void Eliminar(string codigo)
        {
            objetoD.Eliminar(codigo);
        }
    }
}
