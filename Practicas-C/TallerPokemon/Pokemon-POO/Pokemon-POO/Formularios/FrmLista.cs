using Pokemon_POO.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokemon_POO.Modelos;


namespace Pokemon_POO.Formularios {
    public partial class FrmLista : Form {
        public FrmLista() {
            InitializeComponent();
            CenterToScreen();
            LPokemon.MultiColumn = false;
            LPokemon.ScrollAlwaysVisible = true;
        }

        private void btnListar_Click(object sender, EventArgs e) {
            LPokemon.Items.Clear();

            foreach(Pokemon p in TListaPokemon.ListaPokemon) {
                LPokemon.Items.Add(p.PokeDesc());
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LPokemon_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
