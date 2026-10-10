using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Clase1
{
    public partial class N2 : Form
    {
        public N2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingrese Su Nombre: ", "Registro");

            // validar que se ingrese un nombre
            if (!string.IsNullOrEmpty(nombre)) // si el nombre no es null o vacio
            {
                MessageBox.Show($"Ingreso de Dato Correctamente\nNombre: {nombre}\n", "Ingreso Exitoso", MessageBoxButtons.OK);
                txtHistorial.Text = $"Bienvenido {nombre} A C#";
            }
        }
    }
}
