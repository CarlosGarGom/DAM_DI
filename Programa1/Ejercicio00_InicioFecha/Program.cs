using System;
namespace Ejercicio00_InicioFecha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y, m, d;
            DateTime fecha;
            try
            {
                Console.WriteLine("Dia:");
                d = int.Parse(Console.ReadLine());
                Console.WriteLine("Mes");
                m = int.Parse(Console.ReadLine());
                Console.WriteLine("Año:");
                y = int.Parse(Console.ReadLine());

                fecha = new DateTime(y, m, d);

                
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Fecha Invalida: {0}", e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Fecha Correcta");
        }
    }
}
