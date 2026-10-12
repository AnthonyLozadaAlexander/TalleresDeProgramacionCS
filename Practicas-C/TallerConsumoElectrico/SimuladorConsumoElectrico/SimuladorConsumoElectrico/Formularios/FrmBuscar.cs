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
        }

        public string Cliente { get => cliente; set => cliente = value; }

        private void btnBuscar_Click(object sender, EventArgs e) {

        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
