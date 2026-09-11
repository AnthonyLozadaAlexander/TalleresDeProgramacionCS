namespace Clase1
{
    partial class N4
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
            txtValor1 = new TextBox();
            label2 = new Label();
            txtHistorial = new TextBox();
            btnCalcular = new Button();
            label1 = new Label();
            txtValor2 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(115, 82);
            label3.Name = "label3";
            label3.Size = new Size(240, 28);
            label3.TabIndex = 19;
            label3.Text = "Ingrese Los Valores";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(229, 130);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(115, 26);
            txtValor1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold);
            label2.Location = new Point(116, 132);
            label2.Name = "label2";
            label2.Size = new Size(98, 24);
            label2.TabIndex = 17;
            label2.Text = "Valor 1:";
            // 
            // txtHistorial
            // 
            txtHistorial.Location = new Point(115, 296);
            txtHistorial.Multiline = true;
            txtHistorial.Name = "txtHistorial";
            txtHistorial.Size = new Size(240, 133);
            txtHistorial.TabIndex = 16;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(165, 228);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(132, 39);
            btnCalcular.TabIndex = 15;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 38);
            label1.Name = "label1";
            label1.Size = new Size(240, 28);
            label1.TabIndex = 14;
            label1.Text = "Suma De Dos Numeros";
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(228, 176);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(115, 26);
            txtValor2.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold);
            label4.Location = new Point(115, 178);
            label4.Name = "label4";
            label4.Size = new Size(98, 24);
            label4.TabIndex = 20;
            label4.Text = "Valor 2:";
            // 
            // N4
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(490, 503);
            Controls.Add(txtValor2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtValor1);
            Controls.Add(label2);
            Controls.Add(txtHistorial);
            Controls.Add(btnCalcular);
            Controls.Add(label1);
            Name = "N4";
            Text = "N4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtValor1;
        private Label label2;
        private TextBox txtHistorial;
        private Button btnCalcular;
        private Label label1;
        private TextBox txtValor2;
        private Label label4;
    }
}