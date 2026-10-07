using SistemaNominaPolimorfica.Clases; //  importa las clases Empleado, Gerente y Vendedor
using SistemaNominaPolimorfica.Formularios; // importa la clase IngresoCedula
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNominaPolimorfica {
    public partial class Formulario : Form {
        List<Empleado> empleadosEmpresa = new List<Empleado>();

        public Formulario() {
            InitializeComponent();
            CenterToScreen();
            MaximizeBox = false;
            BackColor = Color.White;
            txtBonoAsignado.Enabled = false;
            configurarTabla();
        }

        private void configurarTabla() {
            tabla.Columns.Clear();

            tabla.Columns.Add("Nombre", "Nombre");
            tabla.Columns["Nombre"].DataPropertyName = "Nombre";
            tabla.Columns.Add("SueldoBase", "Sueldo Base");
            tabla.Columns["SueldoBase"].DataPropertyName = "SueldoBase";
            tabla.Columns.Add("ID", "ID");
            tabla.Columns["ID"].DataPropertyName = "_ID";
            tabla.Columns.Add("Cedula", "Cédula");
            tabla.Columns["Cedula"].DataPropertyName = "Cedula";
            tabla.Columns.Add("Cargo", "Cargo");
            tabla.Columns["Cargo"].DataPropertyName = "Cargo";
            tabla.Columns.Add("Sueldo Base", "Sueldo Base");
            tabla.Columns["Sueldo Base"].DataPropertyName = "SueldoBase";
            tabla.Columns.Add("Bono", "Bono");
            tabla.Columns["Bono"].DataPropertyName = "Bono";
            tabla.Columns.Add("TotalVentas", "Total Ventas");
            tabla.Columns["TotalVentas"].DataPropertyName = "TotalVentas";
            tabla.Columns.Add("PagoFinal", "Pago Final");
            tabla.Columns["PagoFinal"].DataPropertyName = "PagoFinal";

            tabla.ReadOnly = true;
            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToDeleteRows = false;
            tabla.AllowUserToResizeRows = false;
            tabla.AllowUserToResizeColumns = false;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void rbdGerente_CheckedChanged(object sender, EventArgs e) {

            if (rbdGerente.Checked) {
                txtBonoAsignado.Enabled = true;
                txtVentas.Enabled = false;
            }
        }

        private void rdbVendedor_CheckedChanged(object sender, EventArgs e) {
            if (rdbVendedor.Checked) {
                txtBonoAsignado.Enabled = false;
                txtVentas.Enabled = true;
            }
        }

        private void agregarEmpleadoTabla(Empleado e) { 

            tabla.Rows.Add(e.Nombre, e.SueldoBase, e.Id, e.Cedula, e.Cargo, e.SueldoBase, ((e is Gerente) ? ((Gerente)e).Bono : 0), (e is Vendedor) ? ((Vendedor)e).TotalVentas : 0 , ( e is Gerente) ? ((Gerente)e).calcularPagoFinal() : (e is Vendedor) ? ((Vendedor)e).calcularPagoFinal() : 0);
        }

        private void agregarVendedor(String nombre, String ID, String cedula, String cargo, double sueldoBase, double totalVentas) {

            Vendedor v = new Vendedor(nombre, sueldoBase, ID, cedula, cargo, totalVentas);
            empleadosEmpresa.Add(v);
            agregarEmpleadoTabla(v);
        }

        private void agregarGerente(String nombre, String ID, String cedula, String cargo, double sueldoBase, double Bono) {
            Gerente g = new Gerente(nombre, sueldoBase, ID, cedula, cargo, Bono);
            empleadosEmpresa.Add(g);
            agregarEmpleadoTabla(g);
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {


            string nombre = txtNombre.Text;
            string ID = txtID.Text;
            string cedula = txtCedula.Text;
            string cargo = rdbVendedor.Checked ? "Vendedor" : "Gerente";
            double sueldoBase = double.Parse(txtSueldoBase.Text);
            double totalVentas = 0.0;

            if(verificarDuplicado(empleadosEmpresa, cedula)) {
                MessageBox.Show("Error: Ya Existe Una Cedula Identica",  "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cargo == "Gerente") {
                double bono = double.Parse(txtBonoAsignado.Text);
                txtVentas.Clear();
                agregarGerente(nombre, ID, cedula, cargo, sueldoBase, bono);
            }else if(cargo == "Vendedor") {
                txtBonoAsignado.Clear();

                if (String.IsNullOrEmpty(txtVentas.Text)) {
                    MessageBox.Show("Error: Debe Ingresar Un Valor Para Total Ventas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                totalVentas = double.Parse(txtVentas.Text);

                

                agregarVendedor(nombre, ID, cedula, cargo, sueldoBase, totalVentas);
            }


        }

        private Boolean verificarDuplicado(List<Empleado> listaEmp, string cedula) {
            bool existe = false;
            return existe = listaEmp.Any(emp => emp.Cedula == cedula);
        }

        private void buscarCedula(String cedula) {
            int index = -1;
            index = empleadosEmpresa.FindIndex(emp => emp.Cedula == cedula);
            if(index != -1) {
                MessageBox.Show($"Empleado Encontrado: " +
                    $"{Environment.NewLine} {empleadosEmpresa[index].Nombre} " +
                    $"{Environment.NewLine} {empleadosEmpresa[index].Id} " +
                    $"{Environment.NewLine} {empleadosEmpresa[index].Cedula} " +
                    $"{Environment.NewLine} {empleadosEmpresa[index].Cargo}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tabla.ClearSelection(); // limpia en la tabla el empleado encontrado seleccionado
                tabla.Rows[index].Selected = true; // selecciona el empleado encontrado en la tabla
            }
            else {
                MessageBox.Show("Empleado No Existente En La Empresa",  "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            using(var ventanaBuscar = new IngresoCedula()) { // usando la ventana de ingreso cedula para buscar un empleado por su cedula
                if (ventanaBuscar.ShowDialog() == DialogResult.OK) { // esperamos a que terminen de ingresar la cedula y se cierre la ventana
                    string cedula = ventanaBuscar.CedulaIngresada; // obtenemos la cedula atraves del getter de la ventana
                    buscarCedula(cedula);
                }
            }
        }
    }
}
