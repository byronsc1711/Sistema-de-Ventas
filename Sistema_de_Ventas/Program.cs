using System;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;


namespace Sistema_de_Ventas
{
    class Ventas
    {
        static void Main(string[] args)
        {
            var aleatorio = new Random();
            var producto = new Productos
            {
                Id = aleatorio.Next(),
                Nombre_Producto = "Litro de leche",
                TipoDeProducto = "lácteos",
                Precio = 1
            };

            var cliente = new Cliente
            {
                Id = aleatorio.Next(),
                Nombre_Cliente = "Juan Scorpio",
                Producto_Adquirido = "lácteos"
            };

            var vendedor = new Vendedor
            {
                Id = aleatorio.Next(),
                Nombre = "Maria",
                Telefono = "0984563421",
                Id_Producto = 0001
            };

            Console.Write($"La vendedora Maria se presenta a los clientes");
            Console.Write($"Se encarga de vender los productos que necesiten los usuarios ");
            Console.WriteLine($" Juan pregunta el precio de {producto.Nombre_Producto} y realiza el pago de {producto.Precio}");
            Console.Write("Presione Enter para salir");
            Console.ReadKey();
        }
    }
}