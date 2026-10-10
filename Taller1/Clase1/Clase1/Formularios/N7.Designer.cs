namespace Taller_1.Formularios {
    partial class N7 {
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
            label3 = new Label();
            txtNum1 = new TextBox();
            label2 = new Label();
            txtHistorial = new TextBox();
            btnSumar = new Button();
            label1 = new Label();
            txtNum2 = new TextBox();
            btnRestar = new Button();
            btnDividir = new Button();
            btnMultiplicar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(461, 64);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 39;
            label3.Text = "Num1:";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(402, 107);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(187, 26);
            txtNum1.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold);
            label2.Location = new Point(461, 136);
            label2.Name = "label2";
            label2.Size = new Size(65, 24);
            label2.TabIndex = 37;
            label2.Text = "Num2:";
            // 
            // txtHistorial
            // 
            txtHistorial.Location = new Point(402, 228);
            txtHistorial.Multiline = true;
            txtHistorial.Name = "txtHistorial";
            txtHistorial.Size = new Size(187, 75);
            txtHistorial.TabIndex = 36;
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSumar.Location = new Point(48, 107);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(154, 39);
            btnSumar.TabIndex = 35;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 44);
            label1.Name = "label1";
            label1.Size = new Size(228, 28);
            label1.TabIndex = 34;
            label1.Text = "Calculadora Basica";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(402, 178);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(187, 26);
            txtNum2.TabIndex = 41;
            // 
            // btnRestar
            // 
            btnRestar.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestar.Location = new Point(48, 163);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(154, 39);
            btnRestar.TabIndex = 42;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDividir.Location = new Point(224, 163);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(154, 39);
            btnDividir.TabIndex = 44;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiplicar.Location = new Point(224, 107);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(154, 39);
            btnMultiplicar.TabIndex = 43;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(222, 252);
            label4.Name = "label4";
            label4.Size = new Size(156, 28);
            label4.TabIndex = 45;
            label4.Text = "Resultado ->";
            // 
            // N7
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 372);
            Controls.Add(label4);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(txtNum2);
            Controls.Add(label3);
            Controls.Add(txtNum1);
            Controls.Add(label2);
            Controls.Add(txtHistorial);
            Controls.Add(btnSumar);
            Controls.Add(label1);
            Name = "N7";
            Text = "E7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtNum1;
        private Label label2;
        private TextBox txtHistorial;
        private Button btnSumar;
        private Label label1;
        private TextBox txtNum2;
        private Button btnRestar;
        private Button btnDividir;
        private Button btnMultiplicar;
        private Label label4;
    }
}