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
            frmProfesional frmAlta = new frmProfesional();
            frmAlta.Text = "Alta Profesional";
            this.ShowABM(frmAlta);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            frmProfesionalBuscar frmBaja = new frmProfesionalBuscar();
            frmBaja.Text = "Baja Profesional";
            this.ShowABM(frmBaja);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmProfesionalBuscar frmModificar = new frmProfesionalBuscar();
            frmModificar.Text = "Modificar Profesional";
            this.ShowABM(frmModificar);
        }


    }
}
