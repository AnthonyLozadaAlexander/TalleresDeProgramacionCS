using System.ComponentModel;

namespace Clase1;

partial class N3
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        txtHistorial = new TextBox();
        btnIngresar = new Button();
        label1 = new Label();
        label2 = new Label();
        txtName = new TextBox();
        label3 = new Label();
        SuspendLayout();
        // 
        // txtHistorial
        // 
        txtHistorial.Location = new Point(300, 73);
        txtHistorial.Multiline = true;
        txtHistorial.Name = "txtHistorial";
        txtHistorial.Size = new Size(240, 133);
        txtHistorial.TabIndex = 10;
        // 
        // btnIngresar
        // 
        btnIngresar.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnIngresar.Location = new Point(48, 167);
        btnIngresar.Name = "btnIngresar";
        btnIngresar.Size = new Size(132, 39);
        btnIngresar.TabIndex = 9;
        btnIngresar.Text = "Ingresar";
        btnIngresar.UseVisualStyleBackColor = true;
        btnIngresar.Click += btnIngresar_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(48, 22);
        label1.Name = "label1";
        label1.Size = new Size(192, 28);
        label1.TabIndex = 8;
        label1.Text = "Bienvenido A C#";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(51, 115);
        label2.Name = "label2";
        label2.Size = new Size(96, 28);
        label2.TabIndex = 11;
        label2.Text = "Nombre:";
        // 
        // txtName
        // 
        txtName.Location = new Point(153, 117);
        txtName.Name = "txtName";
        txtName.Size = new Size(115, 26);
        txtName.TabIndex = 12;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.Location = new Point(48, 68);
        label3.Name = "label3";
        label3.Size = new Size(216, 28);
        label3.TabIndex = 13;
        label3.Text = "Ingrese Su Nombre";
        // 
        // N3
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(571, 318);
        Controls.Add(label3);
        Controls.Add(txtName);
        Controls.Add(label2);
        Controls.Add(txtHistorial);
        Controls.Add(btnIngresar);
        Controls.Add(label1);
        Name = "N3";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "N3";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtHistorial;
    private Button btnIngresar;
    private Label label1;
    private Label label2;
    private TextBox txtName;
    private Label label3;
}