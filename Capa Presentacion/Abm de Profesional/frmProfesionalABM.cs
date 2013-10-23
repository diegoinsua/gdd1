using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.CapaPresentacion.Abm_de_Profesional
{
    public partial class frmProfesionalABM : CapaPresentacion.frmBaseABM
    {
        public frmProfesionalABM()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmProfesionalAlta frmAlta = new frmProfesionalAlta();
            this.ShowABM(frmAlta);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            frmProfesionalBaja frmBaja = new frmProfesionalBaja();
            this.ShowABM(frmBaja);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmProfesionalModificar frmModificar = new frmProfesionalModificar();
            this.ShowABM(frmModificar);
        }


    }
}
