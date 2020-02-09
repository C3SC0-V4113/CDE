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
    public class D_Resultados
    {
        private CD_Resultados objetoD = new CD_Resultados();

        public void CrearRes(int CodCriterio, bool ResultadoCriterio, string CodEvaluacion)
        {
            objetoD.CrearResultado(CodCriterio, ResultadoCriterio, CodEvaluacion);
        }

        public DataTable LeerRes(string CodEvaluacion)
        {
            DataTable tabla = new DataTable();
            tabla = objetoD.LeerResultado(CodEvaluacion);
            return tabla;
        }

        public void EliminarRes(string CodEvaluacion)
        {
            objetoD.EliminarResultado(CodEvaluacion);
        }

        public DataTable LeerFecha(DateTime fechai, DateTime fechaf, string @CodEstandar)
        {
            DataTable tabla = new DataTable();
            tabla = objetoD.BuscarFecha(fechai,fechaf,CodEstandar);
            return tabla;
        }
    }
}
