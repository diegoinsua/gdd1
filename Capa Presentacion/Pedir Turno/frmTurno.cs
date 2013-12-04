using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.CapaPresentacion.Pedir_Turno
{
    public partial class frmTurno : frmBase
    {
        public frmTurno()
        {
            InitializeComponent();
        }

        private void frmTurno_Load(object sender, EventArgs e)
        {

        }

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTurnos.SelectedRows.Count > 0) btnSolicitarTurno.Enabled = true;
            else btnSolicitarTurno.Enabled = true;

        }

        private void btnSolicitarTurno_Click(object sender, EventArgs e)
        {

        }
    }
}
