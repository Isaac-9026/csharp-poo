using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPOO
{
    public class Persona
    {
        //En C# el concepto es ATRIBUTO > PROPIEDAD
        //objeto.Propiedad = valor
        public string? Apellidos { get; set; }
        public string? Nombres { get; set; }
        public string? Email {  get; set; }

        //OLD SCHOOL (atributo)
        private int numHijos;

        //Métodos de acceso GETTER/SETTER
        //objeto.metodo();
        public int getNumHijos() { return numHijos; }
        public void setNumHijos(int value) { numHijos = value; }
    }
}
