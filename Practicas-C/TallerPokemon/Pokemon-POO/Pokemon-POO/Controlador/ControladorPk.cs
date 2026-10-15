using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokemon_POO;
using Pokemon_POO.Formularios;

namespace Pokemon_POO.Controlador {

    public class ControladorPk {
        private FrmMenu vista;
        private FrmRegistrar registrar;

        private FrmDuelo duelo;

        public ControladorPk(FrmMenu vista, FrmRegistrar registrar, FrmDuelo duelo) {
            this.vista = vista;
            this.registrar = registrar;
            this.duelo = duelo;
            configurarTablaPokemon();


            Vista.RegistrarM.Click += (s, e) => mostrarRegistrar();
            // Registrar.agregarR().Click += (s, e)
            Registrar.menuR().Click += (s, e) => Registrar.Hide(); 


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

        private void agregarPokemon() {

        }

        private void configurarTablaPokemon() {
            var colorFondo = Color.FromArgb(240, 240, 240); // Usa el color de tu panel
            Registrar.tablaPokemons().ReadOnly = true;
            Registrar.tablaPokemons().Font = new Font("Montserrat", 7, FontStyle.Bold);
            Registrar.tablaPokemons().BorderStyle = BorderStyle.None;
            
            Registrar.tablaPokemons().BackgroundColor = colorFondo;
            Registrar.tablaPokemons().DefaultCellStyle.BackColor = colorFondo;
            Registrar.tablaPokemons().RowsDefaultCellStyle.BackColor = colorFondo;
            Registrar.tablaPokemons().AlternatingRowsDefaultCellStyle.BackColor = colorFondo;

            Registrar.tablaPokemons().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Registrar.tablaPokemons().Columns.Add("Nombre", "Nombre");
            Registrar.tablaPokemons().Columns.Add("Tipo", "Tipo");
            Registrar.tablaPokemons().Columns.Add("Nivel", "Nivel");
            Registrar.tablaPokemons().Columns.Add("Vida", "Vida");
            Registrar.tablaPokemons().Columns.Add("Ataque", "Ataque");

        }


        public FrmDuelo Duelo { 
            get => duelo;
        }

       

        private void mostrarRegistrar() {
            mostrarFrm(Registrar);
        }

        private void mostrarFrm(Form p) {

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
