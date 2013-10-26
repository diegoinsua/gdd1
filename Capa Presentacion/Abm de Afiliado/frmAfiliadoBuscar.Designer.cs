namespace Clinica_Frba.CapaPresentacion.Abm_de_Afiliado
{
    partial class frmAfiliadoBuscar
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.mtx_DNI = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtx_NroAfiliado = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgv_Afiliado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Afiliado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Apellido);
            this.groupBox1.Controls.Add(this.mtx_DNI);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mtx_NroAfiliado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios de Búsqueda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apellido";
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(108, 58);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(209, 20);
            this.txt_Apellido.TabIndex = 9;
            // 
            // mtx_DNI
            // 
            this.mtx_DNI.Location = new System.Drawing.Point(359, 24);
            this.mtx_DNI.Mask = "99999";
            this.mtx_DNI.Name = "mtx_DNI";
            this.mtx_DNI.Size = new System.Drawing.Size(119, 20);
            this.mtx_DNI.TabIndex = 6;
            this.mtx_DNI.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Tag = "";
            this.label2.Text = "D.N.I.";
            // 
            // mtx_NroAfiliado
            // 
            this.mtx_NroAfiliado.Location = new System.Drawing.Point(108, 24);
            this.mtx_NroAfiliado.Mask = "99999";
            this.mtx_NroAfiliado.Name = "mtx_NroAfiliado";
            this.mtx_NroAfiliado.Size = new System.Drawing.Size(119, 20);
            this.mtx_NroAfiliado.TabIndex = 4;
            this.mtx_NroAfiliado.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Tag = "";
            this.label1.Text = "Número de Afiliado";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(12, 142);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(69, 26);
            this.btn_limpiar.TabIndex = 1;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(435, 142);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(69, 26);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dgv_Afiliado
            // 
            this.dgv_Afiliado.AllowUserToAddRows = false;
            this.dgv_Afiliado.AllowUserToDeleteRows = false;
            this.dgv_Afiliado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Afiliado.Location = new System.Drawing.Point(11, 191);
            this.dgv_Afiliado.Name = "dgv_Afiliado";
            this.dgv_Afiliado.ReadOnly = true;
            this.dgv_Afiliado.Size = new System.Drawing.Size(649, 259);
            this.dgv_Afiliado.TabIndex = 3;
            // 
            // frmAfiliadoBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 473);
            this.Controls.Add(this.dgv_Afiliado);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAfiliadoBuscar";
            this.Text = "Afiliado";
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Afiliado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtx_NroAfiliado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtx_DNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_buscar;
        public System.Windows.Forms.DataGridView dgv_Afiliado;

    }
}