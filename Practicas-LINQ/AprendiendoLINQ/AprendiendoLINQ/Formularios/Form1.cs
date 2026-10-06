using AprendiendoLINQ.Modelos;
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
        List<Producto> inventario = new List<Producto>() {
            new Producto(1, "Teclado Mecanico", "Perifericos", 50, 35.00),
            new Producto(2, "Mouse Gamer", "Perifericos", 25, 46.00),
            new Producto(3, "Monitor 24''", "Perifericos", 30, 32.00),
            new Producto(4, "Laptop Core i7", "Perifericos", 70, 64.00),
            new Producto(5, "Memoria RAM 16GB", "Perifericos", 90, 21.00),
            new Producto(6, "Disco SSD 1TB", "Perifericos", 61, 76.00)
        };


        public Form1() {
            InitializeComponent();
            cboCategorias.Items.Add("Todos");
            cboOrden.Items.Add("Orden Menor a Mayor Precio");
            cboOrden.Items.Add("Orden Mayor a Menor Precio");
            CenterToScreen();
            configurarTabla();
        }

        private void configurarTabla() {
            tabla.BorderStyle = BorderStyle.None;
            tabla.Font = new Font("Cascadia Code", 11, FontStyle.Bold);

            tabla.AutoGenerateColumns = false;
            tabla.Columns.Clear();

            // Configurar las columnas del DataGridView con su DataPropertyName
            tabla.Columns.Add("ID", "ID");
            tabla.Columns["ID"].DataPropertyName = "ID";
            tabla.Columns.Add("Nombre", "Nombre");
            tabla.Columns["Nombre"].DataPropertyName = "Nombre";
            tabla.Columns.Add("Categoria", "Categoria");
            tabla.Columns["Categoria"].DataPropertyName = "Categoria";
            tabla.Columns.Add("Precio", "Precio");
            tabla.Columns["Precio"].DataPropertyName = "Precio";
            tabla.Columns.Add("Stock", "Stock");
            tabla.Columns["Stock"].DataPropertyName = "Stock";

            tabla.ReadOnly = true;
            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToDeleteRows = false;
            tabla.AllowUserToResizeRows = false;
            tabla.AllowUserToResizeColumns = false;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnFiltrar_Click(object sender, EventArgs e) {

            tabla.DataSource = null;

            String nombreProducto = txtNombre.Text.Trim().ToLower();
            String categoria = cboCategorias.SelectedItem?.ToString() ?? "Todos";

            var consulta = inventario.AsEnumerable(); // encadenar la lista a las operaciones LINQ

            // filtro por nombre texto
            if (!String.IsNullOrEmpty(nombreProducto)) {
                consulta = consulta.Where(p => p.Nombre.ToLower().Contains(nombreProducto));
            }

            if(categoria != "Todos") {

                consulta = consulta.Where(p => p.Categoria == categoria);
            }

            // Ordenar de Menor a Mayor
            if(cboOrden.SelectedIndex == 0) {
                consulta = consulta.OrderBy(p => p.Precio);

            } // Ordenar de Mayor a Menor
            else if(cboOrden.SelectedIndex == 1) {
                consulta = consulta.OrderByDescending(p => p.Precio);
            }
            
            tabla.DataSource = consulta.ToList(); // convertir la consulta a lista para mostrarla en el DataGridView

        }

        private void btnEliminar_Click(object sender, EventArgs e) {

            if(tabla.CurrentRow.Index == -1 || tabla.CurrentRow == null) {
                MessageBox.Show("Error: Debe Seleccionar Un Producto De La Tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProducto = (int)(tabla.CurrentRow.Cells["ID"].Value);

            Producto buscarP = inventario.FirstOrDefault(p => p.ID == idProducto);

            if (buscarP != null) {

            }
            
        }
    }
}
