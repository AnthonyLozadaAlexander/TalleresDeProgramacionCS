using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprendiendoLINQ {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            cboCategorias.Items.Add("Todos");
            cboOrden.Items.Add("Orden Menor a Mayor Precio");
            cboOrden.Items.Add("Orden Mayor a Menor Precio");
            configurarTabla();
        }

        private void configurarTabla() {
            tabla.BorderStyle = BorderStyle.None;
            tabla.Font = new Font("Cascadia Code", 11, FontStyle.Bold);

            tabla.AutoGenerateColumns = false;
            tabla.Columns.Clear();

            tabla.Columns.Add("ID", "ID");
            tabla.Columns.Add("Nombre", "Nombre");
            tabla.Columns.Add("Categoria", "Categoria");
            tabla.Columns.Add("Precio", "Precio");
            tabla.Columns.Add("Stock", "Stock");

        }

        private void btnFiltrar_Click(object sender, EventArgs e) {

        }
    }
}
