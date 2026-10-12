using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorConsumoElectrico.Modelos;

namespace SimuladorConsumoElectrico.Controlador {
    public class ControladorPlanilla {

        private int filaSeleccionada = -1;

        private readonly FrmPrincipal vista;

        public ControladorPlanilla(FrmPrincipal vista) {
            this.vista = vista;

            vista.Guardar.Click += (s, e) => GuardarPlanilla(); // Ejecuta la accion del boton
            
        }

        public void GuardarPlanilla() {
            Planilla p; 
            if (!verificarCampos(vista.Titular.Text, vista.Consumo.Text)) {
                return;
            }

            string titular = vista.Titular.Text;
            double consumo = Convert.ToDouble(vista.Consumo.Text);
            p = crearPlanilla(titular, consumo);
            insertarPlanillaEnTabla(p);
            TListaPlanilla.InsertarListaPlanilla(p);

        }

        private void insertarPlanillaEnTabla(Planilla p) {
            vista.TablaFactura.Rows.Add(p.Client, p.ObtenerCategoria(), p.Kwh, p.TarifaBase, p.calcularSubTotal(), p.calcularRecargo(), p.CalcularTotal());
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
