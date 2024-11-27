namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = { 1, 2, 3,4 };
            Console.WriteLine(valores[0]);

            SumaUnoMatriz(valores);

            Console.WriteLine(valores[0]);

            int n = 10;
            ejemploOut(out n, n);
            Console.WriteLine(n);

            int resultado;

            sumarElementosMatriz(valores,out resultado);
            Console.WriteLine(resultado);

        }
        static void SumaUnoMatriz(params int[] elementos)
        {
            ++elementos[0];
        }
        static void ejemploOut(out int p, int p1)
        {
            p = ++p1;
        }
        static void sumarElementosMatriz(int[] elementos, out int suma)
        {
            suma = 0;
            for (int i = 0; i < elementos.Length; i++)
            {
                suma += elementos[i];
            }
        }
    }
}
