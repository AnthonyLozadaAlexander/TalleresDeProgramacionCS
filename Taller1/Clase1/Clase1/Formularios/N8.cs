using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Taller_1.Formularios {
    public partial class N8 : Form {
        public N8() {
            InitializeComponent();
            configurarTabla();
            BackColor = Color.White;
        }

        private void configurarTabla() {
            tablaNotas.Columns.Add("Nota 1", "Nota 1");
            tablaNotas.Columns.Add("Nota 2", "Nota 2");
            tablaNotas.Columns.Add("Nota 3", "Nota 3");
            tablaNotas.Columns.Add("Promedio", "Promedio");
            tablaNotas.Columns.Add("Estado", "Estado");
            tablaNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // ajusta el tamanio de las columnas al contenido

        }

        private bool validarTxT() {
            if (string.IsNullOrWhiteSpace(txtNota1.Text) || string.IsNullOrWhiteSpace(txtNota2.Text) || string.IsNullOrWhiteSpace(txtNota3.Text)) {
                MessageBox.Show("Por favor, complete los campos.");
                return false;
            }
            return true;
        }

        private void btnCalcular_Click(object sender, EventArgs e) {
            try {
                tablaNotas.Rows.Clear();

                double prom = 0.0;
                string estado = "";

                if (!validarTxT()) {
                    return;
                }

                if (Convert.ToDouble(txtNota1.Text) > 0 && Convert.ToDouble(txtNota1.Text) <= 10 && Convert.ToDouble(txtNota2.Text) > 0 && Convert.ToDouble(txtNota2.Text) <= 10
                    && Convert.ToDouble(txtNota3.Text) > 0 && Convert.ToDouble(txtNota3.Text) <= 10) {
                    prom = promedio(txtNota1.Text, txtNota2.Text, txtNota3.Text);
                    estado = prom >= 7 ? "Aprobado" : "Reprobado";
                    insertarFila(txtNota1.Text, txtNota2.Text, txtNota3.Text, prom, estado);

                }
                else {
                    MessageBox.Show("Por favor, ingrese valores entre 0 y 10 para las notas.");
                    return;
                }

                txtHistorial.Text = $"Promedio Final: {prom.ToString("F2")} {Environment.NewLine}" +
                    $" Estado: {estado}";

            }
            catch (FormatException) {
                MessageBox.Show("Debe Ingresar Valores Numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private double promedio(string n1, string n2, string n3) {
            return ((Convert.ToDouble(n1) + Convert.ToDouble(n2) + Convert.ToDouble(n3)) / 3);
        }


        private void insertarFila(string n1, string n2, string n3, double prom, string estado) {
            tablaNotas.Rows.Add(n1, n2, n3, prom.ToString("F2"), estado);
        }
    }
}
