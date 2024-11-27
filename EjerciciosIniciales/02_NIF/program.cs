using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_NIF
{
    class NIF
    {
        static string datoNIF;
        static int dniNIF;
        static char letraNIF;
        static bool nifCorrecto = true;
        static string tablaNIF = "TRWAGMYFPDXBNJZSQVHLCKE";

        static void Main(string[] args)
        {
            Console.Write("Intoducir un N.I.F. :");
            datoNIF = Console.ReadLine().ToUpper();
            // Comprobar si la longitud es la correcta
            if (datoNIF.Length < 8 || datoNIF.Length > 9)
                nifCorrecto = false;
            try
            {
                // Obtiene el número correspondiene al NIF
                dniNIF = int.Parse(datoNIF.Substring(0, datoNIF.Length - 1));
                // Obtiene la letra correspondiente al NIF
                letraNIF = datoNIF[datoNIF.Length - 1];
                // Comprueba si la letra es correcta
                if (letraNIF != tablaNIF[dniNIF % 23])
                    nifCorrecto = false;
            }
            catch (FormatException)
            {
                // La parte nuérica contiene algún dato incorrecto
                nifCorrecto = false;
            }
            if (nifCorrecto)
                Console.WriteLine("El NIF introducido es correcto");
            else
                Console.WriteLine("El NIF introducido es incorrecto");

        }
    }
}
