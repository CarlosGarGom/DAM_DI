using System;
using System.Globalization;

namespace Ej05_VisualizaMes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try { 

            // Solicitar el año y mes 
            Console.Write("Introduce el año: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Introduce el mes (1-12): ");
            int month = int.Parse(Console.ReadLine());

            // Obtener el primer día del mes y el número de días del mes
            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);

            // Mostrar encabezado del calendario
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Mes de {firstDayOfMonth.ToString("MMMM", new CultureInfo("es-ES"))} de {year}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("| LU | MA | MI | JU | VI | SA | DO |");
            Console.WriteLine("---------------------------------------");

            // Encontrar en qué día de la semana empieza el mes
            int startDay = (int)firstDayOfMonth.DayOfWeek;
            startDay = (startDay == 0) ? 7 : startDay; // Ajustar si el primer día es domingo

            // Imprimir los espacios vacíos antes del primer día del mes
            for (int i = 1; i < startDay; i++)
            {
                Console.Write("     ");
            }

            // Imprimir los días del mes
            for (int day = 1; day <= daysInMonth; day++)
            {
                Console.Write($"| {day.ToString("D2")} ");

                // Si es domingo, pasar a la siguiente línea
                if ((startDay + day - 1) % 7 == 0)
                {
                    Console.WriteLine("|");
                    Console.WriteLine("---------------------------------------");
                }
            }

            // Completar la última fila con espacios si no termina en domingo
            int lastDay = (startDay + daysInMonth - 1) % 7;
            if (lastDay != 0)
            {
                for (int i = lastDay; i < 7; i++)
                {
                    Console.Write("     ");
                }
                Console.WriteLine("|");
                Console.WriteLine("---------------------------------------");
            }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error<: El valor introducido no es válido. Por favor, introduce un número.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se produjo un error inesperado: {ex.Message}");
            }
        }
        }
}
