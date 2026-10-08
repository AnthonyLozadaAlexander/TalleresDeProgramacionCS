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
        private List<Empleado> empleadosEmpresa = new List<Empleado>();
        private bool esGerente = false;
        private bool esVendedor = false;

        public bool EsGerente { get => esGerente; set => esGerente = value; }
        public bool EsVendedor { get => esVendedor; set => esVendedor = value; }
        public List<Empleado> EmpleadosEmpresa { get => empleadosEmpresa; set => empleadosEmpresa = value; }

        public Formulario() {
            InitializeComponent();
            CenterToScreen();
            MaximizeBox = false;
            BackColor = Color.White;
            txtBonoAsignado.Enabled = false;
            configurarTabla();
        }

        public DataGridView getTabla() {
            return tabla;
        }


        private void configurarTabla() {
            tabla.Columns.Clear();

            tabla.Font = new Font("Cascadia Code", 10, FontStyle.Bold);
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

            tabla.Rows.Add(e.Nombre, e.SueldoBase, e.Id, e.Cedula, e.Cargo,((e is Gerente) ? ((Gerente)e).Bono : 0), (e is Vendedor) ? ((Vendedor)e).TotalVentas : 0 , ( e is Gerente) ? ((Gerente)e).calcularPagoFinal() : (e is Vendedor) ? ((Vendedor)e).calcularPagoFinal() : 0);
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

            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtID.Text) || String.IsNullOrEmpty(txtCedula.Text) || String.IsNullOrEmpty(txtSueldoBase.Text)) {
                MessageBox.Show("Error: Debe Ingresar Valores En Todos Los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


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
                if (String.IsNullOrEmpty(txtBonoAsignado.Text)) {
                    MessageBox.Show("Error: Debe Ingresar Un Valor Para Bono Asignado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double bono = double.Parse(txtBonoAsignado.Text);
                
                agregarGerente(nombre, ID, cedula, cargo, sueldoBase, bono); // agregamos el gerente a la lista de empleados y a la tabla
                txtBonoAsignado.Clear();
                txtVentas.Clear();
            }
            else if(cargo == "Vendedor") {
                
                if (String.IsNullOrEmpty(txtVentas.Text)) {
                    MessageBox.Show("Error: Debe Ingresar Un Valor Para Total Ventas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                totalVentas = double.Parse(txtVentas.Text);

               
                agregarVendedor(nombre, ID, cedula, cargo, sueldoBase, totalVentas); // agregamos el vendedor a la lista de empleados y a la tabla
                txtBonoAsignado.Clear();
                txtVentas.Clear();
            }


        }

        private Boolean verificarDuplicado(List<Empleado> listaEmp, string cedula) {
            bool existe = false;
            return existe = listaEmp.Any(emp => emp.Cedula == cedula);
        }

        private void buscarCedula(String cedula) {

            if(empleadosEmpresa.Count == 0) {
                MessageBox.Show("No Hay Aun Empleados En La Empresa", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int index = -1;
            index = empleadosEmpresa.FindIndex(emp => emp.Cedula == cedula);
            if(index != -1) {
                MessageBox.Show($"Empleado Encontrado: " +
                    $"{Environment.NewLine} Nombre: {empleadosEmpresa[index].Nombre} " +
                    $"{Environment.NewLine} ID: {empleadosEmpresa[index].Id} " +
                    $"{Environment.NewLine} Cedula: {empleadosEmpresa[index].Cedula} " +
                    $"{Environment.NewLine} Cargo: {empleadosEmpresa[index].Cargo}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tabla.ClearSelection(); // limpia en la tabla el empleado encontrado seleccionado
                tabla.Rows[index].Selected = true; // selecciona el empleado encontrado en la tabla
            }
            else {
                MessageBox.Show("Empleado No Existente En La Empresa",  "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            if(empleadosEmpresa.Count == 0) {
                MessageBox.Show("No hay aun empleados en la lista", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using(var ventanaBuscar = new Buscar()) { // usando la ventana de ingreso cedula para buscar un empleado por su cedula
                if (ventanaBuscar.ShowDialog() == DialogResult.OK) { // esperamos a que terminen de ingresar la cedula y se cierre la ventana
                    string cedula = ventanaBuscar.CedulaIngresada; // obtenemos la cedula atraves del getter de la ventana
                    buscarCedula(cedula);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e) {

            if (empleadosEmpresa.Count == 0) {
                MessageBox.Show("No hay aun empleados en la lista", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tabla.CurrentRow == null) {
                MessageBox.Show("Error: Debe Seleccionar Un Empleado Para Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = tabla.CurrentRow.Index;

            if (index < 0 || index >= empleadosEmpresa.Count) {
                MessageBox.Show("Error: Indice De Empleado No Valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Empleado empleadoSelect = empleadosEmpresa[index]; // tomamos la referencia del empleado de la lista de empleados 

            if(empleadoSelect is Gerente) {
                EsGerente = true;
                EsVendedor = false;
            }
            else {
                EsGerente = false;
                EsVendedor = true;
            }

            using (Modificar frmModificar = new Modificar(empleadoSelect, this)) {
                var result = frmModificar.ShowDialog();
                if(result == DialogResult.OK) {
                    // El empleado ha sido modificado correctamente
                    Empleado empleadoModificado = frmModificar.EmpleadoReferencia; // actualizamos la referencia del empleado con los cambios realizados en el formulario de modificación

                    empleadosEmpresa.RemoveAt(index); // eliminamos el empleado original de la lista de empleados

                    empleadosEmpresa.Insert(index, empleadoModificado); // insertamos el empleado modificado en la lista de empleados en la misma posición)
              

                    actualizarFila(empleadosEmpresa, index);
                }
            }          
            
        }

        private void actualizarFila(List<Empleado> e, int index) {
            
            tabla.Rows[index].Cells["Nombre"].Value = e[index].Nombre;
            tabla.Rows[index].Cells["SueldoBase"].Value = e[index].SueldoBase;
            tabla.Rows[index].Cells["ID"].Value = e[index].Id;
            tabla.Rows[index].Cells["Cedula"].Value = e[index].Cedula;
            tabla.Rows[index].Cells["Cargo"].Value = e[index].Cargo;
            if (e[index] is Gerente gerente) {
                tabla.Rows[index].Cells["Bono"].Value = gerente.Bono;
                tabla.Rows[index].Cells["TotalVentas"].Value = 0; // Los gerentes no tienen ventas
                tabla.Rows[index].Cells["PagoFinal"].Value = gerente.calcularPagoFinal();
            }
            else if (e[index] is Vendedor vendedor) {
                tabla.Rows[index].Cells["Bono"].Value = 0; // Los vendedores no tienen bono
                tabla.Rows[index].Cells["TotalVentas"].Value = vendedor.TotalVentas;
                tabla.Rows[index].Cells["PagoFinal"].Value = vendedor.calcularPagoFinal();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            txtNombre.Clear();
            txtID.Clear();
            txtCedula.Clear();
            txtSueldoBase.Clear();
            txtBonoAsignado.Clear();
            txtVentas.Clear();
            rdbVendedor.Checked = false;
            rbdGerente.Checked = false;


        }
    }
}
