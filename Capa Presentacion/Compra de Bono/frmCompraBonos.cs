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
        Clinica_Frba.CapaDatos.BonoTDG bonoTDG;
        // El usuario tiene el id del plan y del bono



        //--------------
        // CONSTRUCTOR
        //--------------
        public frmCompraBonos()
        {
            InitializeComponent();
         }



        // -----------------
        //  LOAD
        // -----------------
        private void frmCompraBonos_Load(object sender, EventArgs e)
        {
            if (usuario.rol == "Afiliado")
            {
                gbxAfiliado.Visible = false;
                gbxPrecio.Enabled = true;
                gbxCantidad.Enabled = true;

                gbxPrecio.Location = new Point(18, 58);
                gbxCantidad.Location = new Point(18, 159);

                this.mostrarPrecios();

                // Si es un afiliado el que comprará el bono ya puedo crear el objeto Bono.
                bonoTDG = new BonoTDG(usuario);
            }

                        
            // Seteo los label que informan el valor de los bonos
            lblValorBonoConsulta.Text = bonoTDG.precioBonoConsulta.ToString();
            lblValorBonoFarmacia.Text = bonoTDG.precioBonoFarmacia.ToString();
        }




        // -----------------
        // MOSTRAR PRECIOS
        // -----------------
        private void mostrarPrecios()
        {
            lblValorBonoConsulta.Text = bonoTDG.precioBonoConsulta.ToString();
            lblValorBonoFarmacia.Text = bonoTDG.precioBonoFarmacia.ToString();
        }





        // ----------------------------
        // NumericUPDown VALUE CHENGED
        // ----------------------------
        private void nudBonosConsulta_ValueChanged(object sender, EventArgs e)
        {
            this.calcularTotal();
        }

        private void nudBonosFarmacia_ValueChanged(object sender, EventArgs e)
        {
            this.calcularTotal();
        }




        //-----------------
        // CALCULAR TOTAL
        //-----------------

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




        // -----------------
        //  COMPRAR CLICK
        // -----------------
        private void btnComprar_Click(object sender, EventArgs e)
        {

            if (usuario.rol != "Administrativo")
            {
                validarErrores();
                
                if (!huboErrores) 
                bonoTDG.comprarBonos(nudBonosConsulta.Value, nudBonosFarmacia.Value);
            }
            else
                bonoTDG.comprarBonos(nudBonosConsulta.Value, nudBonosFarmacia.Value);

        }

        private void btnBuscarAfiliado_Click(object sender, EventArgs e)
        {
           AfiliadoTDG afiTDG = new AfiliadoTDG();
           int afiliado = Int32.Parse(txtAfiliado.Text);

            // Si el afiliado existe muestro el precio de los bonos
           if (afiTDG.setAfiliadoByNro(afiliado) > 0)
           {
               if (esAfiliadoActivo(afiTDG.dni))
               {
                   bonoTDG.setPrecios(afiTDG.plan);
                   this.mostrarPrecios();
               }
               else
               {
                   lblAfiliadoInexistente.Text = "El afiliado ingresado no se encuentra habilitado.";
                   lblAfiliadoInexistente.Visible = true;
               }

               
               // Oculto la leyenda de que no existe el usuario.
               lblAfiliadoInexistente.Visible = false;
           }
           else
               lblAfiliadoInexistente.Visible = true;



        }

        private bool esAfiliadoActivo(int dni)
        {
            Usuario user = new Usuario();

            user.setUsuarioByDNI(dni);

            if (user.existe) return true;
            else return false;
        }

        private void txtAfiliado_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtAfiliado.soloNumeros(erp,e);

        }

      

               

    }
    
}