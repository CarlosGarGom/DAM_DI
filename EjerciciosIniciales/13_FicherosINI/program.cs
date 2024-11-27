using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_FicherosINI
{
    class FicherosIni
    {
        static void Main(string[] args)
        {

            char[] linea = new char[20];
            string[] lista = Directory.GetFiles("C:\\windows", "*.ini");
            if (lista.Length == 0)
                Console.WriteLine("No hay ficheros .ini en C:\\windows");
            else
                Console.WriteLine("Nombre       |Tamaño    |Primeros 20 caracteres");
            Console.WriteLine(new string('-', 60));
            foreach (string fichero in lista)
            {
                // Visualizar el nombre del fichero:
                Console.Write(Path.GetFileName(fichero).PadRight(12, ' ') + " | ");
                // Visualizar el tamaño del fichero:
                FileInfo objetoFichero = new FileInfo(fichero);
                Console.Write("{0,8} | ", objetoFichero.Length);
                // Leer los 20 primeros caracteres:
                StreamReader flujo = new StreamReader(fichero);
                int nCaracteres = flujo.Read(linea, 0, 20);
                // Visualizar los 20 primeros caracteres:
                for (int i = 0; i < nCaracteres; i++)
                    Console.Write(linea[i]);
                Console.WriteLine();
                // Esto último también se puede hacer con:
                // Console.WriteLine(new string(linea));

                flujo.Close();
            }
            Console.WriteLine(new string('-', 60));

        }
    }
}