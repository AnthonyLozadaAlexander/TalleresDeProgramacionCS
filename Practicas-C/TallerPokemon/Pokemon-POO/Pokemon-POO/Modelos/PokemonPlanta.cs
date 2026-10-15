using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_POO.Modelos {
    public class PokemonPlanta : Pokemon {

        private string debilidad;
        private string inmunidad;

        public PokemonPlanta(string nombre, string tipo, int nivel, int vida, string especie, int ataque, int defensa) : base(nombre, tipo, nivel, vida, especie, ataque, defensa) {
            this.debilidad = "Fuego/Hielo";
            this.inmunidad = "Ninguna";
        }
    }
}
