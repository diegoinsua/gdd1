namespace Clinica_Frba.CapaPresentacion.Compra_de_Bono
{
    partial class frmCompraBonos
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
            this.gbxCantidad = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudBonosConsulta = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudBonosFarmacia = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalTitulo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblValorBonoFarmacia = new System.Windows.Forms.Label();
            this.lblValorBonoConsulta = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxPrecio = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lklAfiliado = new System.Windows.Forms.LinkLabel();
            this.lblAfiliadoNumero = new System.Windows.Forms.Label();
            this.gbxAfiliado = new System.Windows.Forms.GroupBox();
            this.lblBuscarAfiliado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAfiliadoInexistente = new System.Windows.Forms.Label();
            this.btnBuscarAfiliado = new System.Windows.Forms.Button();
            this.lblAfiliado = new System.Windows.Forms.Label();
            this.txtAfiliado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.gbxCantidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBonosConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBonosFarmacia)).BeginInit();
            this.gbxPrecio.SuspendLayout();
            this.gbxAfiliado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCantidad
            // 
            this.gbxCantidad.Controls.Add(this.label3);
            this.gbxCantidad.Controls.Add(this.nudBonosConsulta);
            this.gbxCantidad.Controls.Add(this.label4);
            this.gbxCantidad.Controls.Add(this.nudBonosFarmacia);
            this.gbxCantidad.Controls.Add(this.lblTotal);
            this.gbxCantidad.Controls.Add(this.lblTotalTitulo);
            this.gbxCantidad.Controls.Add(this.label5);
            this.gbxCantidad.Enabled = false;
            this.gbxCantidad.Location = new System.Drawing.Point(18, 272);
            this.gbxCantidad.Name = "gbxCantidad";
            this.gbxCantidad.Size = new System.Drawing.Size(598, 123);
            this.gbxCantidad.TabIndex = 27;
            this.gbxCantidad.TabStop = false;
            this.gbxCantidad.Text = "Compra de Bonos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Indique la cantidad de bonos que desea comprar.";
            // 
            // nudBonosConsulta
            // 
            this.nudBonosConsulta.Location = new System.Drawing.Point(109, 58);
            this.nudBonosConsulta.Name = "nudBonosConsulta";
            this.nudBonosConsulta.Size = new System.Drawing.Size(43, 20);
            this.nudBonosConsulta.TabIndex = 0;
            this.nudBonosConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudBonosConsulta.ValueChanged += new System.EventHandler(this.nudBonosConsulta_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Bonos Consulta:";
            // 
            // nudBonosFarmacia
            // 
            this.nudBonosFarmacia.Location = new System.Drawing.Point(109, 84);
            this.nudBonosFarmacia.Name = "nudBonosFarmacia";
            this.nudBonosFarmacia.Size = new System.Drawing.Size(43, 20);
            this.nudBonosFarmacia.TabIndex = 20;
            this.nudBonosFarmacia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(510, 86);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 22);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalTitulo
            // 
            this.lblTotalTitulo.AutoSize = true;
            this.lblTotalTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTitulo.Location = new System.Drawing.Point(417, 91);
            this.lblTotalTitulo.Name = "lblTotalTitulo";
            this.lblTotalTitulo.Size = new System.Drawing.Size(87, 13);
            this.lblTotalTitulo.TabIndex = 12;
            this.lblTotalTitulo.Text = "Total a pagar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Bonos Farmacia:";
            // 
            // lblValorBonoFarmacia
            // 
            this.lblValorBonoFarmacia.AutoSize = true;
            this.lblValorBonoFarmacia.Location = new System.Drawing.Point(112, 58);
            this.lblValorBonoFarmacia.Name = "lblValorBonoFarmacia";
            this.lblValorBonoFarmacia.Size = new System.Drawing.Size(109, 13);
            this.lblValorBonoFarmacia.TabIndex = 23;
            this.lblValorBonoFarmacia.Text = "lblValorBonoFarmacia";
            // 
            // lblValorBonoConsulta
            // 
            this.lblValorBonoConsulta.AutoSize = true;
            this.lblValorBonoConsulta.Location = new System.Drawing.Point(112, 32);
            this.lblValorBonoConsulta.Name = "lblValorBonoConsulta";
            this.lblValorBonoConsulta.Size = new System.Drawing.Size(107, 13);
            this.lblValorBonoConsulta.TabIndex = 22;
            this.lblValorBonoConsulta.Text = "lblValorBonoConsulta";
            // 
            // btnComprar
            // 
            this.btnComprar.Enabled = false;
            this.btnComprar.Location = new System.Drawing.Point(541, 427);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 26;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "COMPRA DE BONOS";
            // 
            // gbxPrecio
            // 
            this.gbxPrecio.Controls.Add(this.lblValorBonoFarmacia);
            this.gbxPrecio.Controls.Add(this.label6);
            this.gbxPrecio.Controls.Add(this.label2);
            this.gbxPrecio.Controls.Add(this.lblValorBonoConsulta);
            this.gbxPrecio.Enabled = false;
            this.gbxPrecio.Location = new System.Drawing.Point(18, 159);
            this.gbxPrecio.Name = "gbxPrecio";
            this.gbxPrecio.Size = new System.Drawing.Size(598, 95);
            this.gbxPrecio.TabIndex = 31;
            this.gbxPrecio.TabStop = false;
            this.gbxPrecio.Text = "Precio de los Bonos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Bonos Farmacia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Bonos Consulta:";
            // 
            // lklAfiliado
            // 
            this.lklAfiliado.AutoSize = true;
            this.lklAfiliado.Location = new System.Drawing.Point(552, 42);
            this.lklAfiliado.Name = "lklAfiliado";
            this.lklAfiliado.Size = new System.Drawing.Size(55, 13);
            this.lklAfiliado.TabIndex = 32;
            this.lklAfiliado.TabStop = true;
            this.lklAfiliado.Text = "linkLabel1";
            this.ttp.SetToolTip(this.lklAfiliado, "Haga click para cambiar el afiliado.");
            // 
            // lblAfiliadoNumero
            // 
            this.lblAfiliadoNumero.AutoSize = true;
            this.lblAfiliadoNumero.Location = new System.Drawing.Point(490, 42);
            this.lblAfiliadoNumero.Name = "lblAfiliadoNumero";
            this.lblAfiliadoNumero.Size = new System.Drawing.Size(56, 13);
            this.lblAfiliadoNumero.TabIndex = 33;
            this.lblAfiliadoNumero.Text = "Afiliado Nº";
            // 
            // gbxAfiliado
            // 
            this.gbxAfiliado.Controls.Add(this.lblBuscarAfiliado);
            this.gbxAfiliado.Controls.Add(this.label7);
            this.gbxAfiliado.Controls.Add(this.lblAfiliadoInexistente);
            this.gbxAfiliado.Controls.Add(this.btnBuscarAfiliado);
            this.gbxAfiliado.Controls.Add(this.lblAfiliado);
            this.gbxAfiliado.Controls.Add(this.txtAfiliado);
            this.gbxAfiliado.Location = new System.Drawing.Point(18, 58);
            this.gbxAfiliado.Name = "gbxAfiliado";
            this.gbxAfiliado.Size = new System.Drawing.Size(598, 83);
            this.gbxAfiliado.TabIndex = 34;
            this.gbxAfiliado.TabStop = false;
            this.gbxAfiliado.Text = "Afiliado";
            // 
            // lblBuscarAfiliado
            // 
            this.lblBuscarAfiliado.AutoSize = true;
            this.lblBuscarAfiliado.Location = new System.Drawing.Point(20, 19);
            this.lblBuscarAfiliado.Name = "lblBuscarAfiliado";
            this.lblBuscarAfiliado.Size = new System.Drawing.Size(285, 13);
            this.lblBuscarAfiliado.TabIndex = 31;
            this.lblBuscarAfiliado.Text = "Ingrese el número del afiliado que desea adquirir los bonos.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, -15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ingrese el número del afiliado que desea comprar bonos.";
            // 
            // lblAfiliadoInexistente
            // 
            this.lblAfiliadoInexistente.AutoSize = true;
            this.lblAfiliadoInexistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfiliadoInexistente.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAfiliadoInexistente.Location = new System.Drawing.Point(291, 49);
            this.lblAfiliadoInexistente.Name = "lblAfiliadoInexistente";
            this.lblAfiliadoInexistente.Size = new System.Drawing.Size(294, 13);
            this.lblAfiliadoInexistente.TabIndex = 29;
            this.lblAfiliadoInexistente.Text = "No existe ningún afiliado con el número ingresado.";
            this.lblAfiliadoInexistente.Visible = false;
            // 
            // btnBuscarAfiliado
            // 
            this.btnBuscarAfiliado.Location = new System.Drawing.Point(200, 45);
            this.btnBuscarAfiliado.Name = "btnBuscarAfiliado";
            this.btnBuscarAfiliado.Size = new System.Drawing.Size(71, 23);
            this.btnBuscarAfiliado.TabIndex = 28;
            this.btnBuscarAfiliado.Text = "Buscar";
            this.btnBuscarAfiliado.UseVisualStyleBackColor = true;
            this.btnBuscarAfiliado.Click += new System.EventHandler(this.btnBuscarAfiliado_Click);
            // 
            // lblAfiliado
            // 
            this.lblAfiliado.AutoSize = true;
            this.lblAfiliado.Location = new System.Drawing.Point(20, 50);
            this.lblAfiliado.Name = "lblAfiliado";
            this.lblAfiliado.Size = new System.Drawing.Size(56, 13);
            this.lblAfiliado.TabIndex = 27;
            this.lblAfiliado.Text = "Afiliado Nº";
            // 
            // txtAfiliado
            // 
            this.txtAfiliado.Location = new System.Drawing.Point(85, 47);
            this.txtAfiliado.Name = "txtAfiliado";
            this.txtAfiliado.Size = new System.Drawing.Size(100, 20);
            this.txtAfiliado.TabIndex = 26;
            this.ttp.SetToolTip(this.txtAfiliado, "Ingrese el número del afiliado el cual desea adquirir bonos.");
            this.txtAfiliado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAfiliado_KeyPress);
            // 
            // frmCompraBonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 472);
            this.Controls.Add(this.gbxAfiliado);
            this.Controls.Add(this.lblAfiliadoNumero);
            this.Controls.Add(this.lklAfiliado);
            this.Controls.Add(this.gbxPrecio);
            this.Controls.Add(this.gbxCantidad);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.label1);
            this.Name = "frmCompraBonos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCompraBonos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.gbxCantidad.ResumeLayout(false);
            this.gbxCantidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBonosConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBonosFarmacia)).EndInit();
            this.gbxPrecio.ResumeLayout(false);
            this.gbxPrecio.PerformLayout();
            this.gbxAfiliado.ResumeLayout(false);
            this.gbxAfiliado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCantidad;
        private System.Windows.Forms.Label lblValorBonoFarmacia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValorBonoConsulta;
        private System.Windows.Forms.NumericUpDown nudBonosConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudBonosFarmacia;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lklAfiliado;
        private System.Windows.Forms.Label lblAfiliadoNumero;
        private System.Windows.Forms.GroupBox gbxAfiliado;
        private System.Windows.Forms.Label lblBuscarAfiliado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAfiliadoInexistente;
        private System.Windows.Forms.Button btnBuscarAfiliado;
        private System.Windows.Forms.Label lblAfiliado;
        private System.Windows.Forms.TextBox txtAfiliado;
    }
}