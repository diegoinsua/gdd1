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
       
        public frmLoginRol()
        {
            InitializeComponent();
        }


        //-----------------
        // btnAceptarRol
        //-----------------
        private void btnAceptarRol_Click(object sender, EventArgs e)
        {
            this.validarErrores();

            if (!huboErrores)
            {
                //
                // CHEQUEAR!!!
                //
                FormLoginContainer.usuario.rolID = (int)cmbRol.SelectedValue;
                FormLoginContainer.usuario.rolNombre = cmbRol.ValueMember;

                frmClinica formClinica = new frmClinica();
                formClinica.usuario = FormLoginContainer.usuario;
                Show(formClinica);
                Close();

            }
        }
    }
}
