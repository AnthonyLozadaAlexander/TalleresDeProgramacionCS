using PracticaSistemaCalificaciones.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PracticaSistemaCalificaciones {
    public partial class Formulario : Form {
        List<Alumno> alumnosList = new List<Alumno>();
        String regexDecimal = @"^-?\d+([.,]\d+)?$";
        String regexEntero = @"^\d+$"; 

        public Formulario() {
            InitializeComponent();
            CenterToScreen();
            MinimizeBox = false;
            configurarTabla();
            configurarComboBox();
        }

        private void btnSalir_Click(object sender, EventArgs e) {

            DialogResult opc = MessageBox.Show("Desea Salir Del Sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if(opc == DialogResult.Yes) {
                Application.Exit();
            }

        }

        public void configurarComboBox() {
            cboTurno.Font = new Font("Cascadia Code", 11, FontStyle.Bold);
            cboTurno.Items.Add("Mañana");
            cboTurno.Items.Add("Tarde");
            cboTurno.Items.Add("Noche");
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList; // evitar que el usuario edite manualmente el comboBox
            
        }

        public void configurarTabla() {
            tabla.BorderStyle = BorderStyle.None;
            BackColor = Color.White;
            tabla.Font = new Font("Cascadia Code", 11, FontStyle.Bold);

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
        private void Formulario_Load(object sender, EventArgs e) {
            txtTotal.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }


        private void txtNombrE(object sender, EventArgs e) {

        }

        private void btnAgregaR(object sender, EventArgs e) {

            validaciones(); // validaciones basicas de los campos del formulario

            String nombre = txtNombre.Text;
            int edad = Convert.ToInt16(txtEdad.Text);
            String cedula = txtCedula.Text;

            if(!(Regex.IsMatch(cedula, regexEntero))){
                MessageBox.Show("Debe ingresar un formato valido para la cedula (Numerico)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach(Alumno registro in alumnosList) {
                if(registro.Cedula == cedula) {
                    MessageBox.Show("Ya existe un alumno con la misma cedula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            String turno = cboTurno.SelectedItem.ToString();

            double nota1 = Convert.ToDouble(txtNota1.Text);
            double nota2 = Convert.ToDouble(txtNota2.Text);
            double nota3 = Convert.ToDouble(txtNota3.Text);

            if (!(Regex.IsMatch(nota1.ToString(), regexDecimal))) {
                MessageBox.Show("Debe ingresar un formato valido para la nota 1 (Decimal)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!(Regex.IsMatch(nota2.ToString(), regexDecimal))) {
                MessageBox.Show("Debe ingresar un formato valido para la nota 2 (Decimal)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(Regex.IsMatch(nota3.ToString(), regexDecimal))) {
                MessageBox.Show("Debe ingresar un formato valido para la nota 3 (Decimal)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Alumno a = new Alumno(nombre, edad, cedula, turno, nota1, nota2, nota3);
            alumnosList.Add(a);

            Object Promedio = a.calcularPromedio();

            tabla.Rows.Add(a.Nombre, a.Edad, a.Cedula, a.Turno, a.Nota1, a.Nota2, a.Nota3, Promedio);

            Console.WriteLine("Info Del Alumno: " + a.mostrarInformacion());
            txtTotal.Text = alumnosList.Count().ToString();


        }

        private void validaciones() {
            if (cboTurno.SelectedIndex == -1) {
                MessageBox.Show("Debe Seleccionar Un Turno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(txtNombre.Text == "" || String.IsNullOrWhiteSpace(txtNombre.Text)) {
                MessageBox.Show("Debe Ingresar Un Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(txtEdad.Text == "" || String.IsNullOrWhiteSpace(txtEdad.Text)) {
                MessageBox.Show("Debe Ingresar Una Edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(txtCedula.Text == "" || String.IsNullOrWhiteSpace(txtCedula.Text)) {
                MessageBox.Show("Debe Ingresar Una Cedula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(txtNota1.Text == "" || String.IsNullOrWhiteSpace(txtNota1.Text)) {
                MessageBox.Show("Debe Ingresar Una Nota 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(txtNota2.Text == "" || String.IsNullOrWhiteSpace(txtNota2.Text)) {
                MessageBox.Show("Debe Ingresar Una Nota 2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(txtNota3.Text == "" || String.IsNullOrWhiteSpace(txtNota3.Text)) {
                MessageBox.Show("Debe Ingresar Una Nota 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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

        private void totalAlumnos(object sender, EventArgs e) {

        }
    }
}
