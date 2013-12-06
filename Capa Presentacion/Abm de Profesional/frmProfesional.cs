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


            if (huboErrores == false)
            {
                DataTable dt = crearProfesionalDT();
                bool accionCompletada = false;


                // Modifico la DB
                if (this.Text == "Alta Profesional") accionCompletada = prof.insert(dt);
                if (this.Text == "Modificar Profesional") accionCompletada = prof.update(dt);


                // Acciones posteriores 
                if (accionCompletada)
                {
                    limpiarControles();
                    if (this.Text == "Modificar Profesional") this.Dispose(); // cierro el form si es una modificación
                }

                else

                    MessageBox.Show("Se produjo un error que impidio completar el proceso. Intente nuevamente.");
                
            }

            huboErrores = false;
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


        // txtDNI KeyPress
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool charValido = txtDNI.validarCaracter("0123456789", e, "Solo puede ingresar números.");
                        
            if (charValido)  erp.SetError(txtDNI, "error error");            
            
        }


        // txtMatriculaNumero KeyPress
        private void txtMatriculaNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDNI.validarCaracter("0123456789", e, "Solo puede ingresar números.");
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
            dt.Columns.Add(nuevaColumna("telefono", numero));
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



        private DataTable crearProfesionalDT()
        {
                DataTable dt = this.getDtProfesional();
                DataRow dr = dt.NewRow();

                dr["nombre"] = txtNombre.Text;
                dr["apellido"] = txtApellido.Text;
                dr["dni"] = txtDNI.Text;
                dr["sexo"] = cmbSexo.Text;
                dr["fechaNacimiento"] = mtxFechaNacimiento.Text;
                dr["direccion"] = txtDireccion.Text;
                dr["telefono"] = txtTelefono.Text;
                dr["mail"] = txtMail.Text;
                dr["especialidad"] = cmbEspecialidad.ValueMember;

                return dt;
        }


        // FIN DATATABLE

              
    }
}
