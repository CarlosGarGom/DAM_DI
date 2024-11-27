using System;
using System.Collections.Generic;

class Proveedor
{
    // Campos y propiedades
    public string Nombre { get; set; }
    private List<string> productos;

    // Constructor
    public Proveedor(string nombre)
    {
        Nombre = nombre;
        productos = new List<string>();
    }

    // Método para añadir productos
    public void AñadirProducto(string producto)
    {
        productos.Add(producto);
        Console.WriteLine($"Producto '{producto}' añadido al proveedor {Nombre}.");
    }

    // Propiedad para acceder/modificar productos mediante un índice
    public string this[int indice]
    {
        get
        {
            if (indice >= 0 && indice < productos.Count)
            {
                return productos[indice];
            }
            else
            {
                throw new IndexOutOfRangeException("El índice está fuera de rango.");
            }
        }
        set
        {
            if (indice >= 0 && indice < productos.Count)
            {
                productos[indice] = value;
                Console.WriteLine($"Producto en el índice {indice} ha sido modificado a '{value}'.");
            }
            else
            {
                throw new IndexOutOfRangeException("El índice está fuera de rango.");
            }
        }
    }

    // Método para listar todos los productos del proveedor
    public void ListarProductos()
    {
        Console.WriteLine($"Productos del proveedor {Nombre}:");
        for (int i = 0; i < productos.Count; i++)
        {
            Console.WriteLine($"[{i}] {productos[i]}");
        }
    }

    // Propiedad para obtener el número de productos
    public int NumeroDeProductos
    {
        get { return productos.Count; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Crear un nuevo proveedor
            Proveedor bimbo = new Proveedor("BIMBO");

            // Añadir productos al proveedor
            bimbo.AñadirProducto("Croissants de chocolate");
            bimbo.AñadirProducto("Napolitanas de Chocolate");
            bimbo.AñadirProducto("Pan Premium");

            // Listar todos los productos del proveedor
            bimbo.ListarProductos();

            // Acceder a un producto mediante su índice
            Console.WriteLine($"Accediendo al producto en el índice 1: {bimbo[1]}");

            // Modificar un producto mediante su índice
            bimbo[1] = "Napolitanas de Crema";

            // Listar todos los productos para verificar la modificación
            bimbo.ListarProductos();

            Console.WriteLine(bimbo[10]); // Índice fuera de rango
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
