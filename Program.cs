
using System.Text.RegularExpressions;

namespace ClaseProducto

    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Producto nuevoProducto = new Producto("", "", 0m, 0); // objeto(instancia) de clase Producto

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
                        Console.Clear();
                        Console.WriteLine("--- REGISTRAR PRODUCTO ---");
                        Console.WriteLine();

                        Console.WriteLine("Ingrese el nombre del producto que desea registrar\n");
                        Console.Write("Nombre del producto: ");
                        nuevoProducto.Nombre = Console.ReadLine()!;

                        Console.WriteLine("Ingrese el código del producto que desea registrar\n");
                        Console.Write("Código del producto: ");
                        string nuevoCodigo = Console.ReadLine()!;

                        if (Regex.IsMatch(nuevoCodigo, @"^\d{3}$"))
                        {
                            nuevoProducto.Codigo = nuevoCodigo;
                        }
                        else
                        {
                            Console.WriteLine("Código inválido. Ingrese solo tres dígitos!");
                        }

                        Console.WriteLine("Ingrese el precio del producto que desea registrar\n");
                        Console.Write("Precio del producto: ");
                        nuevoProducto.Precio = decimal.Parse(Console.ReadLine()!);

                        Console.WriteLine("Ingrese la cantidad del producto que desea registrar\n");
                        Console.Write("Cantidad del producto: ");
                        nuevoProducto.Cantidad = int.Parse(Console.ReadLine()!);

                        Inventario.AgregarProducto(nuevoProducto); // metodo agregar
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("--- LISTA DE PRODUCTOS EN INVENTARIO---");
                        Inventario.ListarProductos();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("--- BUSCAR PRODUCTO POR CÓDIGO ---");
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el codigo que desea consultar");
                        Console.Write("Codigo: ");
                        string codigoProducto = Console.ReadLine()!; 
                        Console.WriteLine();
                        Inventario.BuscarPorCodigo(codigoProducto); // metodo buscar codigo
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("--- ACTUALIZAR PRECIO ---\n");
                        // Aquí pides el código, el nuevo precio y lo actualizar
                        Console.WriteLine("Ingrese el codigo del producto para actualizar su precio");
                        Console.Write("Codigo: ");
                        string codigoPrecio = Console.ReadLine()!;
                        Console.WriteLine();

                        Inventario.BuscarPorCodigo(codigoPrecio); // metodo buscar codigo

                        Console.WriteLine("Actualice el precio del producto");
                        Console.Write("Nuevo Precio: ");
                        
                        decimal nuevoPrecio = decimal.Parse(Console.ReadLine()!);

                        if (nuevoPrecio < 0)
                        {
                            throw new ArgumentOutOfRangeException(nameof(nuevoPrecio), "El precio agregado debe ser mayor a cero!");
                        }
                        else
                        {
                            Console.WriteLine("El precio ha sido actualizado correctamente");
                            Console.WriteLine($"----- DETALLE DE ACTUALIZACIÓN -----\n");
                            Console.WriteLine($"Precio anterior: {nuevoProducto.Nombre} - RD${nuevoProducto.Precio:N2}\n");
                            nuevoProducto.Precio = nuevoPrecio; // actualiza a nuevo precio
                            Console.WriteLine($"Precio actualizado: {nuevoProducto.Nombre} - RD${nuevoProducto.Precio:N2}");

                        }

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
