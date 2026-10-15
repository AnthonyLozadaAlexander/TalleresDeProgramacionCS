using Pokemon_POO.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_POO.Controlador {
    public static class TListaPokemon {

        private static List<Pokemon> listaPokemon = new List<Pokemon>();

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

    }
}
