using Taller_1.Formularios;
using Taller_1;

namespace Clase1
{
    public partial class Menu : Form {
        public Menu() {
            InitializeComponent();
            CenterToScreen();
            MaximizeBox = false;
        }

        private void mostrarEjercicio(Form formEjercicio) {

            /// limpiamos el panel contenedor antes de mostrar otro Ejercicio
            if (this.panelContenedor.Controls.Count > 0) {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            // configuramos las propiedades del formulario a mostrar
            formEjercicio.TopLevel = false;
            formEjercicio.FormBorderStyle = FormBorderStyle.None;
            formEjercicio.Dock = DockStyle.None;

            // Centrar el formulario dentro del panel contenedor
            // la anchura del panel contenedor - menos la anchura del panel ejercicio / 2
            int x = (this.panelContenedor.Width - formEjercicio.Width) / 2;

            // la altura del panel contenedor - menos la altura del panel ejercicio / 2
            int y = (this.panelContenedor.Height - formEjercicio.Height) / 2;
            formEjercicio.Location = new Point(x, y);

            /// Agregamos  el ejercicio al panel  contenedor
            this.panelContenedor.Controls.Add(formEjercicio);
            this.panelContenedor.Tag = formEjercicio;
            formEjercicio.Show();
        }
        private void btnLimpiar_Click(object sender, EventArgs e) {
            if (this.panelContenedor.Controls.Count > 0) {
                this.panelContenedor.Controls.RemoveAt(0);
                MessageBox.Show("Panel Limpiado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("El Panel Ya Se Encuentra Limpio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnN1_Click(object sender, EventArgs e) {
            N1 E1 = new N1();
            mostrarEjercicio(E1);
        }


        private void btnN2_Click(object sender, EventArgs e) {
            N2 E2 = new N2();
            mostrarEjercicio(E2);
        }

        private void btnN3_Click(object sender, EventArgs e) {
            N3 E3 = new N3();
            mostrarEjercicio(E3);
        }

        private void button1_Click(object sender, EventArgs e) {
            N4 E4 = new N4();
            mostrarEjercicio(E4);
        }

        private void btnN5_Click(object sender, EventArgs e) {
            N5 E5 = new N5();
            mostrarEjercicio(E5);
        }

        private void btnN6_Click(object sender, EventArgs e) {
            N6 E6 = new N6();
            mostrarEjercicio(E6);
        }

        private void btnN7_Click(object sender, EventArgs e) {
            N7 E7 = new N7();
            mostrarEjercicio(E7);
        }

        private void btnN8_Click(object sender, EventArgs e) {
            N8 E8 = new N8();
            mostrarEjercicio(E8);
        }

        private void btnN9_Click(object sender, EventArgs e) {
            N9 E9 = new N9();
            mostrarEjercicio(E9);
        }

        private void btnN10_Click(object sender, EventArgs e) {
            N10 E10 = new N10();
            mostrarEjercicio(E10);
        }
    }
}
