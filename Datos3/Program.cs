using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Datos3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conectando a la base de datos");

            string cc = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Biblioteca;Integrated Security=True";

            SqlConnection con = new SqlConnection(cc);
            string sql = "SELECT * FROM lectores";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet datos = new DataSet();
            da.Fill(datos, "lectores");
            DataTable dt = new DataTable();
            dt = datos.Tables["lectores"];
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(row["nombre_lec"] + " " + row["domicilio_lec"]);
            }
        }
    }
}
