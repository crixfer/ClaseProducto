namespace ClaseProducto
{
    class Program
    {
        static void Main(string[] args)
        {
            // objetos
            Producto radioCasetera = new Producto("Casetera", "CD001", 500m, 1);
            Producto television = new Producto("TV", "CD002", 15000m, 3);
            Producto maquinaCoser = new Producto("Maquina de Coser", "CD003", 8000m, 1);

            radioCasetera.MostrarInformacion();

            television.MostrarInformacion();

            maquinaCoser.MostrarInformacion();

        }
    }
}