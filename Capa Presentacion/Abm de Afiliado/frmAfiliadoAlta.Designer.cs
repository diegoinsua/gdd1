namespace Clinica_Frba.CapaPresentacion.Abm_de_Afiliado
{
    partial class frmAfiliadoAlta
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
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.lbl_FecNacimiento = new System.Windows.Forms.Label();
            this.mtxFecNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.lbl_DNI = new System.Windows.Forms.Label();
            this.mtxDNI = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lbl_Tel = new System.Windows.Forms.Label();
            this.mtxTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_aCargo = new System.Windows.Forms.Label();
            this.mtxaCargo = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Hijos = new System.Windows.Forms.Label();
            this.mtxHijos = new System.Windows.Forms.MaskedTextBox();
            this.cmbEstCivil = new System.Windows.Forms.ComboBox();
            this.lbl_EstadoCivil = new System.Windows.Forms.Label();
            this.lbl_PlanMedico = new System.Windows.Forms.Label();
            this.mtxPlan = new System.Windows.Forms.MaskedTextBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSexo);
            this.groupBox1.Controls.Add(this.lbl_Sexo);
            this.groupBox1.Controls.Add(this.lbl_FecNacimiento);
            this.groupBox1.Controls.Add(this.mtxFecNacimiento);
            this.groupBox1.Controls.Add(this.lbl_DNI);
            this.groupBox1.Controls.Add(this.mtxDNI);
            this.groupBox1.Controls.Add(this.lbl_Apellido);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.lbl_Nombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexo.Location = new System.Drawing.Point(369, 8);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(53, 21);
            this.cmbSexo.TabIndex = 8;
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.Location = new System.Drawing.Point(332, 16);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(31, 13);
            this.lbl_Sexo.TabIndex = 3;
            this.lbl_Sexo.Text = "Sexo";
            // 
            // lbl_FecNacimiento
            // 
            this.lbl_FecNacimiento.AutoSize = true;
            this.lbl_FecNacimiento.Location = new System.Drawing.Point(11, 98);
            this.lbl_FecNacimiento.Name = "lbl_FecNacimiento";
            this.lbl_FecNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lbl_FecNacimiento.TabIndex = 7;
            this.lbl_FecNacimiento.Text = "Fecha de Nacimiento";
            // 
            // mtxFecNacimiento
            // 
            this.mtxFecNacimiento.Location = new System.Drawing.Point(125, 91);
            this.mtxFecNacimiento.Mask = "00/00/0000";
            this.mtxFecNacimiento.Name = "mtxFecNacimiento";
            this.mtxFecNacimiento.Size = new System.Drawing.Size(110, 20);
            this.mtxFecNacimiento.TabIndex = 6;
            this.mtxFecNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_DNI
            // 
            this.lbl_DNI.AutoSize = true;
            this.lbl_DNI.Location = new System.Drawing.Point(11, 72);
            this.lbl_DNI.Name = "lbl_DNI";
            this.lbl_DNI.Size = new System.Drawing.Size(35, 13);
            this.lbl_DNI.TabIndex = 5;
            this.lbl_DNI.Text = "D.N.I.";
            // 
            // mtxDNI
            // 
            this.mtxDNI.Location = new System.Drawing.Point(61, 65);
            this.mtxDNI.Mask = "99999999";
            this.mtxDNI.Name = "mtxDNI";
            this.mtxDNI.Size = new System.Drawing.Size(110, 20);
            this.mtxDNI.TabIndex = 4;
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(11, 46);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_Apellido.TabIndex = 3;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(61, 39);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(209, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(11, 16);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Tag = "";
            this.lbl_Nombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(61, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Mail);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Controls.Add(this.lbl_Tel);
            this.groupBox2.Controls.Add(this.mtxTelefono);
            this.groupBox2.Controls.Add(this.lbl_Direccion);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Location = new System.Drawing.Point(9, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Location = new System.Drawing.Point(8, 70);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(38, 13);
            this.lbl_Mail.TabIndex = 9;
            this.lbl_Mail.Text = "E- mail";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(58, 63);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(209, 20);
            this.txtMail.TabIndex = 8;
            // 
            // lbl_Tel
            // 
            this.lbl_Tel.AutoSize = true;
            this.lbl_Tel.Location = new System.Drawing.Point(8, 42);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(49, 13);
            this.lbl_Tel.TabIndex = 7;
            this.lbl_Tel.Text = "Teléfono";
            // 
            // mtxTelefono
            // 
            this.mtxTelefono.Location = new System.Drawing.Point(58, 35);
            this.mtxTelefono.Mask = "999999999999";
            this.mtxTelefono.Name = "mtxTelefono";
            this.mtxTelefono.Size = new System.Drawing.Size(110, 20);
            this.mtxTelefono.TabIndex = 6;
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(8, 16);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(52, 13);
            this.lbl_Direccion.TabIndex = 5;
            this.lbl_Direccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(58, 9);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(209, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_aCargo);
            this.groupBox3.Controls.Add(this.mtxaCargo);
            this.groupBox3.Controls.Add(this.lbl_Hijos);
            this.groupBox3.Controls.Add(this.mtxHijos);
            this.groupBox3.Controls.Add(this.cmbEstCivil);
            this.groupBox3.Controls.Add(this.lbl_EstadoCivil);
            this.groupBox3.Location = new System.Drawing.Point(9, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 65);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // lbl_aCargo
            // 
            this.lbl_aCargo.AutoSize = true;
            this.lbl_aCargo.Location = new System.Drawing.Point(130, 40);
            this.lbl_aCargo.Name = "lbl_aCargo";
            this.lbl_aCargo.Size = new System.Drawing.Size(90, 13);
            this.lbl_aCargo.TabIndex = 14;
            this.lbl_aCargo.Text = "Personas a cargo";
            // 
            // mtxaCargo
            // 
            this.mtxaCargo.Location = new System.Drawing.Point(224, 33);
            this.mtxaCargo.Mask = "99999";
            this.mtxaCargo.Name = "mtxaCargo";
            this.mtxaCargo.Size = new System.Drawing.Size(41, 20);
            this.mtxaCargo.TabIndex = 13;
            this.mtxaCargo.ValidatingType = typeof(int);
            // 
            // lbl_Hijos
            // 
            this.lbl_Hijos.AutoSize = true;
            this.lbl_Hijos.Location = new System.Drawing.Point(6, 44);
            this.lbl_Hijos.Name = "lbl_Hijos";
            this.lbl_Hijos.Size = new System.Drawing.Size(30, 13);
            this.lbl_Hijos.TabIndex = 12;
            this.lbl_Hijos.Text = "Hijos";
            // 
            // mtxHijos
            // 
            this.mtxHijos.Location = new System.Drawing.Point(74, 35);
            this.mtxHijos.Mask = "99999";
            this.mtxHijos.Name = "mtxHijos";
            this.mtxHijos.Size = new System.Drawing.Size(41, 20);
            this.mtxHijos.TabIndex = 11;
            this.mtxHijos.ValidatingType = typeof(int);
            // 
            // cmbEstCivil
            // 
            this.cmbEstCivil.FormattingEnabled = true;
            this.cmbEstCivil.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Viudo/a",
            "Concubinato",
            "Divorciado/a"});
            this.cmbEstCivil.Location = new System.Drawing.Point(74, 8);
            this.cmbEstCivil.Name = "cmbEstCivil";
            this.cmbEstCivil.Size = new System.Drawing.Size(112, 21);
            this.cmbEstCivil.TabIndex = 10;
            // 
            // lbl_EstadoCivil
            // 
            this.lbl_EstadoCivil.AutoSize = true;
            this.lbl_EstadoCivil.Location = new System.Drawing.Point(6, 16);
            this.lbl_EstadoCivil.Name = "lbl_EstadoCivil";
            this.lbl_EstadoCivil.Size = new System.Drawing.Size(62, 13);
            this.lbl_EstadoCivil.TabIndex = 9;
            this.lbl_EstadoCivil.Text = "Estado Civil";
            // 
            // lbl_PlanMedico
            // 
            this.lbl_PlanMedico.AutoSize = true;
            this.lbl_PlanMedico.Location = new System.Drawing.Point(17, 323);
            this.lbl_PlanMedico.Name = "lbl_PlanMedico";
            this.lbl_PlanMedico.Size = new System.Drawing.Size(66, 13);
            this.lbl_PlanMedico.TabIndex = 7;
            this.lbl_PlanMedico.Text = "Plan Médico";
            // 
            // mtxPlan
            // 
            this.mtxPlan.Location = new System.Drawing.Point(83, 316);
            this.mtxPlan.Mask = "99999";
            this.mtxPlan.Name = "mtxPlan";
            this.mtxPlan.Size = new System.Drawing.Size(110, 20);
            this.mtxPlan.TabIndex = 6;
            this.mtxPlan.ValidatingType = typeof(int);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(20, 369);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(63, 23);
            this.btn_Limpiar.TabIndex = 8;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click_1);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(381, 364);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(63, 23);
            this.btn_Guardar.TabIndex = 9;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // frmAfiliadoAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 399);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.lbl_PlanMedico);
            this.Controls.Add(this.mtxPlan);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAfiliadoAlta";
            this.Text = "Alta de Afiliado";
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
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_DNI;
        private System.Windows.Forms.MaskedTextBox mtxDNI;
        private System.Windows.Forms.Label lbl_FecNacimiento;
        private System.Windows.Forms.MaskedTextBox mtxFecNacimiento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Tel;
        private System.Windows.Forms.MaskedTextBox mtxTelefono;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lbl_Sexo;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbEstCivil;
        private System.Windows.Forms.Label lbl_EstadoCivil;
        private System.Windows.Forms.Label lbl_aCargo;
        private System.Windows.Forms.MaskedTextBox mtxaCargo;
        private System.Windows.Forms.Label lbl_Hijos;
        private System.Windows.Forms.MaskedTextBox mtxHijos;
        private System.Windows.Forms.Label lbl_PlanMedico;
        private System.Windows.Forms.MaskedTextBox mtxPlan;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Guardar;
        public System.Windows.Forms.TextBox txtApellido;
    }
}