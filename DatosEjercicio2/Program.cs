using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DatosEjercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conectando a la base de datos");

            // Cadena de conexión a la base de datos
            string cc = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Biblioteca;Integrated Security=True";

            // Conexión SQL
            using (SqlConnection con = new SqlConnection(cc))
            {
                try
                {
                    // Abrir la conexión
                    con.Open();
                    Console.WriteLine("Conexión exitosa");

                    // Consulta SQL para obtener los datos requeridos
                    string sql = @"
                        SELECT 
                            lectores.nombre_lec AS 'Nombre del lector',
                            libros.titulo_lib AS 'Título del Libro',
                            prestamos.fecha_devol_pre AS 'Fecha de devolución'
                        FROM 
                            prestamos
                        INNER JOIN lectores ON prestamos.Id_lec_pre = lectores.Id_lec
                        INNER JOIN libros ON prestamos.id_lib_pre = libros.Id_lib";

                    // Crear un DataAdapter para ejecutar la consulta y llenar el DataSet
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataSet datos = new DataSet();

                    // Llenar el DataSet con los datos obtenidos
                    da.Fill(datos, "prestamos");

                    // Obtener la tabla de datos
                    DataTable dt = datos.Tables["prestamos"];

                    // Mostrar los datos por consola
                    Console.WriteLine("\nListado de Préstamos:");
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("{0,-20} {1,-30} {2}", "Nombre del lector", "Título del Libro", "Fecha de devolución");
                    Console.WriteLine("---------------------------------------------");

                    foreach (DataRow row in dt.Rows)
                    {
                        Console.WriteLine("{0,-20} {1,-30} {2:dd/MM/yyyy}",
                            row["Nombre del lector"],
                            row["Título del Libro"],
                            row["Fecha de devolución"]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            Console.ReadLine();
        }
    }
}
