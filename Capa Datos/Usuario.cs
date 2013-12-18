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
        public int   telefono; 
        public string   mail;
        public DateTime fechaNacimiento;
        public char     sexo; 

        public string rol = null;  
        public int planCodigo = 0;

        public bool existe = false;



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
            rol = string.Empty;
        }

        public void setUsuarioByDNI(int dni) 
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

            // Cargo los datos
            if (dt.Rows.Count == 1)
            {
                existe = true;

                dni = (int)dt.Rows[0]["USU_DNI"];
                username = (string)dt.Rows[0]["USU_USERNAME"];
                clave = (string)dt.Rows[0]["USU_CLAVE"];
                intentos = (int)dt.Rows[0]["USU_CANTIDAD_INTENTOS"];
                habilitado = (bool)dt.Rows[0]["USU_HABILITADO"];
                tipoDocumento = (string)dt.Rows[0]["USU_TIPO_DOCUMENTO"];
                nombres = (string)dt.Rows[0]["USU_NOMBRES"];
                apellido = (string)dt.Rows[0]["USU_APELLIDO"];
                direccion = (string)dt.Rows[0]["USU_DIRECCION"];
                telefono = (int)dt.Rows[0]["USU_TELEFONO"];
                mail = (string)dt.Rows[0]["USU_MAIL"];
                fechaNacimiento = (DateTime)dt.Rows[0]["USU_FECHA_NACIMIENTO"];
                sexo = (char)dt.Rows[0]["USU_SEXO"];
            }
            else
                existe = false;

            
            
        }
    }
}
