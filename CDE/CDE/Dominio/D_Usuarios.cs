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
    public class D_Usuarios
    {
        private CD_Usuarios UsobjetoD = new CD_Usuarios();

        public bool LoginUser(string user, string pass)
        {
            return UsobjetoD.Login(user, pass);
        }

        public void InsertUsers(string usuario, string contraseña, string Nombre, string Apellido, string CodigoEst)
        {
            UsobjetoD.Insertar(usuario, contraseña, Nombre, Apellido, int.Parse(CodigoEst));
        }

        public void Editar(string codigo, string usuario, string contraseña, string Nombre, string Apellido, string CodigoEst)
        {
            UsobjetoD.Editar(int.Parse(codigo), usuario, contraseña, Nombre, Apellido, int.Parse(CodigoEst));
        }

    }

}
