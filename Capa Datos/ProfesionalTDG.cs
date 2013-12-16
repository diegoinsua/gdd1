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
        public int especialidadCodigo;

        public DataTable getProfesionales()
        {
            string cadenaSQL = "SELECT USU_APELLIDO + ',' + USU_NOMBRES Profesional " +
                               "FROM [GD2C2013].[VARIETE_GDD].[USUARIO]," +
                               "     [GD2C2013].[VARIETE_GDD].[PROFESIONAL] " +
                               "WHERE USU_DNI = PRO_DNI";

            

            // Ejecuto el Select
            DataTable dt = this.executeQuery(cadenaSQL, null);

            return dt;   
        }


        public DataTable getProfesionalesByEspecialidad(int Especialidad)
        {
            string cadenaSQL = "SELECT USU_APELLIDO + ',' + USU_NOMBRES Profesional " +
                               "FROM [GD2C2013].[VARIETE_GDD].[USUARIO]," +
                               "     [GD2C2013].[VARIETE_GDD].[PROFESIONAL] " +
                               "     [GD2C2013].[VARIETE_GDD].[PROFESIONAL_ESPECIALIDADES] " +
                               "WHERE USU_DNI = PRO_DNI AND USU_DNI=PROESP_DNI AND PROESP_ESPECIALIDAD = @Especialidad";

            // Creo un objeto de la clase Parametros
            Parametros parametros = new Parametros();

            // Agrego los parametros al objeto
            parametros.add("@especialidad", Especialidad);



            // Ejecuto el Select
            DataTable dt = this.executeQuery(cadenaSQL, null);

            return dt;
        }




        public DataTable getProfByDNI(int dni)
        {
            // Creo la cadena SQL
            string cadenaSQL = "SELECT " +
                               "[USU_DNI] [Documento Nº] " +
                               ",[PRO_MATRICULA] Matricula " +
                               ",[USU_TIPO_DOCUMENTO] Tipo " +
                               ",[USU_NOMBRES] Nombres " +
                               ",[USU_APELLIDO] Apellido " +
                               ",[USU_USERNAME] Username " +
                               ",[USU_DIRECCION] Direccion " +
                               ",[USU_TELEFONO] Teléfono " +
                               ",[USU_MAIL] [E-Mail] " +
                               ",[USU_FECHA_NACIMIENTO] [Fecha Nac.] " +
                               ",[USU_SEXO] Sexo " +
                               ",[ESP_DESCRIPCION] Especialidad " +
                               " FROM [GD2C2013].[VARIETE_GDD].[USUARIO]," +
                               "      [GD2C2013].[VARIETE_GDD].[PROFESIONAL], " +
                               "      [GD2C2013].[VARIETE_GDD].[ESPECIALIDADES], " +
                               "      [GD2C2013].[VARIETE_GDD].[PROFESIONAL_ESPECIALIDADES] " +
                               " WHERE USU_DNI=@dni AND PRO_DNI=@dni AND PROESP_PROFESIONAL=@dni AND PROESP_ESPECIALIDAD=ESP_CODIGO" ;



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

                string cadEspecialidad = "INSERT INTO [GD2C2013].[VARIETE_GDD].[PROFESIONAL_ESPECIALIDADES] " +
                                        "(PROESP_PROFESIONAL, " +
                                        " PROESP_ESPECIALIDAD) " +
                                        " VALUES " +
                                        "(@dni, @especialidad);";

                string cadUsuario = " INSERT INTO [GD2C2013].[VARIETE_GDD].[USUARIO] " +
                                     "(USU_DNI, " +
                                //   " USU_USERNAME, " +
                                //   " USU_CLAVE, " +
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

                                     "(@dni, @tipoDocumento, @nombres, @apellido, @direccion, " +
                                     " @telefono, @mail, @fechaNacimiento, @sexo); ";


                string cadenaSQL = cadUsuario + cadProfesional + cadEspecialidad;

                // Agrego los parametros
                Parametros param = new Parametros();
                param.add("@dni", p.dni);
                //param.add("@username", p.username);
                //param.add("@clave", p.clave);
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
                param.add("@especialidad", p.especialidadCodigo);

                return executeNonQuery(cadenaSQL, param);



            }


            else
            {
                System.Windows.Forms.MessageBox.Show("Ya existe un usuario con este número de documento.", "Error Nº de Documento", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
            }
                
            return -1;
        }

      
        public int update(Profesional p) { return 0; }
        public int delete(int dni) {
            // Creo la cadena SQL
            string cadenaSQL = "UPDATE [GD2C2013].[VARIETE_GDD].[USUARIO] " +
                              "SET USU_HABILITADO=@deshabilitar " +
                              "WHERE USU_DNI=@dni";

            // Creo un objeto de la clase Parametros
            Parametros parametros = new Parametros();

            // Agrego los parametros al objeto
            parametros.add("@dni", dni);
            parametros.add("@deshabilitar", false);

            // Ejecuto el Select
            return this.executeNonQuery(cadenaSQL, parametros);

        }
    }
}
