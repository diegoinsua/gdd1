using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.CapaPresentacion.Abm_de_Rol
{
    public partial class frmRolABM : Clinica_Frba.CapaPresentacion.frmBaseABM
    {
        public frmRolABM()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmRol frmAlta = new frmRol();
            frmAlta.Text = "Alta Rol";
            this.ShowABM(frmAlta);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            frmRolBuscar frmBaja = new frmRolBuscar();
            frmBaja.Text = "Baja Rol";
            this.ShowABM(frmBaja);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmRolBuscar frmModificar = new frmRolBuscar();
            frmModificar.Text = "Modificar Rol";
            this.ShowABM(frmModificar);
        }
    }
}
