namespace Clase1
{
    partial class N5
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
            label3 = new Label();
            txtValor = new TextBox();
            label2 = new Label();
            txtHistorial = new TextBox();
            btnCalcular = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(112, 74);
            label3.Name = "label3";
            label3.Size = new Size(216, 28);
            label3.TabIndex = 27;
            label3.Text = "Ingresar El Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(226, 122);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(115, 26);
            txtValor.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold);
            label2.Location = new Point(133, 122);
            label2.Name = "label2";
            label2.Size = new Size(87, 24);
            label2.TabIndex = 25;
            label2.Text = "Numero:";
            // 
            // txtHistorial
            // 
            txtHistorial.Location = new Point(112, 234);
            txtHistorial.Multiline = true;
            txtHistorial.Name = "txtHistorial";
            txtHistorial.Size = new Size(240, 133);
            txtHistorial.TabIndex = 24;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(160, 168);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(132, 39);
            btnCalcular.TabIndex = 23;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(468, 28);
            label1.TabIndex = 22;
            label1.Text = "Determinar Si Un Numero Es Par o Impar";
            // 
            // N5
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(495, 479);
            Controls.Add(label3);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(txtHistorial);
            Controls.Add(btnCalcular);
            Controls.Add(label1);
            Name = "N5";
            Text = "N5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtValor;
        private Label label2;
        private TextBox txtHistorial;
        private Button btnCalcular;
        private Label label1;
    }
}