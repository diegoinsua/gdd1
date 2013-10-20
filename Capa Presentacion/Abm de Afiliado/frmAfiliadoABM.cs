using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.CapaPresentacion.Abm_de_Afiliado
{
    public partial class frmAfiliadoABM : Clinica_Frba.CapaPresentacion.frmBaseABM
    {
        public frmAfiliadoABM()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAfiliadoAlta frmAlta = new frmAfiliadoAlta();
            this.ShowABM(frmAlta);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            frmAfiliadoBusqueda frmBusqueda = new frmAfiliadoBusqueda();
            this.ShowABM(frmBusqueda);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmAfiliadoBusqueda frmBusqueda = new frmAfiliadoBusqueda();
            this.ShowABM(frmBusqueda);
        }

      }
}
