using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Linq;

namespace ManipulacionDelDOM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"C:\Users\admin\Desktop\CarlosGarcia\DAM_DI\XML\ManipulacionDelDOM\archivo.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(ruta);

            XmlNode root = doc.DocumentElement;
            // 1 Obtén el primer nodo hijo del elemento raíz (<root>) 
            
            XmlNode firstChild = root.FirstChild;
            while (firstChild != null && firstChild.NodeType != XmlNodeType.Element)
            {
                firstChild = firstChild.NextSibling; // Salta nodos que no son elementos
            }
            Console.WriteLine("Primer nodo hijo: " + firstChild.Name);

            // 2 Obtén el último nodo hijo del elemento <prediccion> 
            XmlNode prediccion = doc.SelectSingleNode("//prediccion");
            if (prediccion != null)
            {
                XmlNode lastChild = prediccion.LastChild;
                while (lastChild != null && lastChild.NodeType != XmlNodeType.Element)
                {
                    lastChild = lastChild.PreviousSibling; // Salta nodos que no son elementos
                }
                Console.WriteLine("Último nodo hijo de <prediccion>: " + lastChild.Name);
            }

            Console.WriteLine("Último nodo hijo de <prediccion>:");
            // 3 Itera entre nodos hermanos de <dia>:
           Console.WriteLine(" Itera entre nodos hermanos de <dia>:");
            XmlNodeList diaNodes = doc.GetElementsByTagName("dia");
            foreach (XmlNode dia in diaNodes)
            {
                Console.WriteLine("Nodo <dia>: " + dia.Attributes["fecha"]?.Value);
                XmlNode sibling = dia.NextSibling;
                while (sibling != null)
                {

                    Console.WriteLine("Hermano: " + sibling.Name + " fecha: "+ dia.Attributes["fecha"]?.Value);

                    sibling = sibling.NextSibling;
                }
            }

            //4 Obtén el nodo anterior al nodo <nombre>:
            XmlNode nombreNode = doc.SelectSingleNode("//nombre");
            if (nombreNode != null)
            {
                XmlNode previousNode = nombreNode.PreviousSibling;
                while (previousNode != null && previousNode.NodeType != XmlNodeType.Element)
                {
                    previousNode = previousNode.PreviousSibling; // Salta nodos que no son elementos
                }
                if (previousNode != null)
                {
                    Console.WriteLine("Nodo anterior a <nombre>: " + previousNode.Name);
                }
                else
                {
                    Console.WriteLine("No hay un nodo anterior a <nombre>.");
                }
            }

            // 5 Listar todas las etiquetas <estado_cielo>:
            Console.WriteLine("Listar todas las etiquetas <estado_cielo>:");
            XmlNodeList estadoCieloNodes = doc.GetElementsByTagName("estado_cielo");
            foreach (XmlNode estadoCielo in estadoCieloNodes)
            {
                string descripcion = estadoCielo.Attributes["descripcion"]?.Value;
                Console.WriteLine("Etiqueta <estado_cielo descripcion="+descripcion+">" + estadoCielo.Value+"</estado_cielo>");
            }


            // 6  Obtén el atributo descripcion del primer <estado_cielo>
            XmlNode estadosCielo = doc.SelectSingleNode("//estado_cielo");
            if (estadosCielo != null)
            {
                string descripcion = estadosCielo.Attributes["descripcion"]?.Value;
                Console.WriteLine("Descripción del primer <estado_cielo>: " + descripcion);
            }

            // 7 Modifica el contenido de <temperatura>/<maxima> del primer día:
            XmlNode primerDia = doc.SelectSingleNode("//dia");
            if (primerDia != null)
            {
                XmlNode maximaNode = primerDia.SelectSingleNode("temperatura/maxima");
                if (maximaNode != null)
                {
                    maximaNode.InnerText = "35"; // Cambiar el valor a 35
                    Console.WriteLine("Contenido de <maxima> modificado a: " + maximaNode.InnerText);


                    doc.Save(@"C:\Users\admin\Desktop\CarlosGarcia\DAM_DI\XML\ManipulacionDelDOM\archivo_modificado.xml");
                }
            }
            // 8 Recorre todos los nodos <racha_max> y elimina aquellos cuyo valor esté vacío  
            // Seleccionar todos los nodos <racha_max>
            XmlNodeList rachaMaxNodes = doc.GetElementsByTagName("racha_max");

            // Crear una lista temporal para almacenar los nodos que deben ser eliminados
            List<XmlNode> nodosAEliminar = new List<XmlNode>();

            foreach (XmlNode racha in rachaMaxNodes)
            {
                // Verificar si el valor del nodo está vacío o contiene solo espacios
                if (string.IsNullOrWhiteSpace(racha.InnerText))
                {
                    nodosAEliminar.Add(racha);
                }
            }

            // Eliminar los nodos vacíos del documento
            foreach (XmlNode nodo in nodosAEliminar)
            {
                nodo.ParentNode.RemoveChild(nodo);
            }

            Console.WriteLine($"Se han eliminado {nodosAEliminar.Count} nodos <racha_max> vacíos.");

            // Guardar los cambios en el archivo (opcional)
            doc.Save(@"C:\Users\admin\Desktop\CarlosGarcia\DAM_DI\XML\ManipulacionDelDOM\archivo_modificado.xml");

            // 9 Crea un nuevo elemento <comentario> dentro del primer <dia> con un texto personalizado. 
            // Seleccionar el primer nodo <dia>
            //
            //XmlNode dia = doc.SelectSingleNode("//dia");

            if (primerDia != null)
            {
                // Crear un nuevo nodo <comentario>
                XmlElement comentario = doc.CreateElement("comentario");
                comentario.InnerText = "Este es un comentario personalizado."; // Texto del comentario

                // Añadir el nodo <comentario> como hijo del nodo <dia>
                primerDia.AppendChild(comentario);

                Console.WriteLine("Nodo <comentario> añadido al primer <dia>.");

                // Guardar los cambios en el archivo (opcional)
                doc.Save(@"C:\Users\admin\Desktop\CarlosGarcia\DAM_DI\XML\ManipulacionDelDOM\archivo_modificado.xml");
            }

            // 10
            int count = 0;

            // Seleccionar todos los nodos <prob_precipitacion>
            XmlNodeList probPrecipitacionNodes = doc.GetElementsByTagName("prob_precipitacion");

            foreach (XmlNode prob in probPrecipitacionNodes)
            {
                if (int.TryParse(prob.InnerText, out int value) && value > 50)
                {
                    count++;
                }
            }

            Console.WriteLine($"Cantidad de elementos <prob_precipitacion> con valores superiores a 50: {count}");

            // 11 Elimina el primer nodo <prob_precipitacion> del primer <dia>. 
            // Obtener el primer nodo <dia>
            //XmlNode primerDia = doc.GetElementsByTagName("dia").Item(0);

            if (primerDia != null)
            {
                // Obtener el primer nodo <prob_precipitacion> dentro del primer <dia>
                XmlNode probPrecipitacion = primerDia.SelectSingleNode("prob_precipitacion");

                if (probPrecipitacion != null)
                {
                    // Eliminar el nodo <prob_precipitacion> del nodo <dia>
                    primerDia.RemoveChild(probPrecipitacion);
                    Console.WriteLine("El primer nodo <prob_precipitacion> dentro del primer <dia> ha sido eliminado.");
                }
                else
                {
                    Console.WriteLine("No se encontró un nodo <prob_precipitacion> dentro del primer <dia>.");
                }
            }
            else
            {
                Console.WriteLine("No se encontró ningún nodo <dia> en el documento.");
            }

            // Guardar los cambios en el archivo (opcional)
            doc.Save(@"C:\Users\admin\Desktop\CarlosGarcia\DAM_DI\XML\ManipulacionDelDOM\archivo_modificado.xml");

            // 12  Eliminar todos los nodos <viento> del segudo día usando  RemoveAll
            // Obtener el segundo día, suponiendo que los días están en nodos <dia> y el segundo es el índice 1 (basado en 0)
            XmlNode segundoDia = doc.SelectNodes("//dia")[1]; // Se asume que hay al menos dos días en el XML

            // Verificar si el nodo <dia> tiene nodos <viento> y eliminarlos
            if (segundoDia != null)
            {
                XmlNodeList vientos = segundoDia.SelectNodes("viento"); // Selecciona todos los nodos <viento> dentro del segundo día

                foreach (XmlNode viento in vientos)
                {
                    viento.ParentNode.RemoveChild(viento); // Elimina cada nodo <viento>
                }
            }

            // Guardar los cambios en el archivo XML
            doc.Save(ruta);

            Console.WriteLine("Todos los nodos <viento> del segundo día fueron eliminados.");
            // 13  Sustituye el primer <estado_cielo> del primer <dia> por un nodo nuevo con valores personalizados. 
            // Obtener el primer nodo <dia>
            //XmlNode primerDia = doc.GetElementsByTagName("dia").Item(0);

            if (primerDia != null)
            {
                // Obtener el primer nodo <estado_cielo> dentro del primer <dia>
                XmlNode estadoCielo = primerDia.SelectSingleNode("estado_cielo");

                if (estadoCielo != null)
                {
                    // Crear un nuevo nodo <estado_cielo> con valores personalizados
                    XmlElement nuevoEstadoCielo = doc.CreateElement("estado_cielo");
                    nuevoEstadoCielo.SetAttribute("descripcion", "Despejado");
                    nuevoEstadoCielo.InnerText = "Sin nubes";

                    // Reemplazar el nodo antiguo con el nuevo
                    primerDia.ReplaceChild(nuevoEstadoCielo, estadoCielo);

                    Console.WriteLine("El primer nodo <estado_cielo> del primer <dia> ha sido reemplazado por uno nuevo.");
                }
                else
                {
                    Console.WriteLine("No se encontró un nodo <estado_cielo> dentro del primer <dia>.");
                }
            }
            else
            {
                Console.WriteLine("No se encontró ningún nodo <dia> en el documento.");
            }

            // 14 Recupera el valor del atributo periodo del primer <prob_precipitacion>.
            // Obtener el primer nodo <prob_precipitacion>
            XmlNode primerProbPrecipitacion = doc.GetElementsByTagName("prob_precipitacion").Item(0);

            if (primerProbPrecipitacion != null)
            {
                // Obtener el valor del atributo "periodo"
                XmlAttribute atributoPeriodo = primerProbPrecipitacion.Attributes["periodo"];

                if (atributoPeriodo != null)
                {
                    Console.WriteLine($"El valor del atributo 'periodo' es: {atributoPeriodo.Value}");
                }
                else
                {
                    Console.WriteLine("El nodo <prob_precipitacion> no tiene un atributo 'periodo'.");
                }
            }
            else
            {
                Console.WriteLine("No se encontró ningún nodo <prob_precipitacion> en el documento.");
            }

            //15  Añade un atributo personalizado notas al primer <dia>.
            // Seleccionar el primer nodo <dia>
            //XmlNode primerDia = doc.SelectSingleNode("//dia");

            if (primerDia != null)
            {
                // Crear el nuevo atributo 'notas'
                XmlAttribute notasAttribute = doc.CreateAttribute("notas");
                notasAttribute.Value = "Nota Personalizada";

                // Añadir el atributo al nodo <dia>
                primerDia.Attributes.Append(notasAttribute);
            }

            // Guardar el archivo XML modificado
            doc.Save(ruta);


            Console.WriteLine("Atributo 'notas' añadido al primer nodo <dia>.");
            // 16 Modifica el atributo descripcion del primer <estado_cielo>. 
            // Obtener el primer nodo <estado_cielo>
            XmlNode primerEstadoCielo = doc.SelectSingleNode("//estado_cielo");

            // Modificar el atributo descripcion
            if (primerEstadoCielo != null)
            {
                primerEstadoCielo.Attributes["descripcion"].Value = "Nuevo estado del cielo"; // Cambia el valor según sea necesario
            }

            // Guardar los cambios en el archivo XML
            doc.Save(ruta);

            Console.WriteLine("Atributo 'descripcion' modificado correctamente.");

            //17 Limpia todos los valores <dato> dentro del nodo <temperatura> del primer <dia>. 
            // Obtener el primer día, suponiendo que los días están en nodos <dia> y el primer es el índice 0
            //XmlNode primerDia = doc.SelectNodes("//dia")[0]; // El primer <dia> tiene índice 0

            // Verificar si el nodo <temperatura> existe dentro del primer día
            XmlNode temperatura = primerDia.SelectSingleNode("temperatura");

            if (temperatura != null)
            {
                // Obtener todos los nodos <dato> dentro de <temperatura>
                XmlNodeList datos = temperatura.SelectNodes("dato");

                // Limpiar los valores de los nodos <dato>
                foreach (XmlNode dato in datos)
                {
                    dato.InnerText = ""; // Limpiar el contenido de cada nodo <dato>
                }
            }

            // Guardar los cambios en el archivo XML
            doc.Save(ruta);

            Console.WriteLine("Todos los valores de <dato> dentro del nodo <temperatura> del primer día han sido limpiados.");



            // 18 Crea un nodo <ventisca> y reemplázalo por el <viento> existente en el primer <dia>. 
            // Obtener el primer día, suponiendo que los días están en nodos <dia> y el primer es el índice 0
            //XmlNode primerDia = doc.SelectNodes("//dia")[0]; // El primer <dia> tiene índice 0

            // Buscar el nodo <viento> dentro del primer día
            XmlNode nodoViento = primerDia.SelectSingleNode("viento");

            if (nodoViento != null)
            {
                // Crear un nuevo nodo <ventisca>
                XmlNode ventisca = doc.CreateElement("ventisca");

                
                ventisca.InnerText = "Fuerza 8, tormenta de nieve"; 

                // Reemplazar el nodo <viento> con el nuevo nodo <ventisca>
                primerDia.ReplaceChild(ventisca, nodoViento);

                // Guardar los cambios en el archivo XML
                doc.Save(ruta);

                Console.WriteLine("El nodo <viento> ha sido reemplazado por <ventisca> en el primer día.");
            }
            else
            {
                Console.WriteLine("No se encontró el nodo <viento> en el primer día.");
            }

            //19 Recorre y muestra los atributos del primer nodo <dia>. 
            // Obtener el primer nodo <dia>
            //XmlNode primerDia = doc.SelectNodes("//dia")[0]; // El primer <dia> tiene índice 0

            // Verificar si el nodo <dia> tiene atributos
            if (primerDia.Attributes != null)
            {
                Console.WriteLine("Atributos del primer nodo <dia>:");

                // Recorrer los atributos del nodo <dia>
                foreach (XmlAttribute atributo in primerDia.Attributes)
                {
                    Console.WriteLine($"{atributo.Name} = {atributo.Value}");
                }
            }
            else
            {
                Console.WriteLine("El primer nodo <dia> no tiene atributos.");
            }

        }



    }
}
