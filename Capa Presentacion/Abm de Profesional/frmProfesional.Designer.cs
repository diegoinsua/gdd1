﻿namespace Clinica_Frba.CapaDatos.Abm_de_Profesional
{
    partial class frmProfesional
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.lbl_FecNacimiento = new System.Windows.Forms.Label();
            this.mtxFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.lbl_DNI = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lbl_Tel = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ttp
            // 
            this.ttp.AutomaticDelay = 0;
            this.ttp.AutoPopDelay = 100;
            this.ttp.InitialDelay = 50;
            this.ttp.OwnerDraw = true;
            this.ttp.ReshowDelay = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.cmbSexo);
            this.groupBox1.Controls.Add(this.lbl_Sexo);
            this.groupBox1.Controls.Add(this.lbl_FecNacimiento);
            this.groupBox1.Controls.Add(this.mtxFechaNacimiento);
            this.groupBox1.Controls.Add(this.lbl_DNI);
            this.groupBox1.Controls.Add(this.lbl_Apellido);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.lbl_Nombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(36, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(61, 80);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(89, 20);
            this.txtDNI.TabIndex = 12;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexo.Location = new System.Drawing.Point(357, 27);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(53, 21);
            this.cmbSexo.TabIndex = 8;
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.ForeColor = System.Drawing.Color.Black;
            this.lbl_Sexo.Location = new System.Drawing.Point(320, 31);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(31, 13);
            this.lbl_Sexo.TabIndex = 3;
            this.lbl_Sexo.Text = "Sexo";
            // 
            // lbl_FecNacimiento
            // 
            this.lbl_FecNacimiento.AutoSize = true;
            this.lbl_FecNacimiento.ForeColor = System.Drawing.Color.Black;
            this.lbl_FecNacimiento.Location = new System.Drawing.Point(225, 86);
            this.lbl_FecNacimiento.Name = "lbl_FecNacimiento";
            this.lbl_FecNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lbl_FecNacimiento.TabIndex = 7;
            this.lbl_FecNacimiento.Text = "Fecha de Nacimiento";
            // 
            // mtxFechaNacimiento
            // 
            this.mtxFechaNacimiento.Location = new System.Drawing.Point(339, 83);
            this.mtxFechaNacimiento.Mask = "00/00/0000";
            this.mtxFechaNacimiento.Name = "mtxFechaNacimiento";
            this.mtxFechaNacimiento.Size = new System.Drawing.Size(71, 20);
            this.mtxFechaNacimiento.TabIndex = 6;
            this.mtxFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_DNI
            // 
            this.lbl_DNI.AutoSize = true;
            this.lbl_DNI.ForeColor = System.Drawing.Color.Black;
            this.lbl_DNI.Location = new System.Drawing.Point(11, 83);
            this.lbl_DNI.Name = "lbl_DNI";
            this.lbl_DNI.Size = new System.Drawing.Size(35, 13);
            this.lbl_DNI.TabIndex = 5;
            this.lbl_DNI.Text = "D.N.I.";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.ForeColor = System.Drawing.Color.Black;
            this.lbl_Apellido.Location = new System.Drawing.Point(11, 57);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_Apellido.TabIndex = 3;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(61, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(209, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Nombre.Location = new System.Drawing.Point(11, 31);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Tag = "";
            this.lbl_Nombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(61, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.lbl_Mail);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Controls.Add(this.lbl_Tel);
            this.groupBox2.Controls.Add(this.lbl_Direccion);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(36, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 127);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Cóntacto";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(64, 80);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(89, 20);
            this.txtTelefono.TabIndex = 13;
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.ForeColor = System.Drawing.Color.Black;
            this.lbl_Mail.Location = new System.Drawing.Point(11, 59);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(38, 13);
            this.lbl_Mail.TabIndex = 9;
            this.lbl_Mail.Text = "E- mail";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(64, 54);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(209, 20);
            this.txtMail.TabIndex = 8;
            // 
            // lbl_Tel
            // 
            this.lbl_Tel.AutoSize = true;
            this.lbl_Tel.ForeColor = System.Drawing.Color.Black;
            this.lbl_Tel.Location = new System.Drawing.Point(11, 83);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(49, 13);
            this.lbl_Tel.TabIndex = 7;
            this.lbl_Tel.Text = "Teléfono";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.ForeColor = System.Drawing.Color.Black;
            this.lbl_Direccion.Location = new System.Drawing.Point(11, 31);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(52, 13);
            this.lbl_Direccion.TabIndex = 5;
            this.lbl_Direccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(64, 28);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(209, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbEspecialidad);
            this.groupBox3.Controls.Add(this.txtMatricula);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox3.Location = new System.Drawing.Point(36, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 88);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Profesionales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Matricula Nº";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(84, 27);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(139, 21);
            this.cmbEspecialidad.TabIndex = 9;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(84, 54);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(139, 20);
            this.txtMatricula.TabIndex = 8;
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatriculaNumero_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Especialidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Matrícula Nº";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(394, 447);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(36, 447);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Location = new System.Drawing.Point(35, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(41, 13);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Título";
            // 
            // frmProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 502);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProfesional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta Profesional";
            this.Load += new System.EventHandler(this.frmProfesional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Sexo;
        private System.Windows.Forms.Label lbl_FecNacimiento;
        private System.Windows.Forms.Label lbl_DNI;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.Label lbl_Tel;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbSexo;
        public System.Windows.Forms.MaskedTextBox mtxFechaNacimiento;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtMail;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.ComboBox cmbEspecialidad;
        public System.Windows.Forms.TextBox txtMatricula;
        public System.Windows.Forms.TextBox txtDNI;
        public System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTitulo;


    }
}