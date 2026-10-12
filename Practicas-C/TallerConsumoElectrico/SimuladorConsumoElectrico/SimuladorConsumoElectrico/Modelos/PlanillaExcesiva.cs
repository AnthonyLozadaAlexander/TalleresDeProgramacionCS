using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorConsumoElectrico.Modelos {
    public class PlanillaExcesiva : Planilla {
        const double TARIFABASE = 0.22;
        public PlanillaExcesiva(string cliente, double kwh) : base(cliente, kwh, TARIFABASE) {
        }

        public override double calcularRecargo() {
            return base.calcularSubTotal() * 0.10 ;
        }

        public override string ObtenerCategoria() {
            return "Excesivo";
        }
    }
}
