namespace Clase1
{
    partial class N2
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
            label1 = new System.Windows.Forms.Label();
            btnIngresar = new System.Windows.Forms.Button();
            txtHistorial = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cascadia Code", 13.745455F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.Location = new System.Drawing.Point(204, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(192, 28);
            label1.TabIndex = 5;
            label1.Text = "Bienvenido A C#";
            label1.Click += label1_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new System.Drawing.Font("Cascadia Code", 11.781818F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnIngresar.Location = new System.Drawing.Point(231, 104);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(132, 39);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtHistorial
            // 
            txtHistorial.Location = new System.Drawing.Point(181, 185);
            txtHistorial.Multiline = true;
            txtHistorial.Name = "txtHistorial";
            txtHistorial.Size = new System.Drawing.Size(240, 308);
            txtHistorial.TabIndex = 7;
            txtHistorial.TextChanged += textBox1_TextChanged;
            // 
            // N2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(630, 609);
            Controls.Add(txtHistorial);
            Controls.Add(btnIngresar);
            Controls.Add(label1);
            Text = "N2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnIngresar;
        private TextBox txtHistorial;
    }
}