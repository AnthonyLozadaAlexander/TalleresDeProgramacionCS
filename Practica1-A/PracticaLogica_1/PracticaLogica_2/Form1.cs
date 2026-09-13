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

            if (!(lstCursos.SelectedItems.Count > 0)) {
                MessageBox.Show("Error: Debe Seleccionar un Curso y un Costo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            /*
             * Toma el indice del curso que se selecciono en la lista de cursos y lo agrega a la lista del carrito y costos 
            */
            int cursoIndex = lstCursos.SelectedIndex;


            lstCur.Items.Add(lstCursos.Items[cursoIndex]);
            lstCos.Items.Add(lstCostos.Items[cursoIndex]);


        }
        private void btnCalcular_Click(object sender, EventArgs e) {


            /*
             * Que el carrito no este vacio 
            */

            if (lstCur.Items.Count == 0) {
                MessageBox.Show("Error: Debe agregar un curso en el carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /*
             * Seleccionar un metodo de pago 
            */
            if(!rdContado.Checked && !rdCredito.Checked) { 
                MessageBox.Show("Error: Debe seleccionar un metodo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            calcularPrecio();

        }

        private double calcularPorcentaje(double subtotal, double valor) {
            return (subtotal * (valor / 100));
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Esta Seguro De Cerrar El Programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (!(lstCur.SelectedItems.Count > 0)) {

                MessageBox.Show("Error: Debe Seleccionar un Curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cursoIndex = lstCur.SelectedIndex;

            lstCur.Items.RemoveAt(cursoIndex);
            lstCos.Items.RemoveAt(cursoIndex);

            calcularPrecio();

        }

        private  void calcularPrecio() {

            double subTotal = 0.0;
            double costo = 0.0;
            double incremento = 0.0;
            double descuento = 0.0;
            double total = 0.0;

            foreach (string i in lstCos.Items) {
                costo = Convert.ToDouble(i);
                subTotal = subTotal + costo;
            }

            txtSubTotal.Text = subTotal.ToString();

            if (rdContado.Checked) {

                descuento = calcularPorcentaje(subTotal, 5.0);
                MessageBox.Show("Se aplicara un descuento del 5% por pago al contado", "Descuento", MessageBoxButtons.OK, MessageBoxIcon.Information);

                total = subTotal - descuento;


            }
            else if (rdCredito.Checked) {

                incremento = calcularPorcentaje(subTotal, 7.0);
                MessageBox.Show("Se aplicara un incremento del 7% por pago a credito", "Incremento", MessageBoxButtons.OK, MessageBoxIcon.Information);

                total = subTotal + incremento;
            }

            txtMontoPagar.Text = total.ToString();
            txtDescuento.Text = descuento.ToString();
            txtIncremento.Text = incremento.ToString();
        }

        public bool validaciones() {

            if (String.IsNullOrEmpty(txtAlumno.Text)) {
                MessageBox.Show("Error: Debe Ingresar un Nombre de Alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!(lstCursos.SelectedItems.Count > 0)) {
                MessageBox.Show("Error: Debe Seleccionar un Curso y un Costo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            

            return true;
        }
        private void btnLimpiar_Click(object sender, EventArgs e) {
            rdContado.Checked = false;
            rdCredito.Checked = false;

            txtAlumno.Clear();
            txtDescuento.Clear();
            txtIncremento.Clear();
            txtMontoPagar.Clear();
            txtSubTotal.Clear();

            lstCur.Items.Clear();
            lstCos.Items.Clear();

            txtAlumno.Focus();
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
