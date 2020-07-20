using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Ventas
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Producto_Adquirido { get; set; }


        public Productos TipodeProducto { get; set; }
        public Productos Precio { get; set; }
        public Productos Nombre_Producto { get; set; }
        public Vendedor Nombre { get; set; }
        public string Registrar()
        {
            return $"{Nombre_Cliente}";
        }
        public string Vender()
        {
            return $"{Nombre} es quien está encargado de vender el {Nombre_Producto}";
        }
        public string Comprar()
        {
            return $"{TipodeProducto} adquirir el producto deseado";
        }
        public string Pagar()
        {
            return $"{Producto_Adquirido} va ha pagar {Precio}";
        }
        
    }
}
