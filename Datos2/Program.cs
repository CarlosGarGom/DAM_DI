using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conectando a la base de datos");
            string cc = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Biblioteca;Integrated Security=True";
            SqlConnection con = new SqlConnection(cc); 
            try { 
                con.Open();
                Console.WriteLine("Conexión exitosa");
                String sql = "INSERT INTO lectores (nombre_lec,domicilio_lec) ";
                sql += "VALUES ('Alfonso Gil','C/ Mayor,3')";
                SqlCommand cmd = new SqlCommand(sql, con); 
                Console.WriteLine(cmd.ExecuteNonQuery()); // Visualiza ‘1’ si modifica


                sql= "SELECT count(*) FROM lectores";
                cmd = new SqlCommand(sql, con);
                int numerolectores = (int)cmd.ExecuteScalar();
                Console.WriteLine("Número de lectores: " + numerolectores);

                sql = "SELECT * FROM lectores";
                cmd = new SqlCommand(sql, con);
                IDataReader datos = cmd.ExecuteReader();
                while (datos.Read()) {
                    Console.WriteLine(datos["nombre_lec"] + " " + datos["domicilio_lec"]);
                }
                Console.ReadLine();
                con.Close();
            } catch (Exception ex) {
                Console.WriteLine("Error:" + ex.ToString());
            } finally { 
                //if (con != null) con.Close(); 
            }
        }
    }
}
