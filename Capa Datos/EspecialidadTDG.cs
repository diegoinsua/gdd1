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
            cadena = "SELECT CODIGO, DESCRIPCION FROM ESPECIALIDADES";

            return executeQuery(cadena, null);
        }
    }
}
