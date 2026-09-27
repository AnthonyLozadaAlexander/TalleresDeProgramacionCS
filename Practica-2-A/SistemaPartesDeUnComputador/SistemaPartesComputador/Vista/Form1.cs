using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPartesComputador {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            BackColor = Color.White;
            CenterToScreen();
            cboDisco.Items.Add("Disco IDE");
            cboDisco.Items.Add("Disco SATA");
            cboDisco.Items.Add("Disco Nvme");

        }

        public Button botonAgregar() => btnAgregar;
        public Button botonEliminar() => btnEliminar;

        public ComboBox tipoDisco() => cboDisco;

        public ListBox listaConfiguraciones() => lstSistema;

        public RadioButton radioButonElestra() => rdbElestra;

        public RadioButton radioButonEption() => rdbEption;

        public RadioButton radioButonSxM() => rdbSxM;

        public RadioButton radioButonMDA() => rdbMDA;
    }
}
