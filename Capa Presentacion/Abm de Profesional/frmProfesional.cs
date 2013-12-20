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
    public partial class frmProfesional : frmBase
    {
        CapaDatos.Profesional p = null;

        // ------------------
        //  CONSTRUCTOR
        // ------------------
        public frmProfesional()
        {
            InitializeComponent();
        }



        //---------------
        // BOTON GUARDAR
        //---------------
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            this.validarErrores();
            this.validarMail(txtMail);
            this.validarFecha(mtxFechaNacimiento);
            
            int filasAfectadas = 0;

            if (huboErrores == false)
            {
                this.setearProfesional();


                // Realizo la operación correspondiente
                if (this.Text == "Alta Profesional") filasAfectadas = p.insert(p);

                if (this.Text == "Modificar Profesional") filasAfectadas = p.update(p); // cierro el form si es una modificación
                                            
            }
            
                // Si el usuario cometio errores en el ingreso de datos.
            else MessageBox.Show("Se encontraron errores en los datos ingresados. Corrija los errores y vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            // Reseteo la bandera de errores de usuario.
            huboErrores = false;


            // Si la operación se completo con éxito limpio los controles e informo.
            if (filasAfectadas > 0) {

                MessageBox.Show("El profesional se agregó correctamente.", "Operación realizada.", MessageBoxButtons.OK, MessageBoxIcon.Information );
                limpiarControles();

            }
            
        }



        //---------------
        // BOTON LIMPIAR
        //---------------
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarControles();
        }





        // ------------------
        // EVENTOS
        // ------------------

        // Load
        private void frmProfesional_Load(object sender, EventArgs e)
        {
            // Creo un objeto profesional
            p = new Clinica_Frba.CapaDatos.Profesional();
            
            // Seteo el label con el titulo
            lblTitulo.Text = this.Text.ToUpper();

            // Lleno el combobox especialidades
            if (cmbEspecialidad.Items.Count == 0)
            {
                DataTable dt = p.getEspecialidades();
                cmbEspecialidad.llenar(dt);
            }

            
        }


        


        private void setearProfesional()    
        {      

                p.dni = Int32.Parse(txtDNI.Text);
                //prof.username = txtUsername.Text;
                //prof.clave = txtClave.Text;
                //prof.intentos
                //prof.habilitado
                p.tipoDocumento = cmbTipoDocumento.Text;
                p.nombres = txtNombre.Text;
                p.apellido = txtApellido.Text;
                p.direccion = txtDireccion.Text;
                p.telefono = Int32.Parse(txtTelefono.Text);
                p.mail = txtMail.Text;
                p.fechaNacimiento = Convert.ToDateTime(mtxFechaNacimiento.Text);
                p.sexo = cmbSexo.Text.Trim().ToCharArray()[0];
                
                                
                // Datos de profesional                
                p.matricula = txtMatricula.Text;
                p.especialidadCodigo = Convert.ToInt32(cmbEspecialidad.SelectedValue.ToString());
        }



        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtTelefono.soloNumeros(erp, e);
        }

        // txtDNI KeyPress
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDNI.soloNumeros(erp, e);
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMatricula.soloNumeros(erp, e);
        }

       
       


              
    }
}
