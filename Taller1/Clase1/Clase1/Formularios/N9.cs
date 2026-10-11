using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Taller_1.Formularios {
    public partial class N9 : Form {
        public N9() {
            InitializeComponent();
            CenterToScreen();
            BackColor = Color.White;
        }

        private void btnIngresar_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) {
                MessageBox.Show("Error: El campo de nombre está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = txtNombre.Text;
            txtHistorial.Text = $"Bienvenido {nombre} a {Environment.NewLine}" +
                $"Visual Studio 2026";

        }
    }
}
