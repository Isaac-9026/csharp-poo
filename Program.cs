//Instancia
using CSharpPOO;

Console.Title = "Prácticas CSharp";

Persona persona = new Persona();
persona.Apellidos = "Paucar Paucar";
persona.Nombres = "Isaac Isaac";
persona.Email = "isaipaucar@gmail.com";
persona.setNumHijos(5);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(persona.Apellidos);
Console.WriteLine(persona.Nombres);
Console.WriteLine(persona.Email);
Console.WriteLine(persona.getNumHijos());

Console.ForegroundColor = ConsoleColor.Yellow;
Documento documento = new Documento("Informe Técnico 01");
Console.WriteLine($"El {documento.Titulo} tiene por código {documento.Codigo}");

Console.ForegroundColor = ConsoleColor.Magenta;
Producto producto = new Producto();
producto.Precio = 7;
Console.WriteLine($"Precio del producto MOUSE {producto.BuscarPrecio(1)}");
Console.WriteLine($"Ruta del producto TECLADO {producto.ObtenerRutaFoto(1)}");//Interfaz
Console.WriteLine($"El precio del producto es {producto.Precio}"); //   Interfaz
Console.WriteLine($"Cantidad de impresoras en stock: {producto.ObtenerStock(1)}"); //Interfaz
producto.registrarProducto("Impresora", 1500); //No hace nada, no devulve nada :D - Interfaz
producto.fechaRegistro = Convert.ToDateTime("2026-10-14"); //Herencia
producto.Estado = true; //Herencia
Console.WriteLine("");

Console.ForegroundColor= ConsoleColor.Cyan;
Alumno alumno = new Alumno("7788", "Diseño Gráfico Digital");
alumno.Apellidos = "Torres Peña"; //Heredado de persona
alumno.Nombres = "Martin"; //Heredado de persona
alumno.Matricular("1122","Administración",false);

Console.WriteLine($"{alumno.Apellidos} {alumno.Nombres} con código [{alumno.Codigo}] estudia {alumno.Carrera}");

Console.ReadKey();
