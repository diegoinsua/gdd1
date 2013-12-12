using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.CapaDatos
{
    class Especialidad : TableDataGateway
    {
        public DataTable getEspecialidades()
        {
            //TODO: CHEQUEAR CADENA
            cadena = "SELECT ESP_CODIGO, ESP_DESCRIPCION FROM VARIETE_GDD.ESPECIALIDADES";

            return executeQuery(cadena, null);
        }
    }
}
