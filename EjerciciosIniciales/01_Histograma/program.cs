using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Histograma
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.Write("Argumento nº " + i + " :");
                for (int j = 0; j < int.Parse(args[i]) ; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            int c = 0;
            foreach (String a in args)
            {
                Console.Write("Argumento nº " + c++ + " :");
                for (int j = 0; j < int.Parse(a); j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            // El segundo bucle se puede sustituir por:
            // Console.Write(new string('*',int.Parse(args[i])));
        }
    }
}
