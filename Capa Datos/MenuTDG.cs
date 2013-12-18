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
            string cadenaSQL = "SELECT ELE_NOMBRE, ELE_PADRE, ELE_FUNCIONALIDAD, FOR_RUTA " +
                               "FROM VARIETE_GDD.ELEMENTO left join VARIETE_GDD.FORMULARIO on ELE_FORM = FOR_NOMBRE, VARIETE_GDD.ROL_FUNCIONALIDADES " +
                               "WHERE (ROLFUN_ROL = @rol) AND  (ROLFUN_FUNCIONALIDAD = ELE_FUNCIONALIDAD) " +
                               "ORDER BY ELE_FUNCIONALIDAD, ELE_FORM asc";
            
            // Creo un objeto de la clase Parametros
            Parametros parametros = new Parametros();

            // Agrego los parametros al objeto
            parametros.add("@rol", rol);

            // Ejecuto el Select
            DataTable dt = this.executeQuery(cadenaSQL, parametros);

            return dt;           

        }
    }
}
