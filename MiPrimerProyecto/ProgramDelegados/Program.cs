namespace Delegados0
{

    class ClaseA
    {
        public void Metodo1(int i) { Console.WriteLine(i); }
        public static void Metodo2(int i) { Console.WriteLine(i + 1); }
    }

    class ClaseB
    {
        public void Metodo1(int i) { Console.WriteLine(i + 2); }
    }

    //Definimos el delegado
    //Con este delegado podemos hacer referencia a cualquier metodo que no devuelva nada y reciba un parametro int
    delegate void MiDelegado(int i);

    internal class Program
    {
        static void Metodo0(int i) { Console.WriteLine(i + 3); }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Delegados!");

            ClaseA oA = new ClaseA();
            ClaseB oB = new ClaseB();
            // Crea el delegado y añade un método de instancia:
            MiDelegado miD = new MiDelegado(oA.Metodo1);

            miD(10); // Visualiza 10 llama a oA.Metodo1 
            // Añade otro método de instancia
            miD += new MiDelegado(oB.Metodo1);

            // Añade otro método de instancia
            miD += new MiDelegado(ClaseA.Metodo2);
            miD(10); // Visualiza 10 12 11

            miD -= new MiDelegado(oA.Metodo1); // Elimina un método
            miD -= new MiDelegado(ClaseA.Metodo2); // Elimina un método
            miD += new MiDelegado(Metodo0); // Añade un método de la clase
            miD(1); // Visualiza 3 4
        }
    }
}
