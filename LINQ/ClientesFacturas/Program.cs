using System;
using System.Collections.Generic;

namespace ClientesFacturas
{
    internal class Program
    {
        class Cliente
        {
            public string Nombre { get; set; }
            public string Dni { get; set; }
            public string Telefono { get; set; }
        }

        class Cliente2
        {
            public string Nombre { get; set; }
            public string Dni { get; set; }
            public string Telefono { get; set; }
            public List<Factura> Facturas { get; set; }
        }

        class Factura
        {
            public int Id { get; set; }
            public string DNI_Cliente { get; set; }
            public DateTime Fecha { get; set; }
            public int Total { get; set; }
        }

        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente> {
                new Cliente { Dni = "1", Nombre = "Pepe", Telefono = "892329999" },
                new Cliente { Dni = "2", Nombre = "Paco", Telefono = "594054905" },
                new Cliente { Dni = "3", Nombre = "Luis", Telefono = "490834838" },
                new Cliente { Dni = "4", Nombre = "Pedro", Telefono = "493489384" },
            };

            List<Factura> facturas = new List<Factura> {
                new Factura { Id = 2, DNI_Cliente = "4", Fecha = new DateTime(2000, 11, 1), Total = 2300 },
                new Factura { Id = 7, DNI_Cliente = "1", Fecha = new DateTime(2003, 11, 24), Total = 300 },
                new Factura { Id = 9, DNI_Cliente = "1", Fecha = new DateTime(2006, 11, 6), Total = 400 },
                new Factura { Id = 12, DNI_Cliente = "3", Fecha = new DateTime(2008, 6, 19), Total = 344 },
                new Factura { Id = 14, DNI_Cliente = "2", Fecha = new DateTime(2008, 1, 22), Total = 20 },
                new Factura { Id = 18, DNI_Cliente = "1", Fecha = new DateTime(2001, 2, 27), Total = 23 },
                new Factura { Id = 24, DNI_Cliente = "1", Fecha = new DateTime(2006, 7, 5), Total = 223 },
                new Factura { Id = 27, DNI_Cliente = "2", Fecha = new DateTime(2009, 1, 8), Total = 295 },
                new Factura { Id = 29, DNI_Cliente = "2", Fecha = new DateTime(2003, 2, 4), Total = 6 },
                new Factura { Id = 43, DNI_Cliente = "2", Fecha = new DateTime(2002, 6, 30), Total = 56 },
                new Factura { Id = 48, DNI_Cliente = "3", Fecha = new DateTime(2003, 7, 23), Total = 70 },
                new Factura { Id = 52, DNI_Cliente = "3", Fecha = new DateTime(2005, 3, 12), Total = 550 },
                new Factura { Id = 67, DNI_Cliente = "3", Fecha = new DateTime(2006, 12, 22), Total = 234 },
                new Factura { Id = 80, DNI_Cliente = "4", Fecha = new DateTime(2007, 12, 24), Total = 1200 },
                new Factura { Id = 82, DNI_Cliente = "4", Fecha = new DateTime(2008, 10, 2), Total = 900 }
            };

            List<Cliente2> clientes2 = new List<Cliente2>
            {
                new Cliente2
                {
                    Dni = "1",
                    Nombre = "Pepe",
                    Telefono = "892329999",
                    Facturas = new List<Factura>
                    {
                        new Factura { Id = 2, DNI_Cliente = "4", Fecha = new DateTime(2000, 11, 1), Total = 2300 },
                        new Factura { Id = 7, DNI_Cliente = "1", Fecha = new DateTime(2003, 11, 24), Total = 300 }
                    }
                }
            };

                var s02 = clientes2.SelectMany(c => c.Facturas);
                foreach (var factura in s02)
                {
                    Console.WriteLine($"Factura ID: {factura.Id}, DNI Cliente: {factura.DNI_Cliente}, Fecha: {factura.Fecha.ToShortDateString()}, Total: {factura.Total}");
                }
        }
    }
}
