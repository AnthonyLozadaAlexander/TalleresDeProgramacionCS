using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNominaPolimorfica.Clases {
    public class Gerente : Empleado{

        public Gerente(String nombre, double sueldoBase): base(nombre, sueldoBase) {
            
        }
    }
}
