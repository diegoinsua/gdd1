using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.CapaDatos
{
    public class Menu : TableDataGateway
    {
        public DataTable getMenu(string rol) 
        {
            // Creo la cadena SQL
            string cadenaSQL = "SELECT ele_nombre, ele_padre, ele_funcionalidad, for_ruta " +
                               "FROM VARIETE_GDD.elemento left join VARIETE_GDD.formulario on ele_form = for_nombre, VARIETE_GDD.rol_funcionalidades " +
                               "WHERE (rolfun_rol = @Admin) AND  (rolfun_funcionalidad = ele_funcionalidad) " +
                               "ORDER BY ele_funcionalidad, ele_form asc";
            
            // Creo un objeto de la clase Parametros
            Parametros parametros = new Parametros();

            // Agrego los parametros al objeto
            parametros.add("@Admin", "Administrador");

            // Ejecuto el Select
            DataTable dt = this.executeQuery(cadenaSQL, parametros);

            return dt;           

        }
    }
}
