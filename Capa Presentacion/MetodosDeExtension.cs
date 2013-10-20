using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.CapaPresentacion
{
    
    //-------------------------------------
    // TEXT BOX
    //-------------------------------------
    public static class MetodosDeExtension
    {


        public static Boolean validarCaracter(this TextBox txt, string caracteresPermitidos, KeyPressEventArgs e) 
        {
    
            String Aceptados = caracteresPermitidos + Convert.ToChar(8);

            if (Aceptados.Contains(""+ e.KeyChar))
            {
                return e.Handled = false;
            }
            else
            {
                return e.Handled = true;
            }
        }



    }
}


