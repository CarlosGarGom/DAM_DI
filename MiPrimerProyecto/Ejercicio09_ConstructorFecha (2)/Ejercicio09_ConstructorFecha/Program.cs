using System.Security.Cryptography;

namespace Ejercicio09_ConstructorFecha
{
    internal class Program
    {
        public class Fecha
        {
            // Campos privados
            private int año;
            private int mes;
            private int dia;

            // Constructor 1: Fecha(int año, int mes, int dia)
            public Fecha(int año, int mes, int dia)
            {
                this.año = año;
                this.mes = mes;
                this.dia = dia;
            }

            public Fecha(string fecha)
            {
                try
                {
                    string[] partes = fecha.Split('/'); // Separar por "/"
                    this.año = int.Parse(partes[0]);
                    this.mes = int.Parse(partes[1]);
                    this.dia = int.Parse(partes[2]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al procesar la fecha: {ex.Message}");
                }
            }
            public bool Validar()
            {
                try
                {
                    // Crear un objeto DateTime, si es inválido lanzará una excepción
                    DateTime fecha = new DateTime(año, mes, dia);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        static void Main(string[] args)
        {
            // Crear objeto con el primer constructor
            // año mes dia
            Fecha fecha1 = new Fecha(2024, 10, 18);
            Console.WriteLine("Validando la fecha 2024/10/18: " + (fecha1.Validar() ? "Válida" : "Inválida"));

            // Crear objeto con el segundo constructor (string)
            // año mes dia
            Fecha fecha2 = new Fecha("2023/02/29");
            Console.WriteLine("Validando la fecha 2024/02/30: " + (fecha2.Validar() ? "Válida" : "Inválida"));
        }
    
    }
}
