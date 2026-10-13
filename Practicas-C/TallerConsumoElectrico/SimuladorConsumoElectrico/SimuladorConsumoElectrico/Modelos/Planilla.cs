using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorConsumoElectrico.Modelos {
    public abstract class Planilla {
        private string Cliente;
        private double kwh;
        private double tarifaBase;

        public Planilla(string cliente, double kwh, double tarifaBase) {
            Cliente = cliente;
            this.kwh = kwh;
            this.tarifaBase = tarifaBase;
        }

        public string Client { get => Cliente; set => Cliente = value; }
        public double Kwh { get => kwh; set => kwh = value; }
        public double TarifaBase { get => tarifaBase; set => tarifaBase = value; }

        public virtual double calcularSubTotal() => kwh * tarifaBase;

        public virtual double calcularRecargo() => 0;

        public double CalcularTotal() => calcularSubTotal() + calcularRecargo();

        public abstract string ObtenerCategoria();

        
    }
}
