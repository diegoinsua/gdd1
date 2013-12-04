using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.CapaPresentacion.Registrar_Agenda
{
    public partial class frmRegistrarAgenda : Form
    {
        public frmRegistrarAgenda()
        {
            InitializeComponent();
        }


        public void llenarCombosHorario()
        {
            bool incluyeSabado = false;

            List<string> horarios = new List<string>();
            
            foreach (CheckBox cbx in clbDias.CheckedItems)
            {
                if (cbx.Text == "Sábado") incluyeSabado = true;
            }



            if (incluyeSabado)
            {
                for (int i = 10; i <= 15; i++)
                {
                    cmbDesde.Items.Add(i.ToString() + ":00");
                    cmbHasta.Items.Add(i.ToString() + ":00");
                }
            }


            else
            {
                for (int i = 7; i <= 20; i++)
                {
                    cmbDesde.Items.Add(i.ToString() + ":00");
                    cmbHasta.Items.Add(i.ToString() + ":00");

                }
            }

        }


        //
        private void clbDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarHorarios();
            
        }


        private void limpiarDias()
        {
            foreach (CheckBox cbx in clbDias.CheckedItems) cbx.Checked = false;
        }


        private void limpiarHorarios()
        {
            cmbDesde.Items.Clear();
            cmbHasta.Items.Clear();

            if (clbDias.CheckedItems.Count != 0) llenarCombosHorario();
        }


        private void dgvProfesional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.limpiarDias();
            this.limpiarHorarios();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.limpiarDias();
            this.limpiarHorarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Antes de guardar tengo que consultar la DB trayendo, si los hay, todos los demas
            // dias en los que atiende el medico y verificar que la suma de horas de atencion
            // no sea superior a 48 y que el rango de fechas no sea superior a 120 dias.
            // Tambien debo validar que el horario inicial no sea igual o menor al final,
            // e idem con las fechas.
        }




      
    }
}
