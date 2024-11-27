namespace Ejercicio10_PruebaInterface
{
    using System;

    // Interface Ihablar con el método Hablar
    public interface IHablar
    {
        void Hablar();
    }

    // Clase Gato que implementa Ihablar
    public class Gato : IHablar
    {
        // Método que implementa la interface
        public void Hablar()
        {
            Console.WriteLine("Miau!");
        }

        // Método adicional de la clase Gato
        public void Andar()
        {
            Console.WriteLine("El gato anda");
        }
    }

    // Clase Robot que implementa Ihablar
    public class Robot : IHablar
    {
        // Método que implementa la interface
        public void Hablar()
        {
            Console.WriteLine("Beep!");
        }

        // Método adicional de la clase Robot
        public void Pensar()
        {
            Console.WriteLine("Estoy pensando");
        }
    }

    // Clase Prueba con el método Main
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de tipo Gato
            Gato miGato = new Gato();
            miGato.Hablar(); 
            miGato.Andar();  

            // Crear un objeto de tipo Robot
            Robot miRobot = new Robot();
            miRobot.Hablar();
            miRobot.Pensar(); 
        }
    }
}
