namespace lambdaDNI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, char> obtenerLetraDNI = dni => "TRWAGMYFPDXBNJZSQVHLCKE"[dni % 23];
            int dni = 12457896;
            Console.WriteLine($"La letra del DNI {dni} es: {obtenerLetraDNI(dni)}");
        }
    }
}
