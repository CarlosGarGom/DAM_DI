using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_ConstructorFecha
{
    class Fecha
    {
        int dia;
        int mes;
        int año;
        public Fecha(int dia, int mes, int año)
        {
            this.dia = dia;
            this.mes = mes;
            this.año = año;
        }
        public Fecha(string fecha)
        {
            this.año = int.Parse(fecha.Substring(0, 2));
            this.mes = int.Parse(fecha.Substring(3, 2));
            this.dia = int.Parse(fecha.Substring(6, 2));
        }
        public bool Validar()
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
    class Prueba
    {
        static void Main(string[] args)
        {
            Fecha fechaA = new Fecha(32, 4, 00);
            Fecha fechaB = new Fecha("03/12/10");
            Console.WriteLine(fechaA.Validar());
            Console.WriteLine(fechaB.Validar());
        }
    }
}