using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace ClaseProducto
{
    public class Producto
    {
        // encapsulamiento
        public string Nombre = string.Empty;
        public string Codigo = string.Empty;
        public decimal Precio;
        public int Cantidad;
        // fin encapsulamiento

        // metodo constructor
        public Producto(string nombre, string codigo, decimal precio, int cantidad)
        {
            Nombre = nombre;
            Codigo = codigo;
            Precio = precio;
            Cantidad = cantidad;
        }

        // metodos

        // METODO MOSTRAR INFORMACION
        public void MostrarInformacion() // Muestra detalle del producto
        {
            Console.WriteLine($"Código producto:   {Codigo}");
            Console.WriteLine($"Nombre producto:   {Nombre}");
            Console.WriteLine($"Precio producto:   $RD{Precio:N2}");
            Console.WriteLine($"Cantidad producto: {Cantidad}");

            Console.WriteLine($"\nTotal a pagar:     $RD{CalcularValorTotal():N2}\n\n");
        }

        // METODO CALCULAR VALOR TOTAL
        public decimal CalcularValorTotal() => Precio * Cantidad; // Calcula el total de precio por cantidad
    }
}