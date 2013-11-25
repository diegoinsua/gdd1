using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.CapaPresentacion.Abm_de_Profesional
{
    public partial class frmProfesionalBuscar : frmBase
    {
        public frmProfesionalBuscar()
        {
            InitializeComponent();
        }


        //--------------------
        // txtMatricula KEYPRESS
        //--------------------
        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMatricula.validarCaracter("0123456789", e, "Solo puede ingresar números.");
        }

        //--------------------
        // txtDNI KEYPRESS
        //--------------------
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMatricula.validarCaracter("0123456789", e, "Solo puede ingresar números.");
        }


        //--------------------
        // txtApellido CLICK
        //--------------------            
        private void txtApellido_Click(object sender, EventArgs e)
        {
            txtApellido.ReadOnly = false;
            txtDNI.ReadOnly = true;
            txtMatricula.ReadOnly = true;
        }


        //--------------------
        // txtMatricula CLICK
        //--------------------
        private void txtMatricula_Click(object sender, EventArgs e)
        {
            txtApellido.ReadOnly = true;
            txtDNI.ReadOnly = true;
            txtMatricula.ReadOnly = false;
        }


        //--------------------
        // txtDNI CLICK
        //--------------------
        private void txtDNI_Click(object sender, EventArgs e)
        {
            txtApellido.ReadOnly = true;
            txtDNI.ReadOnly = false;
            txtMatricula.ReadOnly = true;
        }


        //--------------------
        // btnLimpiar CLICK
        //--------------------
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarControles();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Limpiio el datagridview
            dgvProfesional.Columns.Clear();
            
            // Válido errores
            this.validarErrores();

            // Si no hubo errores
            if (this.huboErrores == false)
            {
                Clinica_Frba.CapaDatos.ProfesionalTDG admTDG = new Clinica_Frba.CapaDatos.ProfesionalTDG();

                if (txtApellido.ReadOnly == false)
                    dgvProfesional.DataSource = admTDG.getAdmByApellido(txtApellido.Text);

                if (txtMatricula.ReadOnly == false)
                    dgvProfesional.DataSource = admTDG.getAdmByMatricula(txtMatricula.Text);

                if (txtDNI.ReadOnly == false)
                    dgvProfesional.DataSource = admTDG.getAdmByDNI(txtDNI.Text);



                if (this.Text == "Modificar Profesional")
                {
                    // Le agrego los botones "Seleccionar"
                    dgvProfesional.agregarBotonSeleccionar("Seleccionar");
                }

                if (this.Text == "Baja Profesional")
                {
                    // Le agrego los botones "Seleccionar"
                    dgvProfesional.agregarBotonSeleccionar("Eliminar");
                }


            }

           

        }

        //--------------------------
        // frmProfesionalBuscar LOAD
        //--------------------------
        private void frmProfesionalBuscar_Load(object sender, EventArgs e)
        {
            dgvProfesional.personalizar();
        }


        //--------------------------
        // dgvProfesional CELLCLICK
        //--------------------------
        private void dgvProfesional_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //---------------------------
            // Si es por una modificación
            //---------------------------
            if (this.Text == "Modificar Profesional")
            {
                string matricula = dgvProfesional.valorColumna(e, "Matricula"); // obtengo la PK de la fila seleccionada

                frmProfesional formModificar = new frmProfesional();
                formModificar.Text = "Modificar Profesional";
                formModificar.txtMatricula.Text = matricula; 
                formModificar.ShowDialog();
            }


            //---------------------------
            // Si es por una eliminación
            //---------------------------
            if (this.Text == "Baja Profesional")
            {
                // Pregunto al usuario si esta seguro de eliminar al Profesional
                string matricula = dgvProfesional.valorColumna(e, "Matricula");
                DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar al profesional cuya matrícula es " + matricula + "?.",
                                                         "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
               
                // Si la respuesta es afirmativa, lo elimino.
                if (dr == DialogResult.Yes)
                {
                    // Elimino el profesional
                    Clinica_Frba.CapaDatos.ProfesionalTDG admTDG = new Clinica_Frba.CapaDatos.ProfesionalTDG();
                    admTDG.delete(matricula);

                    // Reseteo el form
                    dgvProfesional.Columns.Clear();
                    this.limpiarControles();
                    this.habilitarControles();
                }
            }           

        }


    }
}
