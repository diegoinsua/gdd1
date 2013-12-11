using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Clinica_Frba.CapaDatos
{
    public class Profesional : Usuario
    {
        // PROPIEDADES
       public string matricula { get; set; }



        public DataTable getProfByDNI(int dni)
        {
            // Creo la cadena SQL
            string cadenaSQL = "SELECT * FROM VARIETE_GDD.PROFESIONAL where dni=@dni";

            // Creo un objeto de la clase Parametros
            Parametros parametros = new Parametros();

            // Agrego los parametros al objeto
            parametros.add("@dni", dni);

            // Ejecuto el Select
            DataTable dt = this.executeQuery(cadenaSQL, parametros);

            return dt;       
        }

     

        public DataTable getAdmByMatricula(string dni)
        {            
            DataTable dt = new DataTable();
            
            dt.Columns.Add("Matricula", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Apellido", typeof(string));
            dt.Columns.Add("DNI", typeof(int));
            dt.Columns.Add("Especialidad", typeof(string));

            dt.Rows.Add(122, "Juan", "Perez", 30111222, "Cardiologo");
            dt.Rows.Add(100, "Pedro", "Alegre", 1111111, "Neurologo");
            dt.Rows.Add(21, "Osvaldo", "Lopez", 26987121, "Cirujano");
            dt.Rows.Add(49, "Antonio", "Garcia", 35000333, "Oftalmologo");

            return dt;
        }


        public DataTable getEspecialidades()
        {
            Especialidad e = new Especialidad();

            return e.getEspecialidades();
        }




        public int insert(Profesional p) 
        {
           

            // Si no existe ningun usuario en la DB con este DNI
            if (getUsuarioByDNI(p.dni).Rows.Count == 0)
            {

                
                string cadProfesional = "INSERT INTO [GD2C2013].[VARIETE_GDD].[PROFESIONAL] " +
                                        "([PRO_DNI], "       +
                                        " [PRO_MATRICULA]) " +
                                        " VALUES "           +
                                        "(@dni, @matricula);";


                string cadUsuario = " INSERT INTO [GD2C2013].[VARIETE_GDD].[USUARIO], " +
                                     "([USU_DNI], "               +
                                     " [USU_USERNAME], "          +
                                     " [USU_CLAVE], "             +
                                     " [USU_HABILITADO], "        +
                                     " [USU_TIPO_DOCUMENTO], "    +
                                     " [USU_NOMBRES], "           +
                                     " [USU_APELLIDO], "          +
                                     " [USU_DIRECCION], "         +
                                     " [USU_TELEFONO], "          +
                                     " [USU_MAIL], "              +
                                     " [USU_FECHA_NACIMIENTO], "  +
                                     " [USU_SEXO]) "              +

                                     " VALUES " +

                                     "(@dni, @username, @clave,  @habilitado, " +
                                     " @tipoDocumento, @nombres, @apellido, @direccion, " +
                                     " @telefono, @mail, @fechaNacimiento, @sexo); ";


                string cadenaSQL = cadProfesional + cadUsuario;

                           
                // Agrego los parametros
                Parametros param = new Parametros();
                param.add("@dni", p.dni);
                param.add("@username", p.username);
                param.add("@clave", p.clave);
                param.add("@habilitado", p.habilitado);
                param.add("@tipoDocumento", p.tipoDocumento);
                param.add("@nombres", p.nombres);
                param.add("@direccion", p.direccion);
                param.add("@telefono", p.telefono);
                param.add("@mail", p.mail);
                param.add("@fechaNacimiento", p.fechaNacimiento);
                param.add("@sexo", p.sexo);

                param.add("@matricula", p.matricula);
               
                return executeNonQuery(cadenaSQL, param);

               

            }


            else
                
            return -1;
        }

      
        public bool update(DataTable dt) { return true; }
        public bool delete(int matricula) { return true; }
    }
}
