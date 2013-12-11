using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.CapaDatos
{


    public class Bono : TableDataGateway
    {
        private Usuario usuario { get; set; }
        public decimal precioBonoFarmacia { get; set; }
        public decimal precioBonoConsulta { get; set; }

        public Bono(Usuario user)
        {
            usuario = user;
            setPrecios();
        }


        // Consulta la DB, obtiene el precio de los bonos para el plan del usuario
        // y setea las propiedades de precios de los bonos farmacia y consulta.
        public void setPrecios()
        {
        
            // Creo la cadena SQL
            string cadenaSQL = "SELECT tipo, precio " +
                               "FROM bono " +
                               "WHERE plan = @idPlan ";
            
            // Creo un objeto de la clase Parametros
            Parametros parametros = new Parametros();

            // Agrego los parametros al objeto
            parametros.add("@idPlan", usuario.planCodigo);

            // Ejecuto el Select
            DataTable dt = this.executeQuery(cadenaSQL, parametros);

            // precioBonoFarmacia = dt.... 
            // precioBonoConsulta = dt....  

       
        }

        

        public void comprarBonos(decimal cantBonosConsulta, decimal cantBonosFarmacia) { return; }
    }

}
