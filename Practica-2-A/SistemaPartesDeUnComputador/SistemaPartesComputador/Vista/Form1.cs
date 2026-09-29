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
            configurarComboBox();       
        }

        private void configurarComboBox() {
            cboDisco.DropDownStyle = ComboBoxStyle.DropDownList; // evita que el usuario escriba en el comboBox
            cboDisco.Items.Add("Disco IDE");
            cboDisco.Items.Add("Disco SATA");
            cboDisco.Items.Add("Disco Nvme");
        }


        public Button botonAgregar => btnAgregar;
        public Button botonEliminar => btnEliminar;

        public TextBox txtInfo => txtInformacion;

        public ComboBox tipoDisco => cboDisco;

        public ListBox listaConfiguraciones => lstSistema;

        public RadioButton radioButonElestra => rdbElestra;

        public RadioButton radioButonEption => rdbEption;

        public RadioButton radioButonSxM => rdbSxM;

        public RadioButton radioButonMDA => rdbMDA;

        public RadioButton radioButon512GB => rdb512Gb;

        public RadioButton radioButon1TB => rdb1Tb;

        public RadioButton radioButon4TB => rdb4Tb;

        public RadioButton  radioButton16TB => rdb16Tb;

        public CheckBox checkBoxRaid => chkControladorRaid;

        public CheckBox checkBoxVideo => chkGrabadoraVideo;

        public CheckedListBox checkListAccesorios => chkListAccesorios;

        public Button botonLimpiar => btnLimpiar;
    }
}
