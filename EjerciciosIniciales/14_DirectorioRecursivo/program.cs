using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _14_DirectorioRecursivo
{
	class Ficheros
	{
		static void ListaDirectorios(string dir)
		{
			Console.WriteLine("Directorio : "+dir);
			string[] lista=Directory.GetFileSystemEntries(dir);
			foreach (string s in lista)
			{
				if (File.Exists(s))
					Console.WriteLine(Path.GetFileName(s));
				else
					ListaDirectorios(s);
			}
		}
		static void ListaDirectorios1(DirectoryInfo dir)
		 {
			 Console.WriteLine("Directorio : "+dir);
			 FileSystemInfo[] lista=dir.GetFileSystemInfos();
			 foreach (FileSystemInfo f in lista)
			 {
				 if (f is FileInfo)   // Comprueba el tipo de objeto con "is"
					 Console.WriteLine(f.Name);
				 else
					 ListaDirectorios1((DirectoryInfo)f); // Realiza "cast"
			 }
		 }
		public static void Main(string[] args)
		{
			// Utilizando las clases File y Directory
			Console.WriteLine("Introduce el nombre del directorio");
			string dir=Console.ReadLine();
			ListaDirectorios(dir);
			// Utilizando las clases FileInfo y DirectoryInfo
			Console.WriteLine("Introduce el nombre del directorio");
			DirectoryInfo dir1=new DirectoryInfo(Console.ReadLine());
			ListaDirectorios1(dir1);
		}
	}
}
