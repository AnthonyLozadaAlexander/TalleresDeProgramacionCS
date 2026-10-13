using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorConsumoElectrico.Modelos {
    public class PlanillaModerada : Planilla {
        const double TARIFABASE = 0.15;
        public PlanillaModerada(string cliente, double kwh) : base(cliente, kwh, TARIFABASE) {
        }

        public override string ObtenerCategoria() => "Moderada";
    }
}
