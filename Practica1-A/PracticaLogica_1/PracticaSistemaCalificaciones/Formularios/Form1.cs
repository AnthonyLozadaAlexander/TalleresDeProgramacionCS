using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaSistemaCalificaciones {
    public partial class Formulario : Form {
        public Formulario() {
            InitializeComponent();
            CenterToScreen();
            MinimizeBox = false;
            tabla.BorderStyle = BorderStyle.None;
            BackColor = Color.White;
            tabla.Font = new Font("Cascadia Code", 11, FontStyle.Bold);
            configurarTabla();

        }

        private void btnSalir_Click(object sender, EventArgs e) {

            DialogResult opc = MessageBox.Show("Desea Salir Del Sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if(opc == DialogResult.Yes) {
                Application.Exit();
            }

        }

        public void configurarTabla() {
            tabla.AutoGenerateColumns = false;
            tabla.Columns.Clear();

            tabla.Columns.Add("Nombre", "Nombre");
            tabla.Columns.Add("Edad", "Edad");
            tabla.Columns.Add("Cedula", "Cedula");
            tabla.Columns.Add("Turno", "Turno");
            tabla.Columns.Add("Nota 1", "Nota 1");
            tabla.Columns.Add("Nota 2", "Nota 2");
            tabla.Columns.Add("Nota 3", "Nota 3");
            tabla.Columns.Add("Promedio Final", "Promedio Final");
        }
        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void Formulario_Load(object sender, EventArgs e) {

        }

        private void txtNombrE(object sender, EventArgs e) {

        }

        private void btnAgregaR(object sender, EventArgs e) {

        }

        private void btnEliminar_Click(object sender, EventArgs e) {

        }

        private void btnModificar_Click(object sender, EventArgs e) {

        }

        private void txtNota3_TextChanged(object sender, EventArgs e) {

        }

        private void txtNota2_TextChanged(object sender, EventArgs e) {

        }

        private void txtNota1_TextChanged(object sender, EventArgs e) {

        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

    }
}
