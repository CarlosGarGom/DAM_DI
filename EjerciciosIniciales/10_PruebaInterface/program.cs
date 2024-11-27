using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_PruebaInterface
{
    interface IHablar // Interface Ihablar con un solo método sin implementar
	{
		void Hablar();
	}
	class Gato:IHablar 
	{
		public void Hablar() // Implementación de Hablar (debe ser público)
		{
			Console.WriteLine("Miau!");
		}
		public void Andar()
		{
			Console.WriteLine("El gato anda");
        }
    }
	class Robot:IHablar
	{
		public void Hablar() // Implementación de Hablar (debe ser público)
		{
			Console.WriteLine("Beep!");
		}
		public void Pensar()
		{
			Console.WriteLine("Estoy pensado...");
		}
	}
	class PruebaInterface
	{
		static void Main(string[] args)
		{
			// Definición de los objetos y llamadas a métodos
			Gato gatoAzul=new Gato();
			gatoAzul.Andar();
            gatoAzul.Hablar();
            Robot robotMetálico=new Robot();
            robotMetálico.Hablar();
            robotMetálico.Pensar();
            Console.WriteLine("-------------------------------");
            IHablar pruebaIHablar;	// Define un nombre de objeto tipo "IHablar"
                                    // (que implementa la interface "IHablar")
            pruebaIHablar=gatoAzul; // Asigna un objeto Gato a la referencia definida
            pruebaIHablar.Hablar(); // Visualiza "Miau!"
            // pruebaIHablar.Andar(); -> No es posible
            // Desde una referencia interface no se puede llamar a un método que no
            // sea del interface.
            pruebaIHablar=robotMetálico; 
            pruebaIHablar.Hablar();

            // Se puede comprobar que se puede utilizar "pruebaIHablar" para llamar
            // a métodos de objetos correspondientes a clases diferentes.

            // Otro ejemplo de utilización:
            Prueba(new Gato());

		}
        static void Prueba(IHablar i)
        {
            i.Hablar();
        }
	}
}