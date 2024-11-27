using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_FicherosMatemáticos
{
	class MatrizFichero
	{
		// Graba una matriz completa en el fichero especificado:
		static bool GrabaMatriz(int[,] matriz,string fichero)
		{
			int filas=matriz.GetLength(0);    // Determina el tamaño
			int columnas=matriz.GetLength(1);
			try 
			{
				FileStream fs=new FileStream(fichero,FileMode.OpenOrCreate,FileAccess.Write);
				BinaryWriter bw=new BinaryWriter(fs);
				bw.Write(filas);	// Graba el número de filas.
				bw.Write(columnas); // Graba el número de columnas.
				for (int i=0;i<filas;i++)
					for (int j=0;j<columnas;j++)
						bw.Write(matriz[i,j]);  // Graba cada elemento de la matriz.
				bw.Close();
			} 
			catch (Exception e) {
				Console.WriteLine("Error :"+e);
				return false;
			}
			return true;
		}
		// Lee una matriz completa en el fichero especificado:
		static bool LeeMatriz(ref int[,] matriz, string fichero)
		{
			int filas,columnas;
			try 
			{
				if (!File.Exists(fichero)) // Si el fichero no existe
					return false;
				FileStream fs=new FileStream(fichero,FileMode.Open,FileAccess.Read);
				BinaryReader br=new BinaryReader(fs);
				filas=br.ReadInt32();		// Lee el número de filas
				columnas=br.ReadInt32();	// Lee el número de columnas
				// Almacena en la referencia (parámetro "ref") una "nueva" matriz:
				matriz=new int[filas,columnas]; 
				// Lee los datos del fichero y los almacena en matriz
				for (int i=0;i<filas;i++)
					for (int j=0;j<columnas;j++)
						matriz[i,j]=br.ReadInt32();
				br.Close();
			} catch (Exception e) {
				Console.WriteLine("Error :"+e);
				return false;
			}
			return true;
		}

		// Graba un elemento en la fila y columna del fichero especificado:
		static bool GrabaCelda(int elemento, int fila, int columna, string fichero)
		{
			try 
			{
				FileStream fs=new FileStream(fichero,FileMode.Open,FileAccess.ReadWrite);
				BinaryReader br=new BinaryReader(fs); 
				BinaryWriter bw=new BinaryWriter(fs);
				int nfilas=br.ReadInt32();		// Lee el número de filas y
                int ncolumnas=br.ReadInt32();	// columnas
				// Comprueba que la celda esta dentro de los límites de la matriz
				if (fila<0 || fila >nfilas || columna<0 || columna>ncolumnas)
				{
					br.Close();
					return false;
				}
				// Cálculo de la posición (4 bytes = un int)
				// Posición=(fila*ncolumnas*4)+columna*4
				// Los 8 primeros bytes están ocupados => Sumamos 8
				bw.Seek((fila*ncolumnas*4)+columna*4+8,SeekOrigin.Begin);
				bw.Write(elemento);
				bw.Close();
				br.Close();
			} 
			catch (Exception e) 
			{
				Console.WriteLine("Error :"+e);
				return false;
			}
			return true;
		}

		// Lee un elemento de la fila y columna del fichero especificado:
		static bool LeeCelda(ref int elemeto, int fila, int columna, string fichero)
		{
			int nfilas,ncolumnas;
			try 
			{
				if (!File.Exists(fichero)) // Si el fichero no existe
					return false;
				FileStream fs=new FileStream(fichero,FileMode.Open,FileAccess.Read);
				BinaryReader br=new BinaryReader(fs);
				nfilas=br.ReadInt32();		// Lee el número de filas
				ncolumnas=br.ReadInt32();	// y de columnas
				// Comprueba que la celda esta dentro de los límites de la matriz
				if (fila<0 || fila >nfilas || columna<0 || columna>ncolumnas)
				{
					br.Close();
					return false;
				}
				// Cálculo de la posición (4 bytes = un int)
				// Posición=(fila*ncolumnas*4)+columna*4
				// Los 8 primeros bytes están ocupados => Sumamos 8
				// ¡ Se utiliza el FileStream porque BinaryReader no admite Seek !
				fs.Seek((fila*ncolumnas*4)+columna*4+8,SeekOrigin.Begin);				
				elemeto=br.ReadInt32();
				br.Close();
			} 
			catch (Exception e) 
			{
				Console.WriteLine("Error :"+e);
				return false;
			}
			return true;
		}
		// Probar los métodos desarrollados:
		static void Main(string[] args)
		{
			// Pruebas: Crear una matriz y almacenarla en el fichero
			int [,] m1=new int[2,10]{{1,2,3,4,5,6,7,8,9,0},{0,9,8,7,6,5,4,3,2,1}};
			if (GrabaMatriz(m1,"matriz1.txt"))
				Console.WriteLine("Se ha grabado la matriz completa");
			else
				Console.WriteLine("Ocurrió un error en la grabación");

			// Pruebas: Leer una matriz del fichero
			int [,] m2=new int[0,0];
			if (LeeMatriz(ref m2,"matriz1.txt"))
				Console.WriteLine("Se ha leido la matriz completa");
			else
				Console.WriteLine("Ocurrió un error en la lectura");
			for (int i=0;i<m2.GetLength(0);i++)
				for (int j=0;j<m2.GetLength(1);j++)
					Console.Write("{0}-",m2[i,j]);
			Console.WriteLine();

			// Pruebas: Grabar un elemento de la matriz
	
			GrabaCelda(99,1,7,"matriz1.txt");

			// Pruebas: Leer un elemento de la matriz
			int elemento=0;
			LeeCelda(ref elemento,1,7,"matriz1.txt");
			Console.Write(elemento);
			}	
	}
}
