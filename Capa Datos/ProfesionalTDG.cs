using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.CapaDatos
{
    public class Profesional : TableDataGateway
    {
        public DataSet getAdmByApellido(string apellido)
        {
            DataSet adm = new DataSet();
            return adm;
        }

        public DataSet getAdmByDNI(string matricula)
        {
            DataSet adm = new DataSet();
            return adm;
        }

        public DataTable getAdmByMatricula(string dni)
        {            
            DataTable dt = new DataTable();
            
            dt.Columns.Add("Matricula", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Apellido", typeof(string));
            dt.Columns.Add("DNI", typeof(int));
            dt.Columns.Add("Especialidad", typeof(string));

            dt.Rows.Add(122, "Juan", "Perez", 30111222, "Cardiologo");
            dt.Rows.Add(100, "Pedro", "Alegre", 1111111, "Neurologo");
            dt.Rows.Add(21, "Osvaldo", "Lopez", 26987121, "Cirujano");
            dt.Rows.Add(49, "Antonio", "Garcia", 35000333, "Oftalmologo");

            return dt;
        }


        public DataTable getEspecialidades()
        {
            Especialidad e = new Especialidad();

            return e.getEspecialidades();
        }

        public bool insert(DataTable dt) { return true; }
        public bool update(DataTable dt) { return true; }
        public bool delete(int matricula) { return true; }
    }
}
