using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaLogica_1
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult op = MessageBox.Show("Desea Salir Del Programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (op == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtCosto.Clear();
            txtDescuento.Clear();
            txtIgv.Clear();
            txtIncremento.Clear();
            txtMPagar.Clear();

            txtCosto.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double costo = 0.0;
            double descuento = 0.0;
            double igv = 0.0;
            double montoTotal = 0.0;
            double aumento = 0.0;

            if ((txtCosto.Text ==  "") || (String.IsNullOrEmpty(txtCosto.Text))){
                MessageBox.Show("Error: Necesita Ingresar El Costo Del Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            costo = Convert.ToDouble(txtCosto.Text);

            if(costo <= 0.0)
            {
                MessageBox.Show("Error: El costo no puede ser negativo ni igual a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chkContado.Checked)
            {
                if (rdAudio.Checked)
                {
                    descuento = calcularPorcentaje(costo, 6.0);
                    
                }

                else if (rdVideo.Checked)
                {
                    descuento = calcularPorcentaje(costo, 8.0);
                    
                }

                else if (rdLinea.Checked)
                {
                    descuento = calcularPorcentaje(costo, 5.0);
                }

                montoTotal = costo - descuento;
            }

            else{

                if (rdAudio.Checked)
                {
                    aumento = calcularPorcentaje(costo, 7.0);

                }

                else if (rdVideo.Checked)
                {
                    aumento = calcularPorcentaje(costo, 9.0);

                }

                else if (rdLinea.Checked)
                {
                    aumento = calcularPorcentaje(costo, 10.0);
                }

                montoTotal = costo + aumento;
            }

            txtDescuento.Text = descuento.ToString();
            txtIncremento.Text = aumento.ToString();
            igv = calcularPorcentaje(montoTotal, 19.0);
            txtIgv.Text = igv.ToString();
            
            montoTotal += igv;

            txtMPagar.Text = montoTotal.ToString();

        }

        private double calcularPorcentaje(double costo, double valor)
        {
            return (costo * (valor/100.0));
        }
        
    }
}
