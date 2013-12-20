using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.CapaDatos
{
    // ATRIBUTOS

  

    public class BonoTDG : TableDataGateway
    {
        // PROPIEDADES
        private Usuario usuario { get; set; }
        public Decimal precioBonoFarmacia { get; set; }
        public Decimal precioBonoConsulta { get; set; }

       
        
       
        public BonoTDG(Usuario user)
        {
            usuario = user;
            setPrecios(usuario.planCodigo);
        }

       


        // Consulta la DB, obtiene el precio de los bonos para el plan del usuario
        // y setea las propiedades de precios de los bonos farmacia y consulta.
        public void 
            setPrecios(int codigoPlan)
        {
        
            // Creo la cadena SQL
            string cadenaSQL = "SELECT PLA_PRECIO_BONO_FARMACIA, PLA_PRECIO_BONO_CONSULTA " +
                               "FROM VARIETE_GDD.PLANES " +
                               "WHERE PLA_CODIGO = @codigoPlan ";
            
            // Creo un objeto de la clase Parametros
            Parametros parametros = new Parametros();

            // Agrego los parametros al objeto
            parametros.add("@codigoPlan", codigoPlan);

            // Ejecuto el Select
            DataTable dt = this.executeQuery(cadenaSQL, parametros);


            if (dt.Rows.Count > 0)
            {
                precioBonoFarmacia = Decimal.Parse(dt.Rows[0]["PLA_PRECIO_BONO_FARMACIA"].ToString());
                precioBonoConsulta = Decimal.Parse(dt.Rows[0]["PLA_PRECIO_BONO_CONSULTA"].ToString());
            }

        }

        

        public void comprarBonos(decimal cantBonosConsulta, decimal cantBonosFarmacia) { return; }
    }

}
