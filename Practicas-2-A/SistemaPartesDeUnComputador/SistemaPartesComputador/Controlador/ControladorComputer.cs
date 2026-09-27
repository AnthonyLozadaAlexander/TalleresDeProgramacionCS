using SistemaPartesComputador.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPartesComputador.Controlador {
    public class ControladorComputer {

        private Form1 vistaSistema;
        private List<Computador> listaComputador = new List<Computador>();

        public ControladorComputer(Form1 vistaSistema) {
            this.vistaSistema = vistaSistema;
        }

        public void iniciarPrograma() {
            
            Application.Run(vistaSistema);
        } 

        
    }
}
