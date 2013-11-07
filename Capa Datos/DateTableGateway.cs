using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;

namespace Clinica_frba.CapaDatos
{
    public abstract class TableDataGateway
    {

        //----------------//
        //    Atributos   //
        //----------------//
        protected string cadenaConexion = "reemplazar con la cadena de conexion";
        private SqlConnection conexion;


        //----------------//
        //  Constructor   //
        //----------------//
        public TableDataGateway()  { this.conexion = new SqlConnection(cadenaConexion);  }



        //----------------//
        //    Destructor  //
        //----------------//
        ~TableDataGateway() { conexion.Dispose(); }



        //----------------//
        //    Métodos     //  [Pendientes de implenetación]
        //----------------//       
       
        public DataSet executeQuery(string cadenaSQL) { return new DataSet(); } // Ejecuta una consulta que retorna valor (un Select)
        private void executeNonQuery(string cadenaSQL, SqlCommand com) { }      // Ejecuta consultas que no retornan valores (insert, update, delete)
       
        private void beginTransaction() { }
        private void commitTransaction() { }
        private void roolbackTransaction() { }

    }


}
