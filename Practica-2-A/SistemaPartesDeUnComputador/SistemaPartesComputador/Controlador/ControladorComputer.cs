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
            formularioSistema.botonEliminar.Click += (sender, e) => eliminarSistema();
            formularioSistema.botonLimpiar.Click += (sender, e) => limpiar();
        }

        public void Iniciar() {
            Application.Run(formularioSistema);
        } 

        public void registrarSistema() {

            bool tieneControladorRaid = false;
            bool tieneControladorVideo = false;

            String procesador = obtenerProcesador();
            String memoriaRam = obtenerMemoriaRam();

            if(String.IsNullOrEmpty(procesador) || String.IsNullOrEmpty(memoriaRam)) {
                MessageBox.Show("Error: Debe Elegir Un Dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(formularioSistema.tipoDisco.SelectedIndex == -1) {
                MessageBox.Show("Error: Debes elegir un tipo de disco en el comboBox", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (formularioSistema.checkListAccesorios.CheckedItems.Count == 0) {
                MessageBox.Show("Advertencia: Debe elegir almenos un accesorio de las opciones (Microfono, Raton, Teclado)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String discoDuro = formularioSistema.tipoDisco.SelectedItem.ToString();
            tieneControladorRaid = formularioSistema.checkBoxRaid.Checked;
            tieneControladorVideo = formularioSistema.checkBoxVideo.Checked;

            Computador pc = new Computador(procesador, memoriaRam, discoDuro, tieneControladorRaid, tieneControladorVideo);


            // guarda los elementos escogidos del checkList y los agrega a la lista de accesorios del computador
            foreach (string datos in formularioSistema.checkListAccesorios.CheckedItems) {
                pc.agregarAccesorio(datos);
            }


            listaComputador.Add(pc); // base de datos del sistema.
            formularioSistema.txtInfo.Text = pc.ToString();
            actualizarListBox(pc);
           
        }

        public void eliminarSistema() {

            if (listaComputador.Count == 0) {

                MessageBox.Show("Error: No hay datos en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            int index = formularioSistema.listaConfiguraciones.SelectedIndex;

            if (index == -1) {
                    MessageBox.Show("Error: Debe seleccionar un elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            
            listaComputador.RemoveAt(index);
            formularioSistema.listaConfiguraciones.Items.RemoveAt(index);

            if(listaComputador.Count == 0) {
                formularioSistema.txtInfo.Clear();
            }
            
            
        }

        public void actualizarListBox(Computador pc) {
            // Agregamos el objeto pc al listBox del frm
            formularioSistema.listaConfiguraciones.Items.Add(pc.mostrarInformacionLineal());

            // habilitamos el scroll horizontal para que se pueda ver todo el texto si es muy largo
            formularioSistema.listaConfiguraciones.HorizontalScrollbar = true;

            // Estimamos el ancho multiplicando los caracteres del texto por 8 píxeles
            int anchoEstimado = pc.mostrarInformacionLineal().Length * 10;

            // Si el nuevo texto supera el scroll actual, lo estiramos
            if (anchoEstimado > formularioSistema.listaConfiguraciones.HorizontalExtent) {
                formularioSistema.listaConfiguraciones.HorizontalExtent = anchoEstimado;
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


        public void limpiar() {
            formularioSistema.txtInfo.Clear(); // limpiar txtInfo
            formularioSistema.checkBoxRaid.Checked = false; // deseleccionar checkBox
            formularioSistema.checkBoxVideo.Checked = false; // deseleccionar checkBox

            formularioSistema.tipoDisco.SelectedIndex = -1; // deselecciona el comboBox
            formularioSistema.radioButon1TB.Checked = false;  // deselecciona radioButton
            formularioSistema.radioButon4TB.Checked = false;  // deselecciona radioButton
            formularioSistema.radioButon512GB.Checked = false;  // deselecciona radioButton
            formularioSistema.radioButton16TB.Checked = false;

            formularioSistema.radioButonEption.Checked = false;
            formularioSistema.radioButonElestra.Checked = false;
            formularioSistema.radioButonMDA.Checked = false;
            formularioSistema.radioButonSxM.Checked = false;

            // deselecciona los elementos del checkListAccesorios
            for (int i = 0; i < formularioSistema.checkListAccesorios.Items.Count; i++) {
                formularioSistema.checkListAccesorios.SetItemChecked(i, false);
            }
        }



        
    }
}
