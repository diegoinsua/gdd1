﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Clinica_Frba
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new CapaPresentacion.frmClinica() );
            //DESCOMENTAR LO SIGUIENTE PARA VER EL MENU DE ABMS
            //Application.Run(new Form1());
        }
    }
}
