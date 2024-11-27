using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EstructuraClase
{
    class Principal
    {
        struct Spunto
        {
            public int x;
            public int y;
            public int z;
        }
        class Cpunto
        {
            public int x;
            public int y;
            public int z;
        }
        const int n = 1000000;
        static void Main(string[] args)
        {
            Random r = new Random();		// Define el objeto "r" para los nº aleatorios
            DateTime tInicial1 = DateTime.Now;		// Tiempo inicial
            Spunto[] aS = new Spunto[n];	// Declara la matriz de estructuras
            //for (int i = 0; i < n; i++)		// Rellena la matriz de estructuras
            //    aS[i] = new Spunto();
            for (int i = 0; i < n; i++)
            {		// Rellena los campos de la estructura con
                aS[i].x = r.Next();		//  datos aleatorios
                aS[i].y = r.Next();
                aS[i].z = r.Next();
            }
            TimeSpan tiempo1 = DateTime.Now - tInicial1;
            Console.WriteLine("Milisegundos transcurridos (estructuras):" + tiempo1.Milliseconds);

            DateTime tInicial2 = DateTime.Now;		// Tiempo inicial
            Cpunto[] aC = new Cpunto[n];	// Declara la matriz de objetos
            for (int i = 0; i < n; i++)		// Rellena la matriz de objetos
                aC[i] = new Cpunto();
            for (int i = 0; i < n; i++)
            {		// Rellena los campos de los objetos con
                aC[i].x = r.Next();		//  datos aleatorios
                aC[i].y = r.Next();
                aC[i].z = r.Next();
            }
            TimeSpan tiempo2 = DateTime.Now - tInicial2;
            Console.WriteLine("Milisegundos transcurridos (clases):" + tiempo2.Milliseconds);
        }
    }
}
