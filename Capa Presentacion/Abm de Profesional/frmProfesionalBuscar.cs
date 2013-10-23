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
    public partial class frmProfesionalBuscar : frmBase
    {
        public frmProfesionalBuscar()
        {
            InitializeComponent();
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMatricula.validarCaracter("0123456789", e);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMatricula.validarCaracter("0123456789", e);
        }

              

            
        private void txtApellido_Click(object sender, EventArgs e)
        {
            txtApellido.ReadOnly = false;
            txtDNI.ReadOnly = true;
            txtMatricula.ReadOnly = true;
        }

        private void txtMatricula_Click(object sender, EventArgs e)
        {
            txtApellido.ReadOnly = true;
            txtDNI.ReadOnly = true;
            txtMatricula.ReadOnly = false;
        }

        private void txtDNI_Click(object sender, EventArgs e)
        {
            txtApellido.ReadOnly = true;
            txtDNI.ReadOnly = false;
            txtMatricula.ReadOnly = true;
        }

       

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarControles();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.huboErrores == false)
            {
                Clinica_frba.CapaDatos.ProfesionalTDG admTDG = new Clinica_frba.CapaDatos.ProfesionalTDG();

                if (txtApellido.ReadOnly = false && txtApellido.Text != string.Empty)
                {
                    dgvProfesional.DataSource = admTDG.getAdmByApellido(txtApellido.Text);
                }
            }
        }

    }
}
