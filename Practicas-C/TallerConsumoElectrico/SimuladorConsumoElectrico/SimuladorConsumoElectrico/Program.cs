using SimuladorConsumoElectrico.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorConsumoElectrico {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmPrincipal mainFrm = new FrmPrincipal(); // Instancia del formulario principal
            ControladorPlanilla controlador = new ControladorPlanilla(mainFrm); // Instancia del controlador y se le pasa el formulario principal

            Application.Run(mainFrm); // Inicia la aplicación con el formulario principal
        }
    }
}
