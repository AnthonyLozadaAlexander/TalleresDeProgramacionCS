namespace Clase1
{
    partial class N1
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
            label1 = new Label();
            btnClick = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 80);
            label1.Name = "label1";
            label1.Size = new Size(192, 28);
            label1.TabIndex = 3;
            label1.Text = "Bienvenido A C#";
            // 
            // btnClick
            // 
            btnClick.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClick.Location = new Point(88, 145);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(132, 39);
            btnClick.TabIndex = 4;
            btnClick.Text = "Dar Click";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // N1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(318, 293);
            Controls.Add(btnClick);
            Controls.Add(label1);
            Name = "N1";
            Text = "N1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnClick;
    }
}