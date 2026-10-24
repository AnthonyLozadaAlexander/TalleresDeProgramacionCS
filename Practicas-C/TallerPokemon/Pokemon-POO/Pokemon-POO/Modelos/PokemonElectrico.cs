using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_POO.Modelos {
    public class PokemonElectrico : Pokemon {

        private string debilidad;
        private string inmunidad;

        public PokemonElectrico(string nombre, string tipo, int nivel, int vida, string especie, int ataque, int defensa) : base(nombre, tipo, nivel, vida, especie, ataque, defensa) {
            this.debilidad = "Tierra";
            this.inmunidad = "Ninguna";
        }

        public string Debilidad { get => debilidad; set => debilidad = value; }
        public string Inmunidad { get => inmunidad; set => inmunidad = value; }

        public override string PokeDesc() {
            return base.PokeDesc() + $"{Environment.NewLine} Debilidad: {Debilidad} {Environment.NewLine} Inmunidad: {Inmunidad}";
        }

        public override string TipoAtaque() => "Impactrueno";
    }
}
