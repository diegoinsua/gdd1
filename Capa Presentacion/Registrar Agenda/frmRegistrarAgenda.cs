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
    public partial class frmRegistrarAgenda : frmBase
    {
        public frmRegistrarAgenda()
        {
            InitializeComponent();
        }


        public void llenarCombosHorario()
        {

            // Si selecciono algún día
            if (clbDias.CheckedItems.Count != 0)
            {
                bool incluyeSabado = false;

                this.habilitarCombosHorarios();

                // Verifico si selecciono el día sabado          
                foreach (string cbx in clbDias.CheckedItems)
                {
                    if (cbx == "Sábado") incluyeSabado = true;
                }

                // Vacio los combobox
                cmbDesde.DataSource = null;
                cmbHasta.DataSource = null;

                // Cargo los combobox con los horarios
                if (incluyeSabado)
                {
                    cmbDesde.DataSource = horarios(10, 15);
                    cmbHasta.DataSource = horarios(10, 15);
                }
                else
                {
                    cmbDesde.DataSource = horarios(7, 20);
                    cmbHasta.DataSource = horarios(7, 20);
                }

                // Limpio los combobox
                cmbHasta.SelectedIndex = -1;
                cmbDesde.SelectedIndex = -1;
            }

            else deshabilitarCombosHorarios();
           

        }


        //
        private void clbDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.llenarCombosHorario();
            
        }


        private void limpiarDias()
        {
            foreach (CheckBox cbx in clbDias.CheckedItems) cbx.Checked = false;

        }


      


        private void dgvProfesional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.limpiarDias();

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            // Antes de guardar tengo que consultar la DB trayendo, si los hay, todos los demas
            // dias en los que atiende el medico y verificar que la suma de horas de atencion
            // no sea superior a 48 y que el rango de fechas no sea superior a 120 dias.
            // Tambien debo validar que el horario inicial no sea igual o menor al final,
            // e idem con las fechas.

            this.verificarErrores();

            // hacer algo

            this.huboErrores = false;


        }

        private void verificarErrores()
        {
            this.validarErrores();

            DateTime hInicio, hHasta, fInicio, fHasta;
            DateTime.TryParse(cmbDesde.Text.Trim(), out hInicio);
            DateTime.TryParse(cmbHasta.Text.Trim(), out hHasta);
            DateTime.TryParse(cmbFechaDesde.Text.Trim(), out fInicio);
            DateTime.TryParse(cmbFechaHasta.Text.Trim(), out fHasta);

            if (hInicio >= hHasta )
                this.validarPersonalizado(cmbHasta, "El horario inicio no puede ser mayor o igual al de finalización.");

            if (fInicio >= fHasta)
                this.validarPersonalizado(cmbFechaHasta, "La fecha inicio no puede ser mayor o igual al de finalización.");
            else this.validarPersonalizado(cmbFechaHasta, String.Empty);

            if (clbDias.CheckedItems.Count == 0) this.validarPersonalizado(clbDias, "Debe seleccionar al menos un día.");
            else this.validarPersonalizado(clbDias, String.Empty);
        }


        private void frmRegistrarAgenda_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = this.Text.ToUpper();

            dgvProfesional.personalizar();

            CapaDatos.Especialidad esp = new CapaDatos.Especialidad();
            DataTable dtE = esp.getEspecialidades();
            cmbEspecialidades.llenar(dtE);

            CapaDatos.Profesional pro = new CapaDatos.Profesional();            
            dgvProfesional.DataSource = pro.getProfesionales();


            this.deshabilitarCombosHorarios();
            
            this.limpiarControles();
           

        }


        private void deshabilitarCombosHorarios()
        {
            this.cmbDesde.Enabled = false;
            this.cmbHasta.Enabled = false;
        }


        private void habilitarCombosHorarios()
        {
            this.cmbDesde.Enabled = true;
            this.cmbHasta.Enabled = true;
        }


        // EVENTOS
        private void cmbFechaDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.cmbFechaDesde.noEditable(e);
        }


        private void cmbFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            this.cmbFechaDesde.mostrarFechaCorta();
        }

        private void cmbFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            this.cmbFechaHasta.mostrarFechaCorta();
        }



        public List<String> horarios(int desde, int hasta)
        {

            List<string> horarios = new List<string>();


            for (int i = desde; i < hasta; i++)
            {
                if (i < 10)
                {
                    horarios.Add("0" + i.ToString() + ":00");
                    horarios.Add("0" + i.ToString() + ":30");
                }
                else
                {
                    horarios.Add(i.ToString() + ":00");
                    horarios.Add(i.ToString() + ":30");
                }
            }


            return horarios;

        }

        private void cmbEspecialidades_Click(object sender, EventArgs e)
        {
            CapaDatos.Profesional p = new Clinica_Frba.CapaDatos.Profesional();
            if (cmbEspecialidades.Text != String.Empty && cmbEspecialidades.Text != "System.Data.DataRowView")
            {
                MessageBox.Show(cmbEspecialidades.ValueMember);
                dgvProfesional.DataSource = p.getProfesionalesByEspecialidad(Convert.ToInt32(cmbEspecialidades.ValueMember));
            }
        }

      

      
    }
}
