using SimuladorConsumoElectrico.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorConsumoElectrico.Formularios {
    public partial class FrmBuscar : Form {


        private string cliente;

        public FrmBuscar() {
            InitializeComponent();
            CenterToScreen();
        }

        public string Cliente { get => cliente; set => cliente = value; }

        private void btnBuscar_Click(object sender, EventArgs e) {

            if (!String.IsNullOrWhiteSpace(txtNombre.Text)) {
                Cliente = txtNombre.Text.Trim();
                DialogResult = DialogResult.OK;
                Close();
            }
            else {
                MessageBox.Show("Por favor, ingrese un nombre válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
