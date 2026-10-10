using Clase1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Taller_1.Formularios {
    public partial class N7 : Form {
        public N7() {
            InitializeComponent();
            BackColor = Color.White;
        }

        private void btnSumar_Click(object sender, EventArgs e) {
            try {
                if (!validarTxT()) {
                    return;
                }
                sumar(txtNum1.Text, txtNum2.Text);
            }
            catch (FormatException) {
                MessageBox.Show("Debe Ingresar Valores Numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarTxT() {
            if (string.IsNullOrWhiteSpace(txtNum1.Text) || string.IsNullOrWhiteSpace(txtNum2.Text)) {
                MessageBox.Show("Por favor, ingrese ambos números.");
                return false;
            }
            return true;
        }

        private void sumar(string n1, string n2) {
            double num1, num2, sum;

            num1 = Convert.ToDouble(n1);
            num2 = Convert.ToDouble(n2);
            sum = num1 + num2;
            txtHistorial.Text = $"Resultado De La Suma: {Environment.NewLine} {num1} + {num2} :  {sum}";
        }

        private void restar(string n1, string n2) {
            double num1, num2, minus;

            num1 = Convert.ToDouble(n1);
            num2 = Convert.ToDouble(n2);
            minus = num1 - num2;
            txtHistorial.Text = $"Resultado De La Suma: {Environment.NewLine} {num1} - {num2} :  {minus}";
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void btnRestar_Click(object sender, EventArgs e) {
            try {
                if (!validarTxT()) {
                    return;
                }
                restar(txtNum1.Text, txtNum2.Text);
            }
            catch (FormatException) {
                MessageBox.Show("Debe Ingresar Valores Numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Multiplicar(string n1, string n2) {
            double num1, num2, multiply;

            num1 = Convert.ToDouble(n1);
            num2 = Convert.ToDouble(n2);
            multiply = num1 * num2;
            txtHistorial.Text = $"Resultado De La Suma: {Environment.NewLine} ({num1}) ({num2}) :  {multiply}";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e) {
            try {
                if (!validarTxT()) {
                    return;
                }
                Multiplicar(txtNum1.Text, txtNum2.Text);
            }
            catch (FormatException) {
                MessageBox.Show("Debe Ingresar Valores Numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
