using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Campamento
{
    class Program
    {
        static void Main(string[] args)
        {
            TiendaDeCampaña tienda1 = new TiendaDeCampaña("Tienda 1 - Parcela A");
            TiendaDeCampaña tienda2 = new TiendaDeCampaña("Tienda 2 - Parcela B");
            Campista c1 = new Campista("José Fernandez", DateTime.Parse("20/02/2000"));
            Campista c2 = new Campista("Franciso Alonso", DateTime.Parse("10/04/2001"));
            Campista c3 = new Campista("Jorge García", DateTime.Parse("14/12/2001"));
            Campista c4 = new Campista("Luis Ruiz", DateTime.Parse("10/04/2001"));
            Monitor m1 = new Monitor("Arturo Lopez", DateTime.Parse("07/04/1980"));
            Monitor m2 = new Monitor("Rosa García", DateTime.Parse("11/03/1980"));
            Monitor m3 = new Monitor("Pedro Martinez", DateTime.Parse("11/03/1980"));
            c1.moverA(tienda1);
            c2.moverA(tienda1);
            c3.moverA(tienda1);
            c4.moverA(tienda2);
            m1.moverA(tienda1);
            m2.moverA(tienda2);
            m1.moverA(tienda2); // <-- No se puede hacer (no puede haber mas de un monitor) 
        }
    }
    class Persona
    {
        string _nombre;
        DateTime _fechaNacimiento;
        TiendaDeCampaña _tiendaDeCampaña;
        public Persona() { }
        public Persona(string nombre, DateTime fechaNacimiento)
        {
            _nombre = nombre;
            _fechaNacimiento = fechaNacimiento;
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public TiendaDeCampaña TiendaDeCampaña
        {
            get { return _tiendaDeCampaña; }
            set { _tiendaDeCampaña = value; }
        }
    }
    class TiendaDeCampaña
    {
        string _ubicación;
        public List<Campista> _campistas=new List<Campista>();
        public List<Monitor> _monitores=new List<Monitor>();
        public TiendaDeCampaña(string ubicación)
        {
            this._ubicación = ubicación;
        }
        public string Ubicación
        {
            get { return _ubicación; }
            set { _ubicación = value; }
        }
    }
    interface Imovible
    {
        void moverA(TiendaDeCampaña destino);
    }
    class Campista:Persona,Imovible 
    {
        // Utiliza su propio constructor. Es necesario que Persona tenga un
        // constructor sin parámetros. 
        public Campista(string nombre, DateTime fechaNacimiento)
        {
            Nombre = nombre; // Se utilizan las propiedades públicas, no se pueden
            FechaNacimiento = fechaNacimiento; // utilizar los campos privados
        }
        public void moverA(TiendaDeCampaña destino)
        {
            // Comprueba la condición nº de campistas por tienda:
            if (destino._campistas.Count == 5)
            {
                Console.WriteLine("No puede haber más de cinco campistas por tienda");
                return;
            }
            // Si el campista se mueve desde otra tienda, borramos 
            // su referencia en la colección de la  otra tienda:
            if (this.TiendaDeCampaña != null)
                this.TiendaDeCampaña._campistas.Remove(this);
            // Añade el campista a la tienda de destino:
            destino._campistas.Add(this);
            // Actualiza el campo propio TiendaDeCampaña:
            this.TiendaDeCampaña = destino;
            // Visualiza el movimiento:
            Console.WriteLine("El campista " + this.Nombre + " se movió a " + this.TiendaDeCampaña.Ubicación);
        }
    }
    class Monitor:Persona,Imovible
    {   
        // Con esta declaración se llama al constructor de la clase base:
        public Monitor(string nombre, DateTime fechaNacimiento)
            : base(nombre, fechaNacimiento){ }                                
        public void moverA(TiendaDeCampaña destino)
        {
            // Comprueba la condición nº de monitores por tienda:
            if (destino._monitores.Count > 1)
            {
                Console.WriteLine("No puede haber más de dos monitor por tienda");
                return;
            }
            // Comprueba la posibilidad de dejar la tienda sin monitor
            if (this.TiendaDeCampaña != null && this.TiendaDeCampaña._monitores.Count == 1)
            {
                Console.WriteLine("Una tienda con un solo monitor no se pueda quedar sin el");
                return;
            }
            // Si el monitor se mueve desde otra tienda, borramos 
            // su referencia en la colección de la  otra tienda:
            if (this.TiendaDeCampaña != null)
                this.TiendaDeCampaña._monitores.Remove(this);
            // Añade el monitor a la tienda de destino:
            destino._monitores.Add(this);
            // Actualiza el campo propio TiendaDeCampaña:
            this.TiendaDeCampaña = destino;
            Console.WriteLine("El monitor " + this.Nombre + " se movió a " + this.TiendaDeCampaña.Ubicación);
        }
    }
 }
