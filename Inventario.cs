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
            if (item.Codigo == codigo)
            {
                item.MostrarInformacion();
            }

        };

            return "El producto que busca no existe.";
    }

    // METODO LISTAR PRODUCTOS
    public static void ListarProductos()
    {
        int orden = 1;

        if (inventario.Count == 0) // valida la existencia de productos
        {
            Console.WriteLine("\nEl inventario esta vacio");
            return;
        }

        
        foreach (Producto item in inventario) // crea la lista segun los productos
        {
            Console.WriteLine($"----- Producto número #{orden} -----\n");
            item.MostrarInformacion(); // metodo que muestra la informacion del producto
            orden++;
        }

        Console.WriteLine("Producto enlistado correctamente.");
    }

    // METODO ACTUALIZAR PRECIOS
    public static bool ActualizarPrecio(string codigo, decimal precio)
    {
       Producto? productoEncontrado = inventario.FirstOrDefault(p => p.Codigo == codigo);

       if (productoEncontrado != null)
        {
            if (productoEncontrado.Precio != precio)
            {
                productoEncontrado.Precio = precio;
                return true;
            }
        }
        return false;
    }

};




