namespace Clinica_Frba.CapaPresentacion
{
    partial class frmLoginRol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptarRol = new System.Windows.Forms.Button();
            this.btnCerrarRol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(77, 91);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 21);
            this.cmbRol.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rol";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "El usuario ingresado tiene asignado más de un rol. \r\nSeleccione el rol con el cua" +
                "l desea loguearse.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccione un Rol";
            // 
            // btnAceptarRol
            // 
            this.btnAceptarRol.Location = new System.Drawing.Point(184, 140);
            this.btnAceptarRol.Name = "btnAceptarRol";
            this.btnAceptarRol.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarRol.TabIndex = 4;
            this.btnAceptarRol.Text = "Aceptar";
            this.btnAceptarRol.UseVisualStyleBackColor = true;
            this.btnAceptarRol.Click += new System.EventHandler(this.btnAceptarRol_Click);
            // 
            // btnCerrarRol
            // 
            this.btnCerrarRol.Location = new System.Drawing.Point(16, 140);
            this.btnCerrarRol.Name = "btnCerrarRol";
            this.btnCerrarRol.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarRol.TabIndex = 5;
            this.btnCerrarRol.Text = "Cerrar";
            this.btnCerrarRol.UseVisualStyleBackColor = true;
            // 
            // frmLoginRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 183);
            this.Controls.Add(this.btnCerrarRol);
            this.Controls.Add(this.btnAceptarRol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRol);
            this.Name = "frmLoginRol";
            this.Text = "Rol";
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptarRol;
        private System.Windows.Forms.Button btnCerrarRol;
    }
}