using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Clinica_Frba.CapaDatos
{

    public abstract class TableDataGateway
    {

        //----------------//
        //    Atributos   //
        //----------------//
        //protected string cadenaConexion = "reemplazar con la cadena de conexion";
        public SqlConnection conexion;
        public SqlTransaction transaccion;
        public string cadena = "";
        public DataTable dt = null;


        //----------------//
        //  Constructor   //
        //----------------//
        public TableDataGateway()
        { // Obtengo la conexion
            conexion = Conexion.crearConexion();
        }


        //----------------//
        //    Métodos     // 
        //----------------//       


        protected SqlCommand execute(string cadenaSQL, Parametros parametros)
        {
            
            // Creo un comando y lo seteo
            SqlCommand cmd = conexion.CreateCommand();
            cmd.CommandText = cadenaSQL;


            // Agrego los parametros
            if (parametros != null)
            {
                foreach (SqlParameter p in parametros.parametros)
                {
                    cmd.Parameters.Add(p);
                }
            }

            return cmd;
        }



        // Ejecuta una consulta que retorna valor (un Select)
        protected DataTable executeQuery(string cadenaSQL, Parametros parametros)
        {

            SqlCommand cmd = execute(cadenaSQL, parametros);

           
            // Creo el data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // Creo el data table
            DataTable dt = new DataTable();

            // Conecto
            conexion.Open();
            
            // Lleno el data table con el data adapater
            da.Fill(dt);

            cmd.Dispose();
            da.Dispose();
            conexion.Close();

            return dt;



        }


        // Ejecuta consultas que no retornan valores (insert, update, delete)
        protected int executeNonQuery(string cadenaSQL, Parametros parametros)
        {
            int filasAfectadas = 0;
            
            SqlCommand cmd = execute(cadenaSQL, parametros);
            
            conexion.Open();
            transaccion = conexion.BeginTransaction();
            cmd.Transaction = transaccion;

            try
            {
                filasAfectadas = cmd.ExecuteNonQuery();
                transaccion.Commit();
            }
            catch (Exception ex)
            {                           
                transaccion.Rollback();
                
                string msjError = "La operación no pudo realizarse debido a que se produjo el siguiente error: \n";
                System.Windows.Forms.MessageBox.Show(msjError + ex.ToString(), "Error.");
                
                filasAfectadas = 0;
            }

            cmd.Dispose();
            conexion.Close();

            return filasAfectadas;

        }

        


        

    }
}




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
        //protected DataTable executeQuery(string cadenaSQL, Parametros parametros) 
        //{

        //    StringBuilder errores = new StringBuilder();

           
        //    // Obtengo la conexion
        //    SqlConnection conexion = Conexion.conexion; 
          
        //    conexion.Open();

        //    // Creo un comando y lo seteo
        //    SqlCommand cmd = conexion.CreateCommand();          
        //    cmd.CommandText = cadenaSQL;


        //    // Agrego los parametros
        //    if (parametros != null)
        //    {
        //        foreach (SqlParameter p in parametros.parametros)
        //        {
        //            cmd.Parameters.Add(p);
        //        }
        //    }

        //    // Creo el data adapter
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);

        //    // Creo el data table
        //    DataTable dt = new DataTable();

        //    // Lleno el data table con el data adapater
        //    da.Fill(dt);

        //    cmd.Dispose();
        //    da.Dispose();
        //    conexion.Close();

        //    return dt; 
               
            
            

         
        //} 

