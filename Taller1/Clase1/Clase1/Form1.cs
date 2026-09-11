namespace Clase1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            CenterToScreen();

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mostrarEjercicio(Form formEjercicio)
        {

            /// limpiamos el panel contenedor antes de mostrar otro Ejercicio
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            // configuramos las propiedades del formulario a mostrar
            formEjercicio.TopLevel = false;
            formEjercicio.FormBorderStyle = FormBorderStyle.None;
            formEjercicio.Dock = DockStyle.Fill;


            /// Agregamos  el ejercicio al panel  contenedor
            this.panelContenedor.Controls.Add(formEjercicio);
            this.panelContenedor.Tag = formEjercicio;
            formEjercicio.Show();
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            N1 E1 = new N1();
            mostrarEjercicio(E1);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
                MessageBox.Show("Panel Limpiado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El Panel Ya Se Encuentra Limpio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            N2 E2 = new N2();
            mostrarEjercicio(E2);
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            N3 E3 = new N3();
            mostrarEjercicio(E3);
        }

        private void panelBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            N4 E4 = new N4();
            mostrarEjercicio(E4);
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            N5 E5 = new N5();
            mostrarEjercicio(E5);
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            N6 E6 = new N6();
            mostrarEjercicio(E6);
        }
    }
}
