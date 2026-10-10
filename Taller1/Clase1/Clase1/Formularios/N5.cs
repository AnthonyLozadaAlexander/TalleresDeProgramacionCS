using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clase1
{
    public partial class N5 : Form
    {
        public N5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Error: Debe Ingresar Un Valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int num = Convert.ToInt32(txtValor.Text);

            if(num % 2 == 0)
            {
                txtHistorial.Text = $"El numero  {num} es par";
            }
            else
            {
                txtHistorial.Text = $"El numero {num} es impar";
            }
        }
    }
}
