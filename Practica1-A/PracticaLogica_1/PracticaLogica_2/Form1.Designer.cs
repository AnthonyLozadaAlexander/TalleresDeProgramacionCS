namespace PracticaLogica_2
{
    partial class Form1
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
            this.lstCursos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCostos = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lstCos = new System.Windows.Forms.ListBox();
            this.lstCur = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMontoPagar = new System.Windows.Forms.TextBox();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.chkContado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdLinea = new System.Windows.Forms.RadioButton();
            this.rdAudio = new System.Windows.Forms.RadioButton();
            this.rdVideo = new System.Windows.Forms.RadioButton();
            this.chkCredito = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema Seleccion Cursos";
            // 
            // lstCursos
            // 
            this.lstCursos.Font = new System.Drawing.Font("Cascadia Code", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCursos.FormattingEnabled = true;
            this.lstCursos.ItemHeight = 20;
            this.lstCursos.Location = new System.Drawing.Point(46, 167);
            this.lstCursos.Name = "lstCursos";
            this.lstCursos.Size = new System.Drawing.Size(120, 144);
            this.lstCursos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alumno:";
            // 
            // lstCostos
            // 
            this.lstCostos.Font = new System.Drawing.Font("Cascadia Code", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCostos.FormattingEnabled = true;
            this.lstCostos.ItemHeight = 20;
            this.lstCostos.Location = new System.Drawing.Point(172, 167);
            this.lstCostos.Name = "lstCostos";
            this.lstCostos.Size = new System.Drawing.Size(98, 144);
            this.lstCostos.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 117);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 29);
            this.textBox1.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Cascadia Code", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(45, 327);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 38);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Cascadia Code", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(172, 327);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 38);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lstCos
            // 
            this.lstCos.Font = new System.Drawing.Font("Cascadia Code", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCos.FormattingEnabled = true;
            this.lstCos.ItemHeight = 20;
            this.lstCos.Location = new System.Drawing.Point(172, 385);
            this.lstCos.Name = "lstCos";
            this.lstCos.Size = new System.Drawing.Size(98, 144);
            this.lstCos.TabIndex = 14;
            // 
            // lstCur
            // 
            this.lstCur.Font = new System.Drawing.Font("Cascadia Code", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCur.FormattingEnabled = true;
            this.lstCur.ItemHeight = 20;
            this.lstCur.Location = new System.Drawing.Point(46, 385);
            this.lstCur.Name = "lstCur";
            this.lstCur.Size = new System.Drawing.Size(120, 144);
            this.lstCur.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 554);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 29);
            this.textBox2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(396, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "MontoPagar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(396, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Incremento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Descuento";
            // 
            // txtMontoPagar
            // 
            this.txtMontoPagar.Location = new System.Drawing.Point(531, 485);
            this.txtMontoPagar.Multiline = true;
            this.txtMontoPagar.Name = "txtMontoPagar";
            this.txtMontoPagar.Size = new System.Drawing.Size(117, 38);
            this.txtMontoPagar.TabIndex = 28;
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(531, 419);
            this.txtIncremento.Multiline = true;
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(117, 38);
            this.txtIncremento.TabIndex = 27;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(531, 354);
            this.txtDescuento.Multiline = true;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(117, 38);
            this.txtDescuento.TabIndex = 26;
            // 
            // chkContado
            // 
            this.chkContado.AutoSize = true;
            this.chkContado.Font = new System.Drawing.Font("Cascadia Code", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkContado.Location = new System.Drawing.Point(398, 297);
            this.chkContado.Name = "chkContado";
            this.chkContado.Size = new System.Drawing.Size(92, 25);
            this.chkContado.TabIndex = 25;
            this.chkContado.Text = "Contado";
            this.chkContado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Forma De Pago";
            // 
            // rdLinea
            // 
            this.rdLinea.AutoSize = true;
            this.rdLinea.Font = new System.Drawing.Font("Cascadia Code", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLinea.Location = new System.Drawing.Point(489, 186);
            this.rdLinea.Name = "rdLinea";
            this.rdLinea.Size = new System.Drawing.Size(85, 29);
            this.rdLinea.TabIndex = 23;
            this.rdLinea.TabStop = true;
            this.rdLinea.Text = "Linea";
            this.rdLinea.UseVisualStyleBackColor = true;
            // 
            // rdAudio
            // 
            this.rdAudio.AutoSize = true;
            this.rdAudio.Font = new System.Drawing.Font("Cascadia Code", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAudio.Location = new System.Drawing.Point(580, 186);
            this.rdAudio.Name = "rdAudio";
            this.rdAudio.Size = new System.Drawing.Size(85, 29);
            this.rdAudio.TabIndex = 22;
            this.rdAudio.TabStop = true;
            this.rdAudio.Text = "Audio";
            this.rdAudio.UseVisualStyleBackColor = true;
            // 
            // rdVideo
            // 
            this.rdVideo.AutoSize = true;
            this.rdVideo.Font = new System.Drawing.Font("Cascadia Code", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdVideo.Location = new System.Drawing.Point(398, 186);
            this.rdVideo.Name = "rdVideo";
            this.rdVideo.Size = new System.Drawing.Size(85, 29);
            this.rdVideo.TabIndex = 21;
            this.rdVideo.TabStop = true;
            this.rdVideo.Text = "Video";
            this.rdVideo.UseVisualStyleBackColor = true;
            // 
            // chkCredito
            // 
            this.chkCredito.AutoSize = true;
            this.chkCredito.Font = new System.Drawing.Font("Cascadia Code", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCredito.Location = new System.Drawing.Point(496, 297);
            this.chkCredito.Name = "chkCredito";
            this.chkCredito.Size = new System.Drawing.Size(92, 25);
            this.chkCredito.TabIndex = 34;
            this.chkCredito.Text = "Credito";
            this.chkCredito.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 663);
            this.Controls.Add(this.chkCredito);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMontoPagar);
            this.Controls.Add(this.txtIncremento);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.chkContado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdLinea);
            this.Controls.Add(this.rdAudio);
            this.Controls.Add(this.rdVideo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstCos);
            this.Controls.Add(this.lstCur);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstCostos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCursos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sistema Seleccion Cursos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox chkCredito;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMontoPagar;
        private System.Windows.Forms.TextBox txtIncremento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.CheckBox chkContado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdLinea;
        private System.Windows.Forms.RadioButton rdAudio;
        private System.Windows.Forms.RadioButton rdVideo;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCursos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCostos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox lstCos;
        private System.Windows.Forms.ListBox lstCur;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}

