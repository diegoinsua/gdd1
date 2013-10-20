using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.CapaPresentacion.Abm_de_Afiliado
{
    public partial class Alta_Afiliado : Form
    {
        public Alta_Afiliado()
        {
            InitializeComponent();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            cmb_Sexo.SelectedIndex = -1;
            mtx_DNI.Clear();
            mtx_FecNacimiento.Clear();
            txt_Direccion.Clear();
            txt_Mail.Clear();
            mtx_Telefono.Clear();
            cmb_EstCivil.SelectedIndex = -1;
            mtx_Hijos.Clear();
            mtx_aCargo.Clear();
            mtx_Plan.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
