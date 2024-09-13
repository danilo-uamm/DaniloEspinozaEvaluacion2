using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaniloEspinozaEvaluacion2.Model
{
    internal class Persona
    {
        public string sNombre1 { get; set; }
        public string sNombre2 { get; set; }
        public string sApellido1 { get; set; }
        public string sApellido2 { get; set; }
        public int iEdad { get; set; }

        public Persona()
        {
        }

        public Persona(string sNombre1, string sNombre2, string sApellido1, string sApellido2, int iEdad)
        {
            this.sNombre1 = sNombre1;
            this.sNombre2 = sNombre2;
            this.sApellido1 = sApellido1;
            this.sApellido2 = sApellido2;
            this.iEdad = iEdad;
        }

        public override string ToString()
        {
            return $"Nombre completo: {sNombre1} {sNombre2} {sApellido1} {sApellido1}, Edad: {iEdad} años";
        }
    }
}
