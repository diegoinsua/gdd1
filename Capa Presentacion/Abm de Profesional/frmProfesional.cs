using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.CapaPresentacion;


namespace Clinica_Frba.CapaPresentacion.Abm_de_Profesional
{
    public partial class frmProfesional : frmBase
    {
        
       
        
        public frmProfesional()
        {
            InitializeComponent();

            this.Text = "Alta Profesional";

        }

        // Métodos
        private DataColumn nuevaColumna(string nombre, Type tipoDato)
        {
            DataColumn columna = new DataColumn();
            columna.DataType = tipoDato;
            columna.ColumnName = nombre;

            return columna;
        }

       

        // Eventos
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool charValido = txtDNI.validarCaracter("0123456789", e, "Solo puede ingresar números.");
                        
            if (charValido)  erp.SetError(txtDNI, "error error");            
            
        }




        private void txtMatriculaNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDNI.validarCaracter("0123456789", e, "Solo puede ingresar números.");
        }

        //-----------
        // GUARDAR
        //-----------
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            this.validarErrores();
            this.validarMail(txtMail);
                       


            if (huboErrores == false) {
                
                AdministrativoTDG adm = new AdministrativoTDG();
                DataTable dt = crearProfesionalDT();
                 
                bool resultado;

                if (this.Text == "Alta Profesional")  resultado = adm.insert(dt);
                if (this.Text == "Modificar Profesional") resultado = adm.update(dt);
                 
                if ( resultado ) { 
                     limpiarControles();
                     if (this.Text == "Modificar Profesional") this.Dispose(); // cierro el form si es una modificación
                 }
                                
            }

            huboErrores = false;
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiarControles();
        }



        private void frmProfesional_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = this.Text;
        }



        private DataTable dtProfesional()
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



        private DataTable crearProfesionalDT()
        {
                DataTable dt = this.dtProfesional();
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

              
    }
}
