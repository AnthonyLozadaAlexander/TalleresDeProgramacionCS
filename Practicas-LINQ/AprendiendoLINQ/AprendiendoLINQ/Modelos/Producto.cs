using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendiendoLINQ.Modelos {
    public class Producto {

        public int ID;
        public String Nombre;
        public String Categoria;

        public int Stock;

        public double Precio;

        public Producto(int iD, string nombre, string categoria, int stock, double precio) {
            ID = iD;
            Nombre = nombre;
            Categoria = categoria;
            Stock = stock;
            Precio = precio;
        }
    }
}
