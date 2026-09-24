using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNominaPolimorfica.Clases {
    public class Vendedor : Empleado{

        private double totalVentas;
        private double porcentajeComision;

        public Vendedor(double totalVentas,  double porcentajeComision, string nombre, double sueldoBase) : base(nombre, sueldoBase) {
            this.totalVentas = totalVentas;
            this.porcentajeComision = porcentajeComision;
        }

        public double TotalVentas { 
            get => totalVentas;
            set => totalVentas = value; 
        }

        public double PorcentajeComision { 
            get => porcentajeComision; 
            set => porcentajeComision = value; 
        }

        public override double calcularPagoFinal() {
            return SueldoBase + (totalVentas * porcentajeComision);
        }


    }
}
