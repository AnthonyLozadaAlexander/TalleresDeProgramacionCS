using Pokemon_POO.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_POO.Controlador {
    public static class TListaPokemon {

        private static List<Pokemon> listaPokemon = new List<Pokemon>();

        private static bool datosCargados = false;

        public static List<Pokemon> ListaPokemon {
            get => listaPokemon;
        }

        public static void AgregarPokemon(Pokemon p) {
            ListaPokemon.Add(p);
        }

        public static void ModificarPokemon(int index, Pokemon p) {
            ListaPokemon[index] = p;
        }

        public static void EliminarPokemon(int index) {
            ListaPokemon.RemoveAt(index);
        }

        public static int BuscarPokemon(string nombre) {
            int index = ListaPokemon.FindIndex(p => p.Nombre.Equals(nombre));
            return index;
        }

        public static void Datos() {
            if (!datosCargados) {
                PokemonElectrico pikachu = new PokemonElectrico("Pikachu", "Eléctrico", 5, 100, "Ratón Eléctrico", 20, 10);
                PokemonFuego charmander = new PokemonFuego("Charmander", "Fuego", 5, 100, "Lagartija de Fuego", 25, 8);

                AgregarPokemon(pikachu);
                AgregarPokemon(charmander);
            }

            datosCargados = true;
        }

    }
}
