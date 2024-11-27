using System;

namespace Ej_Delegado
{
    // Definir un delegado que devuelva un string
    delegate string DelegadoLectura();

    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias del delegado apuntando a los métodos LeerFichero y LeerConsola
            DelegadoLectura delegadoFichero = LeerFichero;
            DelegadoLectura delegadoConsola = LeerConsola;

            // Usar el método Visualizar para mostrar el resultado de los métodos a través del delegado
            Visualizar(delegadoFichero);
            Visualizar(delegadoConsola);
        }

        // Método Visualizar que recibe un delegado y muestra el valor devuelto en pantalla
        static void Visualizar(DelegadoLectura delegado)
        {
            string resultado = delegado();  // Invocar el delegado
            Console.WriteLine(resultado);    // Mostrar el resultado en pantalla
        }

        static string LeerFichero()
        {
            string leer = "Leo desde Fichero";
            return leer;
        }

        static string LeerConsola()
        {
            string leer = "Leo desde Consola";
            return leer;
        }
    }
}
