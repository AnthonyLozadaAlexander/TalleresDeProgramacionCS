using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clase1
{
    public partial class N6 : Form
    {
        public N6()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEdad.Text))
            {
                MessageBox.Show("Error: Debe ingresar un valor en el campo de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int edad = Convert.ToInt32(txtEdad.Text);

            if(edad >= 18)
            {
                txtHistorial.Text = " Usted Es Mayor De Edad";
            }
            else
            {
                txtHistorial.Text = " Usted No Es Mayor De Edad";
            }

            
        }
    }
}
