using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.CapaDatos
{
    public class Usuario : TableDataGateway
    {
        // PROPIEDADES
        public int      dni; 
        public string   username; 
        public string   clave; 
        public int      intentos; 
        public bool     habilitado; 
        public string   tipoDocumento; 
        public string   nombres; 
        public string   apellido; 
        public string   direccion; 
        public string   telefono; 
        public string   mail;
        public DateTime fechaNacimiento;
        public char     sexo; 

        public string rolNombre;  
        public int planCodigo;  



        public Usuario()
        {
            inicializarUsuario();
        }


        public void inicializarUsuario() 
        {
            dni = 0;
            nombres = string.Empty;
            apellido = string.Empty;
            planCodigo = 0;
            rolNombre = string.Empty;
        }

        public DataTable getUsuarioByDNI(int dni) 
        {
            // Creo la cadena SQL
            //string cadenaSQL = "SELECT * FROM VARIETE_GDD.USUARIO where USU_DNI=@dni AND USU_TIPO_DOCUMENTO=@tipoDocumento";
            string cadenaSQL = "SELECT * FROM VARIETE_GDD.USUARIO where USU_DNI=@dni";

            // Creo un objeto de la clase Parametros
            Parametros parametros = new Parametros();

            // Agrego los parametros al objeto
            parametros.add("@dni", dni);
            parametros.add("@tipoDocumento", tipoDocumento);

            // Ejecuto el Select
            DataTable dt = this.executeQuery(cadenaSQL, parametros);

            return dt;    
        }
    }
}
