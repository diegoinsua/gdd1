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
            this.cmb_Sexo = new System.Windows.Forms.ComboBox();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.lbl_FecNacimiento = new System.Windows.Forms.Label();
            this.mtx_FecNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.lbl_DNI = new System.Windows.Forms.Label();
            this.mtx_DNI = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.lbl_Tel = new System.Windows.Forms.Label();
            this.mtx_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_aCargo = new System.Windows.Forms.Label();
            this.mtx_aCargo = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Hijos = new System.Windows.Forms.Label();
            this.mtx_Hijos = new System.Windows.Forms.MaskedTextBox();
            this.cmb_EstCivil = new System.Windows.Forms.ComboBox();
            this.lbl_EstadoCivil = new System.Windows.Forms.Label();
            this.lbl_PlanMedico = new System.Windows.Forms.Label();
            this.mtx_Plan = new System.Windows.Forms.MaskedTextBox();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_Sexo);
            this.groupBox1.Controls.Add(this.lbl_Sexo);
            this.groupBox1.Controls.Add(this.lbl_FecNacimiento);
            this.groupBox1.Controls.Add(this.mtx_FecNacimiento);
            this.groupBox1.Controls.Add(this.lbl_DNI);
            this.groupBox1.Controls.Add(this.mtx_DNI);
            this.groupBox1.Controls.Add(this.lbl_Apellido);
            this.groupBox1.Controls.Add(this.txt_Apellido);
            this.groupBox1.Controls.Add(this.lbl_Nombre);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmb_Sexo
            // 
            this.cmb_Sexo.FormattingEnabled = true;
            this.cmb_Sexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmb_Sexo.Location = new System.Drawing.Point(369, 8);
            this.cmb_Sexo.Name = "cmb_Sexo";
            this.cmb_Sexo.Size = new System.Drawing.Size(53, 21);
            this.cmb_Sexo.TabIndex = 8;
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
            // mtx_FecNacimiento
            // 
            this.mtx_FecNacimiento.Location = new System.Drawing.Point(125, 91);
            this.mtx_FecNacimiento.Mask = "00/00/0000";
            this.mtx_FecNacimiento.Name = "mtx_FecNacimiento";
            this.mtx_FecNacimiento.Size = new System.Drawing.Size(110, 20);
            this.mtx_FecNacimiento.TabIndex = 6;
            this.mtx_FecNacimiento.ValidatingType = typeof(System.DateTime);
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
            // mtx_DNI
            // 
            this.mtx_DNI.Location = new System.Drawing.Point(61, 65);
            this.mtx_DNI.Mask = "99999";
            this.mtx_DNI.Name = "mtx_DNI";
            this.mtx_DNI.Size = new System.Drawing.Size(110, 20);
            this.mtx_DNI.TabIndex = 4;
            this.mtx_DNI.ValidatingType = typeof(int);
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
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(61, 39);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(209, 20);
            this.txt_Apellido.TabIndex = 2;
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
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(61, 9);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(209, 20);
            this.txt_Nombre.TabIndex = 0;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Mail);
            this.groupBox2.Controls.Add(this.txt_Mail);
            this.groupBox2.Controls.Add(this.lbl_Tel);
            this.groupBox2.Controls.Add(this.mtx_Telefono);
            this.groupBox2.Controls.Add(this.lbl_Direccion);
            this.groupBox2.Controls.Add(this.txt_Direccion);
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
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(58, 63);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(209, 20);
            this.txt_Mail.TabIndex = 8;
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
            // mtx_Telefono
            // 
            this.mtx_Telefono.Location = new System.Drawing.Point(58, 35);
            this.mtx_Telefono.Mask = "99999";
            this.mtx_Telefono.Name = "mtx_Telefono";
            this.mtx_Telefono.Size = new System.Drawing.Size(110, 20);
            this.mtx_Telefono.TabIndex = 6;
            this.mtx_Telefono.ValidatingType = typeof(int);
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
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(58, 9);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(209, 20);
            this.txt_Direccion.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_aCargo);
            this.groupBox3.Controls.Add(this.mtx_aCargo);
            this.groupBox3.Controls.Add(this.lbl_Hijos);
            this.groupBox3.Controls.Add(this.mtx_Hijos);
            this.groupBox3.Controls.Add(this.cmb_EstCivil);
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
            // mtx_aCargo
            // 
            this.mtx_aCargo.Location = new System.Drawing.Point(224, 33);
            this.mtx_aCargo.Mask = "99999";
            this.mtx_aCargo.Name = "mtx_aCargo";
            this.mtx_aCargo.Size = new System.Drawing.Size(41, 20);
            this.mtx_aCargo.TabIndex = 13;
            this.mtx_aCargo.ValidatingType = typeof(int);
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
            // mtx_Hijos
            // 
            this.mtx_Hijos.Location = new System.Drawing.Point(74, 35);
            this.mtx_Hijos.Mask = "99999";
            this.mtx_Hijos.Name = "mtx_Hijos";
            this.mtx_Hijos.Size = new System.Drawing.Size(41, 20);
            this.mtx_Hijos.TabIndex = 11;
            this.mtx_Hijos.ValidatingType = typeof(int);
            // 
            // cmb_EstCivil
            // 
            this.cmb_EstCivil.FormattingEnabled = true;
            this.cmb_EstCivil.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Viudo/a",
            "Concubinato",
            "Divorciado/a"});
            this.cmb_EstCivil.Location = new System.Drawing.Point(74, 8);
            this.cmb_EstCivil.Name = "cmb_EstCivil";
            this.cmb_EstCivil.Size = new System.Drawing.Size(112, 21);
            this.cmb_EstCivil.TabIndex = 10;
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
            // mtx_Plan
            // 
            this.mtx_Plan.Location = new System.Drawing.Point(83, 316);
            this.mtx_Plan.Mask = "99999";
            this.mtx_Plan.Name = "mtx_Plan";
            this.mtx_Plan.Size = new System.Drawing.Size(110, 20);
            this.mtx_Plan.TabIndex = 6;
            this.mtx_Plan.ValidatingType = typeof(int);
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
            this.Controls.Add(this.mtx_Plan);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAfiliadoAlta";
            this.Text = "Alta de Afiliado";
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
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_DNI;
        private System.Windows.Forms.MaskedTextBox mtx_DNI;
        private System.Windows.Forms.Label lbl_FecNacimiento;
        private System.Windows.Forms.MaskedTextBox mtx_FecNacimiento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Tel;
        private System.Windows.Forms.MaskedTextBox mtx_Telefono;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.ComboBox cmb_Sexo;
        private System.Windows.Forms.Label lbl_Sexo;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_EstCivil;
        private System.Windows.Forms.Label lbl_EstadoCivil;
        private System.Windows.Forms.Label lbl_aCargo;
        private System.Windows.Forms.MaskedTextBox mtx_aCargo;
        private System.Windows.Forms.Label lbl_Hijos;
        private System.Windows.Forms.MaskedTextBox mtx_Hijos;
        private System.Windows.Forms.Label lbl_PlanMedico;
        private System.Windows.Forms.MaskedTextBox mtx_Plan;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Guardar;
    }
}