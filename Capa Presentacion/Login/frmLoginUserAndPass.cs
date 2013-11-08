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

                Clinica_frba.CapaDatos.LoginTDG loginTDG = new Clinica_frba.CapaDatos.LoginTDG();

                bool loginValido = loginTDG.validarUsuario(txtUsuario.Text, txtContrasenia.Text);



                if (loginValido)
                {
                     
                    // obtengo el id del usuario y su nombre
                    FormLoginContainer.usuario.id = loginTDG.getIdUsuario(txtUsuario.Text);
                    FormLoginContainer.usuario.nombre = txtUsuario.Text;

                    // Obtengo los roles del usuario
                    DataTable dtRoles = loginTDG.getRol(FormLoginContainer.usuario.id);



                    if (dtRoles.Rows.Count > 1) // Si el usuario tiene mas de un rol
                    {
                        // Muestro la ventana para seleccionar el rol
                        frmLoginRol formRol = new frmLoginRol();
                        formRol.FormLoginContainer = this.FormLoginContainer;

                        FormLoginContainer.Text = "Rol";
                        FormLoginContainer.ShowLogin(formRol);
                    }

                    else
                    {                       
                        // Cargo el rol
                        FormLoginContainer.usuario.rolID = (int)dtRoles.Rows[0][0];
                        FormLoginContainer.usuario.rolNombre = dtRoles.Rows[0][1].ToString();
                        
                        // Creo un formulario Clinica y seteo el usuario logueado
                        frmClinica formClinica = new frmClinica();
                        formClinica.usuario = FormLoginContainer.usuario;
                        
                        // Lo muestro
                        formClinica.Show();

                        //Cierro el form de login
                        this.Close();                        
                    }

                }
                else
                {
                    // Acciones cuando clave de usuario o contraseña incorrecta
                }

            }

            else
            {
                // Acciones cuando no completo los textbox
            }
        }
    }
}
