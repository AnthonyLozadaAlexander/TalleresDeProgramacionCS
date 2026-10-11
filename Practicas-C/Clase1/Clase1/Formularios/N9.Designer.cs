namespace Taller_1.Formularios {
    partial class N9 {
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
            txtNombre = new TextBox();
            btnIngresar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtHistorial = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Cascadia Code SemiBold", 11.7818184F, FontStyle.Bold);
            txtNombre.Location = new Point(144, 88);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 28);
            txtNombre.TabIndex = 10;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(42, 144);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(132, 39);
            btnIngresar.TabIndex = 9;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 32);
            label1.Name = "label1";
            label1.Size = new Size(132, 28);
            label1.TabIndex = 8;
            label1.Text = "Formulario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 88);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 11;
            label2.Text = "Nombre:";
            // 
            // txtHistorial
            // 
            txtHistorial.Font = new Font("Cascadia Code SemiBold", 11.7818184F, FontStyle.Bold);
            txtHistorial.Location = new Point(91, 249);
            txtHistorial.Multiline = true;
            txtHistorial.Name = "txtHistorial";
            txtHistorial.Size = new Size(210, 136);
            txtHistorial.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(147, 203);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 13;
            label3.Text = "Mensaje";
            // 
            // N9
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 413);
            Controls.Add(label3);
            Controls.Add(txtHistorial);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(btnIngresar);
            Controls.Add(label1);
            Name = "N9";
            Text = "N9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Button btnIngresar;
        private Label label1;
        private Label label2;
        private TextBox txtHistorial;
        private Label label3;
    }
}