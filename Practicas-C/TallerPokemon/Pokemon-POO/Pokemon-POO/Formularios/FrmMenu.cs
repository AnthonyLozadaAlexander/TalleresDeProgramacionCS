using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_POO {
    public partial class FrmMenu : Form {
        public FrmMenu() {
            InitializeComponent();
            CenterToScreen();
            
        }

        public Button RegistrarM => btnRegistrar;

        public Button DuelosM => btnDuelos;

        public Button SalirM => btnSalir;

        public Panel contenedor() => panelMostrar;
    }
}
