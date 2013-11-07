using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.CapaPresentacion.Login
{
    public partial class frmLoginContainer : Form
    {
        
        public frmLoginContainer()
        {
            InitializeComponent();
            frmLoginUserAndPass formLogin = new frmLoginUserAndPass();
            this.Text = "Login";
            formLogin.formPadre = this;
            formLogin.Text = "Login";
            this.ShowLogin(formLogin);
            
        }


        public void ShowLogin(Form form)
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
    }
}
