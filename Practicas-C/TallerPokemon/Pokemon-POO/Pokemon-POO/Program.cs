using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokemon_POO.Controlador;
using Pokemon_POO.Formularios;

namespace Pokemon_POO {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmMenu vistaPrincipal = new FrmMenu(); // instancia de la vista principal
            FrmRegistrar registrar = new FrmRegistrar(); // instancia de la vista de registro
            FrmDuelo duelo = new FrmDuelo(); // instancia de la vista de duelo
            ControladorPk Controlador = new ControladorPk(vistaPrincipal, registrar, duelo); // instancia del controlador y se le pasa la vista principal
            Application.Run(vistaPrincipal); // se ejecuta la vista principal
        }
    }
}
