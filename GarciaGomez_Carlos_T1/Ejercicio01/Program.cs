using System;
namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mostrar posicion impar en array
            string[] arrayInicial = { "234 64 32", "23 25 29 31" };

            string[] arrayFinal = NumerosImpares(arrayInicial);

            Console.WriteLine("Array Inicial:");
            foreach (string result in arrayInicial)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("Array Final:");
            foreach (string result in arrayFinal)
            {
                Console.WriteLine(result);
            }
        }
   

    static string[] NumerosImpares(string[] arrayInicial)
    {
       
        string[] arrayFinal = new string[arrayInicial.Length];

     
        // Recorro Array Inicial
        for (int i = 0; i < arrayInicial.Length; i++)
        {
           // Separo los numeros por los espacios
            string[] numeros = arrayInicial[i].Split(' ');

            // Inicializo lista para guardar los numeros impares
            var numerosImpares = new System.Collections.Generic.List<string>();

           //Recorro array de numeros y si la posicion es impar lo guardo
            for (int j = 0; j < numeros.Length; j++)
            {
                // como el array empieza por la posicion 0:
                // podemos sumar 1 a la j o simplemente hacere que la posicion sea par
                if ((j+1) % 2 != 0) 
                {
                    numerosImpares.Add(numeros[j]);
                }
            }
            // Meto los numeros en la posicion Impar al array final
            arrayFinal[i] = string.Join(" ", numerosImpares);
        }

        return arrayFinal;
    }
    }
}
