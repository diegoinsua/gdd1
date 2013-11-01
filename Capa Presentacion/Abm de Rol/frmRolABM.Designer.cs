namespace Clinica_Frba.CapaPresentacion.Abm_de_Rol
{
    partial class frmRolABM
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            this.btnModificar.Enter += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            this.btnBaja.Enter += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            this.btnAlta.Enter += new System.EventHandler(this.btnAlta_Click);
            // 
            // frmRolABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(671, 510);
            this.Name = "frmRolABM";
            this.Text = "ABM Rol";
            this.TipoABM = "Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
