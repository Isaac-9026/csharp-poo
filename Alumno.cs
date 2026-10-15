using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPOO
{
    public class Alumno : Persona
    {
        public string? Codigo { get; set; } = "";
        public string? Carrera { get; set; } = "Ingeniería de Software";


        //Nota: es posible tener más de una implmentación de un  m´´etodo (incluye construcciones)
        //siempre que sea diferente la firma (parámetros)

        //C1: Vacío
        public Alumno() { }

        //C2: Sobrecarga
        public Alumno(string Codigo, string Carrera)
        {
            this.Codigo = Codigo;
            this.Carrera = Carrera;
        }

        /// <summary>
        /// Matricula con codigo
        /// </summary>
        /// <param name="Codigo">Identificar al alumno</param>
        /// <returns></returns>
        public bool Matricular(string Codigo)
        {
            return true;
        }


        /// <summary>
        /// Matricula con especificacion de Carrera
        /// </summary>
        /// <param name="Codigo">Identificar al alumno</param>
        /// <param name="Carrera">Datos de la carrera</param>
        /// <returns></returns>
        public bool Matricular(string Codigo, string Carrera)
        {
            return true;
        }

        /// <summary>
        /// Matricula con especificacion de Carrera y modalidad de presencialidad
        /// </summary>
        /// <param name="Codigo">Identificar al alumno</param>
        /// <param name="Carrera">Datos de la carrera</param>
        /// <param name="esPresencial">True para presencial , false para no presencial</param>
        /// <returns></returns>
        public bool Matricular(string Codigo, string Carrera, bool esPresencial)
        {
            return true;
        }
    }
}
