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
