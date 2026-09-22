using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNominaPolimorfica.Clases {
    public class Empleado {

        private String nombre;
        private double sueldoBase;

        public Empleado(String nombre, double sueldoBase) {
            this.nombre = nombre;
            this.sueldoBase = sueldoBase;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double SueldoBase { get => sueldoBase; set => sueldoBase = value; }

        public virtual double calcularPagoFinal() {
            return SueldoBase;
        }

        
    }
}
