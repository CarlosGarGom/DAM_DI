using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_VisualizaMes
{
    class VisualizaMes
    {

        static void Main(string[] args)
        {
            bool visualiza = false;
            int contador = 1;
            int diaSemana;
            int diasMes;
            string sfecha;
            string[] meses ={"Enero","Febrero","Marzo","Abril","Mayo","Junio",
							   "Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
            DateTime fecha;
            Console.Write("Introduce una fecha (dd/mm/aa) :");
            sfecha = Console.ReadLine();
            try
            {
                fecha = DateTime.Parse(sfecha);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("  Mes de " + meses[fecha.Month - 1] + " de " + fecha.Year);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("| LU | MA | MI | JU | VI | SA | DO |");
                Console.WriteLine("------------------------------------");
                // Dias del mes actual utilizando el método estático DaysInMonth:
                diasMes = DateTime.DaysInMonth(fecha.Year, fecha.Month);
                // Día de la semana para el primer dia del mes:
                diaSemana = (int)new DateTime(fecha.Year, fecha.Month, 1).DayOfWeek;
                // En este caso el cast (int) es necesario porque DayOfWeek es
                // un enumerado,
                // El valor obtenido es 0 para Domingo, 1 para Lunes, etc.
                if (diaSemana == 0) // Si el primer día es Domingo lo 
                    diaSemana = 7; // colocamos en su posición
                for (int lin = 1; lin < 7; lin++)
                {
                    for (int col = 1; col < 8; col++)
                    {
                        if (lin == 1 && col == diaSemana)
                            visualiza = true;
                        if (contador > diasMes)
                            visualiza = false;
                        if (visualiza)
                            Console.Write("| {0,2} ", contador++);
                        else
                            Console.Write("|    ");
                    }
                    Console.WriteLine("|");
                    Console.WriteLine("------------------------------------");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Fecha Incorrecta");
            }
        }
    }
}
