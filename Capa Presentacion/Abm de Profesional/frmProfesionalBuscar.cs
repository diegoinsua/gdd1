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
            txtMatricula.validarCaracter("0123456789", e);
        }

        //--------------------
        // txtDNI KEYPRESS
        //--------------------
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMatricula.validarCaracter("0123456789", e);
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
                Clinica_frba.CapaDatos.ProfesionalTDG admTDG = new Clinica_frba.CapaDatos.ProfesionalTDG();

                if (txtApellido.ReadOnly == false)
                    dgvProfesional.DataSource = admTDG.getAdmByApellido(txtApellido.Text);

                if (txtMatricula.ReadOnly == false)
                    dgvProfesional.DataSource = admTDG.getAdmByMatricula(txtMatricula.Text);

                if (txtDNI.ReadOnly == false)
                    dgvProfesional.DataSource = admTDG.getAdmByDNI(txtDNI.Text);


                // Le agrego los botones "Seleccionar"
                dgvProfesional.agregarBotonSeleccionar();

            }

            else
            {
                dgvProfesional.DataSource = null;
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
            string col = dgvProfesional.valorColumna(e, "Matricula");
      
           if (col != string.Empty)  MessageBox.Show("Matricula Nº " + col);

        }

    }
}
