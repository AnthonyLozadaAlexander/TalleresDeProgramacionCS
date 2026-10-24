using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_POO.Modelos {
    public abstract class Pokemon {

        private string nombre;
        private string tipo;
        private int nivel;
        private int vida;
        private string especie;

        private int ataque;

        private int defensa;

        public Pokemon(string nombre, string tipo, int nivel, int vida, string especie, int ataque, int defensa) {
            this.nombre = nombre;
            this.tipo = tipo;
            this.nivel = nivel;
            this.vida = vida;
            this.especie = especie;
            this.ataque = ataque;
            this.defensa = defensa;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Vida { get => vida; set => vida = value; }
        public string Especie { get => especie; set => especie = value; }
        public int Ataque { get => ataque; set => ataque = value; }
        public int Defensa { get => defensa; set => defensa = value; }

        public abstract string TipoAtaque(); 

        public virtual string PokeDesc() {
            return $" Nombre: {Nombre} {Environment.NewLine} Tipo: {Tipo} {Environment.NewLine} Nivel: {Nivel} {Environment.NewLine} Vida: {Vida} {Environment.NewLine} Especie: {Especie}";
        }

        public virtual void Atacar(Pokemon enemigo) {
            int danio = Ataque - enemigo.defensa;
            if(danio < 0) {
                danio = 0;
            }

            enemigo.RecibirDanio(danio);
        }

        public virtual void RecibirDanio(int cantidad) {
            Vida = Vida - cantidad;
            if(Vida < 0) {
                Vida = 0;
            }
        }

        public override string ToString() {
            return $"Nombre: {Nombre}";
        }


    }
}
