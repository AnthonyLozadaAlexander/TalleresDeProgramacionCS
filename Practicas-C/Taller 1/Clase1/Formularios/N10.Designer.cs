namespace Taller_1.Formularios {
    partial class N10 {
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
            txtX = new TextBox();
            btnCalcular = new Button();
            label1 = new Label();
            txtResult = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(73, 113);
            label3.Name = "label3";
            label3.Size = new Size(48, 28);
            label3.TabIndex = 43;
            label3.Text = "x =";
            // 
            // txtX
            // 
            txtX.Location = new Point(127, 118);
            txtX.Name = "txtX";
            txtX.Size = new Size(174, 26);
            txtX.TabIndex = 42;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(127, 173);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(174, 39);
            btnCalcular.TabIndex = 41;
            btnCalcular.Text = "Calcular ";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 49);
            label1.Name = "label1";
            label1.Size = new Size(228, 28);
            label1.TabIndex = 40;
            label1.Text = "Doble De Un Numero";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(127, 242);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(174, 68);
            txtResult.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 263);
            label2.Name = "label2";
            label2.Size = new Size(48, 28);
            label2.TabIndex = 45;
            label2.Text = "R =";
            // 
            // N10
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 420);
            Controls.Add(label2);
            Controls.Add(txtResult);
            Controls.Add(label3);
            Controls.Add(txtX);
            Controls.Add(btnCalcular);
            Controls.Add(label1);
            Name = "N10";
            Text = "N10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtX;
        private Button btnCalcular;
        private Label label1;
        private TextBox txtResult;
        private Label label2;
    }
}