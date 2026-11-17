namespace ClaseProducto;


public class Inventario
{
    private static List<Producto> inventario = new List<Producto>();

    // metodos

    // METODO AGREGAR PRODUCTO

    public static string AgregarProducto(Producto producto)
    {
        if (!inventario.Any(p => p.Codigo == producto.Codigo))
        {
            inventario.Add(producto);
            return "Producto agregado satisfactoriamente!";
        }
        else
            return "El código ingresado ya existe.";
    }

    // METODO BUSCAR POR CODIGO

    public static string BuscarPorCodigo(string codigo)
    {

        foreach (Producto item in inventario)
        {
            if (item.Codigo == codigo.ToUpper())
            {
                return $"Producto: {item.Codigo} - {item.Nombre} - $RD{item.Precio}";
            }

        };

            return "El producto que busca no existe.";
    }

    // METODO LISTAR PRODUCTOS

    public static void ListarProductos()
    {
        Console.WriteLine("===== LISTA DE INVENTARIO =====");
        int orden = 1;

        if (inventario.Count == 0)
        {
            Console.WriteLine("El inventario esta vacio");
            return;
        }

        // lista de productos
        foreach (Producto item in inventario)
        {
            Console.WriteLine($"----- Producto numero #{orden} -----");
            item.MostrarInformacion();
            orden++;
        }

        Console.WriteLine("Producto enlistado correctamente");
    }

    // METODO ACTUALIZAR PRECIOS

    public static bool ActualizarPrecio(string codigo, decimal precio)
    {
       Producto productoEncontrado = inventario.FirstOrDefault(p => p.Codigo = codigo);
    }

};

// Lista para agregar objetos de clase producto




