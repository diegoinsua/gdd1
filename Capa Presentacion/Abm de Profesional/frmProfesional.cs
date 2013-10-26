using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_frba.CapaDatos;


namespace Clinica_Frba.CapaPresentacion.Abm_de_Profesional
{
    public partial class frmProfesional : frmBase
    {
        
       
        
        public frmProfesional()
        {
            InitializeComponent();
        }

        // Métodos
        private DataColumn nuevaColumna(string nombre, Type tipoDato)
        {
            DataColumn columna = new DataColumn();
            columna.DataType = tipoDato;
            columna.ColumnName = nombre;

            return columna;
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


        // Eventos
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDNI.validarCaracter("0123456789", e);
        }

        private void txtMatriculaNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDNI.validarCaracter("0123456789", e);
        }

        //-----------
        // GUARDAR
        //-----------
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            this.validarErrores();
            this.validarMail(txtMail);
                       


            if (huboErrores == false) {

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


                 AdministrativoTDG adm = new AdministrativoTDG();
                 bool resultado = adm.insert(dr);
                 
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
      

              
    }
}
