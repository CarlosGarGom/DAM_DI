namespace Diccionario
{
    internal class Program
    {
        static Dictionary<string, string> dictionary = new Dictionary<string, string>()
        {
            {"perro", "dog"},
            {"gato", "cat"}
        };

        static void Main(string[] args)
        {

            // Comprobar el número de parámetros
            if (args.Length == 1)
            {
                string key = args[0];

                // Si recibe un parámetro, comprueba si la clave existe
                if (dictionary.ContainsKey(key))
                {
                    dictionary.Remove(key);
                    Console.WriteLine($"Se ha eliminado la clave {key}");
                }
                else
                {
                    Console.WriteLine($"La clave {key} no existe");
                }
            }
            else if (args.Length == 2)
            {
                string key = args[0];
                string value = args[1];

                // Si recibe dos parámetros, comprueba si la clave existe
                if (dictionary.ContainsKey(key))
                {
                    Console.WriteLine($"Ya existe una clave {key}");
                }
                else
                {
                    dictionary.Add(key, value);
                    Console.WriteLine($"Se ha añadido el par {key} {value}");
                }
            }
            else
            {
                Console.WriteLine("Número de parámetros incorrecto. Debes proporcionar 1 o 2 parámetros.");
            }
        }
    }
}
