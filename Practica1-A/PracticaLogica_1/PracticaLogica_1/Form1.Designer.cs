namespace PracticaLogica_1
{
    partial class Formulario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdVideo = new System.Windows.Forms.RadioButton();
            this.rdAudio = new System.Windows.Forms.RadioButton();
            this.rdLinea = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.chkContado = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.txtIgv = new System.Windows.Forms.TextBox();
            this.txtMPagar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturadora De Artefacto Electronico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Costo Del Artefacto:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(337, 132);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(116, 20);
            this.txtCosto.TabIndex = 2;
            this.txtCosto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipos De Artefactos";
            // 
            // rdVideo
            // 
            this.rdVideo.AutoSize = true;
            this.rdVideo.Font = new System.Drawing.Font("Cascadia Code", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdVideo.Location = new System.Drawing.Point(102, 242);
            this.rdVideo.Name = "rdVideo";
            this.rdVideo.Size = new System.Drawing.Size(85, 29);
            this.rdVideo.TabIndex = 4;
            this.rdVideo.TabStop = true;
            this.rdVideo.Text = "Video";
            this.rdVideo.UseVisualStyleBackColor = true;
            // 
            // rdAudio
            // 
            this.rdAudio.AutoSize = true;
            this.rdAudio.Font = new System.Drawing.Font("Cascadia Code", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAudio.Location = new System.Drawing.Point(282, 242);
            this.rdAudio.Name = "rdAudio";
            this.rdAudio.Size = new System.Drawing.Size(85, 29);
            this.rdAudio.TabIndex = 5;
            this.rdAudio.TabStop = true;
            this.rdAudio.Text = "Audio";
            this.rdAudio.UseVisualStyleBackColor = true;
            // 
            // rdLinea
            // 
            this.rdLinea.AutoSize = true;
            this.rdLinea.Font = new System.Drawing.Font("Cascadia Code", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLinea.Location = new System.Drawing.Point(457, 242);
            this.rdLinea.Name = "rdLinea";
            this.rdLinea.Size = new System.Drawing.Size(85, 29);
            this.rdLinea.TabIndex = 6;
            this.rdLinea.TabStop = true;
            this.rdLinea.Text = "Linea";
            this.rdLinea.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Forma De Pago";
            // 
            // chkContado
            // 
            this.chkContado.AutoSize = true;
            this.chkContado.Font = new System.Drawing.Font("Cascadia Code", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkContado.Location = new System.Drawing.Point(102, 357);
            this.chkContado.Name = "chkContado";
            this.chkContado.Size = new System.Drawing.Size(91, 24);
            this.chkContado.TabIndex = 8;
            this.chkContado.Text = "Contado";
            this.chkContado.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Cascadia Code", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(102, 444);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 38);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Cascadia Code", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(102, 509);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(121, 38);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Cascadia Code", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(102, 575);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(121, 38);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(391, 444);
            this.txtDescuento.Multiline = true;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(117, 38);
            this.txtDescuento.TabIndex = 13;
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(391, 509);
            this.txtIncremento.Multiline = true;
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(117, 38);
            this.txtIncremento.TabIndex = 14;
            // 
            // txtIgv
            // 
            this.txtIgv.Location = new System.Drawing.Point(391, 575);
            this.txtIgv.Multiline = true;
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.Size = new System.Drawing.Size(117, 38);
            this.txtIgv.TabIndex = 15;
            // 
            // txtMPagar
            // 
            this.txtMPagar.Location = new System.Drawing.Point(105, 693);
            this.txtMPagar.Multiline = true;
            this.txtMPagar.Name = "txtMPagar";
            this.txtMPagar.Size = new System.Drawing.Size(124, 24);
            this.txtMPagar.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 649);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Monto A Pagar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(256, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Descuento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(256, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Incremento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(256, 581);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "MontoIGV";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 753);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMPagar);
            this.Controls.Add(this.txtIgv);
            this.Controls.Add(this.txtIncremento);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.chkContado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdLinea);
            this.Controls.Add(this.rdAudio);
            this.Controls.Add(this.rdVideo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formulario";
            this.Text = "Facturadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdVideo;
        private System.Windows.Forms.RadioButton rdAudio;
        private System.Windows.Forms.RadioButton rdLinea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkContado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtIncremento;
        private System.Windows.Forms.TextBox txtIgv;
        private System.Windows.Forms.TextBox txtMPagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

