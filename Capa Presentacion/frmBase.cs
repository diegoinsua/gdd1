using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.CapaDatos;

namespace Clinica_Frba.CapaPresentacion
{
    public partial class frmBase : Form
    {
        

        // Atributos
        protected ErrorProvider erp;
        protected ToolTip ttp;
        protected bool huboErrores = false;
        public Form formularioPadre = null;
        public Usuario usuario = null;
        protected string tipoABM;

        
        // Propiedades
        public frmClinica FormClinica { get; set; }
        public CapaPresentacion.Login.frmLoginContainer FormLoginContainer { get; set; }
        
        // Constructor
        
        public frmBase()
        {
            InitializeComponent();

            this.ShowInTaskbar = false;

            ttp = new ToolTip();

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
            
            if (  estaDeshabilitado(email) )
            {
                limpiarError(email);
            }

            else 
            {

                string mail = email.Text;

                if (mail.Length == 0)
                {
                    erp.SetError(email, "Debe ingresar una dirección de E-Mail.");
                    huboErrores = true;

                }

                else if (!((mail.Contains("@") && (mail.Contains(".com") || mail.Contains(".net") ||
                                              mail.Contains(".edu") || mail.Contains(".gov") ||
                                              mail.Contains(".gob")))))
                {
                    erp.SetError(email, "La dirección de E-Mail que ingresó no es válida");
                    huboErrores = true;
                }

                
            }

        }


        protected void validarPersonalizado(Control control, string mensajeError)
        {
            if (estaDeshabilitado(control))
            {
                limpiarError(control);
            }
            else
            {
                erp.SetError(control, mensajeError);

                if (mensajeError != String.Empty)
                {
                    huboErrores = true;
                }
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
            
            if ( estaDeshabilitado(fecha) ) {
                limpiarError(fecha);
                return true;
            }

            else
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
        }


        protected void validarFecha(Control fecha, DateTime fechaMinima)
        {
            if (estaDeshabilitado(fecha))
            {
                limpiarError(fecha);
            }
            else
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

        }
        private void limpiarError(Control control)
        {
            erp.SetError(control, string.Empty);
        }

        
       


        private bool estaDeshabilitado(Control c)
        {
            if (c is TextBox && ((TextBox)c).ReadOnly)                 return true;
            if (c is MaskedTextBox && ((MaskedTextBox)c).ReadOnly)     return true;
            if (c is ComboBox && ((ComboBox)c).Enabled == false)       return true;
            if (c is CheckBox && ((CheckBox)c).Enabled == false)       return true;
            if (c is RadioButton && ((RadioButton)c).Enabled == false) return true;
            if (c is DateTimePicker && ((DateTimePicker)c).Enabled == false) return true;

            return false;
        }

        
        private void validarControlNulo(Control c, string mensaje) {
             
            if (c.Text.Trim() == String.Empty) 
                    {
                        erp.SetError(c, mensaje);
                        huboErrores = true;
                    }
                    else
                    {
                        erp.SetError(c, String.Empty);
                    }
        }
        
        
        private void validarControlesNulos(Control c)
        {

            foreach (Control ctrl in c.Controls)
            {

                if (estaDeshabilitado(ctrl))
                {
                   limpiarError(ctrl);
                }

                else
                {

                    if (ctrl is TextBox || ctrl is MaskedTextBox)
                        validarControlNulo(ctrl, "Debe ingresar un valor.");


                    if (ctrl is ComboBox || ctrl is CheckBox || ctrl is RadioButton)
                        validarControlNulo(ctrl, "Debe seleccionar un valor.");


                    // Si es un contenedor
                    if (ctrl.Controls.Count > 0)
                        validarControlesNulos(ctrl);
                    
                }

            }                      

        }
        

        

        // Limpiar Controles
        protected void limpiarControles()
        {
            limpiarControles(this);
        }
        
        private void limpiarControles(Control c)
        {
            // Elimino los mensajes de error que pudieran haber
            if (huboErrores == true) { erp.Clear(); }

            foreach (Control ctrl in c.Controls)
            {
                if (ctrl is TextBox) { ((TextBox)ctrl).Clear(); }

                if (ctrl is MaskedTextBox) { ((MaskedTextBox)ctrl).Clear(); }

                if (ctrl is CheckBox) { ((CheckBox)ctrl).Checked = false; }

                if (ctrl is RadioButton) { ((RadioButton)ctrl).Checked = false; }

                if (ctrl is ComboBox) { ((ComboBox)ctrl).SelectedIndex = -1; }

                if (ctrl is DateTimePicker) { ((DateTimePicker)ctrl).limpiar(); }


                // Si es un contenedor
                if (ctrl.Controls.Count > 0)
                {
                    limpiarControles(ctrl);
                }
            }
        }


        // Habilitar Controles
        public void habilitarControles()
        {
            habilitarControles(this);
        }

        private void habilitarControles(Control c)
        {
            // Elimino los mensajes de error que pudieran haber
            if (huboErrores == true) { erp.Clear(); }

            foreach (Control ctrl in c.Controls)
            {
                if (ctrl is TextBox) { ((TextBox)ctrl).ReadOnly = false; }

                if (ctrl is MaskedTextBox) { ((MaskedTextBox)ctrl).ReadOnly = false; }

                if (ctrl is CheckBox) { ((CheckBox)ctrl).Enabled = true; }

                if (ctrl is RadioButton) { ((RadioButton)ctrl).Enabled = true; }

                if (ctrl is ComboBox) { ((ComboBox)ctrl).Enabled = true; }


                // Si es un contenedor
                if (ctrl.Controls.Count > 0)
                {
                    habilitarControles(ctrl);
                }
            }
        }

    }
}