using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.CapaPresentacion
{
    public partial class frmBaseABM : Form
    {
        public frmBaseABM()
        {
            InitializeComponent();
        }


        // Atributos
        string tipoABM;



         //Propiedades

        [Description("Tipo de ABM. Por ejemplo: Afiliado"), Browsable(true)]
        public string TipoABM
        {
            get
            {
                return tipoABM;
            }
            set
            {                
                tipoABM = value;
                this.Text = "ABM " + value;
                lblTituloABM.Text = "La Propiedad TipoABM fue seteada!.";

            }
        }



        // Métodos

        public void ShowABM(Form form)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(form);
            this.panel1.Tag = form;
            form.Show();
        }


        private void tituloABM(string accion)
        {
            lblTituloABM.Text = accion + " " + TipoABM;
        }




        // Eventos

        
      

        private void frmBaseABM_Load(object sender, EventArgs e)
        {
            lblTituloABM.Text = "";
            
            // Tamaño del Form
            this.Width = 687;
            this.Height = 548;

            
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            tituloABM("Alta");
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            tituloABM("Baja");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            tituloABM("Modificar");
        }

        

    

       

        
    }
}


   