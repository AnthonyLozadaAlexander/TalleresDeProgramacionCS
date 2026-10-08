using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaNominaPolimorfica.Clases;
using SistemaNominaPolimorfica.Formularios;

namespace SistemaNominaPolimorfica.Formularios {
    public partial class Modificar : Form {
        public Modificar() {
            InitializeComponent();
            CenterToScreen();
            MaximizeBox = false;
        }

        public Modificar(Empleado emp, Formulario main) {
            InitializeComponent();
            CenterToScreen();
            MaximizeBox = false;
            this.main = main;

            if(emp is Gerente) {
                txtVendedor.Text = "False";
                txtGerente.Text = "True";
                txtVentas.Enabled = false; // Deshabilitar el campo de ventas para un gerente
                txtBonoAsignado.Enabled = true; // Habilitar el campo de bono para un gerente
            }
            else if (emp is Vendedor){
                txtVendedor.Text = "True";
                txtGerente.Text = "False";
                txtBonoAsignado.Enabled = false; // Deshabilitar el campo de bono para un vendedor
                txtVentas.Enabled = true; // Habilitar el campo de ventas para un vendedor
            }

            // Inicializar los campos del formulario con los datos del empleado
            txtNombre.Text = emp.Nombre;
            txtID.Text = emp.Id;
            txtCedula.Text = emp.Cedula;
            txtSueldoBase.Text = emp.SueldoBase.ToString();
            String cargo = emp.Cargo;
            txtBonoAsignado.Text = (emp is Gerente) ? ((Gerente) emp).Bono.ToString() : "0";
            txtVentas.Text = (emp is Vendedor) ? ((Vendedor)emp).TotalVentas.ToString() : "0";
        }


        private Formulario main; // referencia al formulario principal

        private Empleado empleado; // referencia al empleado que se va a modificar

        public Empleado EmpleadoReferencia { get => empleado; set => empleado = value; }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            

            if (main.EsVendedor == true) {
                
                String nombre = txtNombre.Text;
                String id = txtID.Text;
                String cedula = txtCedula.Text;
                double sueldoBase = double.Parse(txtSueldoBase.Text);
                double totalVentas = double.Parse(txtVentas.Text);

                Vendedor vendedor = new Vendedor(nombre, 
                    sueldoBase, 
                    id, 
                    cedula,
                    "Vendedor" ,
                    totalVentas);

                EmpleadoReferencia = vendedor;


                cerrarModificar();

            }
            else if (main.EsGerente == true){
                String nombre = txtNombre.Text;
                String id = txtID.Text;
                String cedula = txtCedula.Text;
                double sueldoBase = double.Parse(txtSueldoBase.Text);
                double bono = double.Parse(txtBonoAsignado.Text);

                Gerente gerente = new Gerente(
                    nombre, 
                    sueldoBase, 
                    id, 
                    cedula, 
                    "Gerente", 
                    bono);

                EmpleadoReferencia = gerente;

                cerrarModificar();
            }
        }

        private void cerrarModificar() {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
