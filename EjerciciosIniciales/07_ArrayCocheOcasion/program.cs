using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ArrayCocheOcasion
{

	class CocheOcasión
	{
		string marcaYModelo;
		int km;
		int añosAntiguedad;
		public CocheOcasión(string marcaYModelo, int km, int añosAntiguedad)
		{
			this.marcaYModelo = marcaYModelo;
			this.km = km;
			this.añosAntiguedad = añosAntiguedad;
		}
		public string MarcaYModelo
		{
			get { return marcaYModelo; }
			set { marcaYModelo = value; }
		}
		public int Km
		{
			get { return km; }
			set { km = value; }
		}
		public int AñosAntiguedad
		{
			get { return añosAntiguedad; }
			set { añosAntiguedad = value; }
		}
		public void IncrementarAños()
		{
			añosAntiguedad++;
		}
	}
	class ArrayCoches
	{
		static ArrayList listaCoches = new ArrayList();
		static void AñadirCoche()
		{
			string marcaYModelo;
			int km;
			int añosAntiguedad;
			try
			{
				Console.Write("Introducir Marca y Modelo     :");
				marcaYModelo = Console.ReadLine();
				Console.Write("Introducir Nº Kilómetros      :");
				km = int.Parse(Console.ReadLine());
				Console.Write("Introdicir años de antiguedad :");
				añosAntiguedad = int.Parse(Console.ReadLine());
				CocheOcasión coche = new CocheOcasión(marcaYModelo, km, añosAntiguedad);
				listaCoches.Add(coche);
			}
			catch (FormatException)
			{
				Console.WriteLine("Error al introducir datos");
				Console.ReadLine();
			}
		}
		static void BorrarCoche(int posición)
		{
			if (posición >= 0 && posición < listaCoches.Count)
			{
				listaCoches.RemoveAt(posición);
				Console.WriteLine("Elemento {0} eliminado.", posición);
			}
			else
				Console.WriteLine("Nº de elemento fuera del rango");
			Console.ReadLine();
		}
		static void ListarCoches()
		{
			Console.WriteLine("Marca y Modelo                   Km    Año");
			Console.WriteLine("------------------------------------------");
			foreach (CocheOcasión coche in listaCoches)
			{
				Console.Write(coche.MarcaYModelo.PadRight(30, ' '));
				Console.WriteLine(" {0,5} {1,4} ", coche.Km, coche.AñosAntiguedad);
			}
			Console.WriteLine("------------------------------------------");
			Console.WriteLine("Pulse Return para continuar");
			Console.ReadLine();
		}
		static void IncrementarAños()
		{
			foreach (CocheOcasión coche in listaCoches)
				coche.IncrementarAños();
			Console.WriteLine("Se ha incrementado el añoDentiguedad de cada uno de los coches");
		}
		static void Main(string[] args)
		{
			string opcion = "";
			while (opcion != "5") // Bucle mientras la opción no sea fin
			{
				Console.WriteLine("1.- Añadir Coche");
				Console.WriteLine("2.- Borrar Coche");
				Console.WriteLine("3.- Listado");
				Console.WriteLine("4.- Incrementar Año");
				Console.WriteLine("5.- Fin");
				Console.Write("Opción ? ");
				opcion = Console.ReadLine();
				switch (opcion)
				{
					case "1": // Añadir coche
						AñadirCoche();
						break;
					case "2": // Borrar coche
						Console.Write("Introduce el nº de elemento a borrar:");
						try
						{
							int posición = int.Parse(Console.ReadLine());
							BorrarCoche(posición - 1);
						}
						catch (FormatException)
						{
							Console.WriteLine("Nº de elemento incorrecto.");
						}
						break;
					case "3": // Listado completo
						ListarCoches();
						break;
					case "4": // Incrementar Años
						IncrementarAños();
						Console.WriteLine("Operación realizada. Pulse return.");
						Console.Read();
						break;
				}
			}

		}
	}
}