using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNominaPolimorfica.Formularios {
    public partial class IngresoCedula : Form {
        public IngresoCedula() {
            InitializeComponent();
            CenterToScreen();
            MaximizeBox = false;
        }

        private String cedulaIngresada;

        public string CedulaIngresada { get => cedulaIngresada; set => cedulaIngresada = value; }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            if(String.IsNullOrEmpty(txtCedula.Text)) {
                MessageBox.Show("Por favor, ingrese una cédula válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CedulaIngresada = txtCedula.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
