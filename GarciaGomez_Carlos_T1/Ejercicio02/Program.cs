namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fecha1 = new DateTime(2015, 8, 5);
            var fecha2 = new DateTime(2015, 5, 5);
            var fecha3 = new DateTime(2015, 7, 5);
            var fecha4 = new DateTime(2015, 11, 5);
            ;
            Console.WriteLine($"Fecha: {fecha1}, Trimestre: {fecha1.ObtenerTrimestre()}");
            Console.WriteLine($"Fecha: {fecha2}, Trimestre: {fecha2.ObtenerTrimestre()}");
            Console.WriteLine($"Fecha: {fecha3}, Trimestre: {fecha3.ObtenerTrimestre()}");
            Console.WriteLine($"Fecha: {fecha4}, Trimestre: {fecha4.ObtenerTrimestre()}");
           
           

        }
    }
    public static class Extension
        {
            public static int ObtenerTrimestre(this DateTime fecha)
            {
             
                return (fecha.Month - 1) / 3 + 1;
            }
        }

    
}
