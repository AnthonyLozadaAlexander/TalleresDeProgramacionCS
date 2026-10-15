using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_POO.Modelos {
    public class PokemonTierra : Pokemon {

        private string debilidad;
        private string inmunidad;
        public PokemonTierra(string nombre, string tipo, int nivel, int vida, string especie, int ataque, int defensa) : base(nombre, tipo, nivel, vida, especie, ataque, defensa) {
            this.debilidad = "Agua/Hielo";
            this.inmunidad = "Electricidad";
        }
        public string Debilidad { get => debilidad; set => debilidad = value; }
        public string Inmunidad {
            get => inmunidad; set => inmunidad = value;
        }


    }
}
