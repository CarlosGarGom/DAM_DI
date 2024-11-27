using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_InicioFecha
{
    class Program
    {
        static void Main(string[] args)
        {
            int año, mes, dia;
            try
            {
                Console.Write("Introduce un año :");
                año = int.Parse(Console.ReadLine());
                Console.Write("Introduce un mes :");
                mes = int.Parse(Console.ReadLine());
                Console.Write("Introduce un día:");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("La fecha es " + (ValidaFecha(año, mes, dia) ? "Correcta" : "Incorrecta"));
            }
            catch (FormatException)
            {
                Console.WriteLine("Se ha producido un error. Los datos no son correctos");
            }
        }
        static bool ValidaFecha(int año, int mes, int dia)
        {
            if (año < 0 || mes < 1 || mes > 12 || dia < 1 || dia > 31)
                return false;
            switch (mes)
            {
                case 2:
                    if (dia > 29)
                        return false;
                    bool bisiesto = ((año % 4 == 0) && (año % 100 != 0)) || (año % 400 == 0);
                    if (bisiesto == false & dia == 29)
                        return false;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (dia > 30)
                        return false;
                    break;
            }
            return true;
        }
    }
}
