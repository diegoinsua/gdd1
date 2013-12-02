namespace Clinica_Frba.CapaDatos.Compra_de_Bono
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblValorBonoFarmacia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValorBonoConsulta = new System.Windows.Forms.Label();
            this.nudBonosConsulta = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudBonosFarmacia = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalTitulo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAfiliadoNumero = new System.Windows.Forms.Label();
            this.txtAfiliadoID = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBonosConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBonosFarmacia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblValorBonoFarmacia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblValorBonoConsulta);
            this.groupBox1.Controls.Add(this.nudBonosConsulta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudBonosFarmacia);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblTotalTitulo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 192);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // lblValorBonoFarmacia
            // 
            this.lblValorBonoFarmacia.AutoSize = true;
            this.lblValorBonoFarmacia.Location = new System.Drawing.Point(186, 93);
            this.lblValorBonoFarmacia.Name = "lblValorBonoFarmacia";
            this.lblValorBonoFarmacia.Size = new System.Drawing.Size(109, 13);
            this.lblValorBonoFarmacia.TabIndex = 23;
            this.lblValorBonoFarmacia.Text = "lblValorBonoFarmacia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Indique la cantidad de bonos que desea comprar.";
            // 
            // lblValorBonoConsulta
            // 
            this.lblValorBonoConsulta.AutoSize = true;
            this.lblValorBonoConsulta.Location = new System.Drawing.Point(186, 67);
            this.lblValorBonoConsulta.Name = "lblValorBonoConsulta";
            this.lblValorBonoConsulta.Size = new System.Drawing.Size(107, 13);
            this.lblValorBonoConsulta.TabIndex = 22;
            this.lblValorBonoConsulta.Text = "lblValorBonoConsulta";
            // 
            // nudBonosConsulta
            // 
            this.nudBonosConsulta.Location = new System.Drawing.Point(116, 65);
            this.nudBonosConsulta.Name = "nudBonosConsulta";
            this.nudBonosConsulta.Size = new System.Drawing.Size(43, 20);
            this.nudBonosConsulta.TabIndex = 0;
            this.nudBonosConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudBonosConsulta.ValueChanged += new System.EventHandler(this.nudBonosConsulta_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Bonos Consulta:";
            // 
            // nudBonosFarmacia
            // 
            this.nudBonosFarmacia.Location = new System.Drawing.Point(116, 91);
            this.nudBonosFarmacia.Name = "nudBonosFarmacia";
            this.nudBonosFarmacia.Size = new System.Drawing.Size(43, 20);
            this.nudBonosFarmacia.TabIndex = 20;
            this.nudBonosFarmacia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(373, 162);
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
            this.lblTotalTitulo.Location = new System.Drawing.Point(280, 167);
            this.lblTotalTitulo.Name = "lblTotalTitulo";
            this.lblTotalTitulo.Size = new System.Drawing.Size(87, 13);
            this.lblTotalTitulo.TabIndex = 12;
            this.lblTotalTitulo.Text = "Total a pagar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Bonos Farmacia:";
            // 
            // lblAfiliadoNumero
            // 
            this.lblAfiliadoNumero.AutoSize = true;
            this.lblAfiliadoNumero.Location = new System.Drawing.Point(12, 53);
            this.lblAfiliadoNumero.Name = "lblAfiliadoNumero";
            this.lblAfiliadoNumero.Size = new System.Drawing.Size(56, 13);
            this.lblAfiliadoNumero.TabIndex = 25;
            this.lblAfiliadoNumero.Text = "Afiliado N°";
            this.lblAfiliadoNumero.Visible = false;
            // 
            // txtAfiliadoID
            // 
            this.txtAfiliadoID.Location = new System.Drawing.Point(70, 50);
            this.txtAfiliadoID.Name = "txtAfiliadoID";
            this.txtAfiliadoID.Size = new System.Drawing.Size(100, 20);
            this.txtAfiliadoID.TabIndex = 24;
            this.txtAfiliadoID.Visible = false;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(407, 349);
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
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Compra de Bonos";
            // 
            // frmCompraBonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 394);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAfiliadoNumero);
            this.Controls.Add(this.txtAfiliadoID);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.label1);
            this.Name = "frmCompraBonos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCompraBonos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBonosConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBonosFarmacia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblValorBonoFarmacia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValorBonoConsulta;
        private System.Windows.Forms.NumericUpDown nudBonosConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudBonosFarmacia;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAfiliadoNumero;
        private System.Windows.Forms.TextBox txtAfiliadoID;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label label1;
    }
}