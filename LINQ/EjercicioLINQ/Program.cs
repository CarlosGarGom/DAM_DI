namespace EjercicioLINQ
{
    internal class Program
    {

        class Persona
        {
            String nombre;
            int edad;
            String ciudad;

            public String Nombre { set; get; }
            public int Edad { set; get; }
            public String Ciudad { set; get; }
        }

        public static void Main()
        {
            List<Persona> lista = new List<Persona>
        {
            new Persona { Nombre = "Ana", Edad = 20, Ciudad = "Barcelona" },
            new Persona { Nombre = "David", Edad = 25, Ciudad = "Madrid" },
            new Persona { Nombre = "Carolina", Edad = 30, Ciudad = "Barcelona" },
            new Persona { Nombre = "Bruno", Edad = 35, Ciudad = "Sevilla" },
            new Persona { Nombre = "Elena", Edad = 40, Ciudad = "Madrid" }
        };

            // Utiliza LINQ para filtrar las personas que tengan más de 30 años, y guardar el resultado en una variable mayoresDe30.
            var mayoresDe30 = lista.Where(c => c.Edad > 30).ToList();
            Console.WriteLine("Personas mayores de 30 años:");
            foreach (var persona in mayoresDe30)
            {
                Console.WriteLine($"{persona.Nombre}, {persona.Edad} años, {persona.Ciudad}");
            }
            Console.WriteLine();

            // Utiliza LINQ para ordenar las personas por nombre en orden alfabético ascendente, y guardar el resultado en una variable personasOrdenadas.
            var personasOrdenadas = lista.OrderBy(c => c.Nombre).ToList();
            Console.WriteLine("Personas ordenadas por nombre:");
            foreach (var persona in personasOrdenadas)
            {
                Console.WriteLine($"{persona.Nombre}, {persona.Edad} años, {persona.Ciudad}");
            }
            Console.WriteLine();

            // Utiliza LINQ para encontrar todas las ciudades únicas en esta lista, y guardar el resultado en una variable ciudadesUnicas.
            var ciudadesUnicas = lista.Select(c => c.Ciudad).Distinct().ToList();
            Console.WriteLine("Ciudades únicas:");
            foreach (var ciudad in ciudadesUnicas)
            {
                Console.WriteLine(ciudad);
            }
            Console.WriteLine();

            // Utiliza LINQ para calcular la edad promedio de las personas en la lista, y guardar el resultado en una variable edadPromedio.
            var edadPromedio = lista.Average(c => c.Edad);
            Console.WriteLine($"Edad promedio: {edadPromedio}");
            Console.WriteLine();

            // Utiliza LINQ para encontrar la persona más joven en la lista, y guardar el resultado en una variable personaMasJoven.
            var personaMasJoven = lista.OrderBy(c => c.Edad).FirstOrDefault();
            Console.WriteLine($"Persona más joven: {personaMasJoven.Nombre}, {personaMasJoven.Edad} años");
            
        }
    }
}
