using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_PropiedadesIndizadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Proveedor pro1 = new Proveedor();
            Proveedor pro2 = new Proveedor();
            
            pro1.Nombre = "José Perez";
            pro1.AñadirProducto("Tornillos");
            Console.WriteLine(pro1[0]+"---");

            pro2.Nombre = "Ana García";
            pro2.AñadirProducto("Tuercas");
            pro2.AñadirProducto("Tornillos");
            pro2.AñadirProducto("Arandelas");

            Console.WriteLine(pro2.Nombre);
            for (int i = 0; i < pro2.NumeroDeProductos; i++)
                Console.WriteLine(pro2[i]);


        }
    }
    class Proveedor
    {
        string nombre;
        ArrayList productos = new ArrayList();
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public void AñadirProducto(string producto)
        {
            productos.Add(producto);
        }
        public int NumeroDeProductos
        {
            get { return productos.Count; }
        }
        public string this[int i]
        {
            get 
            {
                if (i >= 0 && i < productos.Count)
                    return (string)productos[i]; 
                // En este caso en necesario el cast porque el tipo devuelto por una 
                // colección es Object y no String (es lo que espera la propiedad)
                return null;
            }
            set 
            {
                if (i >= 0 && i < productos.Count)
                    productos[i]=value;
            }
        }
    }
}
