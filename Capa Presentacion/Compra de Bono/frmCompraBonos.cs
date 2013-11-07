using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.NewFolder3
{
    public partial class frmCompraBonos : Form
    {
        
        DataTable plan;

        public frmCompraBonos()
        {
            InitializeComponent();
        }

        private void nudBonosConsulta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmCompraBonos_Load(object sender, EventArgs e)
        {
            Clinica_frba.CapaDatos.PlanTDG planTDG = new Clinica_frba.CapaDatos.PlanTDG();
            DataTable plan = planTDG.getPlanById(23);

        }


       

       
    }
}
