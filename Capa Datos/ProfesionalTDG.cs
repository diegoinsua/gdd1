using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_frba.CapaDatos
{
    public class ProfesionalTDG : TableDataGateway
    {
        public DataSet getAdmByApellido(string apellido)
        {
            DataSet adm = new DataSet();
            return adm;
        }

        public DataSet getAdmByMatricula(string matricula)
        {
            DataSet adm = new DataSet();
            return adm;
        }

        public DataSet getAdmByDNI(string dni)
        {
            DataSet adm = new DataSet();
            return adm;
        }
    }
}
