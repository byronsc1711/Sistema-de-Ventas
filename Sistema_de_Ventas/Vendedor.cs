using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Ventas
{
    class Vendedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public int Id_Producto { get; set; }
        public string Presentarse()
        {
            return $"{Nombre} Maria es la persona que trabaja como vendedora.";
        }
        public string Comunicarse()
        {
            return "Se comunica con los clientes";
        }
        public string Explicar()
        {
            return $"Juan explica a los usuarios {Id_Producto} sobre los productos";
        }
        public string Cobrar()
        {
            return $"{Nombre} realiza el cobro de todos los productos";
        }
    }
}

