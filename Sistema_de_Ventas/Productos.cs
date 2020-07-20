using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Sistema_de_Ventas
{
    class Productos
    {
        public int Id { get; set; }
        public string Nombre_Producto { get; set; }
        public string TipoDeProducto { get; set; }
        public int Precio { get; set; }
        public Cliente Comprador { get; set; }

        public string Producto()
        {
            if (TipoDeProducto.ToLower() == "verduras y hortalizas")
            {
                return "Son plantas herbácea hortícola";
            }
            else if (TipoDeProducto.ToLower() == "frutas")
            {
                return "Son importante para la salud ";
            }
            else if (TipoDeProducto.ToLower() == "lácteos")
            {
                return "Son alimentos proteicos y de poder energético";
            }
            else
            {
                Console.Write($"¿Que producto es {TipoDeProducto} ? ");
                string nombre = Console.ReadLine();
                return nombre;
            }

        }
        public string Consumir()
        {
            return $"{this.Nombre_Producto} le gusta consumir {this.TipoDeProducto}";
        }
        public string Comprar()
        {
            return $"{this.Nombre_Producto} le gusta comprar {this.TipoDeProducto}";
        }
        public string Vender()
        {
            if (Nombre_Producto.ToLower() == "producto mas comprado")
            {
                return $"Los productos {this.Nombre_Producto} son los mas vendidos {Precio}";
            }
            else
            {
                return "Solo puede el producto mas comprado";
            }

        }
    }
}