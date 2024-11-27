using System;
using System.IO;
namespace Ej15_FicherosMatematicos
{
    internal class Program
    {
        static bool GrabaMatriz(int[,] matriz, string fichero)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            try
            {
                FileStream fs = new FileStream(fichero, FileMode.OpenOrCreate, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(filas);
                bw.Write(columnas);
                for (int i = 0; i < filas; i++)
                    for (int j = 0; j < columnas; j++)
                        bw.Write(matriz[i, j]); // Graba cada elemento de la matriz
                bw.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool LeeMatriz(ref int[,] matriz, string fichero)
        {
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fichero, FileMode.Open,FileAccess.Read)))
                {
                    int filas = reader.ReadInt32();
                    int columnas = reader.ReadInt32();
                    matriz = new int[filas, columnas];

                    // Leer datos de la matriz
                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            matriz[i, j] = reader.ReadInt32();
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int[,] matriz =
                        { { 1, 2 },
                          { 3, 4 } };
            string fichero = "matriz.dat";

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write(matriz[i, 0]);
                for (int j = 1; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            if (GrabaMatriz(matriz, fichero))
            {
                Console.WriteLine("Se ha grabado la matriz completa");
            }
            else
            {
                Console.WriteLine("Ocurrio un error en la grabacion");
            }
        }

    }

}
