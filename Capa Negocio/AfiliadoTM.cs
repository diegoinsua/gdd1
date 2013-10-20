using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Clinica_frba.CapaNegocio
{
    class AfiliadoTM
    {
        // Atributos
        CapaDatos.AfiliadoTDG afiliadoTDG; // Del tipo AfiliadoTDG, clase que se encuentra en la Capa de Datos

        // Constructor 
        public AfiliadoTDG() { afiliadoTDG = new CapaDatos.AfiliadoTDG(); }
       
        // Métodos
        public static void procesar_AltaAfiliado(DataRow registros_NewAfiliado) {
        // COMPLETAR
        }
        
        public DataSet getAfiliadoById(int idAfiliado)
        {
            DataSet afiliado = afiliadoTDG.getAfiliadoById(idAfiliado);
            return afiliado;
        }


        public DataSet getAfiliadoByAtributos() { return new DataSet(); }
       
                
        public void insert(string nombre, string apellido, char sexo, int dni, int fechaNacimiento, string direccion, int telefono,string mail, string estadoCivil, short hijos, short personasA_Cargo, int planMedico ) {}
        

        public void update(string direccion, int telefono, string mail, int planMedico, char sexo, string estadoCivil, short hijos, short personasA_cargo) {
            DataTable afiliado = new DataTable();

            // Algún código obteniendo datos y metiendolos dentro del DataTable
            // NEED SOME HELP AT THIS POINT

            afiliadoTDG.update(afiliado); // actualizo los datos      
        }


        public void delete() {} 

    }
}
