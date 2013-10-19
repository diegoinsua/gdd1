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
        public DataSet getAfiliadoById(int id) { return new DataSet(); }
        public void update(DataTable afiliado) { }
    }
}
