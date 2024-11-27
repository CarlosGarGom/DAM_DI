using System.Collections;

namespace Ejercicio07_ArrayCocheOcasion
{
    public class CocheOcasion
    {
        public string marcaYModelo;
        public int km;
        public int añosAntiguedad;

        public CocheOcasion(string marcaYModelo, int km, int añosAntiguedad)
        {
            this.marcaYModelo = marcaYModelo;
            this.km = km;
            this.añosAntiguedad = añosAntiguedad;

        }
        public string MarcaYModelo
        {
            get { return marcaYModelo; }
            set { marcaYModelo = value; }
        }

        public int Km
        {
            get { return km; }
            set { km = value; }
        }

        public int AñosAntiguedad
        {
            get { return añosAntiguedad; }
            set { añosAntiguedad = value; }
        }

        public void IncrementarAños()
        {
            añosAntiguedad++;
        }
    }

    public class ArrayCoches
    {
        // ArrayList donde se almacenarán los objetos CocheOcasión
        public static ArrayList listaCoches = new ArrayList();
        public static void AñadirCoche()
        {
            string marcaYModelo;


            while (true)
            {
                Console.Write("Introduce la marca y modelo del coche: ");
                marcaYModelo = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(marcaYModelo))
                {
                    Console.WriteLine("La marca y modelo no pueden estar vacíos. Inténtalo de nuevo.");
                }
                else
                {
                    break; // Salir del ciclo si se ha ingresado un valor válido
                }
            }
            int km;
            while (true)
            {
                Console.Write("Introduce los kilómetros del coche: ");
                string inputKm = Console.ReadLine();

                try
                {
                    km = int.Parse(inputKm);
                    if (km < 0) // Validar que no sea un número negativo
                    {
                        Console.WriteLine("Los kilómetros no pueden ser negativos. Inténtalo de nuevo.");
                        continue;
                    }
                    break; // Salir del ciclo si la conversión es correcta
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, introduce un número válido para los kilómetros.");
                }

            }
            int añosAntiguedad;
            while (true)
            {
                Console.Write("Introduce los años de antigüedad del coche: ");
                string inputAños = Console.ReadLine();

                try
                {
                    añosAntiguedad = int.Parse(inputAños);
                    if (añosAntiguedad < 0) // Validar que no sea un número negativo
                    {
                        Console.WriteLine("Los años de antigüedad no pueden ser negativos. Inténtalo de nuevo.");
                        continue;
                    }
                    break; // Salir del ciclo si la conversión es correcta
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, introduce un número válido para los años de antigüedad.");
                }
            }

            // Crear el nuevo coche
            CocheOcasion nuevoCoche = new CocheOcasion(marcaYModelo, km, añosAntiguedad);
            listaCoches.Add(nuevoCoche);

            Console.WriteLine("Coche añadido con éxito.");
        }

        public static void BorrarCoche(int posicion)
        {
            if (posicion >= 0 && posicion < listaCoches.Count)
            {
                listaCoches.RemoveAt(posicion);
                Console.WriteLine("Coche borrado con éxito.");
            }
            else
            {
                Console.WriteLine("Posición no válida.");
            }
        }

        public static void ListarCoches()
        {
            if (listaCoches.Count == 0)
            {
                Console.WriteLine("No hay coches en la lista");
            }
            else
            {
                for (int i = 0; i < listaCoches.Count; i++)
                {
                    CocheOcasion coche = (CocheOcasion)listaCoches[i];

                    Console.WriteLine($"[{i}] Marca y Modelo: {coche.marcaYModelo}, KM: {coche.km} Años Antigüedad: {coche.añosAntiguedad}");
                }
            }
        }

        public static void IncrementarAños()
        {

            foreach (CocheOcasion coche in listaCoches)
            {
                coche.IncrementarAños();
            }
            Console.WriteLine("Años incrementados en todos los coches.");
        }
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                // Mostrar menú
                Console.WriteLine("\nMenú de opciones:");
                Console.WriteLine("1.- Añadir Coche.");
                Console.WriteLine("2.- Borrar Coche.");
                Console.WriteLine("3.- Incrementar Año.");
                Console.WriteLine("4.- Listado.");
                Console.WriteLine("5.- Fin.");
                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        ArrayCoches.AñadirCoche();
                        break;
                    case 2:
                        Console.Write("Introduce la posición del coche a borrar: ");
                        int posicion = int.Parse(Console.ReadLine());
                        ArrayCoches.BorrarCoche(posicion);
                        break;
                    case 3:
                        ArrayCoches.IncrementarAños();
                        break;
                    case 4:
                        ArrayCoches.ListarCoches();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }
            } while (opcion != 5);
        }
    }

}
