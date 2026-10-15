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
    public partial class FrmRegistrar : Form {
        public FrmRegistrar() {
            InitializeComponent();
        }

        public Button agregarR() => btnAgregar;

        public Button menuR() => btnMenuR;

        public DataGridView tablaPokemons() => dvgRegistros;

        public TextBox TxtNombreR() => txtNombre;

        public TextBox TxtNivelR() => txtNivel;

        public TextBox TxtVidaR() => txtVida;

        public TextBox TxtAtaqueR() => txtAtaque;

        public TextBox TxtDefensaR() => txtDefensa;

        public TextBox TxtEspecieR() => txtEspecie;

        public ComboBox CboPokemonR() => cboPokemonsR;

        public Button VerLista() => btnLista;
    }
}
