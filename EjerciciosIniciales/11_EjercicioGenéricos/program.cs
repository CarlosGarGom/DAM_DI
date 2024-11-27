using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_EjercicioGenéricos
{
    class Program
    {
        static List<AnimalDeCompañia> Animales = new List<AnimalDeCompañia>();
        static void Main(string[] args)
        {
            string op = "0";
            while (op != "4")
            {
                Console.WriteLine("1.-Añadir");
                Console.WriteLine("2.-Listado Ordenado");
                Console.WriteLine("3.-Buscar Animal");
                Console.WriteLine("4.-Fin");
                Console.Write("Opción=");
                op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        Console.WriteLine("Introduce el animal a añadir:");
                        Animales.Add(CapturarAnimal());
                        break;
                    case "2":
                        Animales.Sort();
                        Console.WriteLine("Litado");
                        Console.WriteLine("--------------------------------------------");
                        foreach (AnimalDeCompañia animal in Animales)
                        {
                            Console.Write(animal.EspecieAnimal + " ");
                            Console.Write(animal.Raza + " ");
                            Console.WriteLine(animal.FechaDeNacimiento.ToShortDateString());
                        }
                        Console.WriteLine("--------------------------------------------");
                        break;
                    case "3":
                        Console.WriteLine("Introduce el animal a buscar:");
                        AnimalDeCompañia a = CapturarAnimal();
                        int posición=Animales.IndexOf(a);
                        if (posición!=-1)
                            Console.WriteLine("Se ha encontrado en la posición "+posición);
                        else
                            Console.WriteLine("No se ha encontrado en la lista");
                        break;
                }
            }
        }
        static AnimalDeCompañia CapturarAnimal()
        {

            Console.Write("Especie Animal........:");
            string especie = Console.ReadLine();
            Console.Write("Raza..................:");
            string raza = Console.ReadLine();
            Console.Write("Fecha de nacimiento...:");
            DateTime fecha;
            try
            {
                fecha = DateTime.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                fecha = DateTime.Now;
            }
            return new AnimalDeCompañia(especie, raza, fecha);
        }
    }
    class AnimalDeCompañia : IComparable<AnimalDeCompañia>, IEquatable<AnimalDeCompañia>
    {
        string especieAnimal;
        string raza;
        DateTime fechaDeNacimiento;
        public AnimalDeCompañia(string especieAnimal, string raza, DateTime fechaDeNacimiento)
        {
            this.especieAnimal = especieAnimal;
            this.raza = raza;
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        public string EspecieAnimal
        {
            get { return especieAnimal; }
            set { especieAnimal = value; }
        }
        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }
        public DateTime FechaDeNacimiento
        {
            get { return fechaDeNacimiento; }
            set { fechaDeNacimiento = value; }
        }
        public int CompareTo(AnimalDeCompañia animal)
        {
            if (this.especieAnimal.CompareTo(animal.EspecieAnimal) != 0)
                return this.especieAnimal.CompareTo(animal.EspecieAnimal);
            if (this.raza.CompareTo(animal.Raza) != 0)
                return this.raza.CompareTo(animal.Raza);
            if (this.fechaDeNacimiento.CompareTo(animal.FechaDeNacimiento) != 0)
                return this.fechaDeNacimiento.CompareTo(animal.FechaDeNacimiento);
            return 0;
        }

        public bool Equals(AnimalDeCompañia o)
        {
            return this.especieAnimal == o.EspecieAnimal &&
                    this.raza == o.Raza &&
                    this.fechaDeNacimiento == o.FechaDeNacimiento;
            // En éste caso esto es quivalente a:
            //   return this.CompareTo(o) == 0; 

        }
    }
    /**
     ****************************************** Código es VB.NET ******************
    Module Module1
    Dim lista As List(Of AnimalDeCompañía) = New List(Of AnimalDeCompañía)
    Sub Main()
        Console.WriteLine("Introduzca una opción")
        Dim op As String = " "
        Do
            Console.WriteLine("1.- Añadir")
            Console.WriteLine("2.- Listado ordenado")
            Console.WriteLine("3.- Fin")
            Console.Write("Opcion:")
            op = Console.ReadLine()
            Select Case op
                Case "1"
                    Console.Write("Especie Animal........:")
                    Dim especie As String = Console.ReadLine()
                    Console.Write("Raza..................:")
                    Dim raza As String = Console.ReadLine()
                    Console.Write("Fecha de nacimiento...:")
                    Dim fecha As DateTime
                    Try
                        fecha = DateTime.Parse(Console.ReadLine())
                    Catch ex As Exception
                        fecha = DateTime.Now
                    End Try
                    lista.Add(New AnimalDeCompañía(especie, raza, fecha))
                Case "2"
                    lista.Sort()
                    Console.WriteLine("Litado")
                    Console.WriteLine("--------------------------------------------")
                    For Each animal As AnimalDeCompañía In lista
                        Console.Write(animal.EspecieAnimal + " ")
                        Console.Write(animal.Raza + " ")
                        Console.WriteLine(animal.FechaDeNacimiento.ToShortDateString())
                    Next
                    Console.WriteLine("--------------------------------------------")
            End Select
        Loop While op <> "3"
    End Sub
    End Module
    Public Class AnimalDeCompañía
        Implements IComparable(Of AnimalDeCompañía)
        Dim _especieAnimal As String
        Dim _raza As String
        Dim _fechaDeNacimiento As DateTime
        Sub New(ByVal especieAnimal As String, ByVal raza As String, ByVal fechaDeNacimiento As Date)
            Me._especieAnimal = especieAnimal
            Me._raza = raza
            Me._fechaDeNacimiento = fechaDeNacimiento
        End Sub
        Public Property EspecieAnimal() As String
            Get
                Return _especieAnimal
            End Get
            Set(ByVal value As String)
                _especieAnimal = value
            End Set
        End Property
        Public Property Raza() As String
            Get
                Return _raza
            End Get
            Set(ByVal value As String)
                _raza = value
            End Set
        End Property
        Public Property FechaDeNacimiento() As DateTime
            Get
                Return _fechaDeNacimiento
            End Get
            Set(ByVal value As DateTime)
                _fechaDeNacimiento = value
            End Set
        End Property
        Public Function CompareTo(ByVal animal As AnimalDeCompañía) As Integer _
            Implements IComparable(Of AnimalDeCompañía).CompareTo
            If (Me._especieAnimal.Equals(animal.EspecieAnimal) <> True) Then
                Return Me._especieAnimal.CompareTo(animal.EspecieAnimal)
            End If
            If (Me._raza.Equals(animal.Raza) <> True) Then
                Return Me._raza.CompareTo(animal.Raza)
            End If
            If (Me._fechaDeNacimiento.Equals(animal.FechaDeNacimiento) <> True) Then
                Return Me._fechaDeNacimiento.CompareTo(animal.FechaDeNacimiento)
            End If
            Return 0
        End Function
    End Class
*/
}
