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
        private void InitializeComponent() {
            label1 = new Label();
            btnIngresar = new Button();
            txtHistorial = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 37);
            label1.Name = "label1";
            label1.Size = new Size(192, 28);
            label1.TabIndex = 5;
            label1.Text = "Bienvenido A C#";
            label1.Click += label1_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(231, 104);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(132, 39);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtHistorial
            // 
            txtHistorial.Location = new Point(181, 185);
            txtHistorial.Multiline = true;
            txtHistorial.Name = "txtHistorial";
            txtHistorial.Size = new Size(240, 174);
            txtHistorial.TabIndex = 7;
            txtHistorial.TextChanged += textBox1_TextChanged;
            // 
            // N2
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(630, 434);
            Controls.Add(txtHistorial);
            Controls.Add(btnIngresar);
            Controls.Add(label1);
            Name = "N2";
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