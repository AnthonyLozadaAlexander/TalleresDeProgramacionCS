using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorConsumoElectrico.Modelos;
using SimuladorConsumoElectrico.Formularios;

namespace SimuladorConsumoElectrico.Controlador {
    public class ControladorPlanilla {

        private int filaSeleccionada = -1;

        private readonly FrmPrincipal vista;

        public int FilaSeleccionada { get => filaSeleccionada; set => filaSeleccionada = value; }

        public ControladorPlanilla(FrmPrincipal vista) {
            this.vista = vista;

            vista.Guardar.Click += (s, e) => GuardarPlanilla(); // Ejecuta la accion del boton
            vista.Buscar.Click += (s, e) => BuscarPlanilla(); // Ejecuta la accion del boton
            vista.Eliminar.Click += (s, e) => eliminarPlanilla(); // Ejecuta la accion del boton

            // s me permite acceder al objeto que genero el evento, en este caso la tabla
            // e me permite acceder a la informacion del evento, en este caso el evento es el click de la celda de la tabla

            vista.TablaFactura.CellClick += (s, e) => {
                FilaSeleccionada = e.RowIndex;
                if (FilaSeleccionada >= 0) {
                    mostrarInformacionPlanilla(FilaSeleccionada);
                }
            };

        }

        public void eliminarPlanilla() {
            if(FilaSeleccionada != -1) {

                MessageBox.Show($"El Registro [{FilaSeleccionada + 1}] Ha Sido Eliminado Con Exito {Environment.NewLine} Cliente: {TListaPlanilla.ListPlanilla[FilaSeleccionada].Client} {Environment.NewLine} Consumo: {TListaPlanilla.ListPlanilla[FilaSeleccionada].Kwh}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Eliminar la planilla de la lista y de la tabla
                TListaPlanilla.EliminarListaPlanilla(filaSeleccionada);
                vista.TablaFactura.Rows.RemoveAt(FilaSeleccionada);
                vista.HistorialFactura.Clear();
                FilaSeleccionada = -1;

            }
            else {
                MessageBox.Show("Error: No hay ninguna planilla seleccionada para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void BuscarPlanilla() {
            if (TListaPlanilla.ListPlanilla.Count == 0) {
                MessageBox.Show("No hay planillas registradas.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (FrmBuscar buscar = new FrmBuscar()) {
                if(buscar.ShowDialog() == DialogResult.OK) {
                    string titular = buscar.Cliente;
                    buscarTablaFactura(titular);
                    
                }
            }
        }

        private void buscarTablaFactura(String titular) {
            int index = TListaPlanilla.ListPlanilla.FindIndex(p => p.Client == titular);
            if(index != -1) {
                vista.TablaFactura.Rows[index].Selected = true;
            }
        }

        private void buscarTablaFacturaLINQ(string titular) {
            var consulta = TListaPlanilla.ListPlanilla.FirstOrDefault(p => p.Client.Equals(titular, StringComparison.OrdinalIgnoreCase));

            if(consulta != null) {
                int index = TListaPlanilla.ListPlanilla.IndexOf(consulta);
                vista.TablaFactura.Rows[index].Selected = true;
            }
            else {
                MessageBox.Show("Dato No Encontrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        public void GuardarPlanilla() {
            Planilla p; 
            if (!verificarCampos(vista.Titular.Text, vista.Consumo.Text)) {
                return;
            }

            string titular = vista.Titular.Text;

            // Validar que el consumo sea un número válido
            if (!double.TryParse(vista.Consumo.Text, out double consumo)){
                MessageBox.Show("Error: El consumo debe ser un número válido.", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            p = crearPlanilla(titular, consumo);
            insertarPlanillaEnTabla(p);
            TListaPlanilla.InsertarListaPlanilla(p);


        }

        private void mostrarInformacionPlanilla(int fila) {
            string nl = Environment.NewLine; //  salto de linea
            Planilla p = TListaPlanilla.ListPlanilla[fila]; // Referencia a la planilla seleccionada en la tabla

            vista.HistorialFactura.Text =
                "====================================" + nl +
                "         FACTURA ELÉCTRICA       " + nl +
                "====================================" + nl + nl +

                "Cliente:   " + p.Client + nl +
                "Categoria: " + p.ObtenerCategoria() + nl + nl +

                "------------------------------------" + nl +
                "Consumo:     " + p.Kwh + " kWh" + nl +
                "Tarifa Base: $" + p.TarifaBase + nl +
                "Subtotal:    $" + p.calcularSubTotal() + nl +
                "Recargo:     $" + p.calcularRecargo() + nl +
                "------------------------------------" + nl +
                "TOTAL:       $" + p.CalcularTotal() + nl +
                "====================================";

        }

        private void insertarPlanillaEnTabla(Planilla p) {
            vista.TablaFactura.Rows.Add(p.Client, p.ObtenerCategoria(), p.Kwh, p.TarifaBase, p.calcularSubTotal(), p.calcularRecargo(), p.CalcularTotal());
            vista.TablaFactura.ClearSelection(); // Limpia la seleccion de la tabla para que no quede seleccionada la ultima fila agregada
        }

        private Planilla crearPlanilla(string titular, double kwh) {
            Planilla p = null;
            if (kwh >= 0 && kwh <= 150) {
                p = new PlanillaEficiente(titular, kwh);
            }
            else if (kwh > 150 && kwh <= 300) {
                p = new PlanillaModerada(titular, kwh);
            }
            else if (kwh > 300) {
                p = new PlanillaExcesiva(titular, kwh);
            }

            return p;
        }

        private bool verificarCampos(String titular, String consumo) {
            if(String.IsNullOrWhiteSpace(titular) || String.IsNullOrWhiteSpace(consumo)) {
                MessageBox.Show("Error: Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


    }
}
