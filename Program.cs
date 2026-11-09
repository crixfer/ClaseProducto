namespace ClaseProducto
{
    class Program
    {
        static void Main(string[] args)
        {
            // objetos
            Producto RadioCasetera = new Producto("Casetera", "CD001", 500m, 1);
            Producto Television = new Producto("TV", "CD002", 15000m, 3);
            Producto MaquinaCoser = new Producto("Maquina de Coser", "CD003", 8000m, 1);

            RadioCasetera.MostrarInformacion();
            
        }
    }
}