using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokemon_POO;
using Pokemon_POO.Formularios;
using Pokemon_POO.Modelos;

namespace Pokemon_POO.Controlador {

    public class ControladorPk {

        private int indexSeleccionado;
        private FrmMenu vista;
        private FrmRegistrar registrar;
        private FrmDuelo duelo;

        public ControladorPk(FrmMenu vista, FrmRegistrar registrar, FrmDuelo duelo) {

            this.vista = vista;
            this.registrar = registrar;
            this.duelo = duelo;
            configurarTablaPokemon();

            Vista.RegistrarM.Click += (s, e) => mostrarFormulario(Registrar);
            Registrar.agregarR().Click += (s, e) => agregarPokemon();
            Registrar.VerLista().Click += (s, e) => verLista();

            Registrar.tablaPokemons().CellClick += (s, e) => {
                if (e.RowIndex >= 0) {
                    indexSeleccionado = e.RowIndex;
                    MessageBox.Show($"{TListaPokemon.ListaPokemon[indexSeleccionado].PokeDesc()}", "Informacion Del Pokemon Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            Registrar.menuR().Click += (s, e) => Registrar.Hide();

            Vista.DuelosM.Click += (s, e) => {
                mostrarFormulario(Duelo);
                cargarComboPokemon();
            };

            Duelo.MENU().Click += (s, e) => Duelo.Hide();

            Duelo.cboPK1.SelectedIndexChanged += (s, e) => {
                Pokemon pSeleccionado = (Pokemon) Duelo.cboPK1.SelectedItem;
                if (pSeleccionado == null) {
                    Duelo.HP1.Text = "-";
                    return;
                }

                Duelo.HP1.Text = pSeleccionado.Vida.ToString();
            };

            Duelo.cboPK2.SelectedIndexChanged += (s, e) => {
                Pokemon pSeleccionado = (Pokemon)Duelo.cboPK2.SelectedItem;
                if (pSeleccionado == null) {
                    Duelo.HP2.Text = "-";
                    return;
                }
                Duelo.HP2.Text = pSeleccionado.Vida.ToString();
            };

            // Evento para reiniciar la salud de los Pokemons seleccionados
            vista.SalirM.Click += (s, e) => Salir();

        }

        public FrmMenu Vista { 
            get => vista;
        }

        public void Salir() {
            DialogResult confirm = MessageBox.Show("Esta Seguro De Salir?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (confirm.Equals(DialogResult.Yes)) {
                Application.Exit();
            }
        }

        public FrmRegistrar Registrar {
            get => registrar;
        }

        public void verLista() {
            using ( FrmLista lista = new FrmLista()){
                lista.ShowDialog();
            }
        }

        private bool validarCampos() {
            if (string.IsNullOrWhiteSpace(Registrar.TxtNombreR().Text) ||
                string.IsNullOrWhiteSpace(Registrar.TxtNivelR().Text) ||
                string.IsNullOrWhiteSpace(Registrar.TxtVidaR().Text) ||
                string.IsNullOrWhiteSpace(Registrar.TxtEspecieR().Text) ||
                string.IsNullOrWhiteSpace(Registrar.TxtAtaqueR().Text) ||
                string.IsNullOrWhiteSpace(Registrar.TxtDefensaR().Text) ||
                string.IsNullOrEmpty(Registrar.CboPokemonR().SelectedItem?.ToString())) {
                return false;
            }
            return true;
        }

        private void agregarPokemon() {
            try {

                if (!validarCampos()) {
                    MessageBox.Show("Error: Complete Todos Los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {

                    string nombre = Registrar.TxtNombreR().Text;
                    int nivel = int.Parse(Registrar.TxtNivelR().Text);
                    int vida = int.Parse(Registrar.TxtVidaR().Text);
                    string especie = Registrar.TxtEspecieR().Text;
                    int ataque = int.Parse(Registrar.TxtAtaqueR().Text);
                    int defensa = int.Parse(Registrar.TxtDefensaR().Text);
                    string tipo = Registrar.CboPokemonR().SelectedItem.ToString();

                    if (verificarDuplicado(TListaPokemon.ListaPokemon, nombre)) {
                        MessageBox.Show("Error: Ya Existe Un Pokemon Con Ese Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Crear el objeto Pokemon correspondiente según el tipo seleccionado
                    Pokemon p = crearPokemon(nombre, tipo, nivel, vida, especie, ataque, defensa);

                    if (p == null) {
                        MessageBox.Show("Error: Tipo de Pokemon No Valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    TListaPokemon.AgregarPokemon(p);
                    agregarFilaTabla(p);
                }
            }catch(FormatException) {
                MessageBox.Show("Error: Ingrese Valores Numericos En Los Campos De Nivel, Vida, Ataque Y Defensa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Pokemon crearPokemon(string nombre, string tipo, int nivel, int vida, string especie, int ataque, int defensa) {
            switch (tipo) {
                case "Fuego":
                    return new PokemonFuego(nombre, tipo, nivel, vida, especie, ataque, defensa);
                case "Agua":
                    return new PokemonAgua(nombre, tipo, nivel, vida, especie, ataque, defensa);
                case "Planta":
                    return new PokemonPlanta(nombre, tipo, nivel, vida, especie, ataque, defensa);
                case "Electrico":
                    return new PokemonElectrico(nombre, tipo, nivel, vida, especie, ataque, defensa);
                case "Tierra":
                    return new PokemonTierra(nombre, tipo, nivel, vida, especie, ataque, defensa);
                default:
                    return null;
            }
        }

        private bool verificarDuplicado(List<Pokemon> listaP, string nombre) => listaP.Any(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)); 

        private void configurarTablaPokemon() {
            var colorFondo = Color.White;
            Registrar.tablaPokemons().ReadOnly = true;
            Registrar.tablaPokemons().Font = new Font("Montserrat", 7, FontStyle.Bold);
            Registrar.tablaPokemons().BorderStyle = BorderStyle.FixedSingle;
            
            Registrar.tablaPokemons().BackgroundColor = colorFondo;
            Registrar.tablaPokemons().DefaultCellStyle.BackColor = colorFondo;
            Registrar.tablaPokemons().RowsDefaultCellStyle.BackColor = colorFondo;
            Registrar.tablaPokemons().AlternatingRowsDefaultCellStyle.BackColor = colorFondo;

            Registrar.tablaPokemons().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Registrar.tablaPokemons().Columns.Add("Tipo", "Tipo");
            Registrar.tablaPokemons().Columns.Add("Nombre", "Nombre");
            Registrar.tablaPokemons().Columns.Add("Especie", "Especie");
            Registrar.tablaPokemons().Columns.Add("Ataque", "Ataque");
            Registrar.tablaPokemons().Columns.Add("Nivel", "Nivel");
            Registrar.tablaPokemons().Columns.Add("Defensa", "Defensa");
            Registrar.tablaPokemons().Columns.Add("Vida", "Vida");
        }

        private void agregarFilaTabla(Pokemon p) {
            Registrar.tablaPokemons().Rows.Add(p.Tipo, p.Nombre, p.Especie, p.Ataque, p.Nivel, p.Defensa, p.Vida);
        }


        public FrmDuelo Duelo { 
            get => duelo;
        }

        private void cargarComboPokemon() {
            duelo.cboPK1.Items.Clear(); duelo.cboPK2.Items.Clear();

            foreach (Pokemon p in TListaPokemon.ListaPokemon) {
                Duelo.cboPK1.Items.Add(p);
                Duelo.cboPK2.Items.Add(p);
            }
        }

        private void mostrarFormulario(Form p) {
            /// limpiamos el panel contenedor antes de mostrar otro Ejercicio
            if (this.vista.contenedor().Controls.Count > 0) {
                this.vista.contenedor().Controls.RemoveAt(0);
            }

            // configuramos las propiedades del formulario a mostrar
            p.TopLevel = false;
            p.FormBorderStyle = FormBorderStyle.None;
            p.Dock = DockStyle.None;

            // Centrar el formulario dentro del panel contenedor
            // la anchura del panel contenedor - menos la anchura del panel ejercicio / 2
            int x = (this.vista.contenedor().Width - p.Width) / 2;

            // la altura del panel contenedor - menos la altura del panel ejercicio / 2
            int y = (this.vista.contenedor().Height - p.Height) / 2;
            p.Location = new Point(x, y);

            /// Agregamos  el ejercicio al panel  contenedor
            this.vista.contenedor().Controls.Add(p);
            this.vista.contenedor().Tag = p;
            p.Show();
        }   

    }

    
}
