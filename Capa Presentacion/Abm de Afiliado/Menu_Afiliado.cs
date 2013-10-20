using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.NewFolder12
{
    public partial class Afiliado : Form
    {
        public Afiliado()
        {
            InitializeComponent();
        }

       private void ocultarMenuAfiliados()
        {
            lbl_MenuAfiliado.Visible = false;
            btn_Alta.Visible = false;
            btn_Baja.Visible = false;
            btn_Modificar.Visible = false;
            btn_Cancelar.Visible = false;
        }
       
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.ocultarMenuAfiliados();
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Clinica_Frba.CapaPresentacion.Abm_de_Afiliado.Modificacion_Afiliado frm = new Clinica_Frba.CapaPresentacion.Abm_de_Afiliado.Modificacion_Afiliado();
            frm.Show(); 
        }

        private void btn_Alta_Click_1(object sender, EventArgs e)
        {
            Clinica_Frba.CapaPresentacion.Abm_de_Afiliado.Alta_Afiliado frm = new Clinica_Frba.CapaPresentacion.Abm_de_Afiliado.Alta_Afiliado();
            frm.Show(); 
        }
    }
}
