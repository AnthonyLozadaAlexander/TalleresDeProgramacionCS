namespace Pokemon_POO.Formularios {
    partial class FrmLista {
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.LPokemon = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista<Pokemon>";
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Cascadia Code", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(78, 435);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(122, 48);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Cascadia Code", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(228, 435);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(122, 48);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // LPokemon
            // 
            this.LPokemon.AllowDrop = true;
            this.LPokemon.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPokemon.FormattingEnabled = true;
            this.LPokemon.HorizontalScrollbar = true;
            this.LPokemon.ItemHeight = 22;
            this.LPokemon.Location = new System.Drawing.Point(54, 85);
            this.LPokemon.MultiColumn = true;
            this.LPokemon.Name = "LPokemon";
            this.LPokemon.ScrollAlwaysVisible = true;
            this.LPokemon.Size = new System.Drawing.Size(860, 312);
            this.LPokemon.TabIndex = 1;
            // 
            // FrmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 548);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.LPokemon);
            this.Controls.Add(this.label1);
            this.Name = "FrmLista";
            this.Text = "FrmLista";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ListBox LPokemon;
    }
}