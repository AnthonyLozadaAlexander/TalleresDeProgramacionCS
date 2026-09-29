# Documentación y Código Actualizado del Proyecto: Sistema Partes de un Computador

> **Propósito del documento**: Este archivo consolida el código fuente **actualizado**, la arquitectura MVC, el diseño de la interfaz y el análisis funcional del proyecto para que tu chat personalizado de Gemini pueda revisarlo, validar las mejoras implementadas y verificar que todo esté en orden.

---

## 1. Información General del Proyecto

- **Nombre del Proyecto**: `SistemaPartesComputador`
- **Tipo de Aplicación**: Aplicación de Escritorio Windows Forms (.NET Framework 4.7.2)
- **Lenguaje**: C#
- **Patrón de Arquitectura**: Modelo - Vista - Controlador (MVC)
- **Objetivo**: Configuración y ensamblaje simulado de computadoras (procesador, memoria RAM, disco duro, tarjetas controladoras RAID/Video y accesorios periféricos). Permite registrar las configuraciones en memoria, visualizarlas en lista y en detalle, eliminarlas y reiniciar el formulario.

---

## 2. Estructura de Archivos del Proyecto

```text
SistemaPartesDeUnComputador/
├── SistemaPartesDeUnComputador.slnx
└── SistemaPartesComputador/
    ├── App.config
    ├── Program.cs
    ├── SistemaPartesComputador.csproj
    ├── Properties/
    │   ├── AssemblyInfo.cs
    │   ├── Resources.resx
    │   └── Settings.settings
    ├── Modelos/
    │   └── Computador.cs
    ├── Vista/
    │   ├── Form1.cs
    │   ├── Form1.Designer.cs
    │   └── Form1.resx
    └── Controlador/
        └── ControladorComputer.cs
```

---

## 3. Código Fuente Actualizado por Capas

### 3.1. Punto de Entrada (`Program.cs`)

**Ruta**: `SistemaPartesComputador/Program.cs`  
**Rol**: Configura estilos visuales, instancia la vista (`Form1`), inicializa el controlador (`ControladorComputer`) inyectando la vista, y arranca la aplicación.

```csharp
using SistemaPartesComputador.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPartesComputador {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); 

            Form1 sistema = new Form1(); // creacion del formulario
            ControladorComputer controlador = new ControladorComputer(sistema); // instancia del controlador
            
            controlador.Iniciar();
        }
    }
}
```

---

### 3.2. Capa Modelo (`Modelos/Computador.cs`)

**Ruta**: `SistemaPartesComputador/Modelos/Computador.cs`  
**Rol**: Modela la entidad `Computador` con encapsulamiento de sus componentes, almacenamiento de accesorios en una lista dinámica y método `ToString()` para representación textual.

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPartesComputador.Modelos {
    public class Computador {

        private String procesador;

        private String memoriaRam;

        private String tipoDiscoDuro;

        private bool tieneControladorRaid;
        private bool tieneControladorVideo;

        private List<String> accesorios;

        public Computador(String procesador, String memoriaRam, String tipoDiscoDuro, bool tieneControladorRaid, bool tieneControladorVideo) {
            this.procesador = procesador;
            this.memoriaRam = memoriaRam;
            this.tipoDiscoDuro = tipoDiscoDuro;
            this.tieneControladorRaid = tieneControladorRaid;
            this.TieneControladorVideo = tieneControladorVideo;
            accesorios = new List<String>();
        }

        public void agregarAccesorio(String accesorio) {
            accesorios.Add(accesorio); // accesorios del objeto Computador individual
        }

        public override string ToString() {
            return "Procesador: " + procesador + Environment.NewLine + "Memoria RAM: " + memoriaRam + Environment.NewLine + "Tipo de Disco Duro: " + tipoDiscoDuro + "Controlador RAID: " + (tieneControladorRaid ? "Sí" : "No") + Environment.NewLine + "Controlador de Video: " + (tieneControladorVideo ? "Sí" : "No") + Environment.NewLine + "Accesorios: " + string.Join(", ", accesorios);
        }

        public string Procesador { 
            get => procesador;
            set => procesador = value; 
        }

        public string MemoriaRam { 
            get => memoriaRam; 
            set => memoriaRam = value; 
        }
        public string TipoDiscoDuro { 
            get => tipoDiscoDuro; 
            set => tipoDiscoDuro = value; 
        }
        public bool TieneControladorRaid { 
            get => tieneControladorRaid; 
            set => tieneControladorRaid = value; 
        }
        public bool TieneControladorVideo { 
            get => tieneControladorVideo; 
            set => tieneControladorVideo = value; 
        }
        public List<string> Accesorios { 
            get => accesorios; 
        }
    }
}
```

---

### 3.3. Capa Vista (`Vista/Form1.cs` y Controles)

**Ruta**: `SistemaPartesComputador/Vista/Form1.cs`  
**Rol**: Inicializa los componentes visuales, restringe el ComboBox a solo lectura de lista desplegable (`DropDownList`) y expone los controles mediante propiedades públicas con expresión lambda (`=>`) para el controlador.

```csharp
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
        public RadioButton radioButton16TB => rdb16Tb;

        public CheckBox checkBoxRaid => chkControladorRaid;
        public CheckBox checkBoxVideo => chkGrabadoraVideo;

        public CheckedListBox checkListAccesorios => chkListAccesorios;

        public Button botonLimpiar => btnLimpiar;
    }
}
```

#### Controles Principales en `Form1.Designer.cs`:
- **Procesador (`grpProcesador`)**: RadioButtons `rdbElestra` ("Elestra"), `rdbEption` ("Eption"), `rdbSxM` ("SxM"), `rdbMDA` ("MDA").
- **Memoria (`groupBox1`)**: RadioButtons `rdb512Gb` ("512 Gb"), `rdb1Tb` ("1 TB"), `rdb4Tb` ("4 TB"), `rdb16Tb` ("16 TB").
- **Tipo de Disco**: ComboBox `cboDisco` con opciones ("Disco IDE", "Disco SATA", "Disco Nvme").
- **Controladores Opcionales**:
  - CheckBox `chkControladorRaid` ("Controlador Raid")
  - CheckBox `chkGrabadoraVideo` ("Grabadora Video")
- **Accesorios**: CheckedListBox `chkListAccesorios` con opciones ("Microfono", "Raton", "Teclado").
- **Acciones**:
  - `btnAgregar` ("Guardar")
  - `btnEliminar` ("Eliminar")
  - `btnLimpiar` ("Limpiar")
- **Salida**:
  - `txtInformacion` (TextBox Multilínea)
  - `lstSistema` (ListBox con scroll horizontal)

---

### 3.4. Capa Controlador (`Controlador/ControladorComputer.cs`)

**Ruta**: `SistemaPartesComputador/Controlador/ControladorComputer.cs`  
**Rol**: Enlaza eventos de la vista con la lógica de negocio, ejecuta validaciones completas, gestiona la colección `listaComputador`, actualiza las vistas y resetea los controles del formulario.

```csharp
using SistemaPartesComputador.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPartesComputador.Controlador {
    public class ControladorComputer {

        private Form1 formularioSistema;
        private List<Computador> listaComputador = new List<Computador>();

        public ControladorComputer(Form1 vistaSistema) {
            this.formularioSistema = vistaSistema;

            formularioSistema.botonAgregar.Click += (sender, e) => registrarSistema();
            formularioSistema.botonEliminar.Click += (sender, e) => eliminarSistema();
            formularioSistema.botonLimpiar.Click += (sender, e) => limpiar();
        }

        public void Iniciar() {
            Application.Run(formularioSistema);
        } 

        public void registrarSistema() {

            bool tieneControladorRaid = false;
            bool tieneControladorVideo = false;

            String procesador = obtenerProcesador();
            String memoriaRam = obtenerMemoriaRam();

            if(String.IsNullOrEmpty(procesador) || String.IsNullOrEmpty(memoriaRam)) {
                MessageBox.Show("Error: Debe Elegir Un Dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(formularioSistema.tipoDisco.SelectedIndex == -1) {
                MessageBox.Show("Error: Debes elegir un tipo de disco en el comboBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String discoDuro = formularioSistema.tipoDisco.SelectedItem.ToString();
            tieneControladorRaid = formularioSistema.checkBoxRaid.Checked;
            tieneControladorVideo = formularioSistema.checkBoxVideo.Checked;

            Computador pc = new Computador(procesador, memoriaRam, discoDuro, tieneControladorRaid, tieneControladorVideo);

            if(formularioSistema.checkListAccesorios.CheckedItems.Count == 0) {
                MessageBox.Show("Advertencia: Debe elegir almenos un accesorio de las opciones (Raton, Mouse, Teclado)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // guarda los elementos escogidos del checkList y los agrega a la lista de accesorios del computador
            foreach (string datos in formularioSistema.checkListAccesorios.CheckedItems) {
                pc.agregarAccesorio(datos);
            }

            listaComputador.Add(pc); // base de datos del sistema.
            formularioSistema.txtInfo.Text = pc.ToString();
            actualizarListBox(pc);
           
        }

        public void eliminarSistema() {

            if (listaComputador.Count == 0) {

                MessageBox.Show("Error: No hay datos en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            int index = formularioSistema.listaConfiguraciones.SelectedIndex;

            if (index == -1) {
                MessageBox.Show("Error: Debe seleccionar un elemento de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            listaComputador.RemoveAt(index);
            formularioSistema.listaConfiguraciones.Items.RemoveAt(index);

            if(listaComputador.Count == 0) {
                formularioSistema.txtInfo.Clear();
            }
            
        }

        public void actualizarListBox(Computador pc) {
            // Agregamos el objeto pc al listBox del frm
            formularioSistema.listaConfiguraciones.Items.Add(pc);

            // habilitamos el scroll horizontal para que se pueda ver todo el texto si es muy largo
            formularioSistema.listaConfiguraciones.HorizontalScrollbar = true;

            // Estimamos el ancho multiplicando los caracteres del texto por 8 píxeles
            int anchoEstimado = pc.ToString().Length * 15;

            // Si el nuevo texto supera el scroll actual, lo estiramos
            if (anchoEstimado > formularioSistema.listaConfiguraciones.HorizontalExtent) {
                formularioSistema.listaConfiguraciones.HorizontalExtent = anchoEstimado;
            }
        }
  
        private String obtenerProcesador() {
            String pc = "";
            if (formularioSistema.radioButonElestra.Checked) {
                pc = formularioSistema.radioButonElestra.Text;
            }else if (formularioSistema.radioButonEption.Checked) {
                pc = formularioSistema.radioButonEption.Text;
            }else if (formularioSistema.radioButonMDA.Checked) {
                pc = formularioSistema.radioButonMDA.Text;
            }else if(formularioSistema.radioButonSxM.Checked) {
                pc = formularioSistema.radioButonSxM.Text;
            }

            return pc;
        }

        private String obtenerMemoriaRam() {
            String ram = "";
            if (formularioSistema.radioButon512GB.Checked) {
                ram = formularioSistema.radioButon512GB.Text;
            }
            else if (formularioSistema.radioButon1TB.Checked) {
                ram = formularioSistema.radioButon1TB.Text;
            }
            else if (formularioSistema.radioButon4TB.Checked) {
                ram = formularioSistema.radioButon4TB.Text;
            }
            else if (formularioSistema.radioButton16TB.Checked) {
                ram = formularioSistema.radioButton16TB.Text;
            }
            return ram;
        }

        public void limpiar() {
            formularioSistema.txtInfo.Clear(); // limpiar txtInfo
            formularioSistema.checkBoxRaid.Checked = false; // deseleccionar checkBox
            formularioSistema.checkBoxVideo.Checked = false; // deseleccionar checkBox

            formularioSistema.tipoDisco.SelectedIndex = -1; // deselecciona el comboBox
            formularioSistema.radioButon1TB.Checked = false;  // deselecciona radioButton
            formularioSistema.radioButon4TB.Checked = false;  // deselecciona radioButton
            formularioSistema.radioButon512GB.Checked = false;  // deselecciona radioButton
            formularioSistema.radioButton16TB.Checked = false;

            formularioSistema.radioButonEption.Checked = false;
            formularioSistema.radioButonElestra.Checked = false;
            formularioSistema.radioButonMDA.Checked = false;
            formularioSistema.radioButonSxM.Checked = false;

            // deselecciona los elementos del checkListAccesorios
            for (int i = 0; i < formularioSistema.checkListAccesorios.Items.Count; i++) {
                formularioSistema.checkListAccesorios.SetItemChecked(i, false);
            }
        }
    }
}
```

---

## 4. Mejoras Recientes Implementadas en el Proyecto

1. **Validación de Selección al Eliminar (`eliminarSistema`)**:
   - Se añadió la comprobación de `index == -1` para evitar un `ArgumentOutOfRangeException` cuando el usuario pulsa *Eliminar* sin haber seleccionado un elemento de la lista.
   - Si la lista queda vacía tras eliminar (`listaComputador.Count == 0`), se limpia automáticamente el campo de detalle `txtInfo`.
2. **Validación de Accesorios Obligatorios (`registrarSistema`)**:
   - Se valida que `checkListAccesorios.CheckedItems.Count > 0`. Si no se elige ninguno, muestra un mensaje de advertencia y detiene el registro.
3. **Limpieza Completa del Formulario (`limpiar`)**:
   - Ahora desmarca todos los `RadioButton` de Procesador y de Memoria.
   - Restablece el `ComboBox` (`tipoDisco.SelectedIndex = -1`).
   - El desmarcado de accesorios se hace mediante un bucle indexado `for` sobre `Items.Count`, evitando problemas de modificación concurrente de colecciones.

---

## 5. Puntos Técnicos y Observaciones Restantes (Para Revisión con Gemini)

Al pasarle este documento a tu asistente de Gemini, pídele que preste atención a estos detalles:

1. **Salto de línea faltante en `Computador.ToString()`**:
   - En la línea 35 de `Computador.cs`:
     ```csharp
     "Tipo de Disco Duro: " + tipoDiscoDuro + "Controlador RAID: " + (tieneControladorRaid ? "Sí" : "No")
     ```
     Falta un `Environment.NewLine` entre el valor de `tipoDiscoDuro` y `"Controlador RAID: "`. Actualmente genera texto pegado, por ejemplo:  
     `Tipo de Disco Duro: Disco SATAControlador RAID: Sí`.
2. **Texto del mensaje de validación de accesorios**:
   - En `ControladorComputer.cs` (línea 52):
     ```csharp
     MessageBox.Show("Advertencia: Debe elegir almenos un accesorio de las opciones (Raton, Mouse, Teclado)", ...);
     ```
     En el formulario las opciones reales son `"Microfono"`, `"Raton"`, `"Teclado"`. El mensaje menciona `"Mouse"` en lugar de `"Microfono"`.
3. **Visualización en `ListBox` (Saltos de Línea)**:
   - `ListBox` en Windows Forms está diseñado para ítems de una sola línea. Al agregar el objeto `pc` a `listaConfiguraciones`, invoca `ToString()`, que contiene múltiples saltos de línea (`\r\n`). En Windows Forms estándar esto puede mostrar caracteres no imprimibles o solo la primera línea.
   - *Alternativa*: Crear un método `ToShortString()` o formatear un resumen en una sola línea para el `ListBox` (ejemplo: `$"PC: {procesador} | RAM: {memoriaRam} | Disco: {tipoDiscoDuro}"`) y dejar el detalle multilínea exclusivamente para el `txtInfo`.
4. **Diseño Arquitectónico MVC**:
   - Evaluar si el nivel de desacoplamiento entre `Form1` y `ControladorComputer` cumple con los estándares solicitados por la materia (por ejemplo, si se recomienda abstraer la vista mediante una interfaz `IVistaSistema` o si la exposición de controles mediante propiedades lambda es suficiente para el alcance del taller).

---

## 6. Prompt para Enviar a tu Chat Personalizado de Gemini

Copia y pega el siguiente mensaje junto con este archivo `.md`:

> *"Hola Gemini, aquí tienes el código fuente actualizado de mi proyecto 'Sistema Partes de un Computador' en C# Windows Forms (.NET Framework 4.7.2) con arquitectura MVC. Acabo de aplicar varias mejoras (validación de selección antes de eliminar, validación de accesorios y reseteo completo de controles al limpiar). Por favor revísalo y dime:*
> 1. *¿El flujo y la lógica del sistema están correctos y libres de errores en tiempo de ejecución?*
> 2. *¿Qué detalles visuales o de formato faltan por pulir (como en `ToString()` o el `ListBox`)?*
> 3. *¿La implementación de la arquitectura MVC cumple adecuadamente con las buenas prácticas para un proyecto de este nivel?*
> 4. *¿Qué pequeñas recomendaciones me das para que el código quede impecable?"*
