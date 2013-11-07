using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.CapaPresentacion
{
    public partial class frmLoginRol : frmBase
    {
        // Propiedades
        public Form formPadre { get; set; }


        public frmLoginRol()
        {
            InitializeComponent();
        }

        private void btnAceptarRol_Click(object sender, EventArgs e)
        {
            this.validarErrores();

            if (huboErrores)
            {
                // abro el programa
            }
        }
    }
}
