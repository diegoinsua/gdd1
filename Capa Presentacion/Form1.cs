using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CapaPresentacion.Abm_de_Profesional.frmProfesionalABM frmProfesional = new CapaPresentacion.Abm_de_Profesional.frmProfesionalABM();
            frmProfesional.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CapaPresentacion.Abm_de_Afiliado.frmAfiliadoABM frmAfiliado = new CapaPresentacion.Abm_de_Afiliado.frmAfiliadoABM();
            frmAfiliado.Show();
        }
    }
}
