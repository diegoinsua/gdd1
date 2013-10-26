using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.CapaPresentacion.Abm_de_Afiliado
{
    public partial class frmAfiliadoABM : CapaPresentacion.frmBaseABM
    {
        public frmAfiliadoABM()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAfiliadoAlta frmAlta = new frmAfiliadoAlta();
            frmAlta.Text = "Alta Afiliado";
            this.ShowABM(frmAlta);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            frmAfiliadoBusqueda frmBaja = new frmAfiliadoBusqueda();
            frmBaja.Text = "Baja Afiliado";
            this.ShowABM(frmBaja);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmAfiliadoBusqueda frmModificar = new frmAfiliadoBusqueda();
            frmModificar.Text = "Modificar Afiliado";
            this.ShowABM(frmModificar);
        }

      }
}
