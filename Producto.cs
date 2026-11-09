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
            set { Nombre = value; }
        }


        public string? Codigo
        {
            get { return _codigo; }
            set { Codigo = value; }
        }

        public decimal? Precio
        {
            get { return _precio; }
            set { Precio = value; }
        }

        public int? Cantidad
        {
            get { return _cantidad; }
            set { Cantidad = value; }
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
        public void MostrarInformacion()
        {
            Console.WriteLine("===== Información del Producto =====\n");
            Console.WriteLine($"Código producto:   {Codigo}");
            Console.WriteLine($"Nombre producto:   {Nombre}");
            Console.WriteLine($"Precio producto:   $RD{Precio:2N}");
            Console.WriteLine($"Cantidad producto: {Cantidad}");

            Console.WriteLine($"Total a pagar:     {CalcularValorTotal()}");
        }

        public decimal? CalcularValorTotal()
        {
            return Precio * Cantidad;
        }
    }
}