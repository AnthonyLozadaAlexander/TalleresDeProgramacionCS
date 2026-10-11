using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Taller_1.Formularios {
    public partial class N10 : Form {
        public N10() {
            InitializeComponent();
            BackColor = Color.White;
        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            try {
                if (String.IsNullOrWhiteSpace(txtX.Text)) {
                    MessageBox.Show("Error: El campo X no puede estar vacío.");
                    return;
                }

                double x = Convert.ToDouble(txtX.Text);
                double resultado = dobleDe(x);
                txtResult.Text = $"El doble de {x} {Environment.NewLine} " +
                    $"es: {resultado}";
            }
            catch (FormatException) {
                MessageBox.Show("Error: Debe ingresar un valor numérico válido para X.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double dobleDe(double x) {
            return (2) * (x);
        }
    }
}
