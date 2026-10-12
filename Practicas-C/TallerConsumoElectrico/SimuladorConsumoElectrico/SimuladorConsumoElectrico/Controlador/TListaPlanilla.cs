using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorConsumoElectrico.Modelos;

namespace SimuladorConsumoElectrico.Controlador {
    public static class TListaPlanilla { // no necesito instanciar esta clase, por eso es static

        private static List<Planilla> Planilla = new List<Planilla>(); // lista global de planillas en el sistema

        public static List<Planilla> ListPlanilla { get => Planilla; }

        public static void InsertarListaPlanilla(Planilla p) {
            if (p != null) {
                Planilla.Add(p);
            }
        }
        
        public static void ModificarListaPlanilla(int index, Planilla p) {
            if(index >= 0 && index < Planilla.Count && p != null) {
                Planilla[index] = p;
            }
        }

        public static void EliminarListaPlanilla(int index) {
            if(index >= 0 && index  < Planilla.Count) {
                Planilla.RemoveAt(index);
            }
        }
    }
}
