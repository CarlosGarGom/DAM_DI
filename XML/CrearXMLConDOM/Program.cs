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
        var doc = new XmlDocument();

        // Crear el elemento raíz <movimientos>
        XmlElement root = doc.CreateElement("movimientos");
        doc.AppendChild(root);

        // Generar elementos <movimiento>
        foreach (var camion in camiones)
        {
            foreach (var movimiento in camion.Movimientos)
            {
                XmlElement movimientoElement = doc.CreateElement("movimiento");
                movimientoElement.SetAttribute("camion", camion.CodigoDeCamion.ToString());

                XmlElement fechaElement = doc.CreateElement("fechayhora");
                fechaElement.InnerText = movimiento.FechaYHora;
                movimientoElement.AppendChild(fechaElement);

                XmlElement origenElement = doc.CreateElement("origen");
                origenElement.InnerText = movimiento.LugarDeOrigen;
                movimientoElement.AppendChild(origenElement);

                XmlElement destinoElement = doc.CreateElement("destino");
                destinoElement.InnerText = movimiento.LugarDeDestino;
                movimientoElement.AppendChild(destinoElement);

                XmlElement kmElement = doc.CreateElement("km");
                kmElement.InnerText = movimiento.KmRealizados.ToString();
                movimientoElement.AppendChild(kmElement);

                root.AppendChild(movimientoElement);
            }
        }

        // Guardar el archivo XML
        string rutaSalida = @"C:\Users\admin\Desktop\CarlosGarcia\DAM_DI\XML\CrearXMLConDOM\bin\Debug\movimientosDOM.xml";
        doc.Save(rutaSalida);

        Console.WriteLine("El archivo XML ha sido creado correctamente en: " + rutaSalida);
    }
}
