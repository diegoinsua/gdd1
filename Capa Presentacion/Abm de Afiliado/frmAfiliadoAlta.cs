using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.CapaPresentacion.Abm_de_Afiliado
{
    public partial class frmAfiliadoAlta : Form
    {
        public frmAfiliadoAlta()
        {
            InitializeComponent();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            cmb_Sexo.SelectedIndex = -1;
            mtx_DNI.Clear();
            mtx_FecNacimiento.Clear();
            txt_Direccion.Clear();
            txt_Mail.Clear();
            mtx_Telefono.Clear();
            cmb_EstCivil.SelectedIndex = -1;
            mtx_Hijos.Clear();
            mtx_aCargo.Clear();
            mtx_Plan.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //Una vez hecha la validación

            //Creo el DataRow
            DataTable dataTableAuxiliar = new DataTable();

            dataTableAuxiliar.Columns.Add("Nombre", typeof(string));
            dataTableAuxiliar.Columns.Add("Apellido", typeof(string));
            dataTableAuxiliar.Columns.Add("DNI", typeof(int));
            dataTableAuxiliar.Columns.Add("Sexo", typeof(char));
            dataTableAuxiliar.Columns.Add("Fecha", typeof(string));
            dataTableAuxiliar.Columns.Add("Direccion", typeof(string));
            dataTableAuxiliar.Columns.Add("Telefono", typeof(int));
            dataTableAuxiliar.Columns.Add("Mail", typeof(string));
            dataTableAuxiliar.Columns.Add("Estado_Civil", typeof(string));
            dataTableAuxiliar.Columns.Add("Hijos", typeof(int));
            dataTableAuxiliar.Columns.Add("Acargo", typeof(int));
            dataTableAuxiliar.Columns.Add("Plan", typeof(int));

            //AGREO A LA FILA LA INFO DE LOS DISTINTOS CONTROLES
            dataTableAuxiliar.Rows.Add(txt_Nombre.Text, txt_Apellido.Text, mtx_DNI.Text,
                    cmb_Sexo.Text, mtx_FecNacimiento.Text, txt_Direccion.Text, mtx_Telefono.Text,
                           txt_Mail.Text, cmb_EstCivil.Text, mtx_Hijos.Text,
                                mtx_aCargo.Text, mtx_Plan.Text);
            
            //OBTENGO LA PRIMERA FILA DE LA TABLA AUXILIAR
            DataRow row = dataTableAuxiliar.Rows[0];
           
           //DE PRUEBA MUESTRA LOS DATOS CARGADOS EN LA TABLA AUXILIAR
            MessageBox.Show(row[1].ToString());
            MessageBox.Show(row[2].ToString());
            MessageBox.Show(row[3].ToString());
            MessageBox.Show(row[4].ToString());
            MessageBox.Show(row[5].ToString());
            MessageBox.Show(row[6].ToString());
            MessageBox.Show(row[7].ToString());
            MessageBox.Show(row[8].ToString());
            MessageBox.Show(row[9].ToString());
            MessageBox.Show(row[10].ToString());
            MessageBox.Show(row[11].ToString());
                       
        }

        private void btn_Limpiar_Click_1(object sender, EventArgs e)
        {
            txt_Nombre.Clear(); txt_Apellido.Clear(); mtx_DNI.Clear(); cmb_Sexo.SelectedIndex = -1;
            mtx_FecNacimiento.Clear(); txt_Direccion.Clear(); mtx_Telefono.Clear(); txt_Mail.Clear();
            cmb_EstCivil.SelectedIndex = -1; mtx_Hijos.Clear(); mtx_aCargo.Clear(); mtx_Plan.Clear();
        }

       
    }
}
