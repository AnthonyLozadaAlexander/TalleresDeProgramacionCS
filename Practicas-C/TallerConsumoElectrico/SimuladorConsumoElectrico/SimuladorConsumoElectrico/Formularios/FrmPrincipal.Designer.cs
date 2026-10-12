namespace SimuladorConsumoElectrico {
    partial class FrmPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvDatosMedidor = new System.Windows.Forms.GroupBox();
            this.dvgFactura = new System.Windows.Forms.DataGridView();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTitular = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.gvDatosMedidor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(434, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SIMULADOR DE CONSUMO ELECTRICO";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(849, 2);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // gvDatosMedidor
            // 
            this.gvDatosMedidor.Controls.Add(this.txtConsumo);
            this.gvDatosMedidor.Controls.Add(this.txtTitular);
            this.gvDatosMedidor.Controls.Add(this.label2);
            this.gvDatosMedidor.Controls.Add(this.lblTitular);
            this.gvDatosMedidor.Controls.Add(this.btnCalcular);
            this.gvDatosMedidor.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDatosMedidor.Location = new System.Drawing.Point(17, 125);
            this.gvDatosMedidor.Name = "gvDatosMedidor";
            this.gvDatosMedidor.Size = new System.Drawing.Size(846, 219);
            this.gvDatosMedidor.TabIndex = 2;
            this.gvDatosMedidor.TabStop = false;
            this.gvDatosMedidor.Text = "Datos Del Medidor:";
            // 
            // dvgFactura
            // 
            this.dvgFactura.BackgroundColor = System.Drawing.Color.White;
            this.dvgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFactura.Location = new System.Drawing.Point(18, 378);
            this.dvgFactura.Name = "dvgFactura";
            this.dvgFactura.RowHeadersWidth = 47;
            this.dvgFactura.Size = new System.Drawing.Size(845, 389);
            this.dvgFactura.TabIndex = 3;
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(893, 80);
            this.txtFactura.Multiline = true;
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(324, 687);
            this.txtFactura.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(19, 164);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(285, 32);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "[ PROCESAR FACTURA ]";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(39, 55);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(175, 24);
            this.lblTitular.TabIndex = 1;
            this.lblTitular.Text = "Titular Cuenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consumo Mes (Kwh):";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(220, 55);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(169, 28);
            this.txtTitular.TabIndex = 3;
            this.txtTitular.TextChanged += new System.EventHandler(this.txtTitular_TextChanged);
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(220, 93);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(169, 28);
            this.txtConsumo.TabIndex = 4;
            this.txtConsumo.TextChanged += new System.EventHandler(this.txtConsumo_TextChanged);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1229, 779);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.dvgFactura);
            this.Controls.Add(this.gvDatosMedidor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmPrincipal";
            this.Text = "Simulator CE";
            this.gvDatosMedidor.ResumeLayout(false);
            this.gvDatosMedidor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gvDatosMedidor;
        private System.Windows.Forms.DataGridView dvgFactura;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtTitular;
    }
}

