using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

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
        SerializarXML(camiones);
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

    static void SerializarXML(List<Camion> camiones)
    {
        var serializer = new XmlSerializer(typeof(List<Camion>), new XmlRootAttribute("ArrayOfCamión"));

        using (var writer = new StreamWriter(@"C:\Users\admin\Desktop\CarlosGarcia\DAM_DI\XML\ficheroToXML\bin\Debug\movimientos.xml"))
        {
            serializer.Serialize(writer, camiones);
        }

        Console.WriteLine("Los datos han sido serializados correctamente.");
    }
}