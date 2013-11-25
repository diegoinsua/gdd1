using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.CapaDatos
{
    public class LoginTDG : TableDataGateway
    {
        public bool validarUsuario(string usuario, string contrasenia)
        {
            return true;
        }

        public int getIdUsuario(string usuario) { return 5; }

        // Tendra que consultar un método de la clase RolTDG
        public DataTable getRol(int idUser) { return new DataTable(); }


    }
}
