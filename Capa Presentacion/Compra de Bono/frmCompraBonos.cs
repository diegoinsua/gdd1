using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.CapaDatos;

namespace Clinica_Frba.CapaPresentacion.Compra_de_Bono
{
    public partial class frmCompraBonos : frmBase
    {

        //--------------
        //  ATRIBUTOS
        // --------------
        Clinica_Frba.CapaDatos.Bono bonoTDG;
        // El usuario tiene el id del plan y del bono


        //--------------
        // CONSTRUCTOR
        //--------------
        public frmCompraBonos()
        {
            InitializeComponent();
         }


        //------------
        // EVENTOS
        //------------

        // LOAD
        private void frmCompraBonos_Load(object sender, EventArgs e)
        {
            if (usuario.rolNombre == "Administrativo") groupBox2.Visible = true;
            
            bonoTDG = new Bono(usuario);

            
            // Seteo los label que informan el valor de los bonos
            lblValorBonoConsulta.Text = bonoTDG.precioBonoConsulta.ToString();
            lblValorBonoFarmacia.Text = bonoTDG.precioBonoFarmacia.ToString();
        }

               

        // NumericUPDown VALUE CHENGED
        private void nudBonosConsulta_ValueChanged(object sender, EventArgs e)
        {
            this.calcularTotal();
        }

        private void nudBonosFarmacia_ValueChanged(object sender, EventArgs e)
        {
            this.calcularTotal();
        }




        //------------
        // EVENTOS
        //------------

        private void calcularTotal()
        {
            decimal total = (bonoTDG.precioBonoConsulta * nudBonosConsulta.Value) 
                           + (bonoTDG.precioBonoFarmacia * nudBonosFarmacia.Value);

            if (total > 0)
            {
                btnComprar.Enabled = true;
                lblTotal.Text = total.ToString();
            }
            else
            {
                btnComprar.Enabled = false;
                lblTotal.Text = "0.00";
            }

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

            if (usuario.rolNombre != "Administrativo")
            {
                validarErrores();
                
                if (!huboErrores) 
                bonoTDG.comprarBonos(nudBonosConsulta.Value, nudBonosFarmacia.Value);
            }
            else
                bonoTDG.comprarBonos(nudBonosConsulta.Value, nudBonosFarmacia.Value);



        }


               

    }
    
}