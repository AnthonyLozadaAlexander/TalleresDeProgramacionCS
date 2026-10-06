using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendiendoLINQ.Modelos {
    public class Producto {

        private int Id;
        private String nombre;
        private String categoria;

        private int stock;

        private double precio;

        public int ID { get => Id; set => Id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int Stock { get => stock; set => stock = value; }
        public double Precio { get => precio; set => precio = value; }

        public Producto(int iD, string nombre, string categoria, int stock, double precio) {
            ID = iD;
            Nombre = nombre;
            Categoria = categoria;
            Stock = stock;
            Precio = precio;
        }
    }
}
