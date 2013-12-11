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
                               "FROM VARIETE_GDD.elementos left join VARIETE_GDD.formularios on elem_form = form_nombre, VARIETE_GDD.menuXrol " +
                               "WHERE (mero_rol = @Admin) AND  (mero_menu = elem_menu) " +
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
