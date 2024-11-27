using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ClaseCuentaBancaria
{
    class CuentaBancaria
    {
        string nombreCliente;
        string direccion;
        string númeroDeCuenta;
        long saldoActual;
        static float tipoInterés;
        public string getNombre()
        {
            return nombreCliente;
        }
        public void setNombre(string nombre)
        {
            nombreCliente = nombre;
        }        
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string NúmeroCC
        {
            get { return númeroDeCuenta; }
            set { númeroDeCuenta = value; }
        }
        public long SaldoCC
        {
            get
            {
                return saldoActual;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("Saldo negativo");
                else
                    saldoActual = value;
            }
        }
        static public float InterésCC // La propiedad debe ser estática
        {
            get
            {
                return tipoInterés;
            }
            set
            {
                tipoInterés = value;
            }
        }
    }
    class Prueba
    {
        static void Main(string[] args)
        {
            CuentaBancaria.InterésCC = 1.2F; // Asignamos un interés a la clase.
            CuentaBancaria cuentaUno = new CuentaBancaria(); //Crea el objeto cuentaUno
            CuentaBancaria cuentaDos = new CuentaBancaria(); //Crea el objeto cuentaDos
            cuentaUno.setNombre("Antonio"); //Asigna el nómbre con un método
            cuentaDos.setNombre("Luis");
            Console.WriteLine(cuentaUno.getNombre()); // Obtiene el nombre con un método
            cuentaUno.NúmeroCC = "01111"; // Asigna el nombre con una propiedad
            cuentaUno.SaldoCC = 1000; // Asigna el saldo con una propiedad
            cuentaUno.SaldoCC = -100; // Asigna el saldo con una propiedad
            Console.WriteLine(cuentaUno.SaldoCC); // Obtiene el saldo con la propiedad
            Console.WriteLine(CuentaBancaria.InterésCC);  // Visualiza el tipo
            // de interés con la propiedad de clase (no se puede usar el objeto)
        }
    }
}