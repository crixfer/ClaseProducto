namespace ClaseProducto
{
    class Producto
    {
        // encapsulamiento
        private string? _nombre;
        private string? _codigo;
        private decimal? _precio;
        private int? _cantidad;


        public string? Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        public string? Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public decimal? Precio
        {
            get { return _precio; }
            set
            {
                if (value is null)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "El valor asignado es inválido!");
                }
                _precio = value;
            }
        }

        public int? Cantidad
        {
            get { return _cantidad; }
            set
            {
                if (value is null)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "El valor asignado es inválido!");
                }
                _cantidad = value;
            }
        }
        // encapsulamiento

        // metodo constructor
        public Producto(string nombre, string codigo, decimal precio, int cantidad)
        {
            Nombre = nombre;
            Codigo = codigo;
            Precio = precio;
            Cantidad = cantidad;
        }

        // metodos
        public void MostrarInformacion() // Muestra detalle del producto
        {
            Console.WriteLine("===== Información del Producto =====\n");
            Console.WriteLine($"Código producto:   {Codigo}");
            Console.WriteLine($"Nombre producto:   {Nombre}");
            Console.WriteLine($"Precio producto:   $RD{Precio:N2}");
            Console.WriteLine($"Cantidad producto: {Cantidad}");

            Console.WriteLine($"\nTotal a pagar:     $RD{CalcularValorTotal():N2}\n\n");
        }

        public decimal? CalcularValorTotal() // Calcula el total de precio por cantidad
        {
            return Precio * Cantidad;
        }
    }
}