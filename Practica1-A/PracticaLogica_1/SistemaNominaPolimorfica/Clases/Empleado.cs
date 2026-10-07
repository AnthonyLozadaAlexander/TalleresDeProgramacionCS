using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNominaPolimorfica.Clases {
    public abstract class Empleado {

        private String nombre;
        private String ID;

        private String cedula;
        private double sueldoBase;

        private String cargo;

        public Empleado(String nombre, double sueldoBase, string iD, string cedula, string cargo) {
            this.nombre = nombre;
            this.sueldoBase = sueldoBase;
            this.ID = iD;
            this.cedula = cedula;
            this.cargo = cargo;
        }

        public string Cargo { get => cargo; set => cargo = value; }

        public string Nombre { get => nombre; set => nombre = value; }
        public double SueldoBase { get => sueldoBase; set => sueldoBase = value; }
        public string Id { get => ID; set => ID = value; }
        public string Cedula { get => cedula; set => cedula = value; }

        public virtual double calcularPagoFinal() {
            return SueldoBase;
        }

        
    }
}
