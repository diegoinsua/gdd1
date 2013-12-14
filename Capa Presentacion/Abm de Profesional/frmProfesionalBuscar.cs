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
        Clinica_Frba.CapaDatos.Profesional profesional = null;

        public frmProfesionalBuscar()
        {
            InitializeComponent();

            profesional = new Clinica_Frba.CapaDatos.Profesional();

        }


        //--------------------
        // txtMatricula KEYPRESS
        //--------------------
        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMatricula.soloNumeros(erp, e);            
        }

        //--------------------
        // txtDNI KEYPRESS
        //--------------------
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMatricula.soloNumeros(erp, e);  
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
                

                if (txtApellido.ReadOnly == false)
                    dgvProfesional.DataSource = profesional.getProfByApellido(txtApellido.Text);

                if (txtMatricula.ReadOnly == false)
                    dgvProfesional.DataSource = profesional.getProfByMatricula(Convert.ToInt32(txtMatricula.Text));

                if (txtDNI.ReadOnly == false)
                    dgvProfesional.DataSource = profesional.getProfByDNI(Convert.ToInt32(txtDNI.Text));



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

            lblTitulo.Text = this.Text.ToUpper();
        }


        //--------------------------
        // dgvProfesional CELLCLICK
        //--------------------------
        private void dgvProfesional_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvProfesional.click(e))
            {
                //---------------------------
                // Si es por una modificación
                //---------------------------
                if (this.Text == "Modificar Profesional")
                {
                    int dni = Convert.ToInt32(dgvProfesional.valorColumna(e, "Documento Nº")); // obtengo la PK de la fila seleccionada
                    frmProfesional formModificar = new frmProfesional();
                    formModificar.Text = "Modificar Profesional";
                    formModificar.txtDNI.Text = dni.ToString();
                    DataTable dt = profesional.getProfByDNI(dni);

                  CapaDatos.Especialidad especialidad = new CapaDatos.Especialidad();

                 formModificar.cmbEspecialidad.llenar(especialidad.getEspecialidades());
                    
                    formModificar.cmbTipoDocumento.Text = dt.Rows[0]["Tipo"].ToString();
                    formModificar.txtDNI.Text = dni.ToString();
                    formModificar.txtNombre.Text = dt.Rows[0]["Nombres"].ToString();
                    formModificar.txtApellido.Text = dt.Rows[0]["Apellido"].ToString();
                    formModificar.mtxFechaNacimiento.Text = dt.Rows[0]["Fecha Nac."].ToString();
                    formModificar.cmbSexo.Text = dt.Rows[0]["Sexo"].ToString();
                    formModificar.txtDireccion.Text = dt.Rows[0]["Direccion"].ToString();
                    formModificar.txtTelefono.Text = dt.Rows[0]["Teléfono"].ToString();
                    formModificar.txtMail.Text = dt.Rows[0]["E-Mail"].ToString();
                    //formModificar.txtUsername.Text = dt.Rows[0]["Username"].ToString();
                   // formModificar.txtClave.Text = dt.Rows[0]["Clave"].ToString();
                    formModificar.cmbEspecialidad.Text = dt.Rows[0]["Especialidad"].ToString();
                    formModificar.txtMatricula.Text = dt.Rows[0]["Matricula"].ToString();

                    formModificar.ShowDialog();
                }


                //---------------------------
                // Si es por una eliminación
                //---------------------------
                if (this.Text == "Baja Profesional")
                {
                    // Pregunto al usuario si esta seguro de eliminar al Profesional
                    string dni = dgvProfesional.valorColumna(e, "Documento Nº");
                    DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar al profesional cuyo documento es " + dni + "?.",
                                                       "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    // Si la respuesta es afirmativa, lo elimino.
                    if (dr == DialogResult.Yes)
                    {
                        // Elimino el profesional
                        profesional.delete(Int32.Parse(dni));

                        // Reseteo el form
                        dgvProfesional.Columns.Clear();
                        this.limpiarControles();
                        this.habilitarControles();
                    }
                }

            }
        }

     

     

      
       


    }
}
