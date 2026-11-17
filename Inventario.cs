namespace ClaseProducto;


class Inventario
{
    private List<Producto> inventario = new List<Producto>();

    // metodos

    // METODO AGREGAR PRODUCTO

    public string AgregarProducto(Producto producto)
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

    public string BuscarPorCodigo(string codigo) // este metodo es solo la logica. Debo agregar los mensajes de instrucciones
    {

        foreach (Producto item in inventario)
        {
            if (item.Codigo == codigo)
            {
                return item;
            }

        };

    }

    // METODO LISTAR PRODUCTOS

    public string ListarProductos()
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
    }

};

// Lista para agregar objetos de clase producto




