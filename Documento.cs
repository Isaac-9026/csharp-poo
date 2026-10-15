using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPOO
{
    public class Documento
    {
        //PROPIEDADES de solo lectura
        public string? Codigo { get; } = "SENA-DOC";
        public string? Titulo { get; set; }

        //CONSTRUCTOR método que se ejecuta en el momento de crear instancia
        //Se identifica por tener el mismo nombre de la clase
        public Documento(string Titulo)
        {
            this.Titulo = Titulo;
        }
    }
}
