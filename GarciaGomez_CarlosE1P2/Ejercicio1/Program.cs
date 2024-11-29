using System;
using System.Linq;
namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayInicial = { "a1s2 qqq3464s", "x23ss", "24ee sdf" };
            string[] arrayFinal = ConvierteEnNumeros(arrayInicial);

            Console.WriteLine("Array final:");
            foreach (var item in arrayFinal)
            {
                Console.WriteLine(item);
            }
        }

        public static string[] ConvierteEnNumeros(string[] arrayInicial)
        {
            string[] arrayFinal = arrayInicial.Select(linea =>
            {
                var palabras = linea.Split(' ');

                var palabrasNumericas = palabras
                    .Select(palabra =>
                    {
                        string numeros = new string(palabra.Where(char.IsDigit).ToArray());
                        return string.IsNullOrEmpty(numeros) ? null : numeros; 
                    })
                    .Where(n => n != null); 

               
                return string.Join(" ", palabrasNumericas);
            }).ToArray();

            return arrayFinal;
        }
    }
}