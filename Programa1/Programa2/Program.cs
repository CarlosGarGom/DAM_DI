using System; 
namespace Programa2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Pedir por pantalla un nombre hello world + nombre
            //string nombre;

            //Console.WriteLine("Escriba su nombre:");
            //
            //nombre = Console.ReadLine();
            int a = 1;
            int b = 0;
            int c;
            try
            {
                Console.WriteLine("Hello, World! {0} {1}", args[0], args[1]);
                c = a / b;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("error {0}", e.ToString());
            }
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine("error {0}", e.ToString());
            }
        }
    }
}
