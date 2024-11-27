using System;
namespace Ejercicio04_BarrasVerticales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializamos la matriz para almacenar los valores de los 12 meses
            int[] meses = new int[12];

            // Pedimos al usuario que introduzca los valores para cada mes
            Console.WriteLine("Introduce un valor entre 1 y 20 para cada mes:");
            string[] nombresMeses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            for (int i = 0; i < meses.Length; i++)
            {
                int valor;
                do
                {
                    Console.Write($"{nombresMeses[i]}: ");
                    valor = int.Parse(Console.ReadLine());

                    // Validamos que el valor esté entre 1 y 20
                    if (valor < 1 || valor > 20)
                    {
                        Console.WriteLine("Por favor, introduce un valor entre 1 y 20.");
                    }
                } while (valor < 1 || valor > 20);

                meses[i] = valor;
            }

            // El valor máximo en la escala de la gráfica
            int maximo = 20;

            // Generamos el gráfico de barras
            for (int i = maximo; i >= 1; i--)
            {
                Console.Write(i.ToString().PadLeft(2) + " | ");
                for (int j = 0; j < meses.Length; j++)
                {
                    if (meses[j] >= i)
                    {
                        Console.Write("*   ");  // Alineamos usando 3 espacios después del asterisco
                    }
                    else
                    {
                        Console.Write("    ");  // Dejar el espacio vacío con 4 espacios
                    }
                }
                Console.WriteLine();
            }

            // Imprimir la línea separadora
            Console.WriteLine(new string('-', 55));  // Ajustar el largo de la línea separadora

            // Imprimir los nombres de los meses (ya están alineados con 4 espacios)
            string[] nombresAbrevMeses = {" ", "ENE", "FEB", "MAR", "ABR", "MAY", "JUN", "JUL", "AGO", "SEP", "OCT", "NOV", "DIC" };
            foreach (var mes in nombresAbrevMeses)
            {
                Console.Write(mes.PadRight(4));  // Alineamos los nombres de los meses
            }

            Console.WriteLine();
        }
    }
}
