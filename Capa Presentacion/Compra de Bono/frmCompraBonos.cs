using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.CapaDatos.Compra_de_Bono
{
    public partial class frmCompraBonos : frmBase
    {

        // ATRIBUTOS
        decimal valorBonoFarmacia;
        decimal valorBonoConsulta;
        Clinica_Frba.CapaDatos.BonoTDG bonoTDG;
        // El usuario tiene el id del plan y del bono


        // CONSTRUCTOR
        public frmCompraBonos()
        {

            InitializeComponent();

         }


        // EVENTO LOAD
        private void frmCompraBonos_Load(object sender, EventArgs e)
        {
            // Obtengo el valor de los bonos
            valorBonoConsulta = bonoTDG.getPrecio(usuario.planID, "consulta");
            valorBonoFarmacia = bonoTDG.getPrecio(usuario.planID, "farmacia");


            // Seteo los label que informan el valor de los bonos
            lblValorBonoConsulta.Text = valorBonoConsulta.ToString();
            lblValorBonoFarmacia.Text = valorBonoFarmacia.ToString();
        }


        

        // EVENTO NumericUPDown VALUE CHENGED
        private void nudBonosConsulta_ValueChanged(object sender, EventArgs e)
        {
            this.calcularTotal();
        }

        private void nudBonosFarmacia_ValueChanged(object sender, EventArgs e)
        {
            this.calcularTotal();
        }




        // METODOS
        private void calcularTotal()
        {
            decimal total = (valorBonoConsulta * nudBonosConsulta.Value) + (valorBonoFarmacia * nudBonosFarmacia.Value);

            if (total > 0) lblTotal.Text = total.ToString();
            else lblTotal.Text = "0.00";

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            bonoTDG.comprarBonos(nudBonosConsulta.Value, nudBonosFarmacia.Value, "consulta", usuario);


        }


               

    }
    
}