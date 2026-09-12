using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaLogica_2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            CenterToScreen();
            MinimizeBox = false;

            BackColor = Color.White;
            lstCursos.Items.Add("Java 2025");
            lstCursos.Items.Add("C# 2025");
            lstCursos.Items.Add("IOT 2025");
            lstCursos.Items.Add("Pandas Python");

            lstCostos.Items.Add("100");
            lstCostos.Items.Add("200");
            lstCostos.Items.Add("300");
            lstCostos.Items.Add("500");
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtAlumno.Text)) {
                MessageBox.Show("Error: Debe Ingresar un Nombre de Alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(lstCursos.SelectedItems.Count >= 0) || !(lstCostos.SelectedItems.Count >= 0)) {
                MessageBox.Show("Error: Debe Seleccionar un Curso y un Costo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(chkContado.Checked) || chkCredito.Checked) {
                MessageBox.Show("Error: Debe seleccionar un tipo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int cursoIndex = lstCursos.SelectedIndex;


            lstCur.Items.Add(lstCursos.Items[cursoIndex]);
            lstCos.Items.Add(lstCostos.Items[cursoIndex]);
        }
        private void btnCalcular_Click(object sender, EventArgs e) {
            double subTotal = 0.0;
            double costo = 0.0;

            foreach (string i in lstCos.Items) {
                costo = Convert.ToDouble(i);
                subTotal = subTotal + costo;
            }

            txtSubTotal.Text = subTotal.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Esta Seguro De Cerrar El Programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (!(lstCursos.SelectedItems.Count >= 0) || !(lstCostos.SelectedItems.Count >= 0)) {

                MessageBox.Show("Error: Debe Seleccionar un Curso y un Costo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void lstCos_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void lstCur_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void chkContado_CheckedChanged(object sender, EventArgs e) {

        }

        private void chkCredito_CheckedChanged(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
