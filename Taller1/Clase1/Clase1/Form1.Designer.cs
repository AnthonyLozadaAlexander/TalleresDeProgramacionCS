namespace Clase1
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            panelContenedor = new Panel();
            panelBotones = new Panel();
            btnN5 = new Button();
            btnN4 = new Button();
            btnN3 = new Button();
            btnN2 = new Button();
            btnLimpiar = new Button();
            btnN1 = new Button();
            label1 = new Label();
            panelBotones2 = new Panel();
            btnN6 = new Button();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(282, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(606, 796);
            panelContenedor.TabIndex = 0;
            panelContenedor.Paint += panel1_Paint;
            // 
            // panelBotones
            // 
            panelBotones.AutoScroll = true;
            panelBotones.BorderStyle = BorderStyle.Fixed3D;
            panelBotones.Controls.Add(btnN6);
            panelBotones.Controls.Add(btnN5);
            panelBotones.Controls.Add(btnN4);
            panelBotones.Controls.Add(btnN3);
            panelBotones.Controls.Add(btnN2);
            panelBotones.Controls.Add(btnLimpiar);
            panelBotones.Controls.Add(btnN1);
            panelBotones.Location = new Point(-1, -5);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(284, 801);
            panelBotones.TabIndex = 1;
            panelBotones.Paint += panelBotones_Paint;
            // 
            // btnN5
            // 
            btnN5.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnN5.Location = new Point(55, 277);
            btnN5.Name = "btnN5";
            btnN5.Size = new Size(165, 43);
            btnN5.TabIndex = 5;
            btnN5.Text = "Ejercicio N5";
            btnN5.UseVisualStyleBackColor = true;
            btnN5.Click += btnN5_Click;
            // 
            // btnN4
            // 
            btnN4.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnN4.Location = new Point(55, 228);
            btnN4.Name = "btnN4";
            btnN4.Size = new Size(165, 43);
            btnN4.TabIndex = 4;
            btnN4.Text = "Ejercicio N4";
            btnN4.UseVisualStyleBackColor = true;
            btnN4.Click += button1_Click;
            // 
            // btnN3
            // 
            btnN3.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnN3.Location = new Point(55, 179);
            btnN3.Name = "btnN3";
            btnN3.Size = new Size(165, 43);
            btnN3.TabIndex = 3;
            btnN3.Text = "Ejercicio N3";
            btnN3.UseVisualStyleBackColor = true;
            btnN3.Click += btnN3_Click;
            // 
            // btnN2
            // 
            btnN2.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnN2.Location = new Point(55, 126);
            btnN2.Name = "btnN2";
            btnN2.Size = new Size(165, 43);
            btnN2.TabIndex = 2;
            btnN2.Text = "Ejercicio N2";
            btnN2.UseVisualStyleBackColor = true;
            btnN2.Click += btnN2_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(55, 719);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(165, 43);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar Panel";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnN1
            // 
            btnN1.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnN1.Location = new Point(55, 76);
            btnN1.Name = "btnN1";
            btnN1.Size = new Size(165, 43);
            btnN1.TabIndex = 0;
            btnN1.Text = "Ejercicio N1";
            btnN1.UseVisualStyleBackColor = true;
            btnN1.Click += btnN1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 23);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 2;
            label1.Text = "Taller N1";
            // 
            // panelBotones2
            // 
            panelBotones2.Location = new Point(888, -5);
            panelBotones2.Name = "panelBotones2";
            panelBotones2.Size = new Size(259, 801);
            panelBotones2.TabIndex = 3;
            panelBotones2.Paint += panel1_Paint_1;
            // 
            // btnN6
            // 
            btnN6.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnN6.Location = new Point(55, 335);
            btnN6.Name = "btnN6";
            btnN6.Size = new Size(165, 43);
            btnN6.TabIndex = 6;
            btnN6.Text = "Ejercicio N6";
            btnN6.UseVisualStyleBackColor = true;
            btnN6.Click += btnN6_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1146, 795);
            Controls.Add(panelBotones2);
            Controls.Add(label1);
            Controls.Add(panelBotones);
            Controls.Add(panelContenedor);
            Name = "Menu";
            Text = "Menu";
            Load += Form1_Load;
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnN3;

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelBotones;
        private Button btnN1;
        private Label label1;
        private Button btnLimpiar;
        private Button btnN2;
        private Panel panelBotones2;
        private Button btnN4;
        private Button btnN5;
        private Button btnN6;
    }
}
