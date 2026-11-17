
namespace ClaseProducto
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = -1;

            do
            {
                Console.Clear();
                Console.WriteLine("=========================================");
                Console.WriteLine("          GESTIÓN DE INVENTARIO          ");
                Console.WriteLine("=========================================");
                Console.WriteLine("1. Registrar producto");
                Console.WriteLine("2. Listar productos");
                Console.WriteLine("3. Buscar producto por código");
                Console.WriteLine("4. Actualizar precio");
                Console.WriteLine("5. Agregar existencias");
                Console.WriteLine("6. Consultar valor total");
                Console.WriteLine("0. Salir");
                Console.WriteLine("=========================================");
                Console.Write("Seleccione una opción: ");

                // Validamos que el usuario ingrese un número válido
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = -1; // Fuerza a entrar en el 'default' si escribe letras
                }

                Console.WriteLine(); // Salto de línea estético

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("--- REGISTRAR PRODUCTO ---");
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el nombre del producto que desea registrar\n");
                        Console.Write("Nombre del producto: ");

                        Inventario.AgregarProducto();
                        break;

                    case 2:
                        Console.WriteLine("--- LISTAR PRODUCTOS ---");
                        Inventario.ListarProductos();
                        break;

                    case 3:
                        Console.WriteLine("--- BUSCAR PRODUCTO POR CÓDIGO ---");

                        Inventario.BuscarPorCodigo();
                        break;

                    case 4:
                        Console.WriteLine("--- ACTUALIZAR PRECIO ---");
                        // Aquí pides el código, el nuevo precio y lo actualizar
                        break;

                    case 5:
                        Console.WriteLine("--- AGREGAR EXISTENCIAS ---");
                        // Aquí pides el código y sumas la nueva cantidad al stock
                        break;

                    case 6:
                        Console.WriteLine("--- CONSULTAR VALOR TOTAL ---");
                        // Aquí muestras el valor total de un producto o de todo el inventario
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del sistema. ¡Hasta pronto!");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                        break;
                }

                // Pausa la pantalla antes de volver a mostrar el menú (excepto al salir)
                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }
    }
}
