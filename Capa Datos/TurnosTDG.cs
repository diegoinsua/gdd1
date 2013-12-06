using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Clinica_Frba.CapaDatos
{
    class Turnos : TableDataGateway
    {
        public void insert(DataRow turno) { }
        public void update(DataTable turno) { }
        public void delete(DataRow turno) { }
        public DataSet getTurnosById(int id) { return new DataSet(); }
    }
}
