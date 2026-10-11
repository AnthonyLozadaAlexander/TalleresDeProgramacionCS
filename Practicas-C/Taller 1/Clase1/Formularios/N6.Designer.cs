namespace Clase1
{
    partial class N6
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
            txtEdad = new TextBox();
            label2 = new Label();
            txtHistorial = new TextBox();
            btnVerificar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(166, 81);
            label3.Name = "label3";
            label3.Size = new Size(192, 28);
            label3.TabIndex = 33;
            label3.Text = "Ingrese La Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(243, 135);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(115, 26);
            txtEdad.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold);
            label2.Location = new Point(166, 137);
            label2.Name = "label2";
            label2.Size = new Size(65, 24);
            label2.TabIndex = 31;
            label2.Text = "Edad:";
            // 
            // txtHistorial
            // 
            txtHistorial.Location = new Point(142, 263);
            txtHistorial.Multiline = true;
            txtHistorial.Name = "txtHistorial";
            txtHistorial.Size = new Size(240, 48);
            txtHistorial.TabIndex = 30;
            // 
            // btnVerificar
            // 
            btnVerificar.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerificar.Location = new Point(200, 183);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(132, 39);
            btnVerificar.TabIndex = 29;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 38);
            label1.Name = "label1";
            label1.Size = new Size(288, 28);
            label1.TabIndex = 28;
            label1.Text = "Determinar Mayoria Edad";
            // 
            // N6
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(533, 384);
            Controls.Add(label3);
            Controls.Add(txtEdad);
            Controls.Add(label2);
            Controls.Add(txtHistorial);
            Controls.Add(btnVerificar);
            Controls.Add(label1);
            Name = "N6";
            Text = "N6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtEdad;
        private Label label2;
        private TextBox txtHistorial;
        private Button btnVerificar;
        private Label label1;
    }
}