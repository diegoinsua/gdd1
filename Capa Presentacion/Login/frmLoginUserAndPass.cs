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
    public partial class frmLoginUserAndPass : Form
    {
        // Propiedades
        public CapaPresentacion.Login.frmLogin formPadre { get; set; }

        public frmLoginUserAndPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLoginRol formRol = new frmLoginRol();
            formPadre.Text = "Rol";
            formPadre.ShowLogin(formRol);
        }
    }
}
