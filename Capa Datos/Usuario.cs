using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.CapaPresentacion
{
    public class Usuario
    {
        
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int planID { get; set; }
        public string planNombre { get; set; }
        public int rolID { get; set; }
        public string rolNombre { get; set; }


        public Usuario()
        {
            inicializarUsuario();
        }


        public void inicializarUsuario() 
        {
            id = 0;
            nombre = string.Empty;
            apellido = string.Empty;
            planID = 0;
            planNombre = string.Empty;
            rolID = 0;
            rolNombre = string.Empty;
        }
    }
}
