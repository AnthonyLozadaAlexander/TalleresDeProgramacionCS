using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaSistemaMatricula {
    public partial class Formulario : Form {
        public Formulario() {
            InitializeComponent();
            CenterToScreen();
            MinimizeBox = false;
            BackColor = Color.White;
            cboCursos.Items.Add("Matematicas");
            cboCursos.Items.Add("Fisica");
            cboCursos.Items.Add("Calculo");

            cboPago.Items.Add("Contado");
            cboPago.Items.Add("Credito");
        }
        private void cboCursos_SelectedIndexChanged(object sender, EventArgs e) {

            if (cboCursos.SelectedItem.ToString() == "Matematicas") {
                lstCursos.Items.Clear();
                lstCostos.Items.Clear();

                lstCursos.Items.Add("Algebra");
                lstCursos.Items.Add("Geometria");
                lstCursos.Items.Add("Trigonometria");

                lstCostos.Items.Add("100");
                lstCostos.Items.Add("200");
                lstCostos.Items.Add("400");
            }
            else if(cboCursos.SelectedItem.ToString() == "Fisica") {
                lstCursos.Items.Clear();
                lstCostos.Items.Clear();

                lstCursos.Items.Add("Movimiento Rectilineo Uniforme");
                lstCursos.Items.Add("Movimiento Rectilineo Uniformente Acelerado");
                lstCursos.Items.Add("Dinamica");

                lstCostos.Items.Add("100");
                lstCostos.Items.Add("200");
                lstCostos.Items.Add("400");
            }
            else if(cboCursos.SelectedItem.ToString() == "Calculo") {
                lstCursos.Items.Clear();
                lstCostos.Items.Clear();

                lstCursos.Items.Add("Diferencial");
                lstCursos.Items.Add("Integral");
                lstCursos.Items.Add("Vectorial");

                lstCostos.Items.Add("100");
                lstCostos.Items.Add("200");
                lstCostos.Items.Add("400");
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Esta Seguro De Cerrar El Programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                Application.Exit();
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e) {
            if(cboPago.SelectedIndex == -1) {
                MessageBox.Show("Error: Debe seleccionar un metodo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double descuento = 0.0;
            double incremento = 0.0;
            double subtotal = 0.0;
            double total = 0.0;
            double sum = 0.0;
            double mensual = 0.0;
            double valorMatricula = 0.0;

            foreach(var i in lstCos.Items) {
                sum = sum + Convert.ToDouble(i);
            }

            subtotal = sum;

            if (lstCos.Items.Count == 1) {
                valorMatricula = subtotal * 0.80;
            }else if(lstCos.Items.Count == 2) {
                valorMatricula = subtotal * 0.60;
            }else if(lstCos.Items.Count >= 3) {
                valorMatricula = subtotal * 0.50;
            }

            txtMatricula.Text = valorMatricula.ToString();

            if (cboPago.SelectedIndex == 0) {
                descuento = subtotal * 0.10;
                total = subtotal - descuento;
            }
            else if(cboPago.SelectedIndex == 1) {
                incremento = subtotal * 0.10;
                total = subtotal + incremento;
                mensual = total / 4;
            }

            txtMensual.Text = mensual.ToString();
            txtCostoTotal.Text = total.ToString();

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
        private void btnEliminar_Click(object sender, EventArgs e) {

            int index = lstCur.SelectedIndex;

            if(index == -1) {
                MessageBox.Show("Error: Debe Seleccionar Un Curso Para Eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lstCur.Items.RemoveAt(index);
            lstCos.Items.RemoveAt(index);

            actualizarCalculo();
           

        }

        private void actualizarCalculo() {
            double descuento = 0.0;
            double incremento = 0.0;
            double subtotal = 0.0;
            double total = 0.0;
            double sum = 0.0;
            double mensual = 0.0;
            double valorMatricula = 0.0;

            foreach (var i in lstCos.Items) {
                sum = sum + Convert.ToDouble(i);
            }

            subtotal = sum;

            if (lstCos.Items.Count == 1) {
                valorMatricula = subtotal * 0.80;
            }
            else if (lstCos.Items.Count == 2) {
                valorMatricula = subtotal * 0.60;
            }
            else if (lstCos.Items.Count >= 3) {
                valorMatricula = subtotal * 0.50;
            }

            txtMatricula.Text = valorMatricula.ToString();

            if (cboPago.SelectedIndex == 0) {
                descuento = subtotal * 0.10;
                total = subtotal - descuento;
            }
            else if (cboPago.SelectedIndex == 1) {
                incremento = subtotal * 0.10;
                total = subtotal + incremento;
                mensual = total / 4;
            }

            txtMensual.Text = mensual.ToString();
            txtCostoTotal.Text = total.ToString();
        }
        private void btnLimpiar_Click(object sender, EventArgs e) {
            
            txtAlumno.Clear();
            txtCostoTotal.Clear();
            txtMatricula.Clear();
            txtMensual.Clear();

            lstCur.Items.Clear();
            lstCos.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void txtAlumno_TextChanged(object sender, EventArgs e) {

        }

        private void Formulario_Load(object sender, EventArgs e) {

        }

        private void cboPago_SelectedIndexChanged(object sender, EventArgs e) {

        }

    }
}
