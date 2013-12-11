using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Clinica_Frba.CapaDatos
{
    public class Parametros 
    {
        
        public List<SqlParameter> parametros{ get; set; }

      

        public Parametros()
        {
            parametros = new List<SqlParameter>();
        }

        
        public void add(string parametroNombre, string parametroValor) 
        {
            SqlParameter p = new SqlParameter();

            p.SqlDbType = SqlDbType.NChar;
            p.ParameterName = parametroNombre;
            p.Value = parametroValor;
            p.Direction = ParameterDirection.Input;

            parametros.Add(p);        
            
        }

        public void add(string parametroNombre, int parametroValor) 
        {
            SqlParameter p = new SqlParameter();

            p.DbType = DbType.Int32;
            p.ParameterName = parametroNombre;
            p.Value = parametroValor;

            parametros.Add(p);  
        }

        public void add(string parametroNombre, decimal parametroValor) 
        {
            SqlParameter p = new SqlParameter();

            p.DbType = DbType.Decimal;
            p.ParameterName = parametroNombre;
            p.Value = parametroValor;

            parametros.Add(p);  
        }

        public void add(string parametroNombre, DateTime parametroValor) 
        {
            SqlParameter p = new SqlParameter();

            p.DbType = DbType.Date;
            p.ParameterName = parametroNombre;
            p.Value = parametroValor;

            parametros.Add(p);  
        }


        public void add(string parametroNombre, bool parametroValor) 
        {
            SqlParameter p = new SqlParameter();

            p.DbType = DbType.Boolean;
            p.ParameterName = parametroNombre;
            p.Value = parametroValor;

            parametros.Add(p);  
        }


       
    }
}
