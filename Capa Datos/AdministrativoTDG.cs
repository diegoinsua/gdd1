using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Clinica_frba.CapaDatos
{



    public class AdministrativoTDG : TableDataGateway
    {
        // Habrá un objeto TDG por cada tabla en la DB.
        // Heredan todos los métodos de la superclase TableDataGateway.
        // Solo se definen los métodos que varían para cada clase, que son los que realizan los insert, delete, update y select.
        // La cantidad de métodos varía para cada clase, por ej podría haber dos métodos delete distintos uno que elimine según una id y otro según un apellido.
        // Se valen de los métodos exucteQuery y executeNonQuery para realizar las operaciones de consultas. Los heredan de la superclase.

        public bool insert(DataRow adm) { return true; }
        public void update(DataTable adm) { }
        public void delete(string matriculaNumero) { }
        public DataSet getAdmById(int id) { return new DataSet(); }
        public DataSet getAdmByAtributos(string apellido) { return new DataSet(); }

    }
   
}

