using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorConsumoElectrico.Modelos {
    public class PlanillaEficiente : Planilla {

        public const double TARIFABASE = 0.10;
        
        public PlanillaEficiente(string cliente, double kwh) : base(cliente, kwh, TARIFABASE) {
        }

        public override string ObtenerCategoria() {
            return "Eficiente";
        }
    }
}
