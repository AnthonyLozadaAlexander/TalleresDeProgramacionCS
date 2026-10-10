using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Clase1
{
    public partial class N4 : Form
    {
        public N4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
             
            if(String.IsNullOrEmpty(txtValor1.Text) && String.IsNullOrEmpty(txtValor2.Text)){
                MessageBox.Show("Error: Debe Ingresar Dos Valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int num1 = Int32.Parse(txtValor1.Text);
                int num2 = Int32.Parse(txtValor2.Text);

                int result = (num1 + num2);

                txtHistorial.Text = $"El resultado de {num1} + {num2} = {result}";

            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Debe Ingresar Valores Numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
            }

            
        }
    }
}
