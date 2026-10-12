using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorConsumoElectrico {
    public partial class FrmPrincipal : Form {
        public FrmPrincipal() {
            InitializeComponent();
            CenterToScreen();
            btnCalcular.BackColor = Color.White;
            btnCalcular.Enabled = false;
            configurarTabla();
        }

        private void configurarTabla() {
            dvgFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgFactura.Columns.Add("Cliente", "Cliente");
            dvgFactura.Columns.Add("Categoria", "Categoria");
            dvgFactura.Columns.Add("Kwh", "Kwh");
            dvgFactura.Columns.Add("TarifaBase", "Tarifa Base");
            dvgFactura.Columns.Add("SubTotal", "Sub Total");
            dvgFactura.Columns.Add("Recargo", "Recargo");
            dvgFactura.Columns.Add("Total", "Total");
        }

        private void txtTitular_TextChanged(object sender, EventArgs e) {
            btnCalcular.Enabled = activarBotonCalcular();
        }


        // debe estar haber texto en txtTitular y txtConsumo para que se active botonCalcular
        private bool activarBotonCalcular() {
            bool datosCompletados = !String.IsNullOrWhiteSpace(txtTitular.Text) && !String.IsNullOrWhiteSpace(txtConsumo.Text);
            return datosCompletados;
        }

        private void txtConsumo_TextChanged(object sender, EventArgs e) {
            btnCalcular.Enabled = activarBotonCalcular();
        }

        private void btnCalcular_Click(object sender, EventArgs e) {

        }
    }
}
