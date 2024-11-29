namespace Ejercicio2
{
    public static class StringExtension
    {
        public static string ToUpperAndReverse(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return input; 

        
            char[] palabra = input.ToUpper().ToCharArray();
            Array.Reverse(palabra);
            return new string(palabra);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "Hola";
            string resultado = texto.ToUpperAndReverse();
            Console.WriteLine($"Entrada: {texto}");
            Console.WriteLine($"Salida: {resultado}"); 
        }
    }
}
