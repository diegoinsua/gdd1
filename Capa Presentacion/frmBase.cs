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
    public partial class frmBase : Form
    {


        // Atributos
        protected ErrorProvider erp;
        protected bool huboErrores = false;


        // Constructor
        public frmBase()
        {
            InitializeComponent();
            erp = new ErrorProvider();
            erp.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }
               


        // Métodos de Válidación

        protected void validarErrores() {
            huboErrores = false;
            validarControlesNulos(this);            
        }

        

        protected void validarMail(Control email)
        {
            string mail = email.Text;

            if (mail.Contains("@") && (mail.Contains(".com") || mail.Contains(".net") ||
                                         mail.Contains(".edu") || mail.Contains(".gov") ||
                                         mail.Contains(".gob")))
            {
                erp.SetError(email, String.Empty);
                return;
            }

            if (mail.Length != 0)
            {
                erp.SetError(email, "La dirección de E-Mail que ingresó no es válida");
                huboErrores = true;

            }
        }



        protected bool esNulo(Control control)
        {
            if (control.Text == string.Empty)
            {
                return true;
            }

            return true;

        }



        protected bool validarFecha(Control fecha)
        {
            DateTime fechaOut;
            if (DateTime.TryParse(fecha.Text, out fechaOut))
            {
                erp.SetError(fecha, String.Empty);
                return true;
            }
            
            erp.SetError(fecha, "La fecha ingresada no es válida");
            huboErrores = true;
            return false;
        }



        protected void validarFecha(Control fecha, DateTime fechaMinima)
        {
            if (validarFecha(fecha))
            {
                DateTime fechaOut;
                DateTime.TryParse(fecha.Text, out fechaOut);

                if (fechaOut < fechaMinima)
                {
                    erp.SetError(fecha, "Debe ser una fecha posterior al día " + fechaMinima);
                    huboErrores = true;
                    return;
                }

                erp.SetError(fecha, String.Empty);
            }
        }



        
        private void validarControlesNulos(Control c)
        {

            foreach (Control ctrl in c.Controls)
            {
                if (ctrl is TextBox || ctrl is MaskedTextBox) { 
                    if (ctrl.Text.Trim() == String.Empty) 
                    {
                        erp.SetError(ctrl, "Debe ingresar un valor.");
                        huboErrores = true;
                    }
                    else
                    {
                        erp.SetError(ctrl, String.Empty);
                    }
                }

                if (ctrl is ComboBox || ctrl is CheckBox || ctrl is RadioButton)
                { 
                    if (ctrl.Text.Trim() == String.Empty) 
                    {
                        erp.SetError(ctrl, "Debe seleccionar un valor.");
                        huboErrores = true;
                    }
                    else
                    {
                        erp.SetError(ctrl, String.Empty);
                    }
                }

                

                // Si es un contenedor
                validarControlesNulos(ctrl);

            }                      

        }



        protected void validarPersonalizado(Control control, string mensajeError)
        {            
            erp.SetError(control, mensajeError);

            if (mensajeError != String.Empty)
            {
                huboErrores = true;
            }           

        }



        // Limpiar
        protected void limpiarControles()
        {
            limpiarControles(this);
        }


        private void limpiarControles(Control c)
        {

            foreach (Control ctrl in c.Controls)
            {
                if (ctrl is TextBox) { ((TextBox)ctrl).Clear(); }

                if (ctrl is MaskedTextBox) { ((MaskedTextBox)ctrl).Clear(); }

                if (ctrl is CheckBox) { ((CheckBox)ctrl).Checked = false; }

                if (ctrl is RadioButton) { ((RadioButton)ctrl).Checked = false; }

                if (ctrl is ComboBox) { ((ComboBox)ctrl).SelectedIndex = -1; }


                // Si es un contenedor
                if (ctrl.Controls.Count > 0)
                {
                    limpiarControles(ctrl);
                }
            }
        }

    }
}