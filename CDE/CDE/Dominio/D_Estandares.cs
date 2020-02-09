using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAcces;

namespace Dominio
{
    public class D_Estandares
    {
        private CD_Estandares objetoD = new CD_Estandares();

        public DataTable ListarEst()
        {
            DataTable lista = new DataTable();
            lista = objetoD.ListarEstandares();
            return lista;
        }
    }
}
