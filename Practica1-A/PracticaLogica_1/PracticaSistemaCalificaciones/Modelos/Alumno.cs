using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSistemaCalificaciones.Modelos {
    public class Alumno {

        private String nombre;
        private int edad;
        private String cedula;
        private String turno;
        private double nota1;
        private double nota2;
        private double nota3;

        public Alumno(string nombre, int edad, string cedula, string turno, double nota1, double nota2, double nota3) {
            this.nombre = nombre;
            this.edad = edad;
            this.cedula = cedula;
            this.turno = turno;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Turno { get => turno; set => turno = value; }
        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Nota3 { get => nota3; set => nota3 = value; }

        public double calcularPromedio() { 
            return ((nota1 + nota2 + nota3) / 3);
        }

        public String mostrarInformacion() {
            return "Nombre: " + nombre + Environment.NewLine + "Edad: " + edad + Environment.NewLine + "Cedula: " + cedula + Environment.NewLine + "Turno: " + turno + Environment.NewLine + "Nota 1: " + nota1 + Environment.NewLine + "Nota 2: " + nota2 + Environment.NewLine + "Nota 3: " + nota3 + Environment.NewLine + "Promedio: " + calcularPromedio();
        }
    }
}
