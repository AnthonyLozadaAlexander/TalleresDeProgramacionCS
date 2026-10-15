using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_POO.Modelos {
    public class PokemonFuego : Pokemon {

        private String debilidad;
        private String inmunidad;

        public PokemonFuego(string nombre, string tipo, int nivel, int vida, string especie, int ataque, int defensa) : base(nombre, tipo, nivel, vida, especie, ataque, defensa) {
            this.debilidad = "Agua";
            this.inmunidad = "Fuego";
        }

        public string Debilidad { get => debilidad; set => debilidad = value; }
        public string Inmunidad { get => inmunidad; set => inmunidad = value; }

        public override void TipoAtaque() {
            MessageBox.Show("Tecnica Ignea");
        }

        public override string PokeDesc() {
            return base.PokeDesc() + $"{Environment.NewLine} Debilidad: {Debilidad} {Environment.NewLine} Inmunidad: {Inmunidad}";
        }

    }
}
