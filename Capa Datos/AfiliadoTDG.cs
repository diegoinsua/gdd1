using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Clinica_frba.CapaDatos
{
    public class AfiliadoTDG : TableDataGateway
    {
        public bool insert(DataRow afl) { return true; }
        public DataSet getAflByApellido(string apellido) { DataSet afl = new DataSet(); return afl; }
        public DataSet getAflByNroAfiliado(string nroAfiliado) { DataSet afl = new DataSet(); return afl; }
        public DataSet getAflByDNI(int dni) { DataSet afl = new DataSet(); return afl; }

        //Cambiar el delete
        public void delete(string apellido) { }
        public void update(DataTable afiliado) { }
    }
}
