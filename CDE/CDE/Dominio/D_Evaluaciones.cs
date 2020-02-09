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
    public class D_Evaluaciones
    {
        private CD_Evaluaciones objetoD = new CD_Evaluaciones();

        public void CrearEva(string codigo, int total, string CodEstandar, int CodUsuario,DateTime fecha,int cargo)
        {
            objetoD.CrearEvaluacion(codigo,total, CodEstandar, CodUsuario,fecha,cargo);
        }

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            tabla = objetoD.UltimaEvaluacion();
            return tabla;
        }

        public bool Comprobar(string cod)
        {
            return objetoD.ComprobarEvaluado(cod);
        }
    }
}
