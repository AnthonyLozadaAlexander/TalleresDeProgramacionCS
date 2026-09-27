using SistemaPartesComputador.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPartesComputador {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); 

            Form1 sistema = new Form1(); // creacion del formulario
            ControladorComputer window = new ControladorComputer(sistema);
            
            window.iniciarPrograma();
        }
    }
}
