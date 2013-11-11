using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_frba.CapaDatos 
{
    public class Menu : TableDataGateway
    {
        public DataTable getMenu(string rol) 
        {
            // Creo la cadena SQL
            string cadenaSQL = "SELECT item_nombre, item_padre, item_menu, form_ruta " +
                               "FROM items left join formularios on item_formulario = form_nombre, menuXrol " +
                               "WHERE (menuXrol.mero_rol = @Admin) AND  (mero_menu = item_menu) " +
                               "ORDER BY item_padre asc";
            
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
