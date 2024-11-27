using System;
using System.Diagnostics;
namespace Ej03_EstructuraClase
{


    internal class Program
    {
        struct Spunto
        {
            public int x, y, z;
        }

        class Cpunto
        {
            public int x, y, z;
        }

        static void Main(string[] args)
        {
            const int tamano = 1000000;
            Random random = new Random();

            // estructuras
            Spunto[] aS = new Spunto[tamano];
            Stopwatch swStruct = Stopwatch.StartNew();
            for (int i = 0; i < tamano; i++)
            {
                aS[i].x = random.Next();
                aS[i].y = random.Next();
                aS[i].z = random.Next();
            }
            swStruct.Stop();
            Console.WriteLine($"Milisegundos transcurridos (estructuras): {swStruct.ElapsedMilliseconds}");

            // clases
            Cpunto[] aC = new Cpunto[tamano];
            Stopwatch swClass = Stopwatch.StartNew();
            for (int i = 0; i < tamano; i++)
            {
                aC[i] = new Cpunto
                {
                    x = random.Next(),
                    y = random.Next(),
                    z = random.Next()
                };
            }
            swClass.Stop();
            Console.WriteLine($"Milisegundos transcurridos (clases): {swClass.ElapsedMilliseconds}");
        }
    }

}
