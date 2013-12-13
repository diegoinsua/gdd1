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
        public string matricula;
        public string especialidad;



        public DataTable getProfByDNI(int dni)
        {
            // Creo la cadena SQL
            string cadenaSQL = "SELECT * " +
                               "FROM VARIETE_GDD.PROFESIONAL, VARIETE_GDD.USUARIO " +   
                               "WHERE PRO_DNI=@dni AND USU_DNI=@dni";

            // Creo un objeto de la clase Parametros
            Parametros parametros = new Parametros();

            // Agrego los parametros al objeto
            parametros.add("@dni", dni);

            // Ejecuto el Select
            DataTable dt = this.executeQuery(cadenaSQL, parametros); 
            
            return dt;       
        }

        public DataTable getProfByMatricula(int matricula)
        {
            // Creo la cadena SQL
             string cadenaSQL = "SELECT * " +
                               "FROM VARIETE_GDD.PROFESIONAL, VARIETE_GDD.USUARIO " +   
                               "WHERE USU_DNI=PRO_DNI AND PRO_MATRICULA=@matricula";

            // Creo un objeto de la clase Parametros
            Parametros parametros = new Parametros();

            // Agrego los parametros al objeto
            parametros.add("@matricula", matricula);

            // Ejecuto el Select
            DataTable dt = this.executeQuery(cadenaSQL, parametros);

            return dt;
        }

        public DataTable getProfByApellido(string apellido)
        {
            // Creo la cadena SQL
            string cadenaSQL = "SELECT * " +
                              "FROM VARIETE_GDD.PROFESIONAL, VARIETE_GDD.USUARIO " +
                              "WHERE USU_DNI=PRO_DNI AND USU_APELLIDO=@apellido";

            // Creo un objeto de la clase Parametros
            Parametros parametros = new Parametros();

            // Agrego los parametros al objeto
            parametros.add("@apellido", apellido);

            // Ejecuto el Select
            DataTable dt = this.executeQuery(cadenaSQL, parametros);

            return dt;
        }
     

       

        public DataTable getEspecialidades()
        {
            Especialidad e = new Especialidad();

            return e.getEspecialidades();
        }




        public int insert(Profesional p)         {
           

            // Si no existe ningun usuario en la DB con este DNI
            if (getUsuarioByDNI(p.dni).Rows.Count == 0)
            {

                System.Windows.Forms.MessageBox.Show(getUsuarioByDNI(p.dni).Rows.Count.ToString());
                string cadProfesional = "INSERT INTO [GD2C2013].[VARIETE_GDD].[PROFESIONAL] " +
                                        "(PRO_DNI, " +
                                        " PRO_MATRICULA) " +
                                        " VALUES " +
                                        "(@dni, @matricula);";


                string cadUsuario = " INSERT INTO [GD2C2013].[VARIETE_GDD].[USUARIO] " +
                                     "(USU_DNI, " +
                                     " USU_USERNAME, " +
                                     " USU_CLAVE, " +
                    //   " [USU_HABILITADO], "        +
                                     " USU_TIPO_DOCUMENTO, " +
                                     " USU_NOMBRES, " +
                                     " USU_APELLIDO, " +
                                     " USU_DIRECCION, " +
                                     " USU_TELEFONO, " +
                                     " USU_MAIL, " +
                                     " USU_FECHA_NACIMIENTO, " +
                                     " USU_SEXO) " +

                                     " VALUES " +

                                     "(@dni, @username, @clave, " +
                                     " @tipoDocumento, @nombres, @apellido, @direccion, " +
                                     " @telefono, @mail, @fechaNacimiento, @sexo); ";


                string cadenaSQL = cadUsuario + cadProfesional;

                // Agrego los parametros
                Parametros param = new Parametros();
                param.add("@dni", p.dni);
                param.add("@username", p.username);
                param.add("@clave", p.clave);
                // param.add("@habilitado", p.habilitado);
                param.add("@tipoDocumento", p.tipoDocumento);
                param.add("@nombres", p.nombres);
                param.add("@apellido", p.apellido);
                param.add("@direccion", p.direccion);
                param.add("@telefono", p.telefono);
                param.add("@mail", p.mail);
                param.add("@fechaNacimiento", p.fechaNacimiento);
                param.add("@sexo", p.sexo);

                param.add("@matricula", p.matricula);

                return executeNonQuery(cadenaSQL, param);



            }


            else
            {
                System.Windows.Forms.MessageBox.Show("Ya existe un usuario con este número de documento.", "Error Nº de Documento", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
            }
                
            return -1;
        }

      
        public int update(Profesional p) { return 0; }
        public bool delete(int matricula) { return true; }
    }
}
