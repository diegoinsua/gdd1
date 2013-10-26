using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_frba.CapaDatos;

namespace Clinica_Frba.CapaPresentacion.Abm_de_Afiliado
{
    public partial class frmAfiliadoAlta : frmBase
    {
        public frmAfiliadoAlta()
        {
            InitializeComponent();
        }

        

        //Métodos
        private DataColumn nuevaColumna(string nombre, Type tipoDato)
        {
            DataColumn columna = new DataColumn();
            columna.DataType = tipoDato;
            columna.ColumnName = nombre;

            return columna;
        }

        private DataTable dtAfiliado()
        {

            Type caracter = typeof(char);
            Type cadena = typeof(string);
            Type numero = typeof(Int32);
            Type fecha = typeof(DateTime);

            DataTable dt = new DataTable();

            dt.Columns.Add(nuevaColumna("Nombre", cadena));
            dt.Columns.Add(nuevaColumna("Apellido", cadena));
            dt.Columns.Add(nuevaColumna("DNI", numero));
            dt.Columns.Add(nuevaColumna("Sexo", caracter));
            dt.Columns.Add(nuevaColumna("fechaNacimiento", fecha));
            dt.Columns.Add(nuevaColumna("Direccion", cadena));
            dt.Columns.Add(nuevaColumna("Telefono", numero));
            dt.Columns.Add(nuevaColumna("Mail", cadena));
            dt.Columns.Add(nuevaColumna("Estado civil", cadena));
            dt.Columns.Add(nuevaColumna("Hijos", numero));
            dt.Columns.Add(nuevaColumna("Personas a cargo", numero));
            dt.Columns.Add(nuevaColumna("Plan médico", numero));
            
            return dt;

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //Una vez hecha la validación
            this.validarErrores();
            this.validarMail(txtMail);

            if (huboErrores == false)
            {

                DataTable dt = this.dtAfiliado();
                DataRow dr = dt.NewRow();

                dr["Nombre"] = txtNombre.Text;
                dr["Apellido"] = txtApellido.Text;
                dr["DNI"] = mtxDNI.Text;
                dr["Sexo"] = cmbSexo.Text;
                dr["fechaNacimiento"] = mtxFecNacimiento.Text;
                dr["Direccion"] = txtDireccion.Text;
                dr["Telefono"] = mtxTelefono.Text;
                dr["Mail"] = txtMail.Text;
                dr["Estado civil"] = cmbEstCivil;
                dr["Hijos"] = mtxHijos;
                dr["Personas a cargo"] = mtxaCargo;
                dr["Plan médico"] = mtxPlan;

                AfiliadoTDG adm = new AfiliadoTDG();
                bool resultado = adm.insert(dr);

                if (resultado)
                {
                    limpiarControles();
                    if (this.Text == "Modificar Afiliado") this.Dispose(); // cierro el form si es una modificación
                }
            }

            huboErrores = false;
        }

        private void btn_Limpiar_Click_1(object sender, EventArgs e)
        {
            this.limpiarControles();
        }
    }
}
