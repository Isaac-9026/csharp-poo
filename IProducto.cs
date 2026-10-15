using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPOO
{
    internal interface IProducto
    {
        //interfaz = contrato = la forma / reglas de cómo o qué debe implementar una clase
        //Las interfaces NO definen la lógica, solo la responsab
        decimal BuscarPrecio(int codigo);
        int ObtenerStock(int codigo);
        string ObtenerRutaFoto(int codigo);
        void registrarProducto(string nombre, decimal Precio);
    }
}
