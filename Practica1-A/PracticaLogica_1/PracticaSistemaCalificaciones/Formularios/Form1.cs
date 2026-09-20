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

            String cedula = "";
            String nombre = "";
            int edad = 0;

            if (!validaciones()) {    // validaciones basicas de los campos del formulario
                return;
            }
            
            if(!(Regex.IsMatch(txtNombre.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))) {
                MessageBox.Show("Debe ingresar un formato valido para el nombre (No Numerico)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            
            if(!(Regex.IsMatch(txtEdad.Text, regexEntero))) {
                MessageBox.Show("Debe ingresar un formato valido para la edad (Numerico)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            if (!(Regex.IsMatch(txtCedula.Text, regexEntero))){
                MessageBox.Show("Debe ingresar un formato valido para la cedula (Numerico)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            edad = Convert.ToInt16(txtEdad.Text);
            nombre = txtNombre.Text;
            cedula = txtCedula.Text;


            foreach(Alumno registro in alumnosList) {
                if(registro.Cedula == cedula) {
                    MessageBox.Show("Ya existe un alumno con la misma cedula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            String turno = cboTurno.SelectedItem.ToString();

            if (!(Regex.IsMatch(txtNota1.Text, regexDecimal))) {
                MessageBox.Show("Debe ingresar un formato valido para la nota 1 (Decimal)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!(Regex.IsMatch(txtNota2.Text, regexDecimal))) {
                MessageBox.Show("Debe ingresar un formato valido para la nota 2 (Decimal)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(Regex.IsMatch(txtNota3.Text, regexDecimal))) {
                MessageBox.Show("Debe ingresar un formato valido para la nota 3 (Decimal)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // .Replace('.', ',') evita el error de formato decimal por el sistema de idioma
            
            double nota1 = Convert.ToDouble(txtNota1.Text.Replace('.', ','));
            double nota2 = Convert.ToDouble(txtNota2.Text.Replace('.', ','));
            double nota3 = Convert.ToDouble(txtNota3.Text.Replace('.', ','));

            if(nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10 || nota3 < 0 || nota3 > 10) {
                MessageBox.Show("Las notas deben estar entre 0 y 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            Alumno a = new Alumno(nombre, edad, cedula, turno, nota1, nota2, nota3);
            alumnosList.Add(a);

            Double Promedio = a.calcularPromedio();

            tabla.Rows.Add(a.Nombre, a.Edad, a.Cedula, a.Turno, a.Nota1, a.Nota2, a.Nota3, Promedio.ToString("F2"));

            Console.WriteLine("Info Del Alumno: " + a.mostrarInformacion());
            totalAlumnos();


        }

        private bool validaciones() {
            if (cboTurno.SelectedIndex == -1) {
                MessageBox.Show("Debe Seleccionar Un Turno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; 
            }

            if(txtNombre.Text == "" || String.IsNullOrWhiteSpace(txtNombre.Text)) {
                MessageBox.Show("Debe Ingresar Un Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if(txtEdad.Text == "" || String.IsNullOrWhiteSpace(txtEdad.Text)) {
                MessageBox.Show("Debe Ingresar Una Edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if(txtCedula.Text == "" || String.IsNullOrWhiteSpace(txtCedula.Text)) {
                MessageBox.Show("Debe Ingresar Una Cedula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if(txtNota1.Text == "" || String.IsNullOrWhiteSpace(txtNota1.Text)) {
                MessageBox.Show("Debe Ingresar Una Nota 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if(txtNota2.Text == "" || String.IsNullOrWhiteSpace(txtNota2.Text)) {
                MessageBox.Show("Debe Ingresar Una Nota 2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if(txtNota3.Text == "" || String.IsNullOrWhiteSpace(txtNota3.Text)) {
                MessageBox.Show("Debe Ingresar Una Nota 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e) {

            if (alumnosList.Count == 0) {
                MessageBox.Show("No hay alumnos en el Sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(tabla.CurrentRow == null || tabla.CurrentRow.IsNewRow) {
                MessageBox.Show("Debe seleccionar un alumno para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int index = tabla.CurrentRow.Index;
            alumnosList.RemoveAt(index);
            tabla.Rows.RemoveAt(index);
            totalAlumnos();
        }

        public void totalAlumnos() {
            txtTotal.Text = alumnosList.Count().ToString();
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
