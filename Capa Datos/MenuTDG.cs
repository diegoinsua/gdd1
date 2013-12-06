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
            string cadenaSQL = "SELECT elem_nombre, elem_padre, elem_menu, form_ruta " +
                               "FROM elementos left join formularios on elem_form = form_nombre, menuXrol " +
                               "WHERE (menuXrol.mero_rol = @Admin) AND  (mero_menu = elem_menu) " +
                               "ORDER BY elem_menu, elem_form asc";
            
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
