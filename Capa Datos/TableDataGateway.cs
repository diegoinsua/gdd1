using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;

namespace Clinica_Frba.CapaPresentacion
{
    public abstract class TableDataGateway
    {

        //----------------//
        //    Atributos   //
        //----------------//
        //protected string cadenaConexion = "reemplazar con la cadena de conexion";
        private SqlConnection conexion;


        //----------------//
        //  Constructor   //
        //----------------//
       // public TableDataGateway()  { this.conexion = new SqlConnection(cadenaConexion);  }



        //----------------//
        //    Destructor  //
        //----------------//
        //~TableDataGateway() { conexion.Dispose(); }



        //----------------//
        //    Métodos     //  [Pendientes de implenetación]
        //----------------//       


        // Ejecuta una consulta que retorna valor (un Select)
        protected DataTable executeQuery(string cadenaSQL, Parametros parametros) 
        {

            StringBuilder errores = new StringBuilder();

           
            // Obtengo la conexion
            SqlConnection conexion = Conexion.conexion; 
          
            conexion.Open();

            // Creo un comando y lo seteo
            SqlCommand cmd = conexion.CreateCommand();          
            cmd.CommandText = cadenaSQL;
            foreach (SqlParameter p in parametros.parametros)
            {
                cmd.Parameters.Add(p);
            }

            // Creo el data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Creo el data table
            DataTable dt = new DataTable();

            // Lleno el data table con el data adapater
            da.Fill(dt);

            cmd.Dispose();
            da.Dispose();
            conexion.Close();

            return dt; 
               
            
            

         
        } 


        protected void executeNonQuery(string cadenaSQL, SqlCommand com) { }      // Ejecuta consultas que no retornan valores (insert, update, delete)

        protected void beginTransaction() { }
        protected void commitTransaction() { }
        protected void roolbackTransaction() { }

    }


}
