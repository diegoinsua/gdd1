﻿namespace Clinica_Frba.CapaPresentacion.Compra_de_Bono
{
    partial class frmIngresarAfiliado
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAfiliado = new System.Windows.Forms.Label();
            this.btnBuscarAfiliado = new System.Windows.Forms.Button();
            this.lblAfiliadoInexistente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.ttp.SetToolTip(this.textBox1, "Ingrese el número del afiliado el cual desea adquirir bonos.");
            // 
            // lblAfiliado
            // 
            this.lblAfiliado.AutoSize = true;
            this.lblAfiliado.Location = new System.Drawing.Point(53, 74);
            this.lblAfiliado.Name = "lblAfiliado";
            this.lblAfiliado.Size = new System.Drawing.Size(59, 13);
            this.lblAfiliado.TabIndex = 1;
            this.lblAfiliado.Text = "Afiliado Nº:";
            // 
            // btnBuscarAfiliado
            // 
            this.btnBuscarAfiliado.Location = new System.Drawing.Point(195, 133);
            this.btnBuscarAfiliado.Name = "btnBuscarAfiliado";
            this.btnBuscarAfiliado.Size = new System.Drawing.Size(89, 23);
            this.btnBuscarAfiliado.TabIndex = 2;
            this.btnBuscarAfiliado.Text = "Buscar Afiliado";
            this.btnBuscarAfiliado.UseVisualStyleBackColor = true;
            // 
            // lblAfiliadoInexistente
            // 
            this.lblAfiliadoInexistente.AutoSize = true;
            this.lblAfiliadoInexistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfiliadoInexistente.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAfiliadoInexistente.Location = new System.Drawing.Point(23, 97);
            this.lblAfiliadoInexistente.Name = "lblAfiliadoInexistente";
            this.lblAfiliadoInexistente.Size = new System.Drawing.Size(268, 26);
            this.lblAfiliadoInexistente.TabIndex = 3;
            this.lblAfiliadoInexistente.Text = "No se registra a ningún afiliado con el número\r\ningresado.\r\n";
            this.lblAfiliadoInexistente.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "INGRESAR AFILIADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ingrese el número del afiliado que desea comprar bonos.";
            // 
            // frmIngresarAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 161);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAfiliadoInexistente);
            this.Controls.Add(this.btnBuscarAfiliado);
            this.Controls.Add(this.lblAfiliado);
            this.Controls.Add(this.textBox1);
            this.Name = "frmIngresarAfiliado";
            this.Text = "frmIngresarAfiliado";
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAfiliado;
        private System.Windows.Forms.Button btnBuscarAfiliado;
        private System.Windows.Forms.Label lblAfiliadoInexistente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}