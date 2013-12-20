using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Clinica_Frba.CapaDatos;

namespace Clinica_Frba.CapaDatos
{
    public class AfiliadoTDG : TableDataGateway
    {
        public int dni;
        public int grupo;
        public int numero;
        public string estadoCivil;
        public int cantFamiliares;
        public int plan;
        public int cantConsultas;

        public bool existe = false;


        public bool insert(DataRow afl) { return true; }
        public DataSet getAflByApellido(string apellido) { DataSet afl = new DataSet(); return afl; }
       


        //------------------------
        // SET AFILIADO BY NUMERO
        //------------------------
        public DataTable setAfiliadoByNro(int afiliadoNumero) 
        {

            string cadenaSQL = "SELECT * " +
                               "FROM [GD2C2013].[VARIETE_GDD].[AFILIADO]," +
                               "WHERE AFI_NUMERO = @afiliadoNumero";

            // Creo un objeto de la clase Parametros
            Parametros parametros = new Parametros();

            // Agrego los parametros al objeto
            parametros.add("@afiliadoNumero", afiliadoNumero);



            // Ejecuto el Select
            DataTable dt = this.executeQuery(cadenaSQL, null);


            // Almaceno los datos
            if (dt.Rows.Count == 1)
            {
                existe = true;

                numero = (int)dt.Rows[0]["AFI_NUMERO"];
                grupo = (int)dt.Rows[0]["AFI_GRUPO"];
                dni = (int)dt.Rows[0]["AFI_DNI"];
                estadoCivil = dt.Rows[0]["AFI_ESTADO_CIVIL"].ToString();
                cantFamiliares = (int)dt.Rows[0]["AFI_CANTIDAD_FAMILIARES"];
                cantConsultas = (int)dt.Rows[0]["AFI_CANTIDAD_CONSULTAS"];
            }
            else
                existe = false;

            return dt;
   
        }


        public DataSet getAflByDNI(int dni) { DataSet afl = new DataSet(); return afl; }

        //Cambiar el delete
        public void delete(string apellido) { }
        public void update(DataTable afiliado) { }
    }
}
