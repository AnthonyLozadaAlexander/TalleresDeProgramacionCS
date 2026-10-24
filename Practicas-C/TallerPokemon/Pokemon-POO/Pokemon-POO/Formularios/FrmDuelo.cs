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

        public TextBox HP1 => txtHP1;

        public TextBox HP2 => txtHP2;

        public ComboBox cboPK1 => cboPokemon1;

        public ComboBox cboPK2 => cboPokemon2;
    }
}
