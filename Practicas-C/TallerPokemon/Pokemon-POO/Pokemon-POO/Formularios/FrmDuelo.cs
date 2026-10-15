using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_POO.Formularios {
    public partial class FrmDuelo : Form {
        public FrmDuelo() {
            InitializeComponent();
            CenterToScreen();
        }

        public GroupBox contenedorSeleccionar() => gbSeleccionar;

        public GroupBox contenedorHistorial() => gpHistorial;

        public Button MENU() => btnMenu;

        public Button Atacar() => btnAtacar;

        public Button ReiniciarSalud() => btnReiniciarHP;

        private void gbSeleccionar_Enter(object sender, EventArgs e) {

        }
    }
}
