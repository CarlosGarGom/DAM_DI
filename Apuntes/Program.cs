namespace Apuntes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        // Fechas
        public string ObtenerDiaSemana(DateTime fecha)
        {
            return fecha.ToString("dddd"); // Ejemplo: "lunes"
        }
        public int CalcularDiferenciaDias(DateTime fechaInicio, DateTime fechaFin)
        {
            return (fechaFin - fechaInicio).Days;
        }
        public bool EsDiaFestivo(DateTime fecha)
        {
            // Agrega aquí las fechas festivas importantes
            List<DateTime> diasFestivos = new List<DateTime>
    {
        new DateTime(fecha.Year, 1, 1), // Año Nuevo
        new DateTime(fecha.Year, 12, 25) // Navidad
    };

            return diasFestivos.Contains(fecha.Date);
        }
        public List<DateTime> GenerarRangoFechas(DateTime inicio, DateTime fin)
        {
            List<DateTime> rango = new List<DateTime>();
            for (DateTime fecha = inicio; fecha <= fin; fecha = fecha.AddDays(1))
            {
                rango.Add(fecha);
            }
            return rango;
        }

        // Delegados
        public delegate void Operacion(int num1, int num2);

        public void Sumar(int a, int b)
        {
            Console.WriteLine($"Resultado: {a + b}");
        }

        public void EjecutarDelegado()
        {
            Operacion operacion = Sumar;
            operacion(10, 20); // Resultado: 30
        }
        public double EjecutarOperacion(Func<double, double, double> operacion, double x, double y)
        {
            return operacion(x, y);
        }

        public void PruebaFunc()
        {
            double resultado = EjecutarOperacion((a, b) => a * b, 5, 3); // Resultado: 15
            Console.WriteLine($"Resultado: {resultado}");
        }
        //Structs
        public struct Punto
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Punto(int x, int y)
            {
                X = x;
                Y = y;
            }

            public double CalcularDistancia(Punto otro)
            {
                return Math.Sqrt(Math.Pow(otro.X - X, 2) + Math.Pow(otro.Y - Y, 2));
            }
        }
        Punto p1 = new Punto(0, 0);
        Punto p2 = new Punto(3, 4);
        Console.WriteLine($"Distancia: {p1.CalcularDistancia(p2)}"); // Distancia: 5


            // Clases e Interfaces
            public class CuentaBancaria
        {
            public string NumeroCuenta { get; set; }
            public decimal Saldo { get; private set; }

            public CuentaBancaria(string numeroCuenta, decimal saldoInicial)
            {
                NumeroCuenta = numeroCuenta;
                Saldo = saldoInicial;
            }

            public void Depositar(decimal monto)
            {
                Saldo += monto;
            }

            public bool Retirar(decimal monto)
            {
                if (monto > Saldo) return false;
                Saldo -= monto;
                return true;
            }
        }
        public interface IOperaciones
        {
            void Depositar(decimal monto);
            bool Retirar(decimal monto);
        }

        public class CuentaAhorros : CuentaBancaria, IOperaciones
        {
            public CuentaAhorros(string numeroCuenta, decimal saldoInicial) : base(numeroCuenta, saldoInicial) { }
        }
        // Ficheros

        public void EscribirArchivo(string ruta, string contenido)
        {
            File.WriteAllText(ruta, contenido);
        }
        public List<string> LeerArchivo(string ruta)
        {
            return File.Exists(ruta) ? File.ReadAllLines(ruta).ToList() : new List<string>();
        }
        public void GuardarListaEnArchivo(string ruta, List<string> datos)
        {
            File.WriteAllLines(ruta, datos);
        }


    }
}
