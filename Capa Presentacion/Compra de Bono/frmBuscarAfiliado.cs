using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.CapaPresentacion.Compra_de_Bono
{
    public partial class frmBuscarAfiliado : frmBase
    {


        public frmBuscarAfiliado()
        {
            InitializeComponent();
            this.Visible = false;
        }



        private void frmBuscarAfiliado_Load(object sender, EventArgs e)
        {
            if (usuario.rol != "Administrativo")
            {
                frmCompraBonos formCompra = new frmCompraBonos();
                formCompra.usuario = usuario;

                this.formularioClinica.ShowFormulario(formCompra);
            }


        }

        private void txtAfiliado_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtAfiliado.soloNumeros(erp, e);
        }

        private void btnBuscarAfiliado_Click(object sender, EventArgs e)
        {

        }

       
    }
}
