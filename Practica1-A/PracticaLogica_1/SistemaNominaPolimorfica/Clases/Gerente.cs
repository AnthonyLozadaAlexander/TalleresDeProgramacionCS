using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNominaPolimorfica.Clases {
    public class Gerente : Empleado{

        private double bono;

        public Gerente(String nombre, double sueldoBase, double bono): base(nombre, sueldoBase) {
            this.bono = bono; 
        }

        public double Bono {
            get => bono; 
            set => bono = value; 
        }

        public override double calcularPagoFinal() {
            return base.calcularPagoFinal() + bono;
        }
    }
}
