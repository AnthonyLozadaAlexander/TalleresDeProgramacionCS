namespace Pokemon_POO.Formularios {
    partial class FrmDuelo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDuelo));
            this.gpHistorial = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPokemon1 = new System.Windows.Forms.ComboBox();
            this.cboPokemon2 = new System.Windows.Forms.ComboBox();
            this.txtHP1 = new System.Windows.Forms.TextBox();
            this.txtHP2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbSeleccionar = new System.Windows.Forms.GroupBox();
            this.txtHistorial = new System.Windows.Forms.TextBox();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.btnReiniciarHP = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.gpHistorial.SuspendLayout();
            this.gbSeleccionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpHistorial
            // 
            this.gpHistorial.BackColor = System.Drawing.Color.Transparent;
            this.gpHistorial.Controls.Add(this.txtHistorial);
            this.gpHistorial.Font = new System.Drawing.Font("Montserrat SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpHistorial.Location = new System.Drawing.Point(38, 369);
            this.gpHistorial.Name = "gpHistorial";
            this.gpHistorial.Size = new System.Drawing.Size(839, 377);
            this.gpHistorial.TabIndex = 21;
            this.gpHistorial.TabStop = false;
            this.gpHistorial.Text = "[ Historial ]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 33);
            this.label2.TabIndex = 19;
            this.label2.Text = "P1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 33);
            this.label3.TabIndex = 20;
            this.label3.Text = "P2:";
            // 
            // cboPokemon1
            // 
            this.cboPokemon1.Font = new System.Drawing.Font("Montserrat SemiBold", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPokemon1.FormattingEnabled = true;
            this.cboPokemon1.Location = new System.Drawing.Point(252, 45);
            this.cboPokemon1.Name = "cboPokemon1";
            this.cboPokemon1.Size = new System.Drawing.Size(121, 35);
            this.cboPokemon1.TabIndex = 21;
            // 
            // cboPokemon2
            // 
            this.cboPokemon2.Font = new System.Drawing.Font("Montserrat SemiBold", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPokemon2.FormattingEnabled = true;
            this.cboPokemon2.Location = new System.Drawing.Point(252, 100);
            this.cboPokemon2.Name = "cboPokemon2";
            this.cboPokemon2.Size = new System.Drawing.Size(121, 35);
            this.cboPokemon2.TabIndex = 22;
            // 
            // txtHP1
            // 
            this.txtHP1.Location = new System.Drawing.Point(478, 47);
            this.txtHP1.Name = "txtHP1";
            this.txtHP1.Size = new System.Drawing.Size(148, 33);
            this.txtHP1.TabIndex = 23;
            // 
            // txtHP2
            // 
            this.txtHP2.Location = new System.Drawing.Point(478, 98);
            this.txtHP2.Name = "txtHP2";
            this.txtHP2.Size = new System.Drawing.Size(148, 33);
            this.txtHP2.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(415, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 33);
            this.label4.TabIndex = 25;
            this.label4.Text = "HP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(415, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 33);
            this.label5.TabIndex = 26;
            this.label5.Text = "HP:";
            // 
            // gbSeleccionar
            // 
            this.gbSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.gbSeleccionar.Controls.Add(this.btnMenu);
            this.gbSeleccionar.Controls.Add(this.btnReiniciarHP);
            this.gbSeleccionar.Controls.Add(this.btnAtacar);
            this.gbSeleccionar.Controls.Add(this.label5);
            this.gbSeleccionar.Controls.Add(this.label4);
            this.gbSeleccionar.Controls.Add(this.txtHP2);
            this.gbSeleccionar.Controls.Add(this.txtHP1);
            this.gbSeleccionar.Controls.Add(this.cboPokemon2);
            this.gbSeleccionar.Controls.Add(this.cboPokemon1);
            this.gbSeleccionar.Controls.Add(this.label3);
            this.gbSeleccionar.Controls.Add(this.label2);
            this.gbSeleccionar.Font = new System.Drawing.Font("Montserrat SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSeleccionar.Location = new System.Drawing.Point(38, 135);
            this.gbSeleccionar.Name = "gbSeleccionar";
            this.gbSeleccionar.Size = new System.Drawing.Size(839, 228);
            this.gbSeleccionar.TabIndex = 20;
            this.gbSeleccionar.TabStop = false;
            this.gbSeleccionar.Text = "[ Seleccionar ]";
            // 
            // txtHistorial
            // 
            this.txtHistorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHistorial.Location = new System.Drawing.Point(35, 47);
            this.txtHistorial.Multiline = true;
            this.txtHistorial.Name = "txtHistorial";
            this.txtHistorial.Size = new System.Drawing.Size(771, 296);
            this.txtHistorial.TabIndex = 25;
            // 
            // btnAtacar
            // 
            this.btnAtacar.Location = new System.Drawing.Point(209, 151);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(164, 44);
            this.btnAtacar.TabIndex = 27;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = true;
            // 
            // btnReiniciarHP
            // 
            this.btnReiniciarHP.Location = new System.Drawing.Point(421, 151);
            this.btnReiniciarHP.Name = "btnReiniciarHP";
            this.btnReiniciarHP.Size = new System.Drawing.Size(205, 44);
            this.btnReiniciarHP.TabIndex = 28;
            this.btnReiniciarHP.Text = "Reiniciar Salud";
            this.btnReiniciarHP.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(714, 32);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(92, 44);
            this.btnMenu.TabIndex = 29;
            this.btnMenu.Text = "MENU";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // FrmDuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 777);
            this.Controls.Add(this.gpHistorial);
            this.Controls.Add(this.gbSeleccionar);
            this.Name = "FrmDuelo";
            this.Text = "Duelos";
            this.gpHistorial.ResumeLayout(false);
            this.gpHistorial.PerformLayout();
            this.gbSeleccionar.ResumeLayout(false);
            this.gbSeleccionar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpHistorial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPokemon1;
        private System.Windows.Forms.ComboBox cboPokemon2;
        private System.Windows.Forms.TextBox txtHP1;
        private System.Windows.Forms.TextBox txtHP2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbSeleccionar;
        private System.Windows.Forms.TextBox txtHistorial;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Button btnReiniciarHP;
        private System.Windows.Forms.Button btnMenu;
    }
}