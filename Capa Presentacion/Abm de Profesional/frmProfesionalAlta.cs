using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.CapaPresentacion.Abm_de_Profesional
{
    public partial class frmProfesionalAlta : Form
    {
        public frmProfesionalAlta()
        {
            InitializeComponent();
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDNI.validarCaracter("0123456789", e);
        }

       

        
    }
}
