namespace EjercicioMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Método que suma uno a un número y devuelve el resultado en un parámetro de salida
            static void SumarUno(int numero, out int resultado)
            {
                resultado = numero + 1;
            }

            // Método que demuestra que las matrices se pasan por referencia
            static void ModificarMatriz(int[,] matriz)
            {
                matriz[0, 0] = 999; // Cambiamos el primer valor de la matriz
            }

            // Método que usa un parámetro de salida para sumar los elementos de una matriz
            static void SumarElementosMatriz(int[,] matriz, out int suma)
            {
                suma = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        suma += matriz[i, j];
                    }
                }
            }

            static void Main(string[] args)
            {
                // Ejemplo del primer método
                int numero = 5;
                int resultado;
                SumarUno(numero, out resultado);
                Console.WriteLine($"Suma de uno al número {numero} es: {resultado}");

                // Ejemplo del segundo método
                int[,] matriz = { { 1, 2 }, { 3, 4 } };
                Console.WriteLine("Matriz antes de la modificación:");
                MostrarMatriz(matriz);
                ModificarMatriz(matriz);
                Console.WriteLine("Matriz después de la modificación:");
                MostrarMatriz(matriz);

                // Ejemplo del tercer método
                int sumaElementos;
                SumarElementosMatriz(matriz, out sumaElementos);
                Console.WriteLine($"La suma de los elementos de la matriz es: {sumaElementos}");
            }

            // Método auxiliar para mostrar la matriz
            static void MostrarMatriz(int[,] matriz)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        Console.Write(matriz[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
    }
}
