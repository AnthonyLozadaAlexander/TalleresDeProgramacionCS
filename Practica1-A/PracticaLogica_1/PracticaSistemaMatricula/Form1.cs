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

                lstCursos.Items.Add("Algebra");
                lstCursos.Items.Add("Geometria");
                lstCursos.Items.Add("Trigonometria");
            }
            else if(cboCursos.SelectedItem.ToString() == "Fisica") {
                lstCursos.Items.Clear();

                lstCursos.Items.Add("Movimiento Rectilineo Uniforme");
                lstCursos.Items.Add("Movimiento Rectilineo Uniformente Acelerado");
                lstCursos.Items.Add("Dinamica");
            }
            else if(cboCursos.SelectedItem.ToString() == "Calculo") {
                lstCursos.Items.Clear();

                lstCursos.Items.Add("Diferencial");
                lstCursos.Items.Add("Integral");
                lstCursos.Items.Add("Vectorial");
            }
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

        private void btnCerrar_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Esta Seguro De Cerrar El Programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                Application.Exit();
            }
        }
    }
}
