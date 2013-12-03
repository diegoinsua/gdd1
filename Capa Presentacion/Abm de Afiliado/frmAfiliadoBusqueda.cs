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
    public partial class frmAfiliadoBusqueda : frmBase
    {
        public frmAfiliadoBusqueda()
        {
            InitializeComponent();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.limpiarControles();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {            
            // Limpio el datagridview
            dgvAfiliado.Columns.Clear();
            
            // Válido errores
            this.validarErrores();

            // Si no hubo errores
            if (this.huboErrores == false)
            {
                Clinica_Frba.CapaPresentacion.AfiliadoTDG aflTDG = new Clinica_Frba.CapaPresentacion.AfiliadoTDG();

                if (txtApellido.ReadOnly == false)
                    dgvAfiliado.DataSource = aflTDG.getAflByApellido(txtApellido.Text);

                if (mtxNroAfiliado.ReadOnly == false)
                    dgvAfiliado.DataSource = aflTDG.getAflByNroAfiliado(mtxNroAfiliado.Text);

                if (mtxDNI.ReadOnly == false)
                    dgvAfiliado.DataSource = aflTDG.getAflByDNI(Convert.ToInt32(mtxDNI.Text));



                if (this.Text == "Modificar Afiliado")
                {
                    // Le agrego los botones "Seleccionar"
                    dgvAfiliado.agregarBotonSeleccionar("Seleccionar");
                }

                if (this.Text == "Baja Afiliado")
                {
                    // Le agrego los botones "Eliminar"
                    dgvAfiliado.agregarBotonSeleccionar("Eliminar");
                }


            }
        }

      
        //--------------------------
        // frmAfiliadoBusqueda LOAD
        //--------------------------
        private void frmAfiliadoBusqueda_Load(object sender, EventArgs e)
        {
            dgvAfiliado.personalizar();
           
        }
        
        //--------------------------
        // dgvProfesional CELLCLICK
        //--------------------------
        private void dgvAfiliado_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //---------------------------
            // Si es por una modificación
            //---------------------------
            if (this.Text == "Modificar Afiliado")
            {
                string apellido = dgvAfiliado.valorColumna(e, "Apellido"); //Para mostrar en la pantalla de modificacion

                frmAfiliadoAlta formModificar = new frmAfiliadoAlta();
                formModificar.Text = "Modificar Afiliado";
                formModificar.txtApellido.Text = apellido;
                formModificar.ShowDialog();
            }


            //---------------------------
            // Si es por una eliminación
            //---------------------------
            if (this.Text == "Baja Afiliado")
            {
                // Pregunto al usuario si esta seguro de eliminar al Profesional
                string apellido = dgvAfiliado.valorColumna(e, "Apellido");
                DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar al profesional cuyo apellido es " + apellido + "?.",
                                                         "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                // Si la respuesta es afirmativa, lo elimino.
                if (dr == DialogResult.Yes)
                {
                    // Elimino el profesional
                    Clinica_Frba.CapaPresentacion.AfiliadoTDG aflTDG = new Clinica_Frba.CapaPresentacion.AfiliadoTDG();
                    aflTDG.delete(apellido);

                    // Reseteo el form
                    dgvAfiliado.Columns.Clear();
                    this.limpiarControles();
                    this.habilitarControles();
                }
            }

        }
       
        
    }
}
