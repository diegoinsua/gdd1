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
    public partial class frmAfiliadoBusqueda : Form
    {
        public frmAfiliadoBusqueda()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txt_Apellido.Text) || !String.IsNullOrEmpty(mtx_NroAfiliado.Text) || !String.IsNullOrEmpty(mtx_DNI.Text))
            {
                //Primero hacer la consulta

                //DEBUG
                //Creo una tabla de prueba que será mostrada en el data grid
                DataTable dataTableAuxiliar = new DataTable();

                dataTableAuxiliar.Columns.Add("Nombre", typeof(string));
                dataTableAuxiliar.Columns.Add("Apellido", typeof(string));
                dataTableAuxiliar.Columns.Add("DNI", typeof(Int32));
                dataTableAuxiliar.Columns.Add("Nro Afiliado", typeof(Int32));

                //Relleno algunas filas de la tabla
                dataTableAuxiliar.Rows.Add("Pepe", "Lopez", 34784819, 888);
                dataTableAuxiliar.Rows.Add("Pepita", "Lopez", 35784811, 889);
                dataTableAuxiliar.Rows.Add("Pepito", "Lopez", 40784819, 887);

                //SE MUESTRAN LOS RESULTADOS LA CONSULTA FICTICIA QUE TRAJO UNA TABLA
                //EN EL DATA GRID VIEW
                dgv_resultado.DataSource = dataTableAuxiliar;
            }

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_Apellido.Clear(); mtx_DNI.Clear(); mtx_NroAfiliado.Clear();
            //ACA DA ERROR
            dgv_resultado.Rows.Clear();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int i;
            //NO ENTRA :/
            for (i = 0; i < dgv_resultado.Rows.Count; i++)
            {
                if ((bool) dgv_resultado.Rows[i].Cells["eliminar"].Value)
                {
                    //Modificar los datos en capa de Datos
                    //Mostrar los cambios en la Data Grid
                    dgv_resultado.Rows[i].Cells["baja_logica"].Value = "Si";
                    dgv_resultado.Rows[i].Cells["eliminar"].Value = false;
                }
            }
        }

       

       
        
    }
}
