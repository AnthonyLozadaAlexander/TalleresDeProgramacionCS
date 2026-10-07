using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNominaPolimorfica.Clases {
    public class Vendedor : Empleado{

        private double totalVentas;
        

        public Vendedor(string nombre, double sueldoBase, string ID, string cedula, string cargo, double totalVentas) : base(nombre, sueldoBase, ID, cedula, cargo) {
            this.totalVentas = totalVentas;         
        }

        public double TotalVentas { 
            get => totalVentas;
            set => totalVentas = value; 
        }

        public override double calcularPagoFinal() {
            return base.calcularPagoFinal() + (totalVentas * 0.10);
        }


    }
}
