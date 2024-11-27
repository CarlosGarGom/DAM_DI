namespace Programa3
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int a;
            string b = "4,7";
            try
            {
                a = int.Parse(b);
                Console.WriteLine("El numero a es: {0}", a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
           
        }
    }
}
