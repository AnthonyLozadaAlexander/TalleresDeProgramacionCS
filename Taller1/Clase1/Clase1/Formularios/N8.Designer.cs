namespace Taller_1.Formularios {
    partial class N8 {
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
            label4 = new Label();
            txtNota2 = new TextBox();
            label3 = new Label();
            txtNota1 = new TextBox();
            label2 = new Label();
            txtHistorial = new TextBox();
            label1 = new Label();
            tablaNotas = new DataGridView();
            btnCalcular = new Button();
            txtNota3 = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)tablaNotas).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(317, 169);
            label4.Name = "label4";
            label4.Size = new Size(192, 28);
            label4.TabIndex = 52;
            label4.Text = "Promedio Final ";
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(65, 139);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(187, 26);
            txtNota2.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 11.1272726F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(116, 36);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 50;
            label3.Text = "Nota 1";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(62, 72);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(187, 26);
            txtNota1.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold);
            label2.Location = new Point(116, 112);
            label2.Name = "label2";
            label2.Size = new Size(76, 24);
            label2.TabIndex = 48;
            label2.Text = "Nota 2";
            // 
            // txtHistorial
            // 
            txtHistorial.Location = new Point(317, 222);
            txtHistorial.Multiline = true;
            txtHistorial.Name = "txtHistorial";
            txtHistorial.Size = new Size(187, 23);
            txtHistorial.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(287, 26);
            label1.Name = "label1";
            label1.Size = new Size(240, 28);
            label1.TabIndex = 46;
            label1.Text = "Promedio De 3 Notas";
            // 
            // tablaNotas
            // 
            tablaNotas.BackgroundColor = Color.White;
            tablaNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaNotas.Location = new Point(12, 270);
            tablaNotas.Name = "tablaNotas";
            tablaNotas.RowHeadersWidth = 47;
            tablaNotas.Size = new Size(565, 125);
            tablaNotas.TabIndex = 53;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Cascadia Code SemiBold", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(337, 92);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(147, 43);
            btnCalcular.TabIndex = 54;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(68, 219);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(187, 26);
            txtNota3.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold);
            label5.Location = new Point(116, 182);
            label5.Name = "label5";
            label5.Size = new Size(76, 24);
            label5.TabIndex = 55;
            label5.Text = "Nota 3";
            // 
            // N8
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 407);
            Controls.Add(txtNota3);
            Controls.Add(label5);
            Controls.Add(btnCalcular);
            Controls.Add(tablaNotas);
            Controls.Add(label4);
            Controls.Add(txtNota2);
            Controls.Add(label3);
            Controls.Add(txtNota1);
            Controls.Add(label2);
            Controls.Add(txtHistorial);
            Controls.Add(label1);
            Name = "N8";
            Text = "E8";
            ((System.ComponentModel.ISupportInitialize)tablaNotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txtNota2;
        private Label label3;
        private TextBox txtNota1;
        private Label label2;
        private TextBox txtHistorial;
        private Label label1;
        private DataGridView tablaNotas;
        private Button btnCalcular;
        private TextBox txtNota3;
        private Label label5;
    }
}