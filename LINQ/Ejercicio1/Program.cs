namespace Ejercicio1
{
    internal class Program
    {
        public class Coche
        {
            public float r1, r2, r3, r4;

            public Coche(float r1, float r2, float r3, float r4)
            {
                this.r1 = r1;
                this.r2 = r2;
                this.r3 = r3;
                this.r4 = r4;
            }
        }


        static void Main(string[] args)
        {
            Coche coche = new Coche(2.3f, 2.5f, 2.1f, 2.4f);
            Func<Coche, float> presionMedia = c => (c.r1 + c.r2 + c.r3 + c.r4) / 4;
            Console.WriteLine($"La presión media de las ruedas es: {presionMedia(coche)}");
        }
    }
}
