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
    public partial class frmLoginUserAndPass : frmBase
    {
        // Propiedades
        public CapaPresentacion.Login.frmLoginContainer formPadre { get; set; }

        public frmLoginUserAndPass()
        {
            InitializeComponent();
        }




        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.validarErrores();



            if (!huboErrores)
            {

                Clinica_frba.CapaDatos.LoginTDG loginTDG = new Clinica_frba.CapaDatos.LoginTDG();

                bool loginValido = loginTDG.validarUsuario(txtUsuario.Text, txtContrasenia.Text);
                int usuarioID;
                DataTable rol;



                if (loginValido)
                {
                    // Válido usuario y contraseña
                    usuarioID = loginTDG.getIdUsuario(txtUsuario.Text);
                    rol = loginTDG.getRol(usuarioID);


                    if (rol.Rows.Count > 1) // Si el usuario tiene mas de un rol
                    {
                        // Muestro la ventana para seleccionar el rol
                        frmLoginRol formRol = new frmLoginRol();
                        formPadre.Text = "Rol";
                        formPadre.ShowLogin(formRol);
                    }
                    else
                    {
                        // Abro el programa, pues tiene solo un rol
                    }

                }
                else
                {
                    // Acciones clave de usuario o contraseña incorrecta
                }

            }

            else
            {
                // Acciones cuando hay errores
            }
        }
    }
}
