using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Clinica_Frba.CapaPresentacion
{
    public class Conexion
    {
        private static SqlConnection conexionDB = null;
        private static string cadenaConexion = "Persist Security Info=False;User ID=gd;Password=gd2013;Initial Catalog=gd;Server=localhost\\SQLSERVER2008";

        protected Conexion() { }


        public static SqlConnection conexion
        {
            get
            {
                if (conexionDB == null)   conexionDB = new SqlConnection(cadenaConexion);

                return conexionDB;
            }
        }

    }
}



    

