using System;
using System.Linq;
using System.Xml.Linq;

namespace CrearXMLConLINQXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creacion XML
            XElement colegio = new XElement("colegio",
                new XElement("curso",
                    new XElement("codigo", "2DAM"),
                    new XElement("alumno",
                        new XElement("nombre", "Abel"),
                        new XElement("edad", 20)
                    ),
                    new XElement("alumno",
                        new XElement("nombre", "Carlos"),
                        new XElement("edad", 22)
                    ),
                    new XElement("alumno",
                        new XElement("nombre", "Nacho"),
                        new XElement("edad", 18)
                    ),
                    new XElement("alumno",
                        new XElement("nombre", "Mario"),
                        new XElement("edad", 25)
                    )
                ),
                new XElement("curso",
                    new XElement("codigo", "2DAW"),
                    new XElement("alumno",
                        new XElement("nombre", "Yaiza"),
                        new XElement("edad", 29)
                    ),
                    new XElement("alumno",
                        new XElement("nombre", "Angel"),
                        new XElement("edad", 28)
                    ),
                    new XElement("alumno",
                        new XElement("nombre", "Claudia"),
                        new XElement("edad", 21)
                    )
                )
            );

            // Guardar el XML en un archivo
            string rutaArchivo = "colegio.xml";
            colegio.Save(rutaArchivo);

            Console.WriteLine($"Archivo XML generado y guardado en: {rutaArchivo}");

            // 1. Recorrer y mostrar todos los alumnos
            Console.WriteLine("\nListado general de alumnos:");
                var alumnos = colegio.Descendants("alumno")
                                .Select(a => new
                                {
                                    Nombre = a.Element("nombre")?.Value,
                                    Edad = (int)a.Element("edad")
                                });

                foreach (var alumno in alumnos)
                {
                    Console.WriteLine($"Nombre: {alumno.Nombre}, Edad: {alumno.Edad}");
                }

            

            // 2. Agrupar alumnos por curso
            Console.WriteLine("\nAlumnos agrupados por curso:");
            
            var cursos = colegio.Descendants("curso")
                                .Select(c => new
                                {
                                    Curso = c.Element("codigo")?.Value,
                                    Alumnos = c.Elements("alumno")
                                                .Select(a => new
                                                {
                                                    Nombre = a.Element("nombre")?.Value,
                                                    Edad = (int)a.Element("edad")
                                                })
                                });

            foreach (var curso in cursos)
            {
                Console.WriteLine($"\nCurso: {curso.Curso}");
                foreach (var alumno in curso.Alumnos)
                {
                    Console.WriteLine($"  Nombre: {alumno.Nombre}, Edad: {alumno.Edad}");
                }
            }

            // 3. Mostrar alumnos ordenados por edad
            Console.WriteLine("\nAlumnos ordenados por edad:");
            var alumnosOrdenadosPorEdad = colegio.Descendants("alumno")
                                                 .Select(a => new
                                                 {
                                                     Nombre = a.Element("nombre")?.Value,
                                                     Edad = (int)a.Element("edad")
                                                 })
                                                 .OrderBy(a => a.Edad);

            foreach (var alumno in alumnosOrdenadosPorEdad)
            {
                Console.WriteLine($"Nombre: {alumno.Nombre}, Edad: {alumno.Edad}");
            }
        }
    }
}
