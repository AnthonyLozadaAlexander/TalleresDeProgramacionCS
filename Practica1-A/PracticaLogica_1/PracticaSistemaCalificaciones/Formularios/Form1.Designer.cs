namespace PracticaSistemaCalificaciones {
    partial class Formulario {
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 130);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(246, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alumno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(672, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Calificaciones  Del Curso De Visual Studio 2026";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nota Unidad  1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota Unidad  2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(374, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nota Unidad  3:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(750, 130);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 43);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregaR);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(910, 131);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 43);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(557, 131);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(145, 20);
            this.txtNota1.TabIndex = 9;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(557, 172);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(145, 20);
            this.txtNota2.TabIndex = 10;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(557, 220);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(145, 20);
            this.txtNota3.TabIndex = 11;
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AllowUserToResizeColumns = false;
            this.tabla.AllowUserToResizeRows = false;
            this.tabla.BackgroundColor = System.Drawing.Color.White;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(163, 305);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersWidth = 47;
            this.tabla.Size = new System.Drawing.Size(1020, 514);
            this.tabla.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1084, 29);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 43);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cboTurno
            // 
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.Location = new System.Drawing.Point(108, 251);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(246, 21);
            this.cboTurno.TabIndex = 14;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(939, 220);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(145, 20);
            this.txtTotal.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(756, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total  Alumnos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(108, 173);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(246, 20);
            this.txtEdad.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Cedula:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(108, 212);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(246, 20);
            this.txtCedula.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Turno:";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 842);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboTurno);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Name = "Formulario";
            this.Text = "SistemaCalificaciones";
            this.Load += new System.EventHandler(this.Formulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label9;
    }
}

