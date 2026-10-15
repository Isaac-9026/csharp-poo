using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPOO
{
    public class Producto : Activo, IProducto
    {
        //PROPIEDADES con validación
        private decimal _precio;

        public decimal Precio 
        {
            get { return _precio; }
            set
            {
                _precio = value < 0 ? 0 : value;
            }
        }

        public decimal BuscarPrecio(int codigo)
        {
            return 120;
        }

        public string ObtenerRutaFoto(int codigo)
        {
            return "http://aws/fotos/catalog/producto.jpg";
        }

        public int ObtenerStock(int codigo)
        {
            return 1;
        }

        public void registrarProducto(string nombre, decimal Precio)
        {

        }
    }
}
