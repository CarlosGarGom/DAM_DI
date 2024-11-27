using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjercicioArticulo
{

    class Articulo : IComparable<Articulo>
    {
        // Propiedades
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }

        // Constructor
        public Articulo(string tipo, string nombre, int stock)
        {
            Tipo = tipo;
            Nombre = nombre;
            Stock = stock;
        }

        // Implementación de IComparable<Articulo>s
        public int CompareTo(Articulo articulo)
        {
            // Ordenar por el campo 'Tipo'
            return this.Tipo.CompareTo(articulo.Tipo);
        }

        // Método para mostrar información del artículo
        public void MostrarInfo()
        {
            Console.WriteLine($"Tipo: {Tipo}, Nombre: {Nombre}, Stock: {Stock}");
        }
    }
    internal class Program
    {
        // Lista de artículos
        static List<Articulo> lista = new List<Articulo>();

        static void Main(string[] args)
        {
            // Añadir artículos a la lista
            lista.Add(new Articulo("B", "Tornillo 12", 20));
            lista.Add(new Articulo("A", "Tuerca 1", 5));
            lista.Add(new Articulo("C", "Tornillo 3", 4));
            lista.Add(new Articulo("B", "Tornillo 10", 3));
            lista.Add(new Articulo("A", "Tuerca 15", 5));


            // Ordenar usando IComparable
            lista.Sort();
            // Mostrar todos los artículos de la lista
            MostrarArticulos();
            ContarArticulosPorTipo();
        }

        // Método para mostrar la lista de artículos
        static void MostrarArticulos()
        {
            Console.WriteLine("Lista de artículos:");
            foreach (Articulo articulo in lista)
            {
                articulo.MostrarInfo();
            }
        }
        static void ContarArticulosPorTipo()
        {
            var conteoPorTipo = lista.GroupBy(a => a.Tipo)
                                      .Select(b => new { Tipo = b.Key, Total = b.Sum(a => a.Stock) });

            Console.WriteLine("\nTotal de artículos por tipo:");
            foreach (var item in conteoPorTipo)
            {
                Console.WriteLine($"Tipo: {item.Tipo}, Total: {item.Total}");
            }
        }

    }
}
