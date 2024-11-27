using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_BarrasVerticales
{
	class ClaseBarras
	{
		static string [] literalMeses={"ENE","FEB","MAR","ABR","MAY","JUN","JUL",
								"AGO","SEP","OCT","NOV","DIC"};
		static int [] valoresMeses=new int[12];
		static void Main(string[] args)
		{
			// Validar la entrada de datos:
			try 
            {
				for (int i=0;i<args.Length;i++) 
				{
					valoresMeses[i]=int.Parse(args[i]);
					if (valoresMeses[i] > 20)
						throw new FormatException();
				}
			}
			catch(FormatException)
			{
				Console.WriteLine("Se ha introducido un argumento no válido");
				return;
			}
			// Bucle que visualiza cada una de las líneas:
			for (int i=20;i>0;i--)
			{
				Console.Write("{0,2} |",i);
				// Se comprueba el valor de cada mes y se visualiza (o no) el "*"
				for(int j=0;j<12;j++)
					if (valoresMeses[j]>=i)
						Console.Write("  *  ");
					else
						Console.Write("     ");
                Console.WriteLine();
      			}
			// Visualiza el pie del informe:
			Console.WriteLine(new String('-',64));
			Console.Write("    ");
			for (int i=0;i<12;i++)
				Console.Write(" "+literalMeses[i]+" ");
			Console.WriteLine();
			Console.WriteLine(new String('-',64));
		}
	}
}