using SistemaPartesComputador.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPartesComputador.Controlador {
    public class ControladorComputer {

        private Form1 formularioSistema;
        private List<Computador> listaComputador = new List<Computador>();

        public ControladorComputer(Form1 vistaSistema) {
            this.formularioSistema = vistaSistema;

            formularioSistema.botonAgregar.Click += (sender, e) => registrarSistema();
        }

        public void Iniciar() {
            Application.Run(formularioSistema);
        } 

        public void registrarSistema() {

            String procesador = obtenerProcesador();
            String memoriaRam = obtenerMemoriaRam();

            if(String.IsNullOrEmpty(procesador) || String.IsNullOrEmpty(memoriaRam)) {
                MessageBox.Show("Error: Debe Elegir Un Dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String discoDuro = formularioSistema.tipoDisco.SelectedItem.ToString();

            if(discoDuro == null) {
                MessageBox.Show("Error: Debe elegir un tipo de disco duro en el combo", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private String obtenerProcesador() {
            String pc = "";
            if (formularioSistema.radioButonElestra.Checked) {
                pc = formularioSistema.radioButonElestra.Text;
            }else if (formularioSistema.radioButonEption.Checked) {
                pc = formularioSistema.radioButonEption.Text;
            }else if (formularioSistema.radioButonMDA.Checked) {
                pc = formularioSistema.radioButonMDA.Text;
            }else if(formularioSistema.radioButonSxM.Checked) {
                pc = formularioSistema.radioButonSxM.Text;
            }

            return pc;
        }


        private String obtenerMemoriaRam() {
            String ram = "";
            if (formularioSistema.radioButon512GB.Checked) {
                ram = formularioSistema.radioButon512GB.Text;
            }
            else if (formularioSistema.radioButon1TB.Checked) {
                ram = formularioSistema.radioButon1TB.Text;
            }
            else if (formularioSistema.radioButon4TB.Checked) {
                ram = formularioSistema.radioButon4TB.Text;
            }
            else if (formularioSistema.radioButton16TB.Checked) {
                ram = formularioSistema.radioButton16TB.Text;
            }
            return ram;
        }



        
    }
}
