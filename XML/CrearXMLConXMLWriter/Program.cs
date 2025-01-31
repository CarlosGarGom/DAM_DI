using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

public class Camion
{
    public int CodigoDeCamion { get; set; }
    public List<Movimiento> Movimientos { get; set; }

    public Camion()
    {
        Movimientos = new List<Movimiento>();
    }
}

public class Movimiento
{
    public string FechaYHora { get; set; }
    public string LugarDeOrigen { get; set; }
    public string LugarDeDestino { get; set; }
    public int KmRealizados { get; set; }
}

class Program
{
    static void Main()
    {
        string rutaArchivo = @"C:\Users\admin\Desktop\CarlosGarcia\DAM_DI\XML\ficheroToXML\bin\Debug\movimientos.txt";
        var camiones = LeerDatos(rutaArchivo);
        GenerarXML(camiones);
    }

    static List<Camion> LeerDatos(string rutaArchivo)
    {
        var camiones = new List<Camion>();
        var lineas = File.ReadAllLines(rutaArchivo);

        foreach (var linea in lineas)
        {
            var partes = linea.Split(',');

            int codigoCamion = int.Parse(partes[0]);
            string fechaYHora = partes[1];
            string origen = partes[2];
            string destino = partes[3];
            int kmRealizados = int.Parse(partes[4]);

            var camion = camiones.Find(c => c.CodigoDeCamion == codigoCamion);

            if (camion == null)
            {
                camion = new Camion { CodigoDeCamion = codigoCamion };
                camiones.Add(camion);
            }

            var movimiento = new Movimiento
            {
                FechaYHora = fechaYHora,
                LugarDeOrigen = origen,
                LugarDeDestino = destino,
                KmRealizados = kmRealizados
            };

            camion.Movimientos.Add(movimiento);
        }

        return camiones;
    }

    static void GenerarXML(List<Camion> camiones)
    {
        string rutaSalida = @"C:\Users\admin\Desktop\CarlosGarcia\DAM_DI\XML\CrearXMLConXMLWriter\bin\Debug\camiones.xml";

        using (XmlWriter writer = XmlWriter.Create(rutaSalida, new XmlWriterSettings { Indent = true }))
        {
           
            writer.WriteStartDocument();
            writer.WriteStartElement("ArrayOfCamión", "http://www.w3.org/2001/XMLSchema");
            writer.WriteAttributeString("xmlns", "xsi", null, "http://www.w3.org/2001/XMLSchema-instance");
            writer.WriteAttributeString("xmlns", "xsd", null, "http://www.w3.org/2001/XMLSchema");

            
            foreach (var camion in camiones)
            {
                writer.WriteStartElement("Camión");

               
                writer.WriteStartElement("movimientos");

                foreach (var movimiento in camion.Movimientos)
                {
                    writer.WriteStartElement("Movimiento");

                    writer.WriteElementString("FechaYHora", movimiento.FechaYHora);
                    writer.WriteElementString("LugarDeOrigen", movimiento.LugarDeOrigen);
                    writer.WriteElementString("LugarDeDestino", movimiento.LugarDeDestino);
                    writer.WriteElementString("KmRealizados", movimiento.KmRealizados.ToString());

                    writer.WriteEndElement(); 
                }

                writer.WriteEndElement(); 

               
                writer.WriteElementString("CodigoDeCamión", camion.CodigoDeCamion.ToString());

                writer.WriteEndElement(); 
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
        }

        Console.WriteLine("El archivo XML ha sido creado correctamente en: " + rutaSalida);
    }
}
