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
        CapaDatos.Profesional prof = null;

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
                this.crearProfesionalDT();


                // Realizo la operación correspondiente
                if (this.Text == "Alta Profesional") filasAfectadas = prof.insert(prof);

                if (this.Text == "Modificar Profesional") filasAfectadas = prof.update(prof); // cierro el form si es una modificación
                                            
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
            prof = new Clinica_Frba.CapaDatos.Profesional();
            
            // Seteo el label con el titulo
            lblTitulo.Text = this.Text;

            // Lleno el combobox especialidades
            DataTable dt = prof.getEspecialidades();
            cmbEspecialidad.llenar(dt);
        }


        





        //-----------------------
        // DATATABLE PROFESIONAL
        //-----------------------
        private DataTable getDtProfesional()
        {

            Type caracter = typeof(char);
            Type cadena = typeof(string);
            Type numero = typeof(Int32);
            Type fecha = typeof(DateTime);

            DataTable dt = new DataTable();

            dt.Columns.Add(nuevaColumna("nombre", cadena));
            dt.Columns.Add(nuevaColumna("apellido", cadena));
            dt.Columns.Add(nuevaColumna("dni", numero));
            dt.Columns.Add(nuevaColumna("sexo", caracter));
            dt.Columns.Add(nuevaColumna("fechaNacimiento", fecha));
            dt.Columns.Add(nuevaColumna("direccion", cadena));
            dt.Columns.Add(nuevaColumna("telefono", cadena));
            dt.Columns.Add(nuevaColumna("mail", cadena));
            dt.Columns.Add(nuevaColumna("especialidad", cadena));
            dt.Columns.Add(nuevaColumna("matricula", numero));


            return dt;

        }


        private DataColumn nuevaColumna(string nombre, Type tipoDato)
        {
            DataColumn columna = new DataColumn();
            columna.DataType = tipoDato;
            columna.ColumnName = nombre;

            return columna;
        }



        private void crearProfesionalDT()
        {
              

                // Datos de usuario
                prof.dni = Int32.Parse(txtDNI.Text);
                prof.username = txtUsername.Text;
                prof.clave = txtClave.Text;
                //prof.intentos
                //prof.habilitado
                prof.tipoDocumento = cmbTipoDocumento.Text;
                prof.nombres = txtNombre.Text;
                prof.apellido = txtApellido.Text;
                prof.direccion = txtDireccion.Text;
                prof.telefono = txtTelefono.Text;
                prof.mail = txtMail.Text;
                prof.fechaNacimiento = Convert.ToDateTime(mtxFechaNacimiento.Text);
                prof.sexo = cmbSexo.Text.Trim().ToCharArray()[0];
                
                                
                // Datos de profesional                
                prof.matricula = cmbEspecialidad.ValueMember;
                prof.especialidad = cmbEspecialidad.Text;
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
