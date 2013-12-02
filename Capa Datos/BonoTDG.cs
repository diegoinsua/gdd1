using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.CapaDatos
{
    public class BonoTDG : TableDataGateway
    {

        public decimal getPrecio(int idPlan, string tipoBono);

        public void comprarBonos(int cantidad, string tipoBono, Usuario usuario);
    }

}
