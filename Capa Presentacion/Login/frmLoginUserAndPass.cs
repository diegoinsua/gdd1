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
        
        // Constructor
        public frmLoginUserAndPass()
        {
            InitializeComponent();
        }



        // ------------------
        // btnIngresar CLICK
        // ------------------
        private void btnIngresar_Click(object sender, EventArgs e)
        {

            this.validarErrores();


            if (!huboErrores)
            {

                Clinica_Frba.CapaDatos.Login loginTDG = new Clinica_Frba.CapaDatos.Login();
                bool loginValido = loginTDG.validarUsuario(txtUsuario.Text, txtContrasenia.Text);



                if (loginValido)
                {
                     
                    // obtengo el id del usuario y su nombre
                    this.FormLoginContainer.usuario.id = loginTDG.getIdUsuario(txtUsuario.Text);
                    this.FormLoginContainer.usuario.nombre = txtUsuario.Text;

                    // Obtengo los roles del usuario
                    DataTable dtRoles = loginTDG.getRol(FormLoginContainer.usuario.id);



                    if (dtRoles.Rows.Count > 1) // Si el usuario tiene mas de un rol
                    {
                        this.seleccionarRol();
                        
                    }

                    else // Si solo tiene un rol
                    {
                        // Cargo el rol
                        this.FormLoginContainer.usuario.rolID = (int)dtRoles.Rows[0][0];
                        this.FormLoginContainer.usuario.rolNombre = dtRoles.Rows[0][1].ToString();
                        
                        this.lanzarAplicaciones();                     
                    }

                }
                else // Si el usurio o contraseña son incorrectos
                {
                    // Acciones cuando clave de usuario o contraseña incorrecta
                }

            }

            else // Si lleno los textbox usuario y/o contraseña
            {
                // Acciones cuando no completo los textbox
            }
        }


        private void seleccionarRol()
        {
            frmLoginRol formRol = new frmLoginRol();
            formRol.FormLoginContainer = this.FormLoginContainer;

            this.FormLoginContainer.Text = "Rol";
            this.FormLoginContainer.ShowLogin(formRol);
        }


        private void lanzarAplicaciones()
        {
            
            // Creo un formulario Clinica y seteo el usuario logueado
            frmClinica formClinica = new frmClinica();
            formClinica.usuario = FormLoginContainer.usuario;

            // Lo muestro
            formClinica.Show();

            //Cierro el form de login
            this.Close();   

        }

    }
}
