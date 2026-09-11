using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clase1
{
    public partial class N1 : Form
    {
        public N1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo!", "Bienvenido");
        }
    }
}
