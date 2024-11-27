namespace Evento
{
    // Definición del delegado
    public delegate void DelegadoLleno();
    public class Recipiente
    {
        int litrosCapacidadMáxima;
        int litrosOcupados;

        // Definición del evento
        public event DelegadoLleno Lleno;
        public Recipiente(int litrosCapacidadMáxima)
        {
            this.litrosCapacidadMáxima = litrosCapacidadMáxima;
            litrosOcupados = 0;
        }
        public int LitrosOcupados
        {
            get { return litrosOcupados; }
        }

        public void añadirContenido(int litros)
        {
            if ((litrosOcupados + litros) > litrosCapacidadMáxima)
            {
                Lleno(); // Invoca el evento                  
                return;
            }
            litrosOcupados += litros;
            Console.WriteLine("Se han añadido {0} litros", litros);
        }
    }
    internal class Program
    {
        static Recipiente r1 = new Recipiente(100);
        static void Main(string[] args)
        {
            // Añade el método manejador al evento:
            r1.Lleno += new DelegadoLleno(Program.manejadorEvento);
            r1.añadirContenido(50);
            r1.añadirContenido(60);

        }
        public static void manejadorEvento()
        {
            Console.WriteLine("El recipiente está lleno");
        }
    }
}
