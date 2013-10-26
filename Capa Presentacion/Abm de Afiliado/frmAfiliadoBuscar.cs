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
    public partial class frmAfiliadoBuscar : frmBase
    {
        public frmAfiliadoBuscar()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            // Limpiio el datagridview
            dgv_Afiliado.Columns.Clear();

            // Válido errores
            this.validarErrores();

            // Si no hubo errores
            if (this.huboErrores == false)
            {
                //Primero hacer la consulta
                AfiliadoTDG aflTDG = new AfiliadoTDG();

                if (txt_Apellido.ReadOnly == false)
                    dgv_Afiliado.DataSource = aflTDG.getAflByApellido(txt_Apellido.Text);

                if (mtx_NroAfiliado.ReadOnly == false)
                    dgv_Afiliado.DataSource = aflTDG.getAflByNroAfiliado(mtx_NroAfiliado.Text);

                if (mtx_DNI.ReadOnly == false)
                    dgv_Afiliado.DataSource = aflTDG.getAdmByDNI(Convert.ToInt32(mtx_DNI.Text));


                if (this.Text == "Modificar Afiliado")
                {
                    // Le agrego los botones "Seleccionar"
                    dgv_Afiliado.agregarBotonSeleccionar("Seleccionar");
                }

                if (this.Text == "Baja Afiliado")
                {
                    // Le agrego los botones "Eliminar"
                    dgv_Afiliado.agregarBotonSeleccionar("Eliminar");
                }

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
                dgv_Afiliado.DataSource = dataTableAuxiliar;
            }

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.limpiarControles();
        }

        //--------------------------
        // frmAfiliadoBuscar LOAD
        //--------------------------
        private void frmAfiliadoBuscar_Load(object sender, EventArgs e)
        {
            dgv_Afiliado.personalizar();
        }


        //--------------------------
        // dgvAfiliado CELLCLICK
        //--------------------------
        private void dgv_Afiliado_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //---------------------------
            // Si es por una modificación
            //---------------------------
            if (this.Text == "Modificar Afiliado")
            {
                MessageBox.Show("ES UNA MODIF");
                string NroAfiliado = dgv_Afiliado.valorColumna(e, "Nro. de afiliado"); // obtengo la PK de la fila seleccionada

                frmAfiliadoAlta formModificar = new frmAfiliadoAlta();
                formModificar.Text = "Modificar Afiliado";
               
                formModificar.ShowDialog();
            }


            //---------------------------
            // Si es por una eliminación
            //---------------------------
            if (this.Text == "Baja Profesional")
            {
                MessageBox.Show("ES UNA ELIMINACION");
                // Pregunto al usuario si esta seguro de eliminar al Profesional
                string nroAfiliado = dgv_Afiliado.valorColumna(e, "Nro. de afiliado");
                DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar al profesional cuyo Nro. de afiliado es " + nroAfiliado + "?.",
                                                         "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                // Si la respuesta es afirmativa, lo elimino.
                if (dr == DialogResult.Yes)
                {
                    // Elimino el profesional
                    AfiliadoTDG aflTDG = new AfiliadoTDG();
                    aflTDG.delete(Convert.ToInt32(nroAfiliado));

                    // Reseteo el form
                    dgv_Afiliado.Columns.Clear();
                    this.limpiarControles();
                    this.habilitarControles();
                }
            }

        }
    
    }
}
